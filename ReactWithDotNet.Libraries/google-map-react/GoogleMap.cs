﻿namespace ReactWithDotNet.Libraries.google_map_react;

public sealed class GoogleMap : ThirdPartyReactComponent
{
    [React]
    [ReactTransformValueInClient("ReactWithDotNet::Core::ReplaceNullWhenEmpty")]
    public BootstrapURLKeys bootstrapURLKeys { get; } = new();

    [React]
    [ReactTransformValueInClient("ReactWithDotNet::Core::ReplaceNullWhenEmpty")]
    public DefaultCenter defaultCenter { get; } = new();

    [React]
    public int? defaultZoom { get; set; }
}

public sealed class BootstrapURLKeys
{
    public string key { get; set; }
}

public sealed class DefaultCenter
{
    public double? lat { get; set; }

    public double? lng { get; set; }
}