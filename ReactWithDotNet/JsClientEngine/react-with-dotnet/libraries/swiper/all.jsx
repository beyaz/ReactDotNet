import React from 'react';

import ReactWithDotNet from "../../react-with-dotnet";

// NOTE: Swiper has bug when Lazy load, we need to load sync mode
import { SwiperSlide } from 'swiper/react';

function register(name, value)
{
    ReactWithDotNet.RegisterExternalJsObject("ReactWithDotNet.ThirdPartyLibraries._Swiper_." + name, value);
}

register("Swiper", React.lazy(() => import('./Swiper')));
register("SwiperSlide", SwiperSlide);

register('ReactWithDotNet.ThirdPartyLibraries._Swiper_::GrabSwiperInstance', function (args)
{
    return [{ realIndex: args[0].realIndex }];
});