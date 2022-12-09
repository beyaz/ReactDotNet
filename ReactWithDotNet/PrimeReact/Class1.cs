﻿
namespace ReactWithDotNet.PrimeReact;


[Serializable]
public class TreeNode
{
    public string key { get; set; }
    public string label { get; set; }
    public string data { get; set; }
    public string icon { get; set; }
    public string className { get; set; }

    public Style style { get; } = new ();

   
}