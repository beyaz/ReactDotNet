﻿using System;
using System.Net.Mime;
using ReactWithDotNet;
using ReactWithDotNet.PrimeReact;

namespace QuranAnalyzer.WebUI.Components;



class divWithBorder: div
{
    public divWithBorder()
    {
        style.border       = "1px solid rgb(218, 220, 224)";
        style.borderRadius = "5px";
    }
}

class SiteTitle : div
{
    public SiteTitle(string innerText)
    {
        this.innerText = innerText;
        
        style.fontSize = "20px";
    }
}

class LargeTitle : ReactComponent
{
    readonly string text;

    public LargeTitle(string text)
    {
        this.text = text;
    }
    
    public override Element render()
    {
        return new div
        {
            style    = { fontSize = "18px", textAlign = "center", fontWeight = "500"},
            text = text
        };
    }
}


class Important : ReactComponent
{
    readonly string text;

    public Important(string text)
    {
        this.text = text;
    }

    public override Element render()
    {
        return new div
        {
            style = { fontWeight = "500" },
            text  = text
        };
    }
}


class Title : div
{
    public Title(string innerText)
    {
        this.innerText = innerText;

        style.fontSize  = "18px";
        style.textAlign = "center";
    }
}

class SubTitle : div
{
    public SubTitle(string innerText)
    {
        this.innerText = innerText;

        style.fontSize  = "16px";
        style.textAlign = "center";
    }
}

class Article : ReactComponent
{
    public override Element render()
    {
        return new article
        {
            style = { marginLeftRight = "8px", paddingLeftRight = "16px"},
            Children = children
        };
    }
}

class Backdrop: ReactComponent
{
    public Action<string> onClick { get; set; }
    
    public override Element render()
    {
        return new div
        {
            onClick = onClick,
            style =
            {
                position = "absolute",
                top="0",
                left="0",
                zIndex = "1040",
                width = "100vw",
                height = "100vh",
                background = "#f6fbff",
                opacity = "0.3"
            },
            Children = children
        };
    }
}