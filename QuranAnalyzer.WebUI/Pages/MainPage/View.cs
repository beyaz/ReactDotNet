﻿using QuranAnalyzer.WebUI.Components;
using QuranAnalyzer.WebUI.Pages.CharacterCountingPage;
using QuranAnalyzer.WebUI.Pages.InitialLetters;
using QuranAnalyzer.WebUI.Pages.VerseListContainsAllInitialLettersPage;

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
        state = new MainViewModel
        {
            PageId = Context.Query[QueryKey.Page]
        };

        
        Client.OnHandleHamburgerMenuOpened(OnHamburgerMenuOpened);
        Client.OnHamburgerMenuClosed(OnHamburgerMenuClosed);
    }

    void OnHamburgerMenuClosed()
    {
        state.HamburgerMenuIsOpen = false;
        Context.Set(ContextKey.HamburgerMenuIsOpen,state.HamburgerMenuIsOpen);
    }

     void OnHamburgerMenuOpened()
    {
        state.HamburgerMenuIsOpen = true;
    }

    protected override Element render()
    {
        
        
        
        var IsBackDropActive = state.HamburgerMenuIsOpen;

        var top = new FixedTopPanelContainer();

        var left = new FixedLeftMenuContainer { IsOpen = state.HamburgerMenuIsOpen };
        
        var main = new div
        {
            id = "main",
            onScroll = "OnMainDivScrollChanged",
            children =
            {
                new div
                {
                    style = { display = "flex", justifyContent = "center", height = "100%" },
                    children =
                    {
                        new BackdropView { IsActive = IsBackDropActive },
                        new FlexRow(PaddingLeftRight("10%"))
                        {
                            style    =
                            {
                                marginLeftRight = "10px", marginTop = "30px", width = "100%" ,
                                MediaQuery =
                                {
                                    {"(min-width:500px)",new Style {
                                        PaddingLeftRight("5%")
                                    }}
                                }
                            },
                            children =
                            {
                                new LeftMenu{MinWidth(230), MarginTop(100),PositionSticky,Top(30)},
                                buildMainContent()
                            }
                        }
                    }
                }
            },

            style =
            {
                position     = "fixed",
                top          = "0px",
                left         = IsBackDropActive ? "400px" : "0px",
                marginTop    = "50px",
                marginBottom = "27px",

                width     = IsBackDropActive ? "calc(100% - 400px)" : "100%",
                height    = "calc(100% - 65px)",
                overflowY = "auto"
            }
        };

        return new div
        {
            children = { top, left, main },
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

            if (state.PageId == PageId.PreInformation)
            {
                return new PreInformation.PreInformationView();
            }

            if (state.PageId == PageId.InitialLetters)
            {
                return new AllInitialLetters();
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
                return new WordSearchingPage.WordSearchingView();
            }

            if (state.PageId == PageId.AlternativeSystems)
            {
                return new AlternativeSystems.AlternativeSystemsView();
            }

            if (state.PageId == PageId.Definition)
            {
                return new DefinitionPage.DefinitionView();
            }

            if (state.PageId == PageId.PageIdOfMushafOptionsDetail)
            {
                return new MushafOptionsDetail.View();
            }

            if (state.PageId == PageId.WhoIsReshadKhalifePage)
            {
                return new WhoIsReshadKhalifePage();
            }

            if (state.PageId == PageId.PageVerseListContainsAllInitialLetters)
            {
                return new PageVerseListContainsAllInitialLetters();
            }
            

            return new MainPageContent();
        }
    }
}