
import ReactWithDotNet from "../ReactWithDotNet.jsx";

// primereact
import { Button } from 'primereact/button';
import { InputText } from 'primereact/inputtext';
import { InputTextarea } from 'primereact/inputtextarea';
import { BlockUI } from 'primereact/BlockUI';
import { Card } from 'primereact/Card';
import { TabView, TabPanel } from 'primereact/tabview';
import { Splitter, SplitterPanel } from 'primereact/splitter';
import { Slider } from 'primereact/Slider';
import { ListBox } from 'primereact/ListBox';
import { Dropdown } from 'primereact/Dropdown';
import { Column } from 'primereact/Column';
import { DataTable } from 'primereact/DataTable';
import { Checkbox } from 'primereact/Checkbox';
import { InputMask } from 'primereact/InputMask';
import { AutoComplete } from 'primereact/autocomplete';
import { Tree } from 'primereact/tree';
import { InputSwitch } from 'primereact/inputswitch';
import { Panel } from 'primereact/panel';
import { Tooltip } from 'primereact/tooltip';
import { ScrollPanel } from 'primereact/scrollpanel';
import { Message } from 'primereact/message';

function register(name, value)
{
    ReactWithDotNet.RegisterExternalJsObject("ReactWithDotNet.PrimeReact." + name, value);
}

register("Button", Button);
register("InputText", InputText);
register("InputTextarea", InputTextarea);
register("BlockUI", BlockUI);
register("Card", Card);
register("TabView", TabView);
register("TabPanel", TabPanel);
register("SplitterPanel", SplitterPanel);
register("Splitter", Splitter);
register("Slider", Slider);
register("ListBox", ListBox);
register("Dropdown", Dropdown);
register("Column", Column);
register("DataTable", DataTable);
register("Checkbox", Checkbox);
register("InputMask", InputMask);
register("AutoComplete", AutoComplete);
register("Tree", Tree);
register("InputSwitch", InputSwitch);
register("Panel", Panel);
register("Tooltip", Tooltip);
register("Message", Message);
register("ScrollPanel", ScrollPanel);

register("Panel::GetHeaderTemplate", (key) => ReactWithDotNet.GetExternalJsObject(key));

register("GrabOnlyValueParameterFromCommonPrimeReactEvent", function (argumentsAsArray)
{
    //const originalEvent = argumentsAsArray[0].originalEvent;

    const value = argumentsAsArray[0].value;

    return [{ value: value }];
});