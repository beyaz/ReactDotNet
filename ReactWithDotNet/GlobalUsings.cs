﻿global using System;
global using System.Linq.Expressions;
global using static ReactWithDotNet.Extensions;

//global using JsMap2 = System.Collections.Generic.Dictionary<string, object>;

global using JsMap2 = ReactWithDotNet.JsMap;


// fix visual studio bug
// https://stackoverflow.com/questions/64749385/predefined-type-system-runtime-compilerservices-isexternalinit-is-not-defined
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

