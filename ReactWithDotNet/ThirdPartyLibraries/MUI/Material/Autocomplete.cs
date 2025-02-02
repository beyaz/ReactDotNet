﻿// auto generated code (do not edit manually)

namespace ReactWithDotNet.ThirdPartyLibraries.MUI.Material;

public partial class Autocomplete
{
    /// <summary>
    ///     Props applied to the [`Chip`](https://mui.com/material-ui/api/chip/) element.
    ///     <br/>
    ///     @deprecated Use `slotProps.chip` instead. This prop will be removed in v7. See [Migrating from deprecated APIs](/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    
    /// <summary>
    ///     The icon to display in place of the default clear icon.
    ///     <br/>
    ///     @default &lt;ClearIcon fontSize="small" /&gt;
    /// </summary>
    [ReactProp]
    public Element clearIcon { get; set; }
    
    /// <summary>
    ///     The icon to display in place of the default clear icon.
    ///     <br/>
    ///     @default &lt;ClearIcon fontSize="small" /&gt;
    /// </summary>
    public static Modifier ClearIcon(Element value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.clearIcon = value);
    
    /// <summary>
    ///     Override the default text for the *clear* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Clear'
    /// </summary>
    [ReactProp]
    public string clearText { get; set; }
    
    /// <summary>
    ///     Override the default text for the *clear* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Clear'
    /// </summary>
    public static Modifier ClearText(string value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.clearText = value);
    
    /// <summary>
    ///     Override the default text for the *close popup* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Close'
    /// </summary>
    [ReactProp]
    public string closeText { get; set; }
    
    /// <summary>
    ///     Override the default text for the *close popup* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Close'
    /// </summary>
    public static Modifier CloseText(string value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.closeText = value);
    
    /// <summary>
    ///     The props used for each slot inside.
    ///     <br/>
    ///     @deprecated Use the `slotProps` prop instead. This prop will be removed in v7. See [Migrating from deprecated APIs](https://mui.com/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic componentsProps { get; } = new ExpandoObject();
    
    /// <summary>
    ///     If `true`, the component is disabled.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disabled { get; set; }
    
    /// <summary>
    ///     If `true`, the component is disabled.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier Disabled(bool? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.disabled = value);
    
    /// <summary>
    ///     If `true`, the `Popper` content will be under the DOM hierarchy of the parent component.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? disablePortal { get; set; }
    
    /// <summary>
    ///     If `true`, the `Popper` content will be under the DOM hierarchy of the parent component.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier DisablePortal(bool? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.disablePortal = value);
    
    /// <summary>
    ///     Force the visibility display of the popup icon.
    ///     <br/>
    ///     @default 'auto'
    /// </summary>
    [ReactProp]
    public object forcePopupIcon { get; set; }
    
    /// <summary>
    ///     Force the visibility display of the popup icon.
    ///     <br/>
    ///     @default 'auto'
    /// </summary>
    public static Modifier ForcePopupIcon(object value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.forcePopupIcon = value);
    
    /// <summary>
    ///     If `true`, the input will take up the full width of its container.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? fullWidth { get; set; }
    
    /// <summary>
    ///     If `true`, the input will take up the full width of its container.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier FullWidth(bool? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.fullWidth = value);
    
    /// <summary>
    ///     The label to display when the tags are truncated (`limitTags`).
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {number} more The number of truncated tags.
    ///     <br/>
    ///     @returns {ReactNode}
    ///     <br/>
    ///     @default (more) =&gt; `+${more}`
    /// </summary>
    public delegate Element getLimitTagsTextDelegate(double? more);
    
    [ReactProp]
    public getLimitTagsTextDelegate getLimitTagsText { get; set; }
    
    /// <summary>
    ///     The label to display when the tags are truncated (`limitTags`).
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {number} more The number of truncated tags.
    ///     <br/>
    ///     @returns {ReactNode}
    ///     <br/>
    ///     @default (more) =&gt; `+${more}`
    /// </summary>
    public static Modifier GetLimitTagsText(getLimitTagsTextDelegate value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.getLimitTagsText = value);
    
    /// <summary>
    ///     The component used to render the listbox.
    ///     <br/>
    ///     @default 'ul'
    ///     <br/>
    ///     @deprecated Use `slotProps.listbox.component` instead. This prop will be removed in v7. See [Migrating from deprecated APIs](/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    
    /// <summary>
    ///     Props applied to the Listbox element.
    ///     <br/>
    ///     @deprecated Use `slotProps.listbox` instead. This prop will be removed in v7. See [Migrating from deprecated APIs](/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    
    /// <summary>
    ///     If `true`, the component is in a loading state.
    ///     <br/>
    ///     This shows the `loadingText` in place of suggestions (only if there are no suggestions to show, for example `options` are empty).
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? loading { get; set; }
    
    /// <summary>
    ///     If `true`, the component is in a loading state.
    ///     <br/>
    ///     This shows the `loadingText` in place of suggestions (only if there are no suggestions to show, for example `options` are empty).
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier Loading(bool? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.loading = value);
    
    /// <summary>
    ///     Text to display when in a loading state.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Loading…'
    /// </summary>
    [ReactProp]
    public Element loadingText { get; set; }
    
    /// <summary>
    ///     Text to display when in a loading state.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Loading…'
    /// </summary>
    public static Modifier LoadingText(Element value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.loadingText = value);
    
    /// <summary>
    ///     The maximum number of tags that will be visible when not focused.
    ///     <br/>
    ///     Set `-1` to disable the limit.
    ///     <br/>
    ///     @default -1
    /// </summary>
    [ReactProp]
    public double? limitTags { get; set; }
    
    /// <summary>
    ///     The maximum number of tags that will be visible when not focused.
    ///     <br/>
    ///     Set `-1` to disable the limit.
    ///     <br/>
    ///     @default -1
    /// </summary>
    public static Modifier LimitTags(double? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.limitTags = value);
    
    /// <summary>
    ///     Text to display when there are no options.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'No options'
    /// </summary>
    [ReactProp]
    public Element noOptionsText { get; set; }
    
    /// <summary>
    ///     Text to display when there are no options.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'No options'
    /// </summary>
    public static Modifier NoOptionsText(Element value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.noOptionsText = value);
    
    
    /// <summary>
    ///     Override the default text for the *open popup* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Open'
    /// </summary>
    [ReactProp]
    public string openText { get; set; }
    
    /// <summary>
    ///     Override the default text for the *open popup* icon button.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     For localization purposes, you can use the provided [translations](https://mui.com/material-ui/guides/localization/).
    ///     <br/>
    ///     @default 'Open'
    /// </summary>
    public static Modifier OpenText(string value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.openText = value);
    
    /// <summary>
    ///     The component used to render the body of the popup.
    ///     <br/>
    ///     @default Paper
    ///     <br/>
    ///     @deprecated Use `slots.paper` instead. This prop will be removed in v7. See [Migrating from deprecated APIs](/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    
    /// <summary>
    ///     The component used to position the popup.
    ///     <br/>
    ///     @default Popper
    ///     <br/>
    ///     @deprecated Use `slots.popper` instead. This prop will be removed in v7. See [Migrating from deprecated APIs](/material-ui/migration/migrating-from-deprecated-apis/) for more details.
    /// </summary>
    
    /// <summary>
    ///     The icon to display in place of the default popup icon.
    ///     <br/>
    ///     @default &lt;ArrowDropDownIcon /&gt;
    /// </summary>
    [ReactProp]
    public Element popupIcon { get; set; }
    
    /// <summary>
    ///     The icon to display in place of the default popup icon.
    ///     <br/>
    ///     @default &lt;ArrowDropDownIcon /&gt;
    /// </summary>
    public static Modifier PopupIcon(Element value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.popupIcon = value);
    
    /// <summary>
    ///     If `true`, the component becomes readonly. It is also supported for multiple tags where the tag cannot be deleted.
    ///     <br/>
    ///     @default false
    /// </summary>
    [ReactProp]
    public bool? readOnly { get; set; }
    
    /// <summary>
    ///     If `true`, the component becomes readonly. It is also supported for multiple tags where the tag cannot be deleted.
    ///     <br/>
    ///     @default false
    /// </summary>
    public static Modifier ReadOnly(bool? value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.readOnly = value);
    
    /// <summary>
    ///     Render the input.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {object} params
    ///     <br/>
    ///     @returns {ReactNode}
    /// </summary>
    public delegate Element renderInputDelegate(object @params);
    
    [ReactProp]
    public renderInputDelegate renderInput { get; set; }
    
    /// <summary>
    ///     Render the input.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {object} params
    ///     <br/>
    ///     @returns {ReactNode}
    /// </summary>
    public static Modifier RenderInput(renderInputDelegate value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.renderInput = value);
    
    /// <summary>
    ///     Render the option, use `getOptionLabel` by default.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {object} props The props to apply on the li element.
    ///     <br/>
    ///     @param {Value} option The option to render.
    ///     <br/>
    ///     @param {object} state The state of each option.
    ///     <br/>
    ///     @param {object} ownerState The state of the Autocomplete component.
    ///     <br/>
    ///     @returns {ReactNode}
    /// </summary>
    
    /// <summary>
    ///     Render the selected value.
    ///     <br/>
    ///     <br/>
    ///     <br/>
    ///     @param {Value[]} value The `value` provided to the component.
    ///     <br/>
    ///     @param {function} getTagProps A tag props getter.
    ///     <br/>
    ///     @param {object} ownerState The state of the Autocomplete component.
    ///     <br/>
    ///     @returns {ReactNode}
    /// </summary>
    
    /// <summary>
    ///     The size of the component.
    ///     <br/>
    ///     @default 'medium'
    /// </summary>
    [ReactProp]
    public string size { get; set; }
    
    /// <summary>
    ///     The size of the component.
    ///     <br/>
    ///     @default 'medium'
    /// </summary>
    public static Modifier Size(string value) => CreateThirdPartyReactComponentModifier<Autocomplete>(x => x.size = value);
    
    /// <summary>
    ///     The system prop that allows defining system overrides as well as additional CSS styles.
    /// </summary>
    [ReactProp]
    [ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]
    public dynamic sx { get; } = new ExpandoObject();
}
