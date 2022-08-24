﻿using QuranAnalyzer.WebUI.Components;
using QuranAnalyzer.WebUI.Pages.CharacterCountingPage;
using ReactWithDotNet.PrimeReact;

namespace QuranAnalyzer.WebUI.Pages.WordSearchingPage;

class Model
{
    public int ClickCount { get; set; }

    public bool IsBlocked { get; set; }

    public string SearchScript { get; set; }
}

class View : ReactComponent<Model>
{
    public View()
    {
        state = new Model();
        StateInitialized += () =>
        {
            if (state.SearchScript == null)
            {
                var value = Context.Query[QueryKey.SearchQuery];
                if (value is not null)
                {
                    state.SearchScript = SearchScript.ParseScript(value).AsReadibleString();
                }
            }
        };
    }

    void OnCaclculateClicked(string _)
    {
        state.ClickCount++;

        if (state.IsBlocked == false)
        {
            state.IsBlocked = true;
            Context.ClientTask.PushHistory("", $"/?{QueryKey.Page}={PageId.WordSearchingPage}&{QueryKey.SearchQuery}={SearchScript.ParseScript(state.SearchScript).AsString()}");
            Context.ClientTask.GotoMethod(5, nameof(OnCaclculateClicked), _);
            return;
        }

        state.IsBlocked = false;
    }
    
    public override Element render()
    {
        var searchPanel = new divWithBorder
        {
            style = { paddingLeftRight = "15px", paddingBottom = "15px" },
            children =
            {
                new h4 { text = "Kelime Arama" , style = { textAlign = "center"}},

                new VStack
                {
                    new div { text                = "Arama Komutu", style          = { fontWeight = "500", fontSize = "0.9rem", marginBottom = "2px" } },
                    new InputTextarea { valueBind = () => state.SearchScript, rows = 2, autoResize = true}
                },

                new VSpace(3),

                new Button
                {
                    label     = "Ara",
                    onClick   = OnCaclculateClicked,
                    className = "p-button-outlined",
                    style     = { alignSelf = "flex-end", flexDirection = "column", paddingLeft = "50px", paddingRight = "50px" }
                },
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



        var resultList = new div { };
        
        const string yevmen = "يوما";

        var searchWord = yevmen;

        var search = QuranAnalyzer.Analyzer.AnalyzeText(searchWord);

        foreach (var verse in VerseFilter.GetVerseList("*").Value)
        {
            if (verse.WordList.Any(x=>x.HasValueAndSame(search)))
            {
                resultList.Add(new div{ text = verse.Text, style = { border = "1px solid red", margin = "5px"}});
            }
        }





        var results = new divWithBorder
        {
            style = { paddingLeftRight = "15px", paddingBottom = "15px", marginTop = "5px" },
            children =
            {
                new h4("Sonuçlar"),
                new VSpace(10),
                resultList
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
}