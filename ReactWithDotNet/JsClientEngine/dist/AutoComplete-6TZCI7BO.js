import{a as $e}from"./chunk-N7QKVX3U.js";import{a as Be}from"./chunk-KCLCM366.js";import{a as Ue}from"./chunk-NLI5V4OM.js";import{a as Ve}from"./chunk-WMGOVPOA.js";import{a as He}from"./chunk-6MJI4TIR.js";import{a as Fe}from"./chunk-FVQX5RVM.js";import{a as _e}from"./chunk-TP2CMYTS.js";import{a as Ke}from"./chunk-RLEXGT7I.js";import"./chunk-YZIUSMWY.js";import{a as je}from"./chunk-Q4HHYYXZ.js";import{a as Ge}from"./chunk-35DEAE55.js";import{a as Ne}from"./chunk-73MOHHDI.js";import"./chunk-3Q5HW2ZY.js";import{A as oe,B as Le,C as Me,a as k,b as g,d as v,e as se,f as Pe,g as re,k as pe,m as de,n as V,p as Te,u as fe,v as Ae,y as De}from"./chunk-MY5M2XOA.js";import"./chunk-UCYY7ZYD.js";import"./chunk-FXFK3YHI.js";import"./chunk-DLL45UCJ.js";import"./chunk-SI5MANRI.js";import"./chunk-22HPGI5J.js";import{a as Dt}from"./chunk-2W22VGCX.js";import{h as At}from"./chunk-GYULANB4.js";var i=At(Dt());function q(t){"@babel/helpers - typeof";return q=typeof Symbol=="function"&&typeof Symbol.iterator=="symbol"?function(a){return typeof a}:function(a){return a&&typeof Symbol=="function"&&a.constructor===Symbol&&a!==Symbol.prototype?"symbol":typeof a},q(t)}function Lt(t,a){if(q(t)!="object"||!t)return t;var r=t[Symbol.toPrimitive];if(r!==void 0){var u=r.call(t,a||"default");if(q(u)!="object")return u;throw new TypeError("@@toPrimitive must return a primitive value.")}return(a==="string"?String:Number)(t)}function Mt(t){var a=Lt(t,"string");return q(a)=="symbol"?a:a+""}function Je(t,a,r){return(a=Mt(a))in t?Object.defineProperty(t,a,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[a]=r,t}function I(){return I=Object.assign?Object.assign.bind():function(t){for(var a=1;a<arguments.length;a++){var r=arguments[a];for(var u in r)({}).hasOwnProperty.call(r,u)&&(t[u]=r[u])}return t},I.apply(null,arguments)}function ve(t,a){(a==null||a>t.length)&&(a=t.length);for(var r=0,u=Array(a);r<a;r++)u[r]=t[r];return u}function Nt(t){if(Array.isArray(t))return ve(t)}function _t(t){if(typeof Symbol!="undefined"&&t[Symbol.iterator]!=null||t["@@iterator"]!=null)return Array.from(t)}function We(t,a){if(t){if(typeof t=="string")return ve(t,a);var r={}.toString.call(t).slice(8,-1);return r==="Object"&&t.constructor&&(r=t.constructor.name),r==="Map"||r==="Set"?Array.from(t):r==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r)?ve(t,a):void 0}}function Gt(){throw new TypeError(`Invalid attempt to spread non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function Xe(t){return Nt(t)||_t(t)||We(t)||Gt()}function jt(t){if(Array.isArray(t))return t}function Ft(t,a){var r=t==null?null:typeof Symbol!="undefined"&&t[Symbol.iterator]||t["@@iterator"];if(r!=null){var u,e,j,C,O=[],T=!0,F=!1;try{if(j=(r=r.call(t)).next,a===0){if(Object(r)!==r)return;T=!1}else for(;!(T=(u=j.call(r)).done)&&(O.push(u.value),O.length!==a);T=!0);}catch(K){F=!0,e=K}finally{try{if(!T&&r.return!=null&&(C=r.return(),Object(C)!==C))return}finally{if(F)throw e}}return O}}function Kt(){throw new TypeError(`Invalid attempt to destructure non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function $(t,a){return jt(t)||Ft(t,a)||We(t,a)||Kt()}var Ht={root:function(a){var r=a.props,u=a.focusedState;return k("p-autocomplete p-component p-inputwrapper",{"p-autocomplete-dd":r.dropdown,"p-autocomplete-multiple":r.multiple,"p-inputwrapper-filled":r.value,"p-invalid":r.invalid,"p-inputwrapper-focus":u})},container:function(a){var r=a.props,u=a.context;return k("p-autocomplete-multiple-container p-component p-inputtext",{"p-disabled":r.disabled,"p-variant-filled":r.variant?r.variant==="filled":u&&u.inputStyle==="filled"})},loadingIcon:"p-autocomplete-loader",dropdownButton:"p-autocomplete-dropdown",removeTokenIcon:"p-autocomplete-token-icon",token:"p-autocomplete-token p-highlight",tokenLabel:"p-autocomplete-token-label",inputToken:"p-autocomplete-input-token",input:function(a){var r=a.props,u=a.context;return k("p-autocomplete-input",{"p-autocomplete-dd-input":r.dropdown,"p-variant-filled":r.variant?r.variant==="filled":u&&u.inputStyle==="filled"})},panel:function(a){var r=a.context;return k("p-autocomplete-panel p-component",{"p-ripple-disabled":r&&r.ripple===!1||V.ripple===!1})},listWrapper:"p-autocomplete-items-wrapper",list:function(a){var r=a.virtualScrollerOptions,u=a.options;return r?k("p-autocomplete-items",u.className):"p-autocomplete-items"},emptyMessage:"p-autocomplete-item",item:function(a){var r=a.suggestion,u=a.optionGroupLabel,e=a.selected;return u?k("p-autocomplete-item",{"p-disabled":r.disabled},{selected:e}):k("p-autocomplete-item",{"p-disabled":r.disabled},{"p-highlight":e})},itemGroup:"p-autocomplete-item-group",footer:"p-autocomplete-footer",transition:"p-connected-overlay"},Ut=`
@layer primereact {
    .p-autocomplete {
        display: inline-flex;
        position: relative;
    }
    
    .p-autocomplete-loader {
        position: absolute;
        top: 50%;
        margin-top: -.5rem;
    }
    
    .p-autocomplete-dd .p-autocomplete-input {
        flex: 1 1 auto;
        width: 1%;
    }
    
    .p-autocomplete-dd .p-autocomplete-input,
    .p-autocomplete-dd .p-autocomplete-multiple-container {
         border-top-right-radius: 0;
         border-bottom-right-radius: 0;
     }
    
    .p-autocomplete-dd .p-autocomplete-dropdown {
         border-top-left-radius: 0;
         border-bottom-left-radius: 0px;
    }
    
    .p-autocomplete .p-autocomplete-panel {
        min-width: 100%;
    }
    
    .p-autocomplete-panel {
        position: absolute;
        top: 0;
        left: 0;
    }
    
    .p-autocomplete-items {
        margin: 0;
        padding: 0;
        list-style-type: none;
    }
    
    .p-autocomplete-item {
        cursor: pointer;
        white-space: nowrap;
        position: relative;
        overflow: hidden;
    }
    
    .p-autocomplete-multiple-container {
        margin: 0;
        padding: 0;
        list-style-type: none;
        cursor: text;
        overflow: hidden;
        display: flex;
        align-items: center;
        flex-wrap: wrap;
    }
    
    .p-autocomplete-token {
        cursor: default;
        display: inline-flex;
        align-items: center;
        flex: 0 0 auto;
    }
    
    .p-autocomplete-token-icon {
        cursor: pointer;
    }
    
    .p-autocomplete-input-token {
        flex: 1 1 auto;
        display: inline-flex;
    }
    
    .p-autocomplete-input-token input {
        border: 0 none;
        outline: 0 none;
        background-color: transparent;
        margin: 0;
        padding: 0;
        box-shadow: none;
        border-radius: 0;
        width: 100%;
    }
    
    .p-fluid .p-autocomplete {
        display: flex;
    }
    
    .p-fluid .p-autocomplete-dd .p-autocomplete-input {
        width: 1%;
    }
    
    .p-autocomplete-items-wrapper {
        overflow: auto;
    } 
}
`,ae=Le.extend({defaultProps:{__TYPE:"AutoComplete",id:null,appendTo:null,autoFocus:!1,autoHighlight:!1,className:null,completeMethod:null,delay:300,disabled:!1,dropdown:!1,dropdownAriaLabel:null,dropdownAutoFocus:!0,dropdownIcon:null,dropdownMode:"blank",emptyMessage:null,field:null,forceSelection:!1,inputClassName:null,inputId:null,inputRef:null,inputStyle:null,variant:null,invalid:!1,itemTemplate:null,loadingIcon:null,maxLength:null,minLength:1,multiple:!1,name:null,onBlur:null,onChange:null,onClear:null,onClick:null,onContextMenu:null,onDblClick:null,onDropdownClick:null,onFocus:null,onHide:null,onKeyPress:null,onKeyUp:null,onMouseDown:null,onSelect:null,onShow:null,onUnselect:null,optionGroupChildren:null,optionGroupLabel:null,optionGroupTemplate:null,panelClassName:null,panelFooterTemplate:null,panelStyle:null,placeholder:null,readOnly:!1,removeTokenIcon:null,scrollHeight:"200px",selectedItemTemplate:null,selectionLimit:null,showEmptyMessage:!1,size:null,style:null,suggestions:null,tabIndex:null,tooltip:null,tooltipOptions:null,transitionOptions:null,type:"text",value:null,virtualScrollerOptions:null,children:void 0},css:{classes:Ht,styles:Ut}});function qe(t,a){var r=Object.keys(t);if(Object.getOwnPropertySymbols){var u=Object.getOwnPropertySymbols(t);a&&(u=u.filter(function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable})),r.push.apply(r,u)}return r}function M(t){for(var a=1;a<arguments.length;a++){var r=arguments[a]!=null?arguments[a]:{};a%2?qe(Object(r),!0).forEach(function(u){Je(t,u,r[u])}):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(r)):qe(Object(r)).forEach(function(u){Object.defineProperty(t,u,Object.getOwnPropertyDescriptor(r,u))})}return t}var Ze=i.memo(i.forwardRef(function(t,a){var r=fe(),u=t.ptm,e=t.cx,j=i.useContext(de),C=function(l,s){return u(l,M({hostName:t.hostName},s))},O=function(l,s){return C(s,{context:{selected:t.selectedItem.current===l,disabled:l.disabled}})},T=function(l){return v.resolveFieldData(l,t.optionGroupLabel)},F=function(l){return v.resolveFieldData(l,t.field)},K=function(){if(t.panelFooterTemplate){var l=v.getJSXElement(t.panelFooterTemplate,t,t.onOverlayHide),s=r({className:e("footer")},C("footer"));return i.createElement("div",s,l)}return null},N=function(l,s,y){return l.findIndex(function(b){return b[s]===y})},A=i.useRef({key:null,index:0,keyIndex:0}),z=function(l,s,y,b){var d=t.optionGroupTemplate?v.getJSXElement(t.optionGroupTemplate,l,y):t.getOptionGroupLabel(l)||l,p=r(M({index:y,className:e("itemGroup"),"data-p-highlight":!1},b),C("itemGroup"));return i.createElement("li",I({},p,{key:s||null}),d)},J=function(l){return t.selectedItem&&t.selectedItem.current&&Array.isArray(t.selectedItem.current)?t.selectedItem.current.some(function(s){return v.deepEquals(s,l)}):v.deepEquals(t.selectedItem.current,l)},_=function(l,s,y,b){var d=J(l),p=t.itemTemplate?v.getJSXElement(t.itemTemplate,l,y):t.field?v.resolveFieldData(l,t.field):l,S=r(M({index:y,role:"option",className:e("item",{optionGroupLabel:t.optionGroupLabel,suggestion:l,selected:d}),onClick:function(E){return t.onItemClick(E,l)},"aria-selected":d},b),O(l,"item"));return i.createElement("li",I({key:s},S),p,i.createElement(Ne,null))},W=function(l,s){var y=t.getOptionGroupChildren(l);return y.map(function(b,d){var p=s+"_"+d,S=r({"data-group":s,"data-index":d,"data-p-disabled":b.disabled});return _(b,p,d,S)})},X=function(l,s){var y=arguments.length>2&&arguments[2]!==void 0?arguments[2]:{},b={height:y.props?y.props.itemSize:void 0};if(t.optionGroupLabel){if(t.virtualScrollerOptions){var d=N(t.suggestions,t.optionGroupLabel,l);if(d!==-1){A.current={key:l,index:s,keyIndex:d};var p=s+"_"+T(l);return z(l,p,s,{style:b})}var S=s+"_"+A.current.keyIndex,G=r({style:b,"data-group":A.current.keyIndex,"data-index":s-A.current.index-1,"data-p-disabled":l.disabled});return _(l,S,s,G)}var E=W(l,s),w=s+"_"+T(l);return i.createElement(i.Fragment,{key:w},z(l,void 0,s,{style:b}),E)}var D="".concat(s,"_").concat(v.isObject(l)?F(l):l),Q=r({style:b,"data-p-disabled":l.disabled},O(l,"item"));return _(l,D,s,Q)},Z=function(){return t.suggestions?t.suggestions.map(X):null},R=function(l){try{return l==null?void 0:l.map(function(s){return[s==null?void 0:s[t==null?void 0:t.optionGroupLabel]].concat(Xe(s==null?void 0:s[t==null?void 0:t.optionGroupChildren]))}).flat()}catch(s){}},Y=function(){if(t.showEmptyMessage&&v.isEmpty(t.suggestions)){var l=t.emptyMessage||pe("emptyMessage"),s=r({className:e("emptyMessage")},C("emptyMesage")),y=r({className:e("list")},C("list"));return i.createElement("ul",y,i.createElement("li",s,l))}if(t.virtualScrollerOptions){var b=t.suggestions?t.optionGroupLabel?R(t==null?void 0:t.suggestions):t.suggestions:null,d=M(M({},t.virtualScrollerOptions),{style:M(M({},t.virtualScrollerOptions.style),{height:t.scrollHeight}),autoSize:!0,items:b,itemTemplate:function(w,D){return w&&X(w,D.index,D)},contentTemplate:function(w){var D=r({id:t.listId,ref:w.contentRef,style:w.style,className:e("list",{virtualScrollerProps:d,options:w}),role:"listbox"},C("list"));return i.createElement("ul",D,w.children)}});return i.createElement(He,I({ref:t.virtualScrollerRef},d,{pt:C("virtualScroller"),__parentMetadata:{parent:t.metaData}}))}var p=Z(),S=r({id:t.listId,className:e("list"),role:"listbox"},C("list")),G=r({className:e("listWrapper"),style:{maxHeight:t.scrollHeight||"auto"}},C("listWrapper"));return i.createElement("div",G,i.createElement("ul",S,p))},B=function(){var l=M({},t.panelStyle||{}),s=Y(),y=K(),b=r({className:k(t.panelClassName,e("panel",{context:j})),style:l,onClick:function(S){return t.onClick(S)}},C("panel")),d=r({classNames:e("transition"),in:t.in,timeout:{enter:120,exit:100},options:t.transitionOptions,unmountOnExit:!0,onEnter:t.onEnter,onEntering:t.onEntering,onEntered:t.onEntered,onExit:t.onExit,onExited:t.onExited},C("transition"));return i.createElement(Ve,I({nodeRef:a},d),i.createElement("div",I({ref:a},b),s,y))},H=B();return i.createElement(Ge,{element:H,appendTo:t.appendTo})}));Ze.displayName="AutoCompletePanel";function ze(t,a){var r=Object.keys(t);if(Object.getOwnPropertySymbols){var u=Object.getOwnPropertySymbols(t);a&&(u=u.filter(function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable})),r.push.apply(r,u)}return r}function me(t){for(var a=1;a<arguments.length;a++){var r=arguments[a]!=null?arguments[a]:{};a%2?ze(Object(r),!0).forEach(function(u){Je(t,u,r[u])}):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(r)):ze(Object(r)).forEach(function(u){Object.defineProperty(t,u,Object.getOwnPropertyDescriptor(r,u))})}return t}var Ye=i.memo(i.forwardRef(function(t,a){var r=fe(),u=i.useContext(de),e=ae.getProps(t,u),j=i.useState(e.id),C=$(j,2),O=C[0],T=C[1],F=i.useState(!1),K=$(F,2),N=K[0],A=K[1],z=i.useState(!1),J=$(z,2),_=J[0],W=J[1],X=i.useState(!1),Z=$(X,2),R=Z[0],Y=Z[1],B={props:e,state:{id:O,searching:N,focused:_,overlayVisible:R}},H=ae.setMetaData(B),m=H.ptm,l=H.cx,s=H.sx,y=H.isUnstyled;Me(ae.css.styles,y,{name:"autocomplete"});var b=i.useRef(null),d=i.useRef(null),p=i.useRef(e.inputRef),S=i.useRef(null),G=i.useRef(null),E=i.useRef(null),w=i.useRef(null),D=De({target:b,overlay:d,listener:function(n,o){var f=o.type,h=o.valid;h&&(f==="outside"?!tt(n)&&P():P())},when:R}),Q=$(D,2),Qe=Q[0],et=Q[1],tt=function(n){return e.multiple?n.target===S.current||S.current.contains(n.target):n.target===p.current},ye=function(n){E.current&&clearTimeout(E.current);var o=n.target.value;e.multiple||U(n,o),v.isEmpty(o)?(P(),e.onClear&&e.onClear(n)):o.length>=e.minLength?E.current=setTimeout(function(){ee(n,o,"input")},e.delay):P()},ee=function(n,o,f){o!=null&&(f==="input"&&o.trim().length===0||e.completeMethod&&(A(!0),e.completeMethod({originalEvent:n,query:o})))},te=function(n,o,f){if(e.multiple){if(p.current.value="",!mt(o)&&Ee()){var h=e.value?[].concat(Xe(e.value),[o]):[o];U(n,h)}}else ge(o),U(n,o);e.onSelect&&e.onSelect({originalEvent:n,value:o}),f||(g.focus(p.current),P())},U=function(n,o){e.onChange&&e.onChange({originalEvent:n,value:o,stopPropagation:function(){n.stopPropagation()},preventDefault:function(){n.preventDefault()},target:{name:e.name,id:O,value:o}}),w.current=v.isNotEmpty(o)?o:null},le=function(n){var o=arguments.length>1&&arguments[1]!==void 0?arguments[1]:!1;if(v.isEmpty(n))return"";if(typeof n=="string")return n;if(o&&e.selectedItemTemplate)return v.getJSXElement(e.selectedItemTemplate,n)||n;if(e.field){var f;return(f=v.resolveFieldData(n,e.field))!==null&&f!==void 0?f:n}return n},ge=function(n){p.current.value=le(n)},be=function(){Y(!0)},P=function(){Y(!1),A(!1)},nt=function(){re.set("overlay",d.current,u&&u.autoZIndex||V.autoZIndex,u&&u.zIndex.overlay||V.zIndex.overlay),g.addStyles(d.current,{position:"absolute",top:"0",left:"0"}),ie()},rt=function(){e.autoHighlight&&e.suggestions&&e.suggestions.length&&he()},he=function(){var n,o=(n=ce())===null||n===void 0||(n=n.firstChild)===null||n===void 0?void 0:n.firstChild;o&&(!y()&&g.addClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!0))},ot=function(){Qe(),e.onShow&&e.onShow()},at=function(){et()},lt=function(){re.clear(d.current),e.onHide&&e.onHide()},ie=function(){var n=e.multiple?S.current:p.current;g.alignOverlay(d.current,n,e.appendTo||u&&u.appendTo||V.appendTo)},it=function(n){Be.emit("overlay-click",{originalEvent:n,target:b.current})},ut=function(n){e.dropdownAutoFocus&&g.focus(p.current,e.dropdownAutoFocus),e.dropdownMode==="blank"?ee(n,"","dropdown"):e.dropdownMode==="current"&&ee(n,p.current.value,"dropdown"),e.onDropdownClick&&e.onDropdownClick({originalEvent:n,query:p.current.value})},ct=function(n,o){var f=e.value[o],h=e.value.filter(function(x,L){return o!==L});U(n,h),e.onUnselect&&e.onUnselect({originalEvent:n,value:f})},Ce=function(n){if(R){var o=g.findSingle(d.current,'li[data-p-highlight="true"]');switch(n.which){case 40:if(o){var f=ue(o);f&&(!y()&&g.addClass(f,"p-highlight"),f.setAttribute("data-p-highlight",!0),!y()&&g.removeClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!1),g.scrollInView(ce(),f))}else o=g.findSingle(d.current,"li"),g.getAttribute(o,"data-pc-section")==="itemgroup"&&(o=ue(o)),o&&(!y()&&g.addClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!0));n.preventDefault();break;case 38:if(o){var h=Oe(o);h&&(!y()&&g.addClass(h,"p-highlight"),h.setAttribute("data-p-highlight",!0),!y()&&g.removeClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!1),g.scrollInView(ce(),h))}n.preventDefault();break;case 13:o&&(Se(n,o),P(),n.preventDefault());break;case 27:P(),n.preventDefault();break;case 9:o&&Se(n,o),P();break}}if(e.multiple)switch(n.which){case 8:if(e.value&&e.value.length&&!p.current.value){var x=e.value[e.value.length-1],L=e.value.slice(0,-1);U(n,L),e.onUnselect&&e.onUnselect({originalEvent:n,value:x})}break}},Se=function(n,o){if(e.optionGroupLabel){var f=e.suggestions[o.dataset.group];te(n,Re(f)[o.dataset.index])}else te(n,e.suggestions[o.getAttribute("index")])},ue=function(n){var o=n.nextElementSibling;return o?g.getAttribute(o,"data-pc-section")==="itemgroup"?ue(o):o:null},Oe=function(n){var o=n.previousElementSibling;return o?g.getAttribute(o,"data-pc-section")==="itemgroup"?Oe(o):o:null},we=function(n){W(!0),e.onFocus&&e.onFocus(n)},st=function(n){if(e.multiple){p.current.value="";return}var o=v.trim(n.target.value).toLowerCase(),f=(e.suggestions||[]).flatMap(function(x){return x.items?x.items:[x]}),h=f.find(function(x){var L=e.field?v.resolveFieldData(x,e.field):x,ne=L?v.trim(L).toLowerCase():"";return ne&&o===ne});h?te(n,h,!0):(p.current.value="",U(n,null),e.onClear&&e.onClear(n))},Ie=function(n){W(!1),e.forceSelection&&st(n),e.onBlur&&e.onBlur(n)},pt=function(n){g.focus(p.current),e.onClick&&e.onClick(n)},dt=function(n){we(n),!y()&&g.addClass(S.current,"p-focus"),S.current.setAttribute("data-p-focus",!0)},ft=function(n){Ie(n),!y()&&g.removeClass(S.current,"p-focus"),S.current.setAttribute("data-p-focus",!1)},mt=function(n){return e.value?e.value.some(function(o){return v.equals(o,n)}):!1},ce=function(){var n;return d==null||(n=d.current)===null||n===void 0?void 0:n.firstChild},vt=function(n){return e.optionGroupLabel?v.resolveFieldData(n,e.optionGroupLabel):n},Re=function(n){return v.resolveFieldData(n,e.optionGroupChildren)},Ee=function(){return!e.value||!e.selectionLimit||e.value.length<e.selectionLimit};i.useEffect(function(){v.combinedRefs(p,e.inputRef)},[p,e.inputRef]),Ae(function(){O||T(Pe()),e.autoFocus&&g.focus(p.current,e.autoFocus),ie()}),oe(function(){N&&e.autoHighlight&&e.suggestions&&e.suggestions.length&&he()},[N]),oe(function(){N&&(v.isNotEmpty(e.suggestions)||e.showEmptyMessage?be():P(),A(!1))},[e.suggestions]),oe(function(){p.current&&!e.multiple&&ge(e.value),R&&ie()}),Te(function(){E.current&&clearTimeout(E.current),re.clear(d.current)}),i.useImperativeHandle(a,function(){return{props:e,search:ee,show:be,hide:P,focus:function(){return g.focus(p.current)},getElement:function(){return b.current},getOverlay:function(){return d.current},getInput:function(){return p.current},getVirtualScroller:function(){return G.current}}});var yt=function(){var n=le(e.value),o=R?O+"_list":null;return i.createElement(Ke,I({ref:p,id:e.inputId,type:e.type,name:e.name,defaultValue:n,role:"combobox","aria-autocomplete":"list","aria-controls":o,"aria-haspopup":"listbox","aria-expanded":R,className:k(e.inputClassName,l("input",{context:u})),style:e.inputStyle,autoComplete:"off",readOnly:e.readOnly,required:e.required,disabled:e.disabled,placeholder:e.placeholder,size:e.size,maxLength:e.maxLength,tabIndex:e.tabIndex,onBlur:Ie,onFocus:we,onChange:ye,onMouseDown:e.onMouseDown,onKeyUp:e.onKeyUp,onKeyDown:Ce,onKeyPress:e.onKeyPress,onContextMenu:e.onContextMenu,onClick:e.onClick,onDoubleClick:e.onDblClick,pt:m("input"),unstyled:e.unstyled},ke,{__parentMetadata:{parent:B}}))},gt=function(){return v.isNotEmpty(e.value)?e.value.map(function(n,o){var f=o+"multi-item",h=r({className:l("removeTokenIcon"),onClick:function(Tt){return ct(Tt,o)}},m("removeTokenIcon")),x=e.removeTokenIcon||i.createElement($e,h),L=!e.disabled&&se.getJSXIcon(x,me({},h),{props:e}),ne=r({className:l("token")},m("token")),Pt=r({className:l("tokenLabel")},m("tokenLabel"));return i.createElement("li",I({key:f},ne),i.createElement("span",Pt,le(n,!0)),L)}):(w.current=null,null)},bt=function(n){var o=R?O+"_list":null,f=r({className:l("inputToken")},m("inputToken")),h=r(me({id:e.inputId,ref:p,"aria-autocomplete":"list","aria-controls":o,"aria-expanded":R,"aria-haspopup":"listbox",autoComplete:"off",className:e.inputClassName,disabled:e.disabled,maxLength:e.maxLength,name:e.name,onBlur:ft,onChange:n?ye:void 0,onFocus:dt,onKeyDown:n?Ce:void 0,onKeyPress:e.onKeyPress,onKeyUp:e.onKeyUp,placeholder:n?e.placeholder:void 0,readOnly:e.readOnly||!n,required:e.required,role:"combobox",style:e.inputStyle,tabIndex:e.tabIndex,type:e.type},ke),m("input"));return i.createElement("li",f,i.createElement("input",h))},ht=function(){var n=Ee(),o=gt(),f=bt(n),h=r({ref:S,className:l("container",{context:u}),onClick:n?pt:void 0,onContextMenu:e.onContextMenu,onMouseDown:e.onMouseDown,onDoubleClick:e.onDblClick,"data-p-focus":_,"data-p-disabled":e.disabled},m("container"));return i.createElement("ul",h,o,f)},Ct=function(){if(e.dropdown){var n=e.dropdownAriaLabel||e.placeholder||pe("choose");return i.createElement(Fe,{type:"button",icon:e.dropdownIcon||i.createElement(Ue,null),className:l("dropdownButton"),disabled:e.disabled,onClick:ut,"aria-label":n,pt:m("dropdownButton"),__parentMetadata:{parent:B}})}return null},St=function(){if(N){var n=r({className:l("loadingIcon")},m("loadingIcon")),o=e.loadingIcon||i.createElement(_e,I({},n,{spin:!0})),f=se.getJSXIcon(o,me({},n),{props:e});return f}return null},Ot=function(){return e.multiple?ht():yt()},wt=O+"_list",It=v.isNotEmpty(e.tooltip),xe=ae.getOtherProps(e),ke=v.reduceKeys(xe,g.ARIA_PROPS),Rt=St(),Et=Ot(),xt=Ct(),kt=r({id:O,ref:b,style:e.style,className:k(e.className,l("root",{focusedState:_}))},xe,m("root"));return i.createElement(i.Fragment,null,i.createElement("span",kt,Et,Rt,xt,i.createElement(Ze,I({hostName:"AutoComplete",ref:d,virtualScrollerRef:G},e,{listId:wt,onItemClick:te,selectedItem:w,onClick:it,getOptionGroupLabel:vt,getOptionGroupChildren:Re,in:R,onEnter:nt,onEntering:rt,onEntered:ot,onExit:at,onExited:lt,ptm:m,cx:l,sx:s}))),It&&i.createElement(je,I({target:b,content:e.tooltip,pt:m("tooltip")},e.tooltipOptions)))}));Ye.displayName="AutoComplete";export{Ye as default};
