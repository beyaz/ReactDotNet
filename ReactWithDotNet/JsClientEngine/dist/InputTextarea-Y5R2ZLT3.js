import{a as d}from"./chunk-SLTOXZYO.js";import{a as I}from"./chunk-RVEJIPMH.js";import"./chunk-G7S3TOUE.js";import{B as R,C as w,a as g,b as m,d as u,m as O,u as x}from"./chunk-NI4MO4TP.js";import"./chunk-DLL45UCJ.js";import{a as V}from"./chunk-2W22VGCX.js";import{h as k}from"./chunk-GYULANB4.js";var i=k(V());function h(){return h=Object.assign?Object.assign.bind():function(n){for(var t=1;t<arguments.length;t++){var r=arguments[t];for(var o in r)Object.prototype.hasOwnProperty.call(r,o)&&(n[o]=r[o])}return n},h.apply(this,arguments)}function f(n){"@babel/helpers - typeof";return f=typeof Symbol=="function"&&typeof Symbol.iterator=="symbol"?function(t){return typeof t}:function(t){return t&&typeof Symbol=="function"&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},f(n)}function Y(n,t){if(f(n)!=="object"||n===null)return n;var r=n[Symbol.toPrimitive];if(r!==void 0){var o=r.call(n,t||"default");if(f(o)!=="object")return o;throw new TypeError("@@toPrimitive must return a primitive value.")}return(t==="string"?String:Number)(n)}function $(n){var t=Y(n,"string");return f(t)==="symbol"?t:String(t)}function q(n,t,r){return t=$(t),t in n?Object.defineProperty(n,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):n[t]=r,n}var A={root:function(t){var r=t.props,o=t.context,e=t.isFilled;return g("p-inputtextarea p-inputtext p-component",{"p-disabled":r.disabled,"p-filled":e,"p-inputtextarea-resizable":r.autoResize,"p-invalid":r.invalid,"p-variant-filled":r.variant?r.variant==="filled":o&&o.inputStyle==="filled"})}},G=`
@layer primereact {
    .p-inputtextarea-resizable {
        overflow: hidden;
        resize: none;
    }
    
    .p-fluid .p-inputtextarea {
        width: 100%;
    }
}
`,v=R.extend({defaultProps:{__TYPE:"InputTextarea",__parentMetadata:null,autoResize:!1,invalid:!1,variant:null,keyfilter:null,onBlur:null,onFocus:null,onBeforeInput:null,onInput:null,onKeyDown:null,onKeyUp:null,onPaste:null,tooltip:null,tooltipOptions:null,validateOnly:!1,children:void 0},css:{classes:A,styles:G}});function j(n,t){var r=Object.keys(n);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(n);t&&(o=o.filter(function(e){return Object.getOwnPropertyDescriptor(n,e).enumerable})),r.push.apply(r,o)}return r}function B(n){for(var t=1;t<arguments.length;t++){var r=arguments[t]!=null?arguments[t]:{};t%2?j(Object(r),!0).forEach(function(o){q(n,o,r[o])}):Object.getOwnPropertyDescriptors?Object.defineProperties(n,Object.getOwnPropertyDescriptors(r)):j(Object(r)).forEach(function(o){Object.defineProperty(n,o,Object.getOwnPropertyDescriptor(r,o))})}return n}var K=i.memo(i.forwardRef(function(n,t){var r=x(),o=i.useContext(O),e=v.getProps(n,o),p=i.useRef(t),y=i.useRef(0),b=v.setMetaData(B(B({props:e},e.__parentMetadata),{},{context:{disabled:e.disabled}})),P=b.ptm,E=b.cx,F=b.isUnstyled;w(v.css.styles,F,{name:"inputtextarea"});var S=function(l){e.autoResize&&c(),e.onFocus&&e.onFocus(l)},z=function(l){e.autoResize&&c(),e.onBlur&&e.onBlur(l)},D=function(l){e.autoResize&&c(),e.onKeyUp&&e.onKeyUp(l)},_=function(l){e.onKeyDown&&e.onKeyDown(l),e.keyfilter&&d.onKeyPress(l,e.keyfilter,e.validateOnly)},T=function(l){e.onBeforeInput&&e.onBeforeInput(l),e.keyfilter&&d.onBeforeInput(l,e.keyfilter,e.validateOnly)},H=function(l){e.onPaste&&e.onPaste(l),e.keyfilter&&d.onPaste(l,e.keyfilter,e.validateOnly)},N=function(l){var a=l.target;e.autoResize&&c(u.isEmpty(a.value)),e.onInput&&e.onInput(l),u.isNotEmpty(a.value)?m.addClass(a,"p-filled"):m.removeClass(a,"p-filled")},c=function(l){var a=p.current;a&&m.isVisible(a)&&(y.current||(y.current=a.scrollHeight,a.style.overflow="hidden"),(y.current!==a.scrollHeight||l)&&(a.style.height="",a.style.height=a.scrollHeight+"px",parseFloat(a.style.height)>=parseFloat(a.style.maxHeight)?(a.style.overflowY="scroll",a.style.height=a.style.maxHeight):a.style.overflow="hidden",y.current=a.scrollHeight))};i.useEffect(function(){u.combinedRefs(p,t)},[p,t]),i.useEffect(function(){e.autoResize&&c(!0)},[e.autoResize]);var U=i.useMemo(function(){return u.isNotEmpty(e.value)||u.isNotEmpty(e.defaultValue)},[e.value,e.defaultValue]),C=u.isNotEmpty(e.tooltip),M=r({ref:p,className:g(e.className,E("root",{context:o,isFilled:U})),onFocus:S,onBlur:z,onKeyUp:D,onKeyDown:_,onBeforeInput:T,onInput:N,onPaste:H},v.getOtherProps(e),P("root"));return i.createElement(i.Fragment,null,i.createElement("textarea",M),C&&i.createElement(I,h({target:p,content:e.tooltip,pt:P("tooltip")},e.tooltipOptions)))}));K.displayName="InputTextarea";export{K as default};
