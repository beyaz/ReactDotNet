﻿using System.Threading.Tasks;
using QuranAnalyzer.WebUI.Pages.CharacterCountingPage;
using QuranAnalyzer.WebUI.Pages.Shared;
using Switch = ReactWithDotNet.Libraries.mui.material.Switch;

namespace QuranAnalyzer.WebUI.Pages.WordSearchingPage;

class WordSearchingViewModel
{
    public int ClickCount { get; set; }

    public bool IsBlocked { get; set; }

    public string SearchOption { get; set; } = SearchOptions.Same;

    public string SearchScript { get; set; }

    public string SearchScriptErrorMessage { get; set; }
}

static class SearchOptions
{
    public const string Contains = "3";
    public const string EndsWith = "2";
    public const string Same = "4";
    public const string StartsWith = "1";
}

class WordSearchingView : ReactComponent<WordSearchingViewModel>
{
    protected override Task componentDidMount()
    {
        Client.OnArabicKeyboardPressed(ArabicKeyboardPressed);

        return Task.CompletedTask;
    }

    protected override void constructor()
    {
        state = new WordSearchingViewModel();

        var value = Context.Query[QueryKey.SearchQuery];
        if (value is not null)
        {
            var parseResponse = SearchScript.ParseScript(value);
            if (parseResponse.IsFail)
            {
                state.SearchScriptErrorMessage = parseResponse.FailMessage;
                Client.GotoMethod(3000, ClearErrorMessage);
                return;
            }

            state.SearchScript = parseResponse.Value.AsReadibleString();
        }
    }

    protected override Element render()
    {
        IEnumerable<Element> searchPanel() => new[]
        {
            When(state.IsBlocked, () => new div { PositionAbsolute, LeftRight(0), TopBottom(0), BackgroundColor("rgba(0, 0, 0, 0.3)"), Zindex(3) }),
            When(state.IsBlocked, () => new FlexRowCentered
            {
                PositionAbsolute, FontWeight700, LeftRight(0), TopBottom(0), Zindex(4),
                Children(new LoadingIcon { wh(17), mr(5) }, "Lütfen bekleyiniz...")
            }),

            new h4 { text = "Kelime Arama", style = { textAlign = "center" } },

            new FlexColumn
            {
                new FlexColumn
                {
                    new div { text = "Arama Komutu", style = { fontWeight = "500", fontSize = "0.9rem", marginBottom = "2px" } },

                    new TextArea { TextArea.Bind(() => state.SearchScript), FontFamily_Lateef }, // rows = 2, autoResize = true,

                    new ErrorText { Text = state.SearchScriptErrorMessage }
                },

                Space(15),
                PartOption,
                Space(15),

                new FlexRow(JustifyContentSpaceBetween)
                {
                    new Helpcomponent(),
                    new ActionButton { Label = "Ara", OnClick = OnCaclculateClicked } + Height(22)
                }
            }
        };

        if (state.ClickCount == 0)
        {
            return Container(Panel(searchPanel()));
        }

        var searchScript = SearchScript.ParseScript(state.SearchScript).Unwrap();

        if (state.IsBlocked)
        {
            return Container(Panel(searchPanel()));
        }

        Response<(List<WordColorizedVerse> resultVerseList, List<SummaryInfo> summaryInfoList, (int sumOfChapterNumbers, int sumOfVerseNumbers, int sumOfCounts))> calculate()
        {
            var matchMap = new Dictionary<string, List<(IReadOnlyList<LetterInfo> searchWord, IReadOnlyList<(LetterInfo start, LetterInfo end)> startPoints)>>();

            var summaries = new List<SummaryInfo>();

            foreach (var (searchOption,chapterFilter, searchWord) in searchScript.Lines)
            {
                var filteredVersesResponse = VerseFilter.GetVerseList(chapterFilter);
                if (filteredVersesResponse.IsFail)
                {
                    return filteredVersesResponse.ErrorsAsArray;
                }

                var filteredVerses = filteredVersesResponse.Value;

                foreach (var verse in filteredVerses)
                {
                    IReadOnlyList<(LetterInfo start, LetterInfo end)> startAndEndPoints = null;
                    if (searchOption == SearchOptions.Same)
                    {
                        startAndEndPoints = verse.GetStartAndEndPointsOfSameWords(searchWord);
                    }
                    else if (searchOption == SearchOptions.Contains)
                    {
                        startAndEndPoints = verse.GetStartAndEndPointsOfContainsWords(searchWord);
                    }
                    else if (searchOption == SearchOptions.EndsWith)
                    {
                        startAndEndPoints = verse.GetStartAndEndPointsOfEndsWithWords(searchWord);
                    }
                    
                    if (startAndEndPoints?.Count > 0)
                    {
                        if (!matchMap.ContainsKey(verse.Id))
                        {
                            matchMap.Add(verse.Id, new List<(IReadOnlyList<LetterInfo> searchWord, IReadOnlyList<(LetterInfo start, LetterInfo end)> startPoints)>());
                        }

                        matchMap[verse.Id].Add((searchWord, startAndEndPoints));

                        // update summary
                        {
                            if (summaries.All(x => x.Name != searchWord.AsText()))
                            {
                                summaries.Add(new SummaryInfo { Name = searchWord.AsText() });
                            }

                            summaries.First(x => x.Name == searchWord.AsText()).Count += startAndEndPoints.Count;
                        }
                    }
                }
            }

            var sumOfChapterNumbers = 0;
            var sumOfVerseNumbers   = 0;
            var sumOfCounts         = 0;

            var resultVerses = new List<WordColorizedVerse>();

            foreach (var (verseId, matchList) in matchMap.ToList().OrderBy(x => x.Key, new VerseNumberComparer()))
            {
                resultVerses.Add(new WordColorizedVerse
                {
                    Verse     = VerseFilter.GetVerseById(verseId),
                    MatchList = matchList
                });

                sumOfChapterNumbers += int.Parse(verseId.Split(':')[0]);
                sumOfVerseNumbers   += int.Parse(verseId.Split(':')[1]);

                sumOfCounts += matchList.Sum(x => x.startPoints.Count).Unwrap();
            }

            return (resultVerses, summaries, (sumOfChapterNumbers, sumOfVerseNumbers, sumOfCounts));
        }

        return calculate().Then((resultVerseList, summaryInfoList, _) =>
                                {
                                    Element[] results =
                                    {
                                        new h4("Sonuçlar") + TextAlignCenter,

                                        new CountsSummaryView { Counts = summaryInfoList },
                                        new VSpace(30),
                                        new div
                                        {
                                            Children(resultVerseList)
                                        }
                                    };

                                    return Container(Panel(searchPanel()), Panel(results));
                                },
                                failMessage =>
                                {
                                    state.SearchScriptErrorMessage = failMessage;

                                    return Container(Panel(searchPanel()));
                                });
    }

    static Element Container(params Element[] panels)
    {
        return new FlexColumn(Gap(10), AlignItemsStretch, WidthMaximized, MaxWidth(800))
        {
            Children(panels)
        };
    }

    static Element Panel(IEnumerable<Element> rows)
    {
        return new FlexColumn(BorderRadiusForPanels, ComponentBorder, PaddingLeftRight(15), PaddingBottom(15), PositionRelative)
        {
            Children(rows)
        };
    }

    void ArabicKeyboardPressed(string letter)
    {
        state.SearchScriptErrorMessage = null;
        state.ClickCount               = 0;
        state.SearchScript             = state.SearchScript?.Trim() + " " + letter;
    }

    void ClearErrorMessage()
    {
        state.SearchScriptErrorMessage = null;
    }

    void OnCaclculateClicked()
    {
        state.SearchScriptErrorMessage = null;
        if (state.SearchScript.HasNoValue())
        {
            state.SearchScriptErrorMessage = "Arama Komutu doldurulmalıdır";
            Client.GotoMethod(1000, ClearErrorMessage);
            return;
        }

        var scriptParseResponse = SearchScript.ParseScript(state.SearchScript);
        if (scriptParseResponse.IsFail)
        {
            state.SearchScriptErrorMessage = scriptParseResponse.FailMessage;
            Client.GotoMethod(3000, ClearErrorMessage);
            return;
        }

        var script = scriptParseResponse.Value;

        state.ClickCount++;

        if (state.IsBlocked == false)
        {
            state.IsBlocked = true;
            Client.PushHistory("", $"/?{QueryKey.Page}={PageId.WordSearchingPage}&{QueryKey.SearchQuery}={script.AsString()}");
            Client.GotoMethod(OnCaclculateClicked);
            return;
        }

        state.IsBlocked = false;
    }

    Element PartOption()
    {
        return new FlexRow(BorderRadiusForPanels, ComponentBorder, JustifyContentSpaceEvenly, AlignContentCenter)
        {
            new FlexRowCentered { new Switch { @checked = state.SearchOption == SearchOptions.StartsWith, onChange = ValueChange, value = SearchOptions.StartsWith }, "başlar" },
            new FlexRowCentered { new Switch { @checked = state.SearchOption == SearchOptions.EndsWith, onChange   = ValueChange, value = SearchOptions.EndsWith }, "biter" },
            new FlexRowCentered { new Switch { @checked = state.SearchOption == SearchOptions.Contains, onChange   = ValueChange, value = SearchOptions.Contains }, "içerir" },
            new FlexRowCentered { new Switch { @checked = state.SearchOption == SearchOptions.Same, onChange       = ValueChange, value = SearchOptions.Same }, "aynısı" }
        };
    }

    void ValueChange(ChangeEvent changeEvent)
    {
        state.SearchOption = changeEvent.target.value;
    }
}