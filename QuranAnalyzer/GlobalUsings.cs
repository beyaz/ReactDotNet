﻿global using System;
global using System.Collections.Generic;
global using System.Linq;

// fix visual studio bug
// https://stackoverflow.com/questions/64749385/predefined-type-system-runtime-compilerservices-isexternalinit-is-not-defined
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit
    {
    }
}