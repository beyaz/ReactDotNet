﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using ReactDotNet;
using ReactDotNet.PrimeReact;
using static QuranAnalyzer.WebUI.MixinForUI;
using static ReactDotNet.Mixin;

namespace QuranAnalyzer.WebUI;

[Serializable]
public class FactViewModel
{
    public string SelectedFact { get; set; }
    public string SummaryText { get; set; }

    public ClientTask ClientTask { get; set; }
    public string OperationName { get; set; }
    public bool IsBlocked { get; set; }

    public string SuraFilter { get; set; }

    public string SearchCharacters { get; set; }

    public int CountOfCharacters { get; set; }
    

    public int SelectedTabIndex { get; set; }
    public Occurence[] ResultRecords { get; set; }

    
    public IReadOnlyList<MatchInfo> matchRecords{ get; set; }
}

[Serializable]
public sealed class Occurence
{
    public int? Charachter1 { get; set; }
    public int? Charachter2 { get; set; }
    public int? Charachter3 { get; set; }
    public int? Charachter4 { get; set; }
    public int? Charachter5 { get; set; }
    public int? Charachter6 { get; set; }
    public int? Charachter7 { get; set; }
    public int? Charachter8 { get; set; }
    public int? Charachter9 { get; set; }

    public string AyahNumber { get; set; }
}

class FactView : ReactComponent<FactViewModel>
{
    public FactView()
    {
        state = new FactViewModel();
    }

    public void constructor()
    {
        state = new FactViewModel();
    }

    

    void OnSelectClicked()
    {
        if (state.IsBlocked == false)
        {
            state.OperationName = "Hesaplanıyor...";
            state.IsBlocked     = true;
            state.ClientTask    = new ClientTask {ComebackWithLastAction = true};
            return;
        }

        state.matchRecords = Mixin.SearchCharachters(state.SuraFilter, state.SearchCharacters).Value;


        var results = new List<Occurence>();

        foreach (var record in state.matchRecords)
        {
            var occurence = new Occurence
            {
                AyahNumber = record.aya._index
            };

            if (results.Any(x=>x.AyahNumber == occurence.AyahNumber))
            {
                continue;
            }

            results.Add(occurence);

            foreach (var charachter in WordSearcher.ToList(state.SearchCharacters))
            {
                var propertyName = "Charachter" + (WordSearcher.ToList(state.SearchCharacters).ToList().IndexOf(charachter) + 1);

                var property     = typeof(Occurence).GetProperty(propertyName);
                
                var count =  state.matchRecords.Count(m => record.aya._index == m.aya._index && m.ToString() == charachter);

                property.SetValue(occurence, count);
            }

                
        }

        state.ResultRecords = results.ToArray();

        state.CountOfCharacters = state.matchRecords.Count;

        state.IsBlocked     = false;
        state.OperationName = null;

        state.SummaryText = "42. suredeki " + state.SearchCharacters[0] + " harfi geçiş sayısı :";
    }

    public override Element render()
    {
        var container = new VPanel
        {
            Margin = {Left = 10, Right = 10},
        };

        var searchBar = new Card
        {
            title  = "Arama",
            Margin = {Top = 5},
            
            children =
            {
                new VPanel
                {
                    new VPanel
                    {
                        new div {text            = "Sure:"},
                        new InputText {valueBind = () => state.SuraFilter}
                    },

                    new Space {Height = 10},

                    new VPanel
                    {
                        new div {text            = "Aranan Karakterler"},
                        new InputText {valueBind = () => state.SearchCharacters}
                    },

                    new Space {Height = 10},

                    new Button("p-button-outlined") {label = "Ara", onClick = OnSelectClicked},
                }
            }
        };

        if (state.SummaryText.HasNoValue())
        {
            return BlockUI(container + searchBar, state.IsBlocked, state.OperationName);
        }

        var summaryContent = new HPanel
        {
            new div {text = state.SummaryText},
            new div {text = state.CountOfCharacters.ToString(), style = {marginLeft = px(5), marginRight = px(5)}}
        };

        if (state.CountOfCharacters % 19 == 0)
        {
            summaryContent.Add(new div {text = "("});
            summaryContent.Add(new div {text = "19 x " + state.CountOfCharacters / 19, style = {color = "red", marginLeft = px(5), marginRight = px(5)}});
            summaryContent.Add(new div {text = ")"});
        }


        var resultColumns = new List<Column>
        {
            new Column {field = nameof(Occurence.AyahNumber), header = "Ayet No"},
        };

        
        foreach (var charachter in WordSearcher.ToList(state.SearchCharacters))
        {
            var propertyName = "Charachter" + (WordSearcher.ToList(state.SearchCharacters).ToList().IndexOf(charachter) + 1);

            resultColumns.Add(new Column {field = propertyName, header = charachter.ToString()});
            
        }

        var dt = new DataTable
        {
            scrollHeight = px(300),
            scrollable   = true,
            value        = state.ResultRecords,
            
        };

        dt.children.AddRange(resultColumns);

        var results = new Card
        {
            title  = "Sonuçlar",
            Margin = {Top = 5},
            children =
            {
                new TabView
                {
                    onTabChange = e=>state.SelectedTabIndex = e.index,
                    activeIndex = state.SelectedTabIndex,
                    children =
                    {
                        new TabPanel
                        {
                            header = "Özet",
                            children =
                            {
                                summaryContent
                            }
                        },
                        new TabPanel
                        {
                            header = "Detaylı Tablo",
                            children =
                            {
                                dt
                            }
                        },
                        new TabPanel
                        {
                            header = "Mushaf Üzerinde Göster",
                            children =
                            {
                                CharachterSearchResultColorizer.ColorizeCharachterSearchResults(state.matchRecords)
                            }
                        }
                    }
                }
            }
        };

        return BlockUI(container + searchBar + results, state.IsBlocked, state.OperationName);
    }
}