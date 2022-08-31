﻿using QuranAnalyzer.WebUI.Components;
using QuranAnalyzer.WebUI.Pages.CharacterCountingPage;

namespace QuranAnalyzer.WebUI.Pages.MainPage;

[Serializable]
public class MainViewModel
{
    public string PageId { get; set; }
    public string SelectedFact { get; set; }
    public string SummaryText { get; set; }

    public string OperationName { get; set; }
    public bool IsBlocked { get; set; }

    public bool HamburgerMenuIsOpen { get; set; }

    public double MainDivScrollY { get; set; }
    

    public string LastClickedMenuId { get; set; }

    public CharacterCountingViewModel CharacterCountingViewModel { get; set; }
}

class View : ReactComponent<MainViewModel>
{
    

    protected override void constructor()
    {
        state        = new MainViewModel
        {
            PageId = Context.Query[QueryKey.Page]
        };

        ClientTask.CallJsFunction("RegisterScrollEvents");
        ClientTask.ListenEvent(ApplicationEventName.OnHamburgerMenuOpened, nameof(OnHamburgerMenuOpened));
        ClientTask.ListenEvent(ApplicationEventName.OnHamburgerMenuClosed, nameof(OnHamburgerMenuClosed));
    }


    public void OnHamburgerMenuClosed()
    {
        state.HamburgerMenuIsOpen = false;
    }

    public void OnHamburgerMenuOpened()
    {
        state.HamburgerMenuIsOpen = true;
    }

    public override Element render()
    {
        var IsBackDropActive = state.HamburgerMenuIsOpen;
        
        var top = new FixedTopPanelContainer
        {
            new TopNavigationPanel()
        };

        var backDrop = new BackdropView { IsActive = IsBackDropActive };
        var main = new div
        {
            id = "main",
            children =
            {
                new div
                {
                    style = { display = "flex", justifyContent = "center", height = "100%"},
                    children =
                    {
                        backDrop,
                        new div
                        {
                            style    = { marginLeftRight = "10px", marginTop = "10px", maxWidth = "800px", width = "100%"},
                            children = { buildMainContent() }
                        }
                    }
                }
            },

            style =
            {
                position     = "fixed",
                top          = "0px",
                left         = (IsBackDropActive ? "400px" : "0px"),
                marginTop    = "50px",
                marginBottom = "27px",

                width     = IsBackDropActive ? "calc(100% - 400px)" : "100%",
                height    = "calc(100% - 65px)",
                overflowY = "auto"
            }
        };

        return new div
        {
            children = { top, new FixedLeftMenuContainer { IsOpen = state.HamburgerMenuIsOpen }, main },
            style    = { width_height = "100%" }
        };


       

        Element buildMainContent()
        {
            if (state.PageId == PageId.MainPage)
            {
                return new MainPageContent();
            }

            if (state.PageId == PageId.SecuringDataWithCurrentTechnology)
            {
                return new SecuringDataWithCurrentTechnology.View();
            }

            if (state.PageId == PageId.InitialLetters)
            {
                return new InitialLetters.AllInitialLetters();
            }
            
            if (state.PageId == PageId.QuestionAnswerPage)
            {
                return new QuestionAnswerPage.View();
            }

            if (state.PageId == PageId.ContactPage)
            {
                return new ContactPage.View();
            }

           

            if (state.PageId == PageId.CharacterCounting)
            {
                return new CharacterCountingView();
            }

            

            if (state.PageId == PageId.WordSearchingPage)
            {
                return new WordSearchingPage.View();
            }


            return new MainPageContent();
        }
        

       

       

        
         
    }

    
}