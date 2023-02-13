﻿namespace QuranAnalyzer.WebUI.Pages.Shared;

class Helpcomponent : ReactComponent
{
    public bool IsHelpVisible { get; set; }

    public bool ShowHelpMessageForLetterSearch { get; set; }

    static HtmlElementModifier SrcArrowDown =>
        Src("data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/PjwhRE9DVFlQRSBzdmcgIFBVQkxJQyAnLS8vVzNDLy9EVEQgU1ZHIDEuMS8vRU4nICAnaHR0cDovL3d3dy53My5vcmcvR3JhcGhpY3MvU1ZHLzEuMS9EVEQvc3ZnMTEuZHRkJz48c3ZnIGhlaWdodD0iNTEycHgiIGlkPSJMYXllcl8xIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MTIgNTEyOyIgdmVyc2lvbj0iMS4xIiB2aWV3Qm94PSIwIDAgNTEyIDUxMiIgd2lkdGg9IjUxMnB4IiB4bWw6c3BhY2U9InByZXNlcnZlIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIj48cG9seWdvbiBwb2ludHM9IjM5Ni42LDE2MCA0MTYsMTgwLjcgMjU2LDM1MiA5NiwxODAuNyAxMTUuMywxNjAgMjU2LDMxMC41ICIvPjwvc3ZnPg==");

    static HtmlElementModifier SrcArrowUp =>
        Src("data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/PjwhRE9DVFlQRSBzdmcgIFBVQkxJQyAnLS8vVzNDLy9EVEQgU1ZHIDEuMS8vRU4nICAnaHR0cDovL3d3dy53My5vcmcvR3JhcGhpY3MvU1ZHLzEuMS9EVEQvc3ZnMTEuZHRkJz48c3ZnIGhlaWdodD0iNTEycHgiIGlkPSJMYXllcl8xIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MTIgNTEyOyIgdmVyc2lvbj0iMS4xIiB2aWV3Qm94PSIwIDAgNTEyIDUxMiIgd2lkdGg9IjUxMnB4IiB4bWw6c3BhY2U9InByZXNlcnZlIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIj48cG9seWdvbiBwb2ludHM9IjM5Ni42LDM1MiA0MTYsMzMxLjMgMjU2LDE2MCA5NiwzMzEuMyAxMTUuMywzNTIgMjU2LDIwMS41ICIvPjwvc3ZnPg==");

    string DescriptionPart
    {
        get
        {
            if (ShowHelpMessageForLetterSearch)
            {
                return "harflerini";
            }

            return "kelimesini";
        }
    }

    string SearchItem
    {
        get
        {
            if (ShowHelpMessageForLetterSearch)
            {
                return ArabicLetter.Qaaf;
            }

            return "الله";
        }
    }

    protected override Element render()
    {
        if (IsHelpVisible)
        {
            return new FlexColumn(Gap(20))
            {
                Title() + MarginTop(11),
                HelpDetail
            };
        }

        return Title();
    }

    Element HelpDetail()
    {
        return new div(TextAlignCenter)
        {
            new table
            {
                new tbody
                {
                    new tr
                    {
                        new th { "Komut" } + FontWeight500, new th { "Açıklama" } + FontWeight500
                    },
                    new tr { Height(15) },
                    new tr
                    {
                        commandText($"* | {SearchItem}"),
                        description("(Tüm mushaf boyunca geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    },
                    new tr { Height(10) },
                    new tr
                    {
                        commandText($"2:* | {SearchItem}"),
                        description("(2. surenin tamamında geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    },
                    new tr { Height(10) },
                    new tr
                    {
                        commandText($"2:*, 3:*, 7:5-40 | {SearchItem}"),
                        description("(2. surenin tamamında, 3. surenin tamamında ve 7. surenin 5 ila 40. ayetler arasında geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    },
                    new tr { Height(10) },
                    new tr
                    {
                        commandText($"2:*, -2:4, -2:8 | {SearchItem}"),
                        description("(2. surenin tamamında(4. ve 8. ayetler hariç), geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    },
                    new tr { Height(10) },
                    new tr
                    {
                        commandText($"*, -9:128, -9:129 | {SearchItem}"),
                        description("(Tüm mushaf boyunca (9:128 ve 9:129 hariç), geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    },
                    new tr { Height(10) },
                    new tr
                    {
                        commandText($"2:17 --> 5:4 | {SearchItem}"),
                        description("(2. surenin 17. ayeti ile 5. surenin 4. ayeti arasında geçen ", (b)SearchItem, $" {DescriptionPart} aratır)")
                    }
                }
            }
        };

        static Element commandText(string text)
        {
            return new td { (b)text } + Width(200) + ComponentBorder + BorderRadius(5);
        }

        static Element description(params Element[] children)
        {
            return new td { children } + Width(400);
        }
    }

    Element Title()
    {
        return new FlexRow(AlignItemsCenter, Gap(5), CursorPointer, OnClick(_ => IsHelpVisible = !IsHelpVisible))
        {
            new img
            {
                wh(20), 
                SrcArrowUp,
                Transition("all 1500ms ease"),
                IsHelpVisible ?Transform("rotate(180deg)") :Transform("rotate(40deg)")
            },
            "Örnek arama komutları"
        };
    }
}