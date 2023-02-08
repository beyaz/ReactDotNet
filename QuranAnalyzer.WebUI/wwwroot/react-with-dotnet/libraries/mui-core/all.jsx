import React from 'react';

import ReactWithDotNet from "../../react-with-dotnet";

import FormGroup from '@mui/material/FormGroup';
import FormControlLabel from '@mui/material/FormControlLabel';
import Tooltip from '@mui/material/Tooltip';


function register(name, value)
{
    ReactWithDotNet.RegisterExternalJsObject("ReactWithDotNet.Libraries.mui.material." + name, value);
}

// Connect components as Lazy
register("Switch", React.lazy(() => import('./Switch')));
register("Tooltip", Tooltip);
register("FormGroup", FormGroup);
register("FormControlLabel", FormControlLabel);
