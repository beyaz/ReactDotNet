﻿using ReactWithDotNet.ThirdPartyLibraries._react_split_;
using ReactWithDotNet.ThirdPartyLibraries.PrimeReact;
using ReactWithDotNet.ThirdPartyLibraries.ReactFreeScrollbar;
using static ReactWithDotNet.WebSite.Components.LivePreview;

namespace ReactWithDotNet.WebSite.HelperApps;

record HtmlToCSharpViewModel
{
    public string RenderPartOfCSharpCode { get; init; }
    public int EditCount { get; init; }
    public string HtmlText { get; init; }
    public string StatusMessage { get; init; }
    public string Guid { get; init; }
}

class HtmlToCSharpView : Component<HtmlToCSharpViewModel>
{
    static ScriptManager Scripts => ScriptManager.Instance;

    public Task Refresh()
    {
        return Task.CompletedTask;
    }

    protected override Task constructor()
    {
        state = new()
        {
            HtmlText = @"
<div style='width: 100%; height: 100%; border-left: 0.50px #DBDBDB solid; border-top: 0.50px #DBDBDB solid; border-right: 0.50px #DBDBDB solid; border-bottom: 0.50px #DBDBDB solid; justify-content: flex-start; align-items: flex-start; gap: 10px; display: inline-flex'>
    <div style='flex: 1 1 0; height: 433px; flex-direction: column; justify-content: flex-start; align-items: flex-start; gap: 15px; display: inline-flex'>
        <img style='width: 405px; height: 186px; background: linear-gradient(0deg, #C4C4C4 0%, #C4C4C4 100%)' src='https://cdn.gezbegen.com/wp-content/uploads/2016/03/maldivler.jpg' />
        <div style='align-self: stretch; height: 180px; padding-left: 16px; padding-right: 16px; flex-direction: column; justify-content: flex-start; align-items: flex-start; gap: 8px; display: flex'>
            <div style='align-self: stretch; height: 36px; justify-content: space-between; align-items: center; gap: 32px; display: inline-flex'>
                <div style='padding-left: 10px; padding-right: 10px; padding-top: 4px; padding-bottom: 4px; background: #F6F6F6; justify-content: flex-start; align-items: flex-start; gap: 10px; display: flex'>
                    <div style='color: #4A4A49; font-size: 14px; font-family: Open Sans; font-weight: 600; line-height: 24px; word-wrap: break-word'>Geziler</div>
                </div>
                <div style='padding: 10px; justify-content: flex-start; align-items: flex-start; gap: 10px; display: flex'>
                    <div style='color: #79797B; font-size: 12px; font-family: Open Sans; font-weight: 600; line-height: 16px; word-wrap: break-word'>5 dk okuma</div>
                </div>
            </div>
            <div style='align-self: stretch; color: #4A4A49; font-size: 16px; font-family: SF Pro Text; font-weight: 600; line-height: 24px; word-wrap: break-word'>Massa aenean tortor nunc egestas. At amet, risus facilisi sed.</div>
            <div style='align-self: stretch; height: 84px; color: #4A4A49; font-size: 14px; font-family: Open Sans; font-weight: 400; line-height: 20px; word-wrap: break-word'>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Tempus tristique id leo scelerisque dui a, ultricies. Massa aenean tortor nunc egestas. At amet, risus.</div>
            <div style='align-self: stretch; color: #79797B; font-size: 12px; font-family: Open Sans; font-weight: 700; text-transform: uppercase; line-height: 16px; word-wrap: break-word'>Bugün</div>
        </div>
    </div>
</div>
",

            Guid = Guid.NewGuid().ToString("N")
        };

        CalculateOutput();

        return Task.CompletedTask;
    }

    protected override Element render()
    {
        var htmlEditor = new CSharpCodeEditor
        {
            valueBind                = () => state.HtmlText,
            valueBindDebounceHandler = HtmlText_OnEditFinished
        };

        var csharpEditor = new CSharpCodeEditor
        {
            valueBind                = () => state.RenderPartOfCSharpCode,
            valueBindDebounceHandler = RenderPartOfCSharpCode_OnEditFinished
        };

        var statusMessageEditor = new Message
        {
            severity = "success",
            text     = state.StatusMessage,
            style    = { position = "fixed", zIndex = "5", bottom = "25px", right = "25px", display = state.StatusMessage is null ? "none" : "" }
        };

        return new FlexColumn
        {
            SizeFull,
            Padding(10),
            FontSize13,

            new FlexRow(FontSize23, Padding(10), WidthFull, JustifyContentSpaceBetween)
            {
                "Html to ReactWithDotNet",
                new FlexRow(AlignItemsCenter, FontSize12)
                {
                    new b(FontWeight500)
                    {
                        "Usage Info"
                    },
                    ": Paste any html input panel then c# code will be genered automatically.",
                    
                    SpaceX(4),
                    new PlayButton
                    {
                        Label    = "Play tutorial (2 min)",
                        VideoUrl = Dummy.VideoUrl,
                    }

                    
                }
            },
            new FlexRow(SizeFull)
            {
                new TwoRowSplittedForm
                {
                    new FlexColumn(SizeFull, Gap(8))
                    {
                        new GroupBox
                        {
                            Title = "Html input",
                            children =
                            {
                                new FreeScrollBar
                                {
                                    htmlEditor
                                }
                            }
                        },

                        new GroupBox
                        {
                            Title = "c# output",
                            children =
                            {
                                new FreeScrollBar
                                {
                                    new FlexColumn(HeightFull)
                                    {
                                        csharpEditor
                                    }
                                }
                            }
                        }
                    },

                    new GroupBox
                    {
                        Title = "Preview",
                        children =
                        {
                            new FlexColumn(SizeFull, Padding(8))
                            {
                                new iframe
                                {
                                    id    = state.Guid,
                                    src   = Page.LivePreviewUrl(state.Guid),
                                    style = { BorderNone, SizeFull },
                                    title = "Live Editor Preview"
                                }
                            }
                        },
                        style =
                        {
                            // paper
                            BackgroundImage("radial-gradient(#a5a8ed 0.5px, #f8f8f8 0.5px)"),
                            BackgroundSize("10px 10px")
                        }
                    }
                }
            },

            statusMessageEditor
        };
    }

    void CalculateOutput()
    {
        try
        {
            state = state with
            {
                RenderPartOfCSharpCode = HtmlToReactWithDotNetCsharpCodeConverter.HtmlToCSharp(state.HtmlText)
            };

            Scripts[state.Guid] = new()
            {
                RenderPartOfCSharpCode = state.RenderPartOfCSharpCode
            };

            RefreshComponentPreview(Client, state.Guid);
        }
        catch (Exception exception)
        {
            state = state with { StatusMessage = "Error occured: " + exception.Message };
        }
    }

    Task HtmlText_OnEditFinished()
    {
        OnHtmlValueChanged(state.HtmlText);
        return Task.CompletedTask;
    }

    void OnHtmlValueChanged(string htmlText)
    {
        state = state with
        {
            EditCount = state.EditCount + 1,
            StatusMessage = null,
            HtmlText = htmlText
        };

        if (string.IsNullOrWhiteSpace(htmlText))
        {
            state = state with
            {
                RenderPartOfCSharpCode = null
            };

            Scripts[state.Guid] = null;

            return;
        }

        CalculateOutput();
    }

    Task RenderPartOfCSharpCode_OnEditFinished()
    {
        Scripts[state.Guid] = new()
        {
            RenderPartOfCSharpCode = state.RenderPartOfCSharpCode
        };

        RefreshComponentPreview(Client, state.Guid);

        return Task.CompletedTask;
    }

    class GroupBox : PureComponent
    {
        public string Title { get; init; }

        protected override Element render()
        {
            return new fieldset(SizeFull, Border(Solid(0.8, rgb(226, 232, 240))), BorderRadius(4))
            {
                new legend(MarginLeftRight(8), DisplayFlexRowCentered, Border(Solid(0.8, rgb(226, 232, 240))), BorderRadius(4))
                {
                    new label(FontWeight600, PaddingLeftRight(4))
                    {
                        Title
                    }
                },

                children
            };
        }
    }

    class TwoRowSplittedForm : PureComponent
    {
        protected override Element render()
        {
            return new FlexRow(SizeFull)
            {
                new style
                {
                    new("gutter",
                    [
                        BackgroundRepeatNoRepeat,
                        BackgroundPosition("50%")
                    ]),
                    new("gutter.gutter-horizontal",
                    [
                        BackgroundImage("url('data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAeCAYAAADkftS9AAAAIklEQVQoU2M4c+bMfxAGAgYYmwGrIIiDjrELjpo5aiZeMwF+yNnOs5KSvgAAAABJRU5ErkJggg==')"),
                        Cursor("col-resize")
                    ])
                },

                new Split
                {
                    sizes      = [40, 60],
                    gutterSize = 12,
                    style      = { WidthFull, DisplayFlexRow },

                    children =
                    {
                        children
                    }
                }
            };
        }
    }
}