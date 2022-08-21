﻿using static QuranAnalyzer.WebUI.Extensions;
using static QuranAnalyzer.ArabicLetter;

namespace QuranAnalyzer.WebUI.Pages.InitialLetters;

class InitialLetterGroup_Alif_Laam_Miim_Ra : InitialLetterGroup
{

    static string Id(int chapterNumber, string letter) => $"Alif_Laam_Miim_Ra-{chapterNumber}-{letter}";

    static string IdOfCountingResult(int chapterNumber) => $"Alif_Laam_Miim_Ra-{chapterNumber}";


    public override Element render()
    {
        return new div
        {

            new table
            {
                style = { width = "100%" },
                children =
                {
                    new tbody
                    {
                        HeaderTr,
                        HeaderSpace,
                        new tr
                        {
                            new td
                            {
                                new Chapter { ChapterNumber = 13, ChapterName = "Rad" }
                            },
                            new td
                            {
                                new InitialLetterLineGroup
                                {
                                    Items =
                                    {
                                        new InitialLetter { id = Id(13, Alif), text = Alif },
                                        new InitialLetter { id = Id(13, Laam), text = Laam },
                                        new InitialLetter { id = Id(13, Miim), text = Miim },
                                        new InitialLetter { id = Id(13, Raa), text = Raa },
                                    }
                                }
                            },
                            new td
                            {
                                new div
                                {
                                    style = { marginTop = "50px", display = "flex", justifyContent = "center" },
                                    children =
                                    {
                                        new CountingResult
                                        {
                                            id = IdOfCountingResult(13), MultipleOf = 78, SearchScript = GetLetterCountingScript("13:*", Alif, Laam, Miim, Raa)
                                        }
                                    }
                                }
                            }
                        },
                       }

                },


            },


            new Arrow { start = Id(13, Alif), end = IdOfCountingResult(13) },
            new Arrow { start = Id(13, Laam), end = IdOfCountingResult(13) },
            new Arrow { start = Id(13, Miim), end = IdOfCountingResult(13) },
            new Arrow { start = Id(13, Raa), end  = IdOfCountingResult(13) },
            

        };
    }
}