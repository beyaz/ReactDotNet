﻿using ReactWithDotNet.WebSite.HeaderComponents;

namespace ReactWithDotNet.WebSite;

static class Dummy
{
    public static Menu Menu => MenuAccess.MenuList.First();

    public static MenuItem MenuItem => Menu.Children.First();

    public static string VideoUrl => "https://uploads.codesandbox.io/uploads/user/fb7bd72f-ef17-4810-9e14-ca854fb0f56e/9GBo-mountain-video.mp4";
}

class Deneme45
{
    public static string Abc5()
    {
        return static_method_1();
    }
    
    public static string static_method_1()
    {
        return static_method_2("abc-123-0","abc-123-1",7);
    }
    
    public static string static_method_2(string str1, string str2, int number1)
    {
        return str2;
    }
}