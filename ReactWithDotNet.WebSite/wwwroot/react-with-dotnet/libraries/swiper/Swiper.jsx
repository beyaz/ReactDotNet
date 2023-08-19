
import ReactWithDotNet from "../../react-with-dotnet";

import { Swiper } from 'swiper/react';

// import Swiper core and required modules
import {
    Navigation,
    Pagination,
    Scrollbar,
    A11y,
    Thumbs,
    FreeMode,
    Autoplay,
    EffectFade,
    EffectCube,
    EffectFlip,
    EffectCards,
    EffectCreative
} from 'swiper/modules';



// Import Swiper styles
import 'swiper/css';
import 'swiper/css/navigation';
import 'swiper/css/pagination';
import 'swiper/css/scrollbar';
import 'swiper/css/effect-fade';
import 'swiper/css/free-mode';
import 'swiper/css/thumbs';
import 'swiper/css/effect-cube';
import 'swiper/css/effect-flip';
import 'swiper/css/effect-cards';
import 'swiper/css/effect-creative';

const ModuleMap = [
    ['Navigation', Navigation],
    ['Pagination', Pagination],
    ['Scrollbar', Scrollbar],
    ['A11y', A11y],
    ['Thumbs', Thumbs],
    ['FreeMode', FreeMode],    
    ['Autoplay', Autoplay],
    ['EffectFade', EffectFade],
    ['EffectCube', EffectCube],
    ['EffectFlip', EffectFlip],
    ['EffectCards', EffectCards],
    ['EffectCreative', EffectCreative]
];

function ToSwiperModule(moduleName)
{
    for (var i = 0; i < ModuleMap.length; i++)
    {
        const arr = ModuleMap[i];

        for (var j = 0; j < arr.length; j++)
        {
            if (moduleName === arr[j])
            {
                return arr[1];
            }
        }
    }

    throw 'ToSwiperModule -> invalidArgument: ' + moduleName;
}

function ConvertToSwiperModules(moduleNames)
{
    if (moduleNames)
    {
        for (var i = 0; i < moduleNames.length; i++)
        {
            moduleNames[i] = ToSwiperModule(moduleNames[i]);
        }
    }
   
    return moduleNames;
}

/**
 * @param {string} dotNetFullClassNameOf3rdPartyComponent
 */
ReactWithDotNet.OnThirdPartyComponentPropsCalculated('ReactWithDotNet.ThirdPartyLibraries._Swiper_.Swiper', props =>
{
    if (props.modules)
    {
        ConvertToSwiperModules(props.modules);
    }

    return props;
});

export default Swiper;