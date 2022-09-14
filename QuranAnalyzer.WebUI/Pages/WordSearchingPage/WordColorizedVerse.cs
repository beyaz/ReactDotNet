﻿using System.Text;
using static QuranAnalyzer.WebUI.LetterColorPalette;

namespace QuranAnalyzer.WebUI.Pages.WordSearchingPage;

class WordColorizedVerse : ReactComponent
{
    public  Verse Verse { get; set; }

    public IReadOnlyList<LetterInfo> VerseLetters => Verse.AnalyzedFullText;

    public IReadOnlyList<(IReadOnlyList<LetterInfo> searchWord, IReadOnlyList<(LetterInfo start, LetterInfo end)> startEndPoints)> MatchList { get; set; }

    protected override Element render()
    {
        if (Verse == null)
        {
            Verse = VerseFilter.GetVerseById("2:286");
            MatchList = new List<(IReadOnlyList<LetterInfo> searchWord, IReadOnlyList<(LetterInfo first, LetterInfo last)> startPoints)>
            {
                (Analyzer.AnalyzeText("واليوم").Unwrap(), new [] { (VerseLetters[6], VerseLetters[9]), (VerseLetters[28], VerseLetters[33]),(VerseLetters[258], VerseLetters[268]) }),
                (Analyzer.AnalyzeText("يوم").Unwrap(), new [] { (VerseLetters[45], VerseLetters[50]), (VerseLetters[68], VerseLetters[78]) }),
                (Analyzer.AnalyzeText("باليوم").Unwrap(), new [] { (VerseLetters[96], VerseLetters[100]), (VerseLetters[178], VerseLetters[184]), (VerseLetters[228], VerseLetters[235]) })
            };
        }

        var verseLetters = VerseLetters.ToList();

        var cursor = 0;

        var html = new StringBuilder();
        
        while (cursor < verseLetters.Count)
        {
            var letterInfo = verseLetters[cursor];

            var hasAnyMatch = false;
            
            var searchWordIndex = 0;
            foreach (var (_, startEndPoints) in MatchList)
            {
                foreach (var startEndPoint in startEndPoints)
                {
                    var startIndex = startEndPoint.start.StartIndex;
                    var endIndex = startEndPoint.end.StartIndex;

                    if (startIndex == letterInfo.StartIndex)
                    {
                        var span = new span
                        {
                            innerText = string.Join(string.Empty, verseLetters.GetRange(startIndex, endIndex - startIndex).Select(x => x.MatchedLetter)),
                            style =
                            {
                                color        = GetColor(searchWordIndex),
                                border       = "1px dashed rgb(218, 220, 224)",
                                borderRadius = "4px",
                                fontWeight   = "bold"
                            }
                        };

                        html.Append(span);

                        cursor = endIndex + 1;

                        hasAnyMatch = true;
                        break;
                    }
                }

                if (hasAnyMatch)
                {
                    break;
                }

                searchWordIndex++;
            }

            if (hasAnyMatch)
            {
                continue;
            }

            html.Append(letterInfo.MatchedLetter);

            cursor++;
        }

        var countsView = new HPanel
        {
            style =
            {
                padding        = "5px",
                justifyContent = "center",
                flexWrap       = "wrap"
            },
        };

        {
            var searchWordIndex = 0;

            foreach (var (searchWord, startEndPoints) in MatchList)
            {
                var countView = new HPanel
                {
                    children =
                    {
                        new div { text = string.Join(string.Empty,searchWord), style = { color = GetColor(searchWordIndex), fontWeight = "bold" } },

                        new div { text = ":", style = { marginLeftRight = "4px" } },

                        new div { text = startEndPoints.Count.ToString(), style = { fontSize = "0.78rem" } }
                    },
                    style = { marginLeft = "10px" }
                };

                countsView.appendChild(countView);

                searchWordIndex++;
            }
        }
        var textView = new div
        {
            innerHTML = html.ToString(),
            style =
            {
                fontSize    = "1.4rem",
                padding     = "5px",
                fontFamily  = "Lateef, cursive",
                direction   = "rtl",
                marginRight = "auto"
            }
        };


        var verseId = new div
        {
            text = $"{Verse.Id}",
            style =
            {
                fontSize   = "0.8rem",
                fontWeight = "bold",
                marginLeft = "2px"
            }
        };

        var topLegend = new legend
        {
            style = { display = "flex", flexDirection = "row", alignItems = "center" },
            children =
            {
                verseId,
                countsView
            }
        };

        return new fieldset
        {
            children = { topLegend, new VSpace(5), textView },
            style =
            {
                marginTop    = "5px",
                border       = "1px dashed rgb(218, 220, 224)",
                borderRadius = "4px",

                display       = "flex",
                flexDirection = "column",
                alignItems    = "flex-start"
            }
        };
        
    }
}