﻿using ReactDotNet;

namespace QuranAnalyzer.WebUI;

class FactMiniViewModel
{
    public ClientTask ClientTask { get; set; }
    public FactModel Fact { get; set; }
}

class FactMiniView : ReactComponent<FactMiniViewModel>
{
    public FactMiniView()
    {
        state = new FactMiniViewModel();
    }

    void OnClicked(string name)
    {
        state.ClientTask = new ClientTask
        {
            DispatchEvent           = true,
            DispatchEventName       = "OnFactClicked",
            DispatchEventParameters = new object[] {name}
        };
    }

    public override Element render()
    {
        var model = state.Fact;

        var title = new div
        {
            text = model.Name,
            style =
            {
                color      = "#08090a",
                fontSize   = "17px",
                fontWeight = "600"
            }
        };

        var description = new div
        {
            text = model.ShortDescription,
            style =
            {
                wordBreak = WordBreak.break_all,
                margin    = "15px",
                fontSize  = ReactDotNet.Mixin.px(13),
                color     = "#546285"
            }
        };

        return new div
               {
                   onClick = () => OnClicked(state.Fact.Name),
                   children =
                   {
                       new div
                       {
                           title,
                           description
                       }
                       + new Style
                       {
                           padding = "5px"
                       }
                   }
               }
               + new Style
               {
                   border         = "1px solid #ced4da",
                   borderRadius   = "5px",
                   width          = ReactDotNet.Mixin.px(150),
                   height         = ReactDotNet.Mixin.px(150),
                   boxShadow      = "0 4px 8px 0 rgba(0,0,0,0.2)",
                   margin         = ReactDotNet.Mixin.px(20),
                   display        = Display.flex,
                   justifyContent = JustifyContent.center,
                   alignItems     = AlignItems.center,
                   flexDirection  = FlexDirection.column,
                   textAlign      = TextAlign.center,
                   fontFamily     = "Verdana,sans-serif",
                   cursor = Cursor.pointer
               };
    }
}