// import core library
import ReactWithDotNet from "./ReactWithDotNet";

// import libraries which you use in your porject
import "./integration/primereact";
import "./integration/rsuite";
import "./integration/react-xarrows";
import "./integration/google-map-react";


// your app specific imports and codes
import './app.css'


var currentScrollY = 0;

function OnMainDivScrollChanged(e)
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

        ReactWithDotNet.DispatchEvent('MainContentDivScrollChanged', [scrollY]);
    }
    else
    {
        currentScrollY = scrollY;
    }
}

ReactWithDotNet.RegisterExternalJsObject("OnMainDivScrollChanged", OnMainDivScrollChanged);
