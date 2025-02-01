﻿// auto generated code (do not edit manually)

namespace ReactWithDotNet.ThirdPartyLibraries.MUI.Material;

public sealed class Tooltip : ElementBase
{
    /// <summary>
    ///     If `true`, adds an arrow to the tooltip.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? arrow { get; set; }
    
    /// <summary>
    ///     If `true`, adds an arrow to the tooltip.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier Arrow(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.arrow = value);
    
    /// <summary>
    ///     Override or extend the styles applied to the component.
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(convert_mui_style_map_to_class_map))]
    public Dictionary<string, Style> classes { get; } = new ();
    
    /// <summary>
    ///     The components used for each slot inside.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @deprecated use the `slots` prop instead. This prop will be removed in v7. See [Migrating from deprecated APIs](https://mui.com/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic components { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The extra props for the slot components.
    ///     <br/>
    ///     You can override the existing props or add new ones.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @deprecated use the `slotProps` prop instead. This prop will be removed in v7. See [Migrating from deprecated APIs](https://mui.com/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @default {}
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic componentsProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     Set to `true` if the `title` acts as an accessible description.
    ///     <br/>
    ///     By default the `title` acts as an accessible label for the child.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? describeChild { get; set; }
    
    /// <summary>
    ///     Set to `true` if the `title` acts as an accessible description.
    ///     <br/>
    ///     By default the `title` acts as an accessible label for the child.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DescribeChild(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.describeChild = value);
    
    /// <summary>
    ///     Do not respond to focus-visible events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disableFocusListener { get; set; }
    
    /// <summary>
    ///     Do not respond to focus-visible events.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DisableFocusListener(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.disableFocusListener = value);
    
    /// <summary>
    ///     Do not respond to hover events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disableHoverListener { get; set; }
    
    /// <summary>
    ///     Do not respond to hover events.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DisableHoverListener(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.disableHoverListener = value);
    
    /// <summary>
    ///     Makes a tooltip not interactive, i.e. it will close when the user
    ///     <br/>
    ///     hovers over the tooltip before the `leaveDelay` is expired.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disableInteractive { get; set; }
    
    /// <summary>
    ///     Makes a tooltip not interactive, i.e. it will close when the user
    ///     <br/>
    ///     hovers over the tooltip before the `leaveDelay` is expired.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DisableInteractive(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.disableInteractive = value);
    
    /// <summary>
    ///     Do not respond to long press touch events.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disableTouchListener { get; set; }
    
    /// <summary>
    ///     Do not respond to long press touch events.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DisableTouchListener(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.disableTouchListener = value);
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip.
    ///     <br/>
    ///     This prop won't impact the enter touch delay (`enterTouchDelay`).
    ///     <br/>
    ///     @default 100
    /// </summary>
    [ReactProp]
    public double? enterDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip.
    ///     <br/>
    ///     This prop won't impact the enter touch delay (`enterTouchDelay`).
    ///     <br/>
    ///     @default 100
    /// </summary>
    public static Modifier EnterDelay(double? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.enterDelay = value);
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip when one was already recently opened.
    ///     <br/>
    ///     @default 0
    /// </summary>
    [ReactProp]
    public double? enterNextDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before showing the tooltip when one was already recently opened.
    ///     <br/>
    ///     @default 0
    /// </summary>
    public static Modifier EnterNextDelay(double? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.enterNextDelay = value);
    
    /// <summary>
    ///     The number of milliseconds a user must touch the element before showing the tooltip.
    ///     <br/>
    ///     @default 700
    /// </summary>
    [ReactProp]
    public double? enterTouchDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds a user must touch the element before showing the tooltip.
    ///     <br/>
    ///     @default 700
    /// </summary>
    public static Modifier EnterTouchDelay(double? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.enterTouchDelay = value);
    
    /// <summary>
    ///     If `true`, the tooltip follow the cursor over the wrapped element.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? followCursor { get; set; }
    
    /// <summary>
    ///     If `true`, the tooltip follow the cursor over the wrapped element.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier FollowCursor(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.followCursor = value);
    
    /// <summary>
    ///     This prop is used to help implement the accessibility logic.
    ///     <br/>
    ///     If you don't provide this prop. It falls back to a randomly generated id.
    /// </summary>
    [ReactProp]
    public string id { get; set; }
    
    /// <summary>
    ///     This prop is used to help implement the accessibility logic.
    ///     <br/>
    ///     If you don't provide this prop. It falls back to a randomly generated id.
    /// </summary>
    public static Modifier Id(string value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.id = value);
    
    /// <summary>
    ///     The number of milliseconds to wait before hiding the tooltip.
    ///     <br/>
    ///     This prop won't impact the leave touch delay (`leaveTouchDelay`).
    ///     <br/>
    ///     @default 0
    /// </summary>
    [ReactProp]
    public double? leaveDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds to wait before hiding the tooltip.
    ///     <br/>
    ///     This prop won't impact the leave touch delay (`leaveTouchDelay`).
    ///     <br/>
    ///     @default 0
    /// </summary>
    public static Modifier LeaveDelay(double? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.leaveDelay = value);
    
    /// <summary>
    ///     The number of milliseconds after the user stops touching an element before hiding the tooltip.
    ///     <br/>
    ///     @default 1500
    /// </summary>
    [ReactProp]
    public double? leaveTouchDelay { get; set; }
    
    /// <summary>
    ///     The number of milliseconds after the user stops touching an element before hiding the tooltip.
    ///     <br/>
    ///     @default 1500
    /// </summary>
    public static Modifier LeaveTouchDelay(double? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.leaveTouchDelay = value);
    
    /// <summary>
    ///     Callback fired when the component requests to be closed.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {React.SyntheticEvent} event The event source of the callback.
    /// </summary>
    [ReactProp]
    public Func<MouseEvent, Task> onClose {get;set;}
    
    /// <summary>
    ///     Callback fired when the component requests to be open.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {React.SyntheticEvent} event The event source of the callback.
    /// </summary>
    [ReactProp]
    public Func<MouseEvent, Task> onOpen {get;set;}
    
    /// <summary>
    ///     If `true`, the component is shown.
    /// </summary>
    [ReactProp]
    public bool? open { get; set; }
    
    /// <summary>
    ///     If `true`, the component is shown.
    /// </summary>
    public static Modifier Open(bool? value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.open = value);
    
    /// <summary>
    ///     Tooltip placement.
    ///     <br/>
    ///     @default 'bottom'
    /// </summary>
    [ReactProp]
    public string placement { get; set; }
    
    /// <summary>
    ///     Tooltip placement.
    ///     <br/>
    ///     @default 'bottom'
    /// </summary>
    public static Modifier Placement(string value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.placement = value);
    
    /// <summary>
    ///     Props applied to the [`Popper`](https://mui.com/material-ui/api/popper/) element.
    ///     <br/>
    ///     @deprecated use the `slotProps.popper` prop instead. This prop will be removed in v7. See [Migrating from deprecated APIs](https://mui.com/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    ///     <br/>
    ///     @default {}
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic PopperProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     The system prop that allows defining system overrides as well as additional CSS styles.
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic sx { get; } = new ExpandoObject();
    
    /// <summary>
    ///     Tooltip title. Zero-length titles string, undefined, null and false are never displayed.
    /// </summary>
    [ReactProp]
    public Element title { get; set; }
    
    /// <summary>
    ///     Tooltip title. Zero-length titles string, undefined, null and false are never displayed.
    /// </summary>
    public static Modifier Title(Element value) => CreateThirdPartyReactComponentModifier<Tooltip>(x => x.title = value);
    
    protected override Element GetSuspenseFallbackElement()
    {
        return _children?.FirstOrDefault() ?? new ReactWithDotNetSkeleton.Skeleton();
    }
    
    public Tooltip(){ }
    
    public Tooltip(params Action<Tooltip>[] modifiers) => modifiers.ApplyAll(Add);
    
    public Tooltip(StyleModifier styleModifier, params Action<Tooltip>[] modifiers)
    {
        Add(styleModifier);
        modifiers.ApplyAll(Add);
    }
    
    public void Add(Action<Tooltip> modify) => modify?.Invoke(this);
}
