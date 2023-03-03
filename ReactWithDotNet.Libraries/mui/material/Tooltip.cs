// auto generated code (do not edit manually)

namespace ReactWithDotNet.Libraries.mui.material;

public sealed class Tooltip : ElementBase
{
    /// <summary>
    ///     If `true`, adds an arrow to the tooltip.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? arrow { get; set; }
    
    /// <summary>
    ///     Override or extend the styles applied to the component.
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(convert_mui_style_map_to_class_map))]
    public Dictionary<string, Style> classes { get; } = new ();
    
    /// <summary>
    ///     The components used for each slot inside.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     This prop is an alias for the `slots` prop.
    ///     <br/>
    ///     It's recommended to use the `slots` prop instead.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic components { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The extra props for the slot components.
    ///     <br/>
    ///     You can override the existing props or add new ones.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     This prop is an alias for the `slotProps` prop.
    ///     <br/>
    ///     It's recommended to use the `slotProps` prop instead, as `componentsProps` will be deprecated in the future.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic componentsProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     Set to `true` if the `title` acts as an accessible description.
    ///     <br/>
    ///     By default the `title` acts as an accessible label for the child.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? describeChild { get; set; }
    
    /// <summary>
    ///     Do not respond to focus-visible events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? disableFocusListener { get; set; }
    
    /// <summary>
    ///     Do not respond to hover events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? disableHoverListener { get; set; }
    
    /// <summary>
    ///     Makes a tooltip not interactive, i.e. it will close when the user
    ///     <br/>
    ///     hovers over the tooltip before the `leaveDelay` is expired.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? disableInteractive { get; set; }
    
    /// <summary>
    ///     Do not respond to long press touch events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? disableTouchListener { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip.
    ///     <br/>
    ///     This prop won't impact the enter touch delay (`enterTouchDelay`).
    ///     <br/>
    ///     @default 100
    /// </summary>
    [React]
    public double? enterDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip when one was already recently opened.
    ///     <br/>
    ///     @default 0
    /// </summary>
    [React]
    public double? enterNextDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds a user must touch the element before showing the tooltip.
    ///     <br/>
    ///     @default 700
    /// </summary>
    [React]
    public double? enterTouchDelay { get; set; }
    
    /// <summary>
    ///     If `true`, the tooltip follow the cursor over the wrapped element.
    ///     <br/>
    ///     @default false
    /// </summary>
    [React]
    public bool? followCursor { get; set; }
    
    /// <summary>
    ///     This prop is used to help implement the accessibility logic.
    ///     <br/>
    ///     If you don't provide this prop. It falls back to a randomly generated id.
    /// </summary>
    [React]
    public string id { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before hiding the tooltip.
    ///     <br/>
    ///     This prop won't impact the leave touch delay (`leaveTouchDelay`).
    ///     <br/>
    ///     @default 0
    /// </summary>
    [React]
    public double? leaveDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds after the user stops touching an element before hiding the tooltip.
    ///     <br/>
    ///     @default 1500
    /// </summary>
    [React]
    public double? leaveTouchDelay { get; set; }
    
    /// <summary>
    ///     Callback fired when the component requests to be closed.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {React.SyntheticEvent} event The event source of the callback.
    /// </summary>
    
    /// <summary>
    ///     Callback fired when the component requests to be open.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {React.SyntheticEvent} event The event source of the callback.
    /// </summary>
    
    /// <summary>
    ///     If `true`, the component is shown.
    /// </summary>
    [React]
    public bool? open { get; set; }
    
    /// <summary>
    ///     Tooltip placement.
    ///     <br/>
    ///     @default 'bottom'
    /// </summary>
    [React]
    public string placement { get; set; }
    
    /// <summary>
    ///     Props applied to the [`Popper`](/material-ui/api/popper/) element.
    ///     <br/>
    ///     @default {}
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic PopperProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The extra props for the slot components.
    ///     <br/>
    ///     You can override the existing props or add new ones.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     This prop is an alias for the `componentsProps` prop, which will be deprecated in the future.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic slotProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The components used for each slot inside.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     This prop is an alias for the `components` prop, which will be deprecated in the future.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [React]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic slots { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The system prop that allows defining system overrides as well as additional CSS styles.
    /// </summary>
    [React]
    [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
    public dynamic sx { get; } = new ExpandoObject();
    
    /// <summary>
    ///     Tooltip title. Zero-length titles string, undefined, null and false are never displayed.
    /// </summary>
    [React]
    public Element title { get; set; }
    
    protected override Element GetSuspenseFallbackElement()
    {
        return _children?.FirstOrDefault() ?? new ReactWithDotNetSkeleton.Skeleton();
    }
}
