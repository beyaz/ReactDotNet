﻿using QuranAnalyzer.WebUI.Components;
using ReactWithDotNet.PrimeReact;
using static QuranAnalyzer.Analyzer;

namespace QuranAnalyzer.WebUI.Pages.CharacterCountingPage;


[Serializable]
public class CharacterCountingViewModel
{
    public string ChapterFilter { get; set; }

    public string SearchLetters { get; set; }
    
    public MushafOption mushafOption { get; set; } = new();

    public int ClickCount { get; set; }

    public bool IsBlocked { get; set; }
}


class CharacterCountingView : ReactComponent<CharacterCountingViewModel>
{
    #region Constructors
    public CharacterCountingView()
    {
        state = new CharacterCountingViewModel();

        StateInitialized += () =>
        {
            if (state.ChapterFilter == null)
            {
                var value = Context.Query[QueryKey.SearchQuery];
                if (value is not null)
                {
                    state.ChapterFilter    = value.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).TryGet(0);
                    state.SearchLetters = value.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).TryGet(1);
                }
            }
        };
    }
    #endregion

    public void ComponentDidMount()
    {
        Context.ClientTask.ListenEvent("ArabicKeyboardPressed", nameof(ArabicKeyboardPressed));
    }

    public void ArabicKeyboardPressed(string letter)
    {
        state.ClickCount = 0;
        state.SearchLetters += " " + letter;
    }

    #region Public Methods
    public override Element render()
    {
        var searchPanel = new divWithBorder
        {
            style = { paddingLeftRight = "15px", paddingBottom = "15px"},
            
            children =
            {
                new h4{text = "Harf Arama"},
                new VStack
                {
                    new VStack
                    {
                        new div { text = "Sure:", style = { fontWeight = "500", fontSize = "0.9rem", marginBottom = "2px"}},
                        new InputText { valueBind = () => state.ChapterFilter }
                    },

                    new VSpace(15),

                    new VStack
                    {
                        new div { text = "Aranacak Karakterlerler" , style = { fontWeight = "500", fontSize = "0.9rem", marginBottom = "2px"}},
                        new InputText { valueBind = () => state.SearchLetters, style = { direction = "ltr"}},
                        
                    },
                    new VSpace(3),
                    new Panel
                    {
                        header = "Arapça Klavye",
                        collapsed = true,
                        toggleable = true,
                        children =
                        {
                            new ArabicKeyboard()
                        },
                        headerTemplate = "QuranAnalyzer_WebUI_PanelHeaderTemplate"
                    },

                    new VSpace(3),
                    new MushafOptionsView
                    {
                        MushafOption                = state.mushafOption,
                        Bestaten_7_69               = () => state.mushafOption.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten,
                        UseElifReferencesFromTanzil = ()=>state.mushafOption.UseElifReferencesFromTanzil,
                        CountHamzaAsAlif            = ()=>state.mushafOption.CountHamzaAsAlif,

                    },
                    
                    new VSpace(20),

                    new Button
                    {
                        label     = "Ara",
                        onClick   = OnCaclculateClicked,
                        className = "p-button-outlined",
                        style     = { alignSelf = "flex-end", flexDirection = "column", paddingLeft = "50px", paddingRight = "50px" }
                    },

                    
                }
            }
        };

        if (state.ClickCount == 0)
        {
            return searchPanel;
        }

        if (state.IsBlocked)
        {
            return new CalculatingComponent { searchPanel };
        }

        var searchLetters = AnalyzeText(state.SearchLetters).Where(IsArabicLetter).GroupBy(x=>x.ArabicLetterIndex).Select(grp=>grp.FirstOrDefault()).Distinct().ToList();

        var summaryInfoList = searchLetters.AsListOf(x => new SummaryInfo
        {
            Count = VerseFilter.GetVerseList(state.ChapterFilter).Then(verses => QuranAnalyzerMixin.GetCountOfCharacter(verses, x.ArabicLetterIndex,state.mushafOption)).Value,
            Name  = x.MatchedLetter
        });


        

        var mushafVerse = new List<LetterColorizer>();
        
        foreach (var verse in VerseFilter.GetVerseList(state.ChapterFilter).Value)
        {
            if (verse.AnalyzedFullText.Any(x => searchLetters.Any(l=>l.ArabicLetterIndex == x.ArabicLetterIndex)))
            {
                var letterColorizer = new LetterColorizer
                {
                    VerseTextNodes          = verse.AnalyzedFullText,
                    ChapterNumber           = verse.ChapterNumber.ToString(),
                    VerseNumber             = verse.Index,
                    LettersForColorizeNodes = searchLetters,
                    VerseText               = verse.TextWithBismillah,
                    Verse = verse,
                    option = state.mushafOption
                };
                
                mushafVerse.Add(letterColorizer);
            }
            
            
        }



        var results = new divWithBorder
        {
            style = { paddingLeftRight = "15px", paddingBottom = "15px" , marginTop = "5px"},
            children =
            {
                new h4("Sonuçlar"),
                
                new CountsSummaryView { Counts = summaryInfoList },
                new VSpace(30),
                new div
                {
                    Children = mushafVerse
                }
            }
        };




        return new div
        {
            children = { searchPanel, results },
            style =
            {
                display = "flex", flexDirection = "column", alignItems = "stretch"
            }
        };
    }
    #endregion

    #region Methods
    void OnCaclculateClicked(string _)
    {
        state.ClickCount++;
        
        if (state.IsBlocked == false)
        {
            state.IsBlocked     = true;
            Context.ClientTask.PushHistory("", $"/?{QueryKey.Page}={PageId.CharacterCounting}&{QueryKey.SearchQuery}={state.ChapterFilter}|{state.SearchLetters}");
            Context.ClientTask.GotoMethod(5, nameof(OnCaclculateClicked), _);
            return;
        }

        state.IsBlocked     = false;

       
    }
    #endregion
}