﻿using QuranAnalyzer.WebUI.Pages.AlternativeSystems;
using QuranAnalyzer.WebUI.Pages.CharacterCountingPage;
using QuranAnalyzer.WebUI.Pages.CountOfAllahPage;
using QuranAnalyzer.WebUI.Pages.DefinitionPage;
using QuranAnalyzer.WebUI.Pages.InitialLetters;
using QuranAnalyzer.WebUI.Pages.VerseListContainsAllInitialLettersPage;
using QuranAnalyzer.WebUI.Pages.WordSearchingPage;

namespace QuranAnalyzer.WebUI.Pages.MainPage;

class View : ReactPureComponent
{
    string SelectedPageId => Context.Query[QueryKey.Page] ?? PageId.MainPage;

    protected override Element render()
    {
        return new div(WidthMaximized, HeightAuto)
        {
            new FixedTopPanelContainer(),

            new main(DisplayFlex, FlexDirectionRow, JustifyContentCenter, HeightAuto)
            {
                new MainContentContainer
                {
                    MarginTopBottom(30),

                    new LeftMenu
                    {
                        SelectedPageId = SelectedPageId,
                        style =
                        {
                            MinWidth(230),
                            MarginTop(101),
                            MediaQueryOnMobile(new Style { DisplayNone })
                        }
                    },

                    buildMainContent()
                }
            }
        };

        Element buildMainContent()
        {
            return SelectedPageId switch
            {
                PageId.MainPage                               => new MainPageContent(),
                PageId.SecuringDataWithCurrentTechnology      => new SecuringDataWithCurrentTechnology.PageSecuringDataWithCurrentTechnology(),
                PageId.PreInformation                         => new PagePreInformation(),
                PageId.InitialLetters                         => new AllInitialLetters(),
                PageId.QuestionAnswerPage                     => new PageQuestionAnswer(),
                PageId.ContactPage                            => new ContactPage.View(),
                PageId.CharacterCounting                      => new CharacterCountingView(),
                PageId.WordSearchingPage                      => new WordSearchingView(),
                PageId.AlternativeSystems                     => new AlternativeSystemsView(),
                PageId.Definition                             => new DefinitionView(),
                PageId.PageIdOfMushafOptionsDetail            => new MushafOptionsDetail.View(),
                PageId.WhoIsReshadKhalifePage                 => new PageWhoIsReshadKhalife(),
                PageId.WhyFamousPeopleAreSilentPage           => new PageWhyFamousPeopleAreSilent(),
                PageId.AboutEdipYukselPage                    => new PageAboutEdipYuksel(),
                PageId.PageVerseListContainsAllInitialLetters => new PageVerseListContainsAllInitialLetters(),
                PageId.AdditionalVersesPage                   => new PageAdditionalVerses(),
                PageId.CountOfAllahPage                       => new CountOfAllah(),
                PageId.AllInitialLettersCombined              => new AllInitialLettersCombined.View(),
                PageId.WhereIsTheProblemPage                  => new PageWhereIsTheProblem(),
                PageId.IsHeMessangerPage                      => new PageIsHeMessanger(),
                _                                             => new MainPageContent()
            };
        }
    }
}