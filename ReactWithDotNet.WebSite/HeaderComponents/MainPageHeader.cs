﻿namespace ReactWithDotNet.WebSite.HeaderComponents;

class MainPageHeader : PureComponent
{
    protected override Element render()
    {
        return new header(DisplayFlex, JustifyContentCenter, BoxShadow($"inset 0px -1px 1px {Theme.grey_100}"))
        {
            new div(ContainerStyle)
            {
                new HeaderMenuBar()
            }
        };
    }
}