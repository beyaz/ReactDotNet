﻿using ReactWithDotNet.react_xarrows;
using static QuranAnalyzer.ArabicLetter;
using static QuranAnalyzer.WebUI.Extensions;

namespace QuranAnalyzer.WebUI.Pages.InitialLetters;


class InitialLetter : ReactComponent
{

    public string Label { get; set; }

    public string innerText
    {
        set => Label = value;
    }

    public string id { get; set; }

    public string SecondBorderColor { get; set; }
    
    public override Element render()
    {
        var containerDiv = new div
        {
            style = { borderRadius = "0.5rem", padding = "4px", margin = "1px" },

            children =
            {
                new div
                {
                    style     = { border = "thin solid #a9acaa", borderRadius = "0.5rem", padding = "5px", margin = "5px" },
                    id        = id,
                    innerText = Label
                }
            }
        };

        if (SecondBorderColor is not null)
        {
            containerDiv.style.border = $"1px solid {SecondBorderColor}";
        }
        
        return containerDiv;
    }
}

class CountingResult: ReactComponent
{
    public string id { get; set; }

    public int MultipleOf { get; set; }

    public string SearchScript { get; set; }

    public override Element render()
    {
        return new div
        {
            style = { display = "flex", flexDirection = "row", marginLeft = "5px", marginTop = "60px" },
            id    = id,
            children =
            {
                new div($"19 x {MultipleOf}"),
                new a
                {
                    innerText = "incele",
                    href      = $"?{QueryKey.Page}={PageId.CharacterCounting}&{QueryKey.SearchQuery}={SearchScript}",
                    style     = { marginLeft = "5px" }
                }
            }
        };
    }
}

class InitialLetterLineGroup: ReactComponent
{
    public List<InitialLetter> Items { get; } = new();

    
    public override Element render()
    {
        return new div
        {
            style =
            {
                display = "flex", margin = "6px"
            },
            Children = Items
        };
    }
}

class Chapter : ReactComponent
{
    public int ChapterNo { get; set; }
    
    public string ChapterName { get; set; }

    public override Element render()
    {
        return new div
        {
            style = { margin = "5px" },
            
            children =
            {
                new div{innerText  = $"Sure - {ChapterNo}"},
                new HStack
                {
                    style={fontWeight = "600"},
                    children=
                    {
                        new div{ innerText = "("},
                        new div{ innerText = ChapterName, style = { fontStyle = "bold"}},
                        new div{ innerText = ")"}
                    }
                }
            }
        };
    }
}

public class View : ReactComponent
{
    public override Element render()
    {
        const string Elif = "Elif-" + Alif;
        const string Lam  = "Lam-" + Laam;
        const string Mim  = "Mim-" + Miim;
        const string Sad  = "Sad-" + Saad;
        const string Kaf  = "Kāf-"+ Qaaf;
        const string Ha   = "Hā-" + Haa;
        
        const string Ain  = "ʿAin-" + Ayn;
        const string Ra   = "Rāʾ-" + Raa;
        const string Ta   = "Ṭāʾ-" + Taa_;
        
        const string Nun  = "Nūn-" + ArabicLetter.Nun;


        var table = new table
        {
            new tbody
            {
                new tr
                {
                    new th { innerText = "Sure" },
                    new th { innerText = "Başlangıç Harfleri" },
                    new th { innerText = "Sayım Sonuçları" }
                },
                new tr
                {
                    new td { new Chapter { ChapterNo = 2, ChapterName = "Bakara" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"2-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"2-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"2-{Mim}", innerText  = Mim }
                            }
                        }
                    },

                    new td { new CountingResult { id = "2-counts", MultipleOf = 521, SearchScript = GetLetterCountingScript("2:*", Alif, Laam, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 3, ChapterName = "İmran Ailesi" } },

                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"3-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"3-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"3-{Mim}", innerText  = Mim }
                            }
                        },
                    },
                    new td { new CountingResult { id = "3-counts", MultipleOf = 298, SearchScript = GetLetterCountingScript("3:*", Alif, Laam, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 7, ChapterName = "Araf" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"7-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"7-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"7-{Mim}", innerText  = Mim },
                                new InitialLetter { id = $"7-{Sad}", innerText  = Sad}
                            }
                        }
                    },

                    new td { new CountingResult { id = "7-counts", MultipleOf = 280, SearchScript = GetLetterCountingScript("7:*", Alif, Laam, Miim,Saad) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 10, ChapterName = "Yunus" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"10-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"10-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"10-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "10-counts", MultipleOf = 131, SearchScript = GetLetterCountingScript("10:*", Alif, Laam, Raa) } }
                },
                new tr
                {
                    new td { new Chapter { ChapterNo = 11, ChapterName = "Hûd" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"11-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"11-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"11-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "11-counts", MultipleOf = 131, SearchScript = GetLetterCountingScript("11:*", Alif, Laam, Raa) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 12, ChapterName = "Yusuf" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"12-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"12-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"12-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "12-counts", MultipleOf = 125, SearchScript = GetLetterCountingScript("12:*", Alif, Laam, Raa) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 13, ChapterName = "Rad" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"13-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"13-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"13-{Mim}", innerText  = Mim },
                                new InitialLetter { id = $"13-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "13-counts", MultipleOf = 78, SearchScript = GetLetterCountingScript("13:*", Alif, Laam,Miim, Raa) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 14, ChapterName = "İbrahim" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"14-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"14-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"14-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "14-counts", MultipleOf = 63, SearchScript = GetLetterCountingScript("14:*", Alif, Laam, Raa) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 15, ChapterName = "Hicr" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"15-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"15-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"15-{Ra}", innerText   = Ra }
                            }
                        }
                    },

                    new td { new CountingResult { id = "15-counts", MultipleOf = 48, SearchScript = GetLetterCountingScript("15:*", Alif, Laam, Raa) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 19, ChapterName = "Meryem" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"19-{Kaf}", innerText = Kaf },
                                new InitialLetter { id = $"19-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"19-{Yaa}", innerText  = Yaa },
                                new InitialLetter { id = $"19-{Ain}", innerText = Ain },
                                new InitialLetter { id = $"19-{Sad}", innerText = Sad }

                            }
                        }
                    },
                    new td { new CountingResult { id = "19-counts", MultipleOf = 42, SearchScript = GetLetterCountingScript("19:*", Kaaf, Haa_, Yaa, Ayn, Saad) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 20, ChapterName = "Taha" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"20-{Ta}", innerText = Ta },
                                new InitialLetter { id = $"20-{Ha}", innerText = Ha }
                            }
                        }
                    }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 26, ChapterName = "Şuara" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"26-{Ta}", innerText  = Ta },
                                new InitialLetter { id = $"26-{Siin}", innerText = Siin },
                                new InitialLetter { id = $"26-{Mim}", innerText = Mim }
                            }
                        }
                    },
                    new td { new CountingResult { id = "TaSinMim", MultipleOf = 93, SearchScript = GetLetterCountingScript("19:*,20:*,26:*,27:*,28:*", Taa, Haa, Siin, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 27, ChapterName = "Neml" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"27-{Ta}", innerText  = Ta },
                                new InitialLetter { id = $"27-{Siin}", innerText = Siin }
                            }
                        }
                    }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 28, ChapterName = "Kasas" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"28-{Ta}", innerText  = Ta },
                                new InitialLetter { id = $"28-{Siin}", innerText = Siin },
                                new InitialLetter { id = $"28-{Mim}", innerText = Mim }
                            }
                        }
                    },
                    new td { new CountingResult { id = "Three-Sad", MultipleOf = 8, SearchScript  = GetLetterCountingScript("7:*,19:*,38:*", Saad) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 29, ChapterName = "Ankebut" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"29-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"29-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"29-{Mim}", innerText  = Mim }
                            }
                        }
                    },

                    new td { new CountingResult { id = "29-counts", MultipleOf = 88, SearchScript = GetLetterCountingScript("29:*", Alif, Laam, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 30, ChapterName = "Rum" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"30-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"30-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"30-{Mim}", innerText  = Mim }
                            }
                        }
                    },

                    new td { new CountingResult { id = "30-counts", MultipleOf = 66, SearchScript = GetLetterCountingScript("30:*", Alif, Laam, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 31, ChapterName = "Lokman" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"31-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"31-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"31-{Mim}", innerText  = Mim }
                            }
                        }
                    },

                    new td { new CountingResult { id = "31-counts", MultipleOf = 43, SearchScript = GetLetterCountingScript("31:*", Alif, Laam, Miim) } }
                },
                
                new tr
                {
                    new td { new Chapter { ChapterNo = 32, ChapterName = "Secde" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"32-{Elif}", innerText = Elif },
                                new InitialLetter { id = $"32-{Lam}", innerText  = Lam },
                                new InitialLetter { id = $"32-{Mim}", innerText  = Mim }
                            }
                        }
                    },

                    new td { new CountingResult { id = "32-counts", MultipleOf = 30, SearchScript = GetLetterCountingScript("32:*", Alif, Laam, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 36, ChapterName = "Yasin" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"36-{Yaa}", innerText  = Yaa },
                                new InitialLetter { id = $"36-{Siin}", innerText = Siin }
                            }
                        }
                    },
                    new td { new CountingResult { id = "36-counts", MultipleOf = 15, SearchScript = GetLetterCountingScript("36:*", Yaa, Siin) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 38, ChapterName = "Sad" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"38-{Sad}", innerText = Sad }
                            }
                        }
                    }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 40, ChapterName = "Mümin" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"40-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"40-{Mim}", innerText = Mim }
                            }
                        }
                    }
                },
                
                new tr
                {
                    new td { new Chapter { ChapterNo = 41, ChapterName = "Fussilet" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"41-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"41-{Mim}", innerText = Mim }
                            }
                        }
                    },
                    new td { new CountingResult { id = "42-Ain-Sin-Kaf", MultipleOf = 11, SearchScript = GetLetterCountingScript("42:*", Ayn, Siin, Qaaf) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 42, ChapterName = "Şura" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"42-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"42-{Mim}", innerText = Mim },
                                new InitialLetter { id = $"42-{Ain}", innerText = Ain },
                                new InitialLetter { id = $"42-{Siin}", innerText = Siin },
                                new InitialLetter { id = $"42-{Kaf}", innerText = Kaf }
                            }
                        }
                    },
                    new td { new CountingResult { id = $"42-{Kaf}-counts", MultipleOf = 3, SearchScript = GetLetterCountingScript("42:*", Qaaf) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 43, ChapterName = "Zuhruf" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"43-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"43-{Mim}", innerText = Mim }
                            }
                        }
                    },
                    new td { new CountingResult { id = "Ha-Mim", MultipleOf = 113, SearchScript = GetLetterCountingScript("40:*,41:*,42:*,43:*,44:*,45:*,46:*", Haa, Miim) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 44, ChapterName = "Duhan" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"44-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"44-{Mim}", innerText = Mim }
                            }
                        }
                    }
                },
                
                new tr
                {
                    new td { new Chapter { ChapterNo = 45, ChapterName = "Casiye" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"45-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"45-{Mim}", innerText = Mim }
                            }
                        }
                    }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 46, ChapterName = "Ahkaf" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"46-{Ha}", innerText  = Ha },
                                new InitialLetter { id = $"46-{Mim}", innerText = Mim }
                            }
                        }
                    }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 50, ChapterName = "Kaf" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"50-{Kaf}", innerText = Kaf }
                            }
                        }
                    },
                    new td { new CountingResult { id = "50-counts", MultipleOf = 3, SearchScript = GetLetterCountingScript("50:*", Qaaf) } }
                },

                new tr
                {
                    new td { new Chapter { ChapterNo = 68, ChapterName = "Kalem" } },
                    new td
                    {
                        new InitialLetterLineGroup
                        {
                            Items =
                            {
                                new InitialLetter { id = $"68-{Nun}", innerText = Nun }
                            }
                        }
                    },
                    new td { new CountingResult { id = "68-counts", MultipleOf = 7, SearchScript = GetLetterCountingScript("68:*", Nun) } }
                }
            }

        };



        var colorForConnectedFromOtherChapters = "#66f295";


        return new div
        {
           style={ display = "flex", flexDirection = "row" , fontSize = Context.ClientWidth < 400 ? "5px": null },
           children =
           {
               table,

               new Arrow{startElementId=$"2-{Elif}", endElementId = "2-counts"},
               new Arrow{startElementId=$"2-{Lam}",endElementId = "2-counts"},
               new Arrow{startElementId=$"2-{Mim}",endElementId = "2-counts"},


               new Arrow{startElementId=$"3-{Elif}",endElementId = "3-counts"},
               new Arrow{startElementId=$"3-{Lam}",endElementId = "3-counts"},
               new Arrow{startElementId=$"3-{Mim}",endElementId = "3-counts"},

               new Arrow{startElementId =$"7-{Elif}",endElementId = "7-counts"},
               new Arrow{startElementId =$"7-{Lam}",endElementId  = "7-counts"},
               new Arrow{startElementId =$"7-{Mim}",endElementId  = "7-counts"},
               new Arrow{startElementId =$"7-{Sad}",endElementId  = "7-counts"},

               new Arrow{startElementId =$"10-{Elif}",endElementId = "10-counts"},
               new Arrow{startElementId =$"10-{Lam}",endElementId  = "10-counts"},
               new Arrow{startElementId =$"10-{Ra}", endElementId  = "10-counts"},

               new Arrow{startElementId =$"11-{Elif}",endElementId = "11-counts"},
               new Arrow{startElementId =$"11-{Lam}",endElementId  = "11-counts"},
               new Arrow{startElementId =$"11-{Ra}", endElementId  = "11-counts"},

               new Arrow{startElementId =$"12-{Elif}",endElementId = "12-counts"},
               new Arrow{startElementId =$"12-{Lam}",endElementId  = "12-counts"},
               new Arrow{startElementId =$"12-{Ra}", endElementId  = "12-counts"},

               new Arrow{startElementId =$"13-{Elif}",endElementId = "13-counts"},
               new Arrow{startElementId =$"13-{Lam}",endElementId  = "13-counts"},
               new Arrow{startElementId =$"13-{Mim}",endElementId  = "13-counts"},
               new Arrow{startElementId =$"13-{Ra}",endElementId  =  "13-counts"},

               new Arrow{startElementId =$"14-{Elif}",endElementId = "14-counts"},
               new Arrow{startElementId =$"14-{Lam}",endElementId  = "14-counts"},
               new Arrow{startElementId =$"14-{Ra}",endElementId   = "14-counts"},

               new Arrow{startElementId =$"15-{Elif}",endElementId = "15-counts"},
               new Arrow{startElementId =$"15-{Lam}",endElementId  = "15-counts"},
               new Arrow{startElementId =$"15-{Ra}",endElementId   = "15-counts"},

               new Arrow{startElementId=$"19-{Kaf}",endElementId = "19-counts"},
               new Arrow{startElementId=$"19-{Ha}",endElementId =  "19-counts"},
               new Arrow{startElementId=$"19-{Yaa}",endElementId =  "19-counts"},
               new Arrow{startElementId=$"19-{Ain}",endElementId = "19-counts"},
               new Arrow{startElementId=$"19-{Sad}",endElementId = "19-counts"},

               new Arrow{startElementId =$"19-{Ha}",endElementId  = "TaSinMim"},
               new Arrow{startElementId =$"20-{Ta}",endElementId  = "TaSinMim"},
               new Arrow{startElementId =$"20-{Ha}",endElementId  = "TaSinMim"},
               new Arrow{startElementId =$"26-{Ta}",endElementId  = "TaSinMim"},
               new Arrow{startElementId =$"26-{Siin}",endElementId = "TaSinMim"},
               new Arrow{startElementId =$"26-{Mim}",endElementId = "TaSinMim"},
               new Arrow{startElementId =$"27-{Ta}",endElementId  = "TaSinMim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"27-{Siin}",endElementId = "TaSinMim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"28-{Ta}",endElementId  = "TaSinMim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"28-{Siin}",endElementId = "TaSinMim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"28-{Mim}",endElementId = "TaSinMim", StartAnchorFromTop = true},

               new Arrow{startElementId =$"29-{Elif}", endElementId  = "29-counts"},
               new Arrow{startElementId =$"29-{Lam}", endElementId   = "29-counts"},
               new Arrow{startElementId =$"29-{Mim}", endElementId   = "29-counts"},

               new Arrow{startElementId =$"30-{Elif}", endElementId = "30-counts"},
               new Arrow{startElementId =$"30-{Lam}", endElementId  = "30-counts"},
               new Arrow{startElementId =$"30-{Mim}", endElementId  = "30-counts"},

               new Arrow{startElementId =$"31-{Elif}", endElementId = "31-counts"},
               new Arrow{startElementId =$"31-{Lam}", endElementId  = "31-counts"},
               new Arrow{startElementId =$"31-{Mim}", endElementId  = "31-counts"},


               new Arrow{startElementId =$"32-{Elif}", endElementId = "32-counts"},
               new Arrow{startElementId =$"32-{Lam}", endElementId  = "32-counts"},
               new Arrow{startElementId =$"32-{Mim}", endElementId  = "32-counts"},

               new Arrow{startElementId =$"36-{Yaa}", endElementId = "36-counts"},
               new Arrow{startElementId =$"36-{Siin}", endElementId = "36-counts"},

               new Arrow{startElementId =$"7-{Sad}",  endElementId = "Three-Sad", Dashness = true,StartAnchorFromRight  = true,color=colorForConnectedFromOtherChapters},
               new Arrow{startElementId =$"19-{Sad}", endElementId = "Three-Sad",Dashness  = true, StartAnchorFromRight = true,color=colorForConnectedFromOtherChapters},
               new Arrow{startElementId =$"38-{Sad}", endElementId = "Three-Sad",Dashness  = true, StartAnchorFromRight = true,color=colorForConnectedFromOtherChapters},
               
               new Arrow{startElementId =$"42-{Ain}", endElementId = "42-Ain-Sin-Kaf", StartAnchorFromTop = true},
               new Arrow{startElementId =$"42-{Siin}", endElementId = "42-Ain-Sin-Kaf",StartAnchorFromTop  = true},
               new Arrow{startElementId =$"42-{Kaf}", endElementId = "42-Ain-Sin-Kaf",StartAnchorFromTop  = true},

               new Arrow{startElementId =$"42-{Kaf}", endElementId = $"42-{Kaf}-counts"},

               new Arrow{startElementId =$"40-{Ha}", endElementId  = "Ha-Mim"},
               new Arrow{startElementId =$"40-{Mim}", endElementId = "Ha-Mim"},
               new Arrow{startElementId =$"41-{Ha}", endElementId  = "Ha-Mim"},
               new Arrow{startElementId =$"41-{Mim}", endElementId = "Ha-Mim"},
               new Arrow{startElementId =$"42-{Ha}", endElementId  = "Ha-Mim"},
               new Arrow{startElementId =$"42-{Mim}", endElementId = "Ha-Mim"},
               new Arrow{startElementId =$"43-{Ha}", endElementId  = "Ha-Mim"},
               new Arrow{startElementId =$"43-{Mim}", endElementId = "Ha-Mim"},
               new Arrow{startElementId =$"44-{Ha}", endElementId  = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"44-{Mim}", endElementId = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"45-{Ha}", endElementId  = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"45-{Mim}", endElementId = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"46-{Ha}", endElementId  = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"46-{Mim}", endElementId = "Ha-Mim", StartAnchorFromTop = true},
               new Arrow{startElementId =$"46-{Mim}", endElementId = "Ha-Mim", StartAnchorFromTop = true},

               new Arrow{startElementId =$"50-{Kaf}", endElementId  = "50-counts"},
               new Arrow{startElementId =$"68-{Nun}", endElementId = "68-counts"},
           }
        };
        


        
        
    }

   
}

class Arrow: ReactComponent
{
   public  string startElementId;
   public  string endElementId;
   public  string color;

   
   public bool StartAnchorFromTop { get; set; }
   public bool StartAnchorFromRight { get; set; }
    

    public bool Dashness { get; set; }

    public override Element render()
    {
        color ??= "#a9acaa";
        
        return new Xarrow
        {
            start       = startElementId,
            end         = endElementId,
            path        = "smooth",
            color       = color,
            strokeWidth = 1,
            startAnchor = StartAnchorFromTop ? "top" : StartAnchorFromRight ? "right" : "bottom",
            dashness    = true,
            //curveness  = 1.02,
            endAnchor = "left"

        };
    }
}