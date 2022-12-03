// import core library
import ReactWithDotNet from "./react-with-dotnet/react-with-dotnet";

// import libraries which you use in your porject
import "./react-with-dotnet/libraries/react-xarrows";
import "./react-with-dotnet/libraries/react-free-scrollbar";

// your app specific imports and codes
import './app.css'

var currentScrollY = 0;

ReactWithDotNet.RegisterExternalJsObject("OnMainDivScrollChanged", function (e)
{
    var scrollY = e.target.scrollTop;

    function canFireAction()
    {
        if (scrollY > 0)
        {
            return currentScrollY === 0;
        }

        if (currentScrollY > 0)
        {
            return true;   
        }

        return false;
    }

    if (canFireAction())
    {
        currentScrollY = scrollY;

        ReactWithDotNet.DispatchEvent('MainContentDivScrollChangedOverZero', [scrollY]);
    }
    else
    {
        currentScrollY = scrollY;
    }
});
