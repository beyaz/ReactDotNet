import React from 'react';

import ReactWithDotNet from "../../react-with-dotnet";

import { motion } from "framer-motion"

motion.div

function register(name, value)
{
    ReactWithDotNet.RegisterExternalJsObject("ReactWithDotNet.ThirdPartyLibraries.FramerMotion." + name, value);
}

// Connect components as Lazy
register("motion_div", React.lazy(() => import('./motion.div')));
