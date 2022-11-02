﻿using static QuranAnalyzer.WebUI.Extensions;
using static QuranAnalyzer.ArabicLetter;

namespace QuranAnalyzer.WebUI.Pages.InitialLetters;

class Note : ReactComponent
{
    public string Text { get; set; }
    
    protected override Element render()
    {
        return new FlexRow(PaddingLeftRight("10%"), PaddingTop(50))
        {
            new strong{Text("Not:"), MarginRight(5)}, new div{ Children(children) }
        };
    }
}

class InitialLetterGroup_Chapter19 : InitialLetterGroup
{
    static string Id(int chapterNumber, string letter) => $"Chapter19-{chapterNumber}-{letter}";

    static string IdOfCountingResult => $"Chapter19-{nameof(IdOfCountingResult)}";

    static Element countingResult => new CountingResult { id = IdOfCountingResult, MultipleOf = 42, SearchScript = GetLetterCountingScript("19:*", Kaaf, Haa_, Yaa, Ayn, Saad) };

    protected override Element render()
    {
        return new div
        {
            new table(Width("100%"))
            {
                new tbody
                {
                    HeaderTr,
                    HeaderSpace,
                    new tr
                    {
                        new td
                        {
                            new Chapter { ChapterNumber = 19, ChapterName = "Meryem" }
                        },
                        new td
                        {
                            new InitialLetterLineGroup
                            {
                                new InitialLetter { id = Id(19, Qaaf), text = Qaaf },
                                new InitialLetter { id = Id(19, Haa), text  = Haa_ },
                                new InitialLetter { id = Id(19, Yaa), text  = Yaa },
                                new InitialLetter { id = Id(19, Ayn), text  = Ayn },
                                new InitialLetter { id = Id(19, Saad), text = Saad }
                            }
                        },
                        new td
                        {
                            rowSpan = 99,
                            children =
                            {
                                new FlexRow(JustifyContentCenter,MarginTop(50))
                                {
                                    countingResult
                                }
                            }
                        }
                    },

                }

            },


            new Arrow { start = Id(19, Qaaf), end = IdOfCountingResult},
            new Arrow { start = Id(19, Haa), end  = IdOfCountingResult},
            new Arrow { start = Id(19, Yaa), end  = IdOfCountingResult},
            new Arrow { start = Id(19, Ayn), end  = IdOfCountingResult},
            new Arrow { start = Id(19, Saad), end = IdOfCountingResult},


            new Note
            {
                @"Meryem suresi Kuran'da en baştan ",  (strong)"19." ," sıradadır. ",
                @"Aynı zamanda", (strong)" en çok başlangıç harfi olan", " suredir. ",
                " 5 tane başlangıç harfi vardır.",
                " Bu beş tane başlangıç harfinin toplam geçiş adeti ise yine 19 un bir katı olan ", 798.AsMultipleOf19() ,"'dir."
            }
        };
    }
}