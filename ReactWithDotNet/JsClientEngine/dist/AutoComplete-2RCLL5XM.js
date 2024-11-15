import{a as $e}from"./chunk-H6HPSW2M.js";import{a as Be}from"./chunk-HIJWCHI6.js";import{a as Ue}from"./chunk-YP4CRCJJ.js";import{a as Ve}from"./chunk-ILQCQS6V.js";import{a as He}from"./chunk-ONPWR4IX.js";import{a as Fe}from"./chunk-AMRZ3OII.js";import{a as Ne}from"./chunk-KRUAA7WP.js";import{a as Ke}from"./chunk-PPVZF2IH.js";import"./chunk-SLTOXZYO.js";import{a as je}from"./chunk-RVEJIPMH.js";import{a as Ge}from"./chunk-G7S3TOUE.js";import{a as _e}from"./chunk-M5SPJYNF.js";import"./chunk-UNQNBLXI.js";import{A as te,B as De,C as Me,a as k,b as y,d as m,e as ce,f as Pe,g as ee,k as se,m as pe,n as $,p as Te,u as de,v as Ae,y as Le}from"./chunk-NI4MO4TP.js";import"./chunk-UCYY7ZYD.js";import"./chunk-FXFK3YHI.js";import"./chunk-DLL45UCJ.js";import"./chunk-SI5MANRI.js";import"./chunk-22HPGI5J.js";import{a as Lt}from"./chunk-2W22VGCX.js";import{h as At}from"./chunk-GYULANB4.js";var i=At(Lt());function z(t){"@babel/helpers - typeof";return z=typeof Symbol=="function"&&typeof Symbol.iterator=="symbol"?function(a){return typeof a}:function(a){return a&&typeof Symbol=="function"&&a.constructor===Symbol&&a!==Symbol.prototype?"symbol":typeof a},z(t)}function Dt(t,a){if(z(t)!=="object"||t===null)return t;var r=t[Symbol.toPrimitive];if(r!==void 0){var u=r.call(t,a||"default");if(z(u)!=="object")return u;throw new TypeError("@@toPrimitive must return a primitive value.")}return(a==="string"?String:Number)(t)}function Mt(t){var a=Dt(t,"string");return z(a)==="symbol"?a:String(a)}function Je(t,a,r){return a=Mt(a),a in t?Object.defineProperty(t,a,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[a]=r,t}function R(){return R=Object.assign?Object.assign.bind():function(t){for(var a=1;a<arguments.length;a++){var r=arguments[a];for(var u in r)Object.prototype.hasOwnProperty.call(r,u)&&(t[u]=r[u])}return t},R.apply(this,arguments)}function me(t,a){(a==null||a>t.length)&&(a=t.length);for(var r=0,u=new Array(a);r<a;r++)u[r]=t[r];return u}function _t(t){if(Array.isArray(t))return me(t)}function Nt(t){if(typeof Symbol!="undefined"&&t[Symbol.iterator]!=null||t["@@iterator"]!=null)return Array.from(t)}function We(t,a){if(t){if(typeof t=="string")return me(t,a);var r=Object.prototype.toString.call(t).slice(8,-1);if(r==="Object"&&t.constructor&&(r=t.constructor.name),r==="Map"||r==="Set")return Array.from(t);if(r==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r))return me(t,a)}}function Gt(){throw new TypeError(`Invalid attempt to spread non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function Xe(t){return _t(t)||Nt(t)||We(t)||Gt()}function jt(t){if(Array.isArray(t))return t}function Ft(t,a){var r=t==null?null:typeof Symbol!="undefined"&&t[Symbol.iterator]||t["@@iterator"];if(r!=null){var u,e,G,h,w=[],A=!0,j=!1;try{if(G=(r=r.call(t)).next,a===0){if(Object(r)!==r)return;A=!1}else for(;!(A=(u=G.call(r)).done)&&(w.push(u.value),w.length!==a);A=!0);}catch(F){j=!0,e=F}finally{try{if(!A&&r.return!=null&&(h=r.return(),Object(h)!==h))return}finally{if(j)throw e}}return w}}function Kt(){throw new TypeError(`Invalid attempt to destructure non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function q(t,a){return jt(t)||Ft(t,a)||We(t,a)||Kt()}var Ht={root:function(a){var r=a.props,u=a.focusedState;return k("p-autocomplete p-component p-inputwrapper",{"p-autocomplete-dd":r.dropdown,"p-autocomplete-multiple":r.multiple,"p-inputwrapper-filled":r.value,"p-invalid":r.invalid,"p-inputwrapper-focus":u})},container:function(a){var r=a.props,u=a.context;return k("p-autocomplete-multiple-container p-component p-inputtext",{"p-disabled":r.disabled,"p-variant-filled":r.variant?r.variant==="filled":u&&u.inputStyle==="filled"})},loadingIcon:"p-autocomplete-loader",dropdownButton:"p-autocomplete-dropdown",removeTokenIcon:"p-autocomplete-token-icon",token:"p-autocomplete-token p-highlight",tokenLabel:"p-autocomplete-token-label",inputToken:"p-autocomplete-input-token",input:function(a){var r=a.props,u=a.context;return k("p-autocomplete-input",{"p-autocomplete-dd-input":r.dropdown,"p-variant-filled":r.variant?r.variant==="filled":u&&u.inputStyle==="filled"})},panel:function(a){var r=a.context;return k("p-autocomplete-panel p-component",{"p-ripple-disabled":r&&r.ripple===!1||$.ripple===!1})},listWrapper:"p-autocomplete-items-wrapper",list:function(a){var r=a.virtualScrollerOptions,u=a.options;return r?k("p-autocomplete-items",u.className):"p-autocomplete-items"},emptyMessage:"p-autocomplete-item",item:function(a){var r=a.suggestion,u=a.optionGroupLabel;return u?k("p-autocomplete-item",{"p-disabled":r.disabled}):k("p-autocomplete-item",{"p-disabled":r.disabled})},itemGroup:"p-autocomplete-item-group",footer:"p-autocomplete-footer",transition:"p-connected-overlay"},Ut=`
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
`,ne=De.extend({defaultProps:{__TYPE:"AutoComplete",id:null,appendTo:null,autoFocus:!1,autoHighlight:!1,className:null,completeMethod:null,delay:300,disabled:!1,dropdown:!1,dropdownAriaLabel:null,dropdownAutoFocus:!0,dropdownIcon:null,dropdownMode:"blank",emptyMessage:null,field:null,forceSelection:!1,inputClassName:null,inputId:null,inputRef:null,inputStyle:null,variant:null,invalid:!1,itemTemplate:null,loadingIcon:null,maxLength:null,minLength:1,multiple:!1,name:null,onBlur:null,onChange:null,onClear:null,onClick:null,onContextMenu:null,onDblClick:null,onDropdownClick:null,onFocus:null,onHide:null,onKeyPress:null,onKeyUp:null,onMouseDown:null,onSelect:null,onShow:null,onUnselect:null,optionGroupChildren:null,optionGroupLabel:null,optionGroupTemplate:null,panelClassName:null,panelFooterTemplate:null,panelStyle:null,placeholder:null,readOnly:!1,removeTokenIcon:null,scrollHeight:"200px",selectedItemTemplate:null,selectionLimit:null,showEmptyMessage:!1,size:null,style:null,suggestions:null,tabIndex:null,tooltip:null,tooltipOptions:null,transitionOptions:null,type:"text",value:null,virtualScrollerOptions:null,children:void 0},css:{classes:Ht,styles:Ut}});function qe(t,a){var r=Object.keys(t);if(Object.getOwnPropertySymbols){var u=Object.getOwnPropertySymbols(t);a&&(u=u.filter(function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable})),r.push.apply(r,u)}return r}function _(t){for(var a=1;a<arguments.length;a++){var r=arguments[a]!=null?arguments[a]:{};a%2?qe(Object(r),!0).forEach(function(u){Je(t,u,r[u])}):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(r)):qe(Object(r)).forEach(function(u){Object.defineProperty(t,u,Object.getOwnPropertyDescriptor(r,u))})}return t}var Ze=i.memo(i.forwardRef(function(t,a){var r=de(),u=t.ptm,e=t.cx,G=i.useContext(pe),h=function(l,c){return u(l,_({hostName:t.hostName},c))},w=function(l,c){return h(c,{context:{selected:t.selectedItem.current===l,disabled:l.disabled}})},A=function(l){return m.resolveFieldData(l,t.optionGroupLabel)},j=function(l){return m.resolveFieldData(l,t.field)},F=function(){if(t.panelFooterTemplate){var l=m.getJSXElement(t.panelFooterTemplate,t,t.onOverlayHide),c=r({className:e("footer")},h("footer"));return i.createElement("div",c,l)}return null},N=function(l,c,O){return l.findIndex(function(f){return f[c]===O})},L=i.useRef({key:null,index:0,keyIndex:0}),J=function(l,c,O,f){var g=t.optionGroupTemplate?m.getJSXElement(t.optionGroupTemplate,l,O):t.getOptionGroupLabel(l)||l,v=r(_({index:O,className:e("itemGroup"),"data-p-highlight":!1},f),h("itemGroup"));return i.createElement("li",R({},v,{key:c||null}),g)},K=function(l,c,O,f){var g=m.deepEquals(t.selectedItem,l),v=t.itemTemplate?m.getJSXElement(t.itemTemplate,l,O):t.field?m.resolveFieldData(l,t.field):l,p=r(_({index:O,role:"option",className:e("item",{optionGroupLabel:t.optionGroupLabel,suggestion:l}),onClick:function(D){return t.onItemClick(D,l)},"aria-selected":g},f),w(l,"item"));return i.createElement("li",R({key:c},p),v,i.createElement(_e,null))},U=function(l,c){var O=t.getOptionGroupChildren(l);return O.map(function(f,g){var v=c+"_"+g,p=r({"data-group":c,"data-index":g,"data-p-disabled":f.disabled});return K(f,v,g,p)})},B=function(l,c){var O=arguments.length>2&&arguments[2]!==void 0?arguments[2]:{},f={height:O.props?O.props.itemSize:void 0};if(t.optionGroupLabel){if(t.virtualScrollerOptions){var g=N(t.suggestions,t.optionGroupLabel,l);if(g!==-1){L.current={key:l,index:c,keyIndex:g};var v=c+"_"+A(l);return J(l,v,c,{style:f})}var p=c+"_"+L.current.keyIndex,I=r({style:f,"data-group":L.current.keyIndex,"data-index":c-L.current.index-1,"data-p-disabled":l.disabled});return K(l,p,c,I)}var D=U(l,c),S=c+"_"+A(l);return i.createElement(i.Fragment,{key:S},J(l,void 0,c,{style:f}),D)}var P="".concat(c,"_").concat(m.isObject(l)?j(l):l),oe=r({style:f,"data-p-disabled":l.disabled},w(l,"item"));return K(l,P,c,oe)},re=function(){return t.suggestions?t.suggestions.map(B):null},W=function(l){try{return l==null?void 0:l.map(function(c){return[c==null?void 0:c[t==null?void 0:t.optionGroupLabel]].concat(Xe(c==null?void 0:c[t==null?void 0:t.optionGroupChildren]))}).flat()}catch(c){}},E=function(){if(t.showEmptyMessage&&m.isEmpty(t.suggestions)){var l=t.emptyMessage||se("emptyMessage"),c=r({className:e("emptyMessage")},h("emptyMesage")),O=r({className:e("list")},h("list"));return i.createElement("ul",O,i.createElement("li",c,l))}if(t.virtualScrollerOptions){var f=t.suggestions?t.optionGroupLabel?W(t==null?void 0:t.suggestions):t.suggestions:null,g=_(_({},t.virtualScrollerOptions),{style:_(_({},t.virtualScrollerOptions.style),{height:t.scrollHeight}),autoSize:!0,items:f,itemTemplate:function(S,P){return S&&B(S,P.index,P)},contentTemplate:function(S){var P=r({id:t.listId,ref:S.contentRef,style:S.style,className:e("list",{virtualScrollerProps:g,options:S}),role:"listbox"},h("list"));return i.createElement("ul",P,S.children)}});return i.createElement(He,R({ref:t.virtualScrollerRef},g,{pt:h("virtualScroller"),__parentMetadata:{parent:t.metaData}}))}var v=re(),p=r({id:t.listId,className:e("list"),role:"listbox"},h("list")),I=r({className:e("listWrapper"),style:{maxHeight:t.scrollHeight||"auto"}},h("listWrapper"));return i.createElement("div",I,i.createElement("ul",p,v))},X=function(){var l=_({},t.panelStyle||{}),c=E(),O=F(),f=r({className:k(t.panelClassName,e("panel",{context:G})),style:l,onClick:function(p){return t.onClick(p)}},h("panel")),g=r({classNames:e("transition"),in:t.in,timeout:{enter:120,exit:100},options:t.transitionOptions,unmountOnExit:!0,onEnter:t.onEnter,onEntering:t.onEntering,onEntered:t.onEntered,onExit:t.onExit,onExited:t.onExited},h("transition"));return i.createElement(Ve,R({nodeRef:a},g),i.createElement("div",R({ref:a},f),c,O))},V=X();return i.createElement(Ge,{element:V,appendTo:t.appendTo})}));Ze.displayName="AutoCompletePanel";function ze(t,a){var r=Object.keys(t);if(Object.getOwnPropertySymbols){var u=Object.getOwnPropertySymbols(t);a&&(u=u.filter(function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable})),r.push.apply(r,u)}return r}function fe(t){for(var a=1;a<arguments.length;a++){var r=arguments[a]!=null?arguments[a]:{};a%2?ze(Object(r),!0).forEach(function(u){Je(t,u,r[u])}):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(r)):ze(Object(r)).forEach(function(u){Object.defineProperty(t,u,Object.getOwnPropertyDescriptor(r,u))})}return t}var Ye=i.memo(i.forwardRef(function(t,a){var r=de(),u=i.useContext(pe),e=ne.getProps(t,u),G=i.useState(e.id),h=q(G,2),w=h[0],A=h[1],j=i.useState(!1),F=q(j,2),N=F[0],L=F[1],J=i.useState(!1),K=q(J,2),U=K[0],B=K[1],re=i.useState(!1),W=q(re,2),E=W[0],X=W[1],V={props:e,state:{id:w,searching:N,focused:U,overlayVisible:E}},C=ne.setMetaData(V),l=C.ptm,c=C.cx,O=C.sx,f=C.isUnstyled;Me(ne.css.styles,f,{name:"autocomplete"});var g=i.useRef(null),v=i.useRef(null),p=i.useRef(e.inputRef),I=i.useRef(null),D=i.useRef(null),S=i.useRef(null),P=i.useRef(null),oe=Le({target:g,overlay:v,listener:function(n,o){var d=o.type,b=o.valid;b&&(d==="outside"?!tt(n)&&T():T())},when:E}),ve=q(oe,2),Qe=ve[0],et=ve[1],tt=function(n){return e.multiple?n.target===I.current||I.current.contains(n.target):n.target===p.current},ye=function(n){S.current&&clearTimeout(S.current);var o=n.target.value;e.multiple||H(n,o),m.isEmpty(o)?(T(),e.onClear&&e.onClear(n)):o.length>=e.minLength?S.current=setTimeout(function(){Z(n,o,"input")},e.delay):T()},Z=function(n,o,d){o!=null&&(d==="input"&&o.trim().length===0||e.completeMethod&&(L(!0),e.completeMethod({originalEvent:n,query:o})))},Y=function(n,o,d){if(e.multiple){if(p.current.value="",!mt(o)&&Ee()){var b=e.value?[].concat(Xe(e.value),[o]):[o];H(n,b)}}else ge(o),H(n,o);e.onSelect&&e.onSelect({originalEvent:n,value:o}),d||(y.focus(p.current),T())},H=function(n,o){e.onChange&&e.onChange({originalEvent:n,value:o,stopPropagation:function(){n.stopPropagation()},preventDefault:function(){n.preventDefault()},target:{name:e.name,id:w,value:o}}),P.current=m.isNotEmpty(o)?o:null},ae=function(n){if(m.isNotEmpty(n)){if(typeof n=="string")return n;if(e.selectedItemTemplate){var o=m.getJSXElement(e.selectedItemTemplate,n);return o||n}else if(e.field){var d=m.resolveFieldData(n,e.field);return d!=null?d:n}return n}return""},ge=function(n){p.current.value=ae(n)},be=function(){X(!0)},T=function(){X(!1),L(!1)},nt=function(){ee.set("overlay",v.current,u&&u.autoZIndex||$.autoZIndex,u&&u.zIndex.overlay||$.zIndex.overlay),y.addStyles(v.current,{position:"absolute",top:"0",left:"0"}),le()},rt=function(){e.autoHighlight&&e.suggestions&&e.suggestions.length&&he()},he=function(){var n,o=(n=ue())===null||n===void 0||(n=n.firstChild)===null||n===void 0?void 0:n.firstChild;o&&(!f()&&y.addClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!0))},ot=function(){Qe(),e.onShow&&e.onShow()},at=function(){et()},lt=function(){ee.clear(v.current),e.onHide&&e.onHide()},le=function(){var n=e.multiple?I.current:p.current;y.alignOverlay(v.current,n,e.appendTo||u&&u.appendTo||$.appendTo)},it=function(n){Be.emit("overlay-click",{originalEvent:n,target:g.current})},ut=function(n){e.dropdownAutoFocus&&y.focus(p.current,e.dropdownAutoFocus),e.dropdownMode==="blank"?Z(n,"","dropdown"):e.dropdownMode==="current"&&Z(n,p.current.value,"dropdown"),e.onDropdownClick&&e.onDropdownClick({originalEvent:n,query:p.current.value})},ct=function(n,o){var d=e.value[o],b=e.value.filter(function(x,M){return o!==M});H(n,b),e.onUnselect&&e.onUnselect({originalEvent:n,value:d})},Ce=function(n){if(E){var o=y.findSingle(v.current,'li[data-p-highlight="true"]');switch(n.which){case 40:if(o){var d=ie(o);d&&(!f()&&y.addClass(d,"p-highlight"),d.setAttribute("data-p-highlight",!0),!f()&&y.removeClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!1),y.scrollInView(ue(),d))}else o=y.findSingle(v.current,"li"),y.getAttribute(o,"data-pc-section")==="itemgroup"&&(o=ie(o)),o&&(!f()&&y.addClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!0));n.preventDefault();break;case 38:if(o){var b=Se(o);b&&(!f()&&y.addClass(b,"p-highlight"),b.setAttribute("data-p-highlight",!0),!f()&&y.removeClass(o,"p-highlight"),o.setAttribute("data-p-highlight",!1),y.scrollInView(ue(),b))}n.preventDefault();break;case 13:o&&(Oe(n,o),T(),n.preventDefault());break;case 27:T(),n.preventDefault();break;case 9:o&&Oe(n,o),T();break}}if(e.multiple)switch(n.which){case 8:if(e.value&&e.value.length&&!p.current.value){var x=e.value[e.value.length-1],M=e.value.slice(0,-1);H(n,M),e.onUnselect&&e.onUnselect({originalEvent:n,value:x})}break}},Oe=function(n,o){if(e.optionGroupLabel){var d=e.suggestions[o.dataset.group];Y(n,Re(d)[o.dataset.index])}else Y(n,e.suggestions[o.getAttribute("index")])},ie=function(n){var o=n.nextElementSibling;return o?y.getAttribute(o,"data-pc-section")==="itemgroup"?ie(o):o:null},Se=function(n){var o=n.previousElementSibling;return o?y.getAttribute(o,"data-pc-section")==="itemgroup"?Se(o):o:null},we=function(n){B(!0),e.onFocus&&e.onFocus(n)},st=function(n){if(e.multiple){p.current.value="";return}var o=m.trim(n.target.value).toLowerCase(),d=(e.suggestions||[]).flatMap(function(x){return x.items?x.items:[x]}),b=d.find(function(x){var M=e.field?m.resolveFieldData(x,e.field):x,Q=M?m.trim(M).toLowerCase():"";return Q&&o===Q});b?Y(n,b,!0):(p.current.value="",H(n,null),e.onClear&&e.onClear(n))},Ie=function(n){B(!1),e.forceSelection&&st(n),e.onBlur&&e.onBlur(n)},pt=function(n){y.focus(p.current),e.onClick&&e.onClick(n)},dt=function(n){we(n),!f()&&y.addClass(I.current,"p-focus"),I.current.setAttribute("data-p-focus",!0)},ft=function(n){Ie(n),!f()&&y.removeClass(I.current,"p-focus"),I.current.setAttribute("data-p-focus",!1)},mt=function(n){return e.value?e.value.some(function(o){return m.equals(o,n)}):!1},ue=function(){var n;return v==null||(n=v.current)===null||n===void 0?void 0:n.firstChild},vt=function(n){return e.optionGroupLabel?m.resolveFieldData(n,e.optionGroupLabel):n},Re=function(n){return m.resolveFieldData(n,e.optionGroupChildren)},Ee=function(){return!e.value||!e.selectionLimit||e.value.length<e.selectionLimit};i.useEffect(function(){m.combinedRefs(p,e.inputRef)},[p,e.inputRef]),Ae(function(){w||A(Pe()),e.autoFocus&&y.focus(p.current,e.autoFocus),le()}),te(function(){N&&e.autoHighlight&&e.suggestions&&e.suggestions.length&&he()},[N]),te(function(){N&&(m.isNotEmpty(e.suggestions)||e.showEmptyMessage?be():T(),L(!1))},[e.suggestions]),te(function(){p.current&&!e.multiple&&ge(e.value),E&&le()}),Te(function(){S.current&&clearTimeout(S.current),ee.clear(v.current)}),i.useImperativeHandle(a,function(){return{props:e,search:Z,show:be,hide:T,focus:function(){return y.focus(p.current)},getElement:function(){return g.current},getOverlay:function(){return v.current},getInput:function(){return p.current},getVirtualScroller:function(){return D.current}}});var yt=function(){var n=ae(e.value),o=E?w+"_list":null;return i.createElement(Ke,R({ref:p,id:e.inputId,type:e.type,name:e.name,defaultValue:n,role:"combobox","aria-autocomplete":"list","aria-controls":o,"aria-haspopup":"listbox","aria-expanded":E,className:k(e.inputClassName,c("input",{context:u})),style:e.inputStyle,autoComplete:"off",readOnly:e.readOnly,required:e.required,disabled:e.disabled,placeholder:e.placeholder,size:e.size,maxLength:e.maxLength,tabIndex:e.tabIndex,onBlur:Ie,onFocus:we,onChange:ye,onMouseDown:e.onMouseDown,onKeyUp:e.onKeyUp,onKeyDown:Ce,onKeyPress:e.onKeyPress,onContextMenu:e.onContextMenu,onClick:e.onClick,onDoubleClick:e.onDblClick,pt:l("input"),unstyled:e.unstyled},ke,{__parentMetadata:{parent:V}}))},gt=function(){return m.isNotEmpty(e.value)?e.value.map(function(n,o){var d=o+"multi-item",b=r({className:c("removeTokenIcon"),onClick:function(Tt){return ct(Tt,o)}},l("removeTokenIcon")),x=e.removeTokenIcon||i.createElement($e,b),M=!e.disabled&&ce.getJSXIcon(x,fe({},b),{props:e}),Q=r({className:c("token")},l("token")),Pt=r({className:c("tokenLabel")},l("tokenLabel"));return i.createElement("li",R({key:d},Q),i.createElement("span",Pt,ae(n)),M)}):(P.current=null,null)},bt=function(n){var o=E?w+"_list":null,d=r({className:c("inputToken")},l("inputToken")),b=r(fe({id:e.inputId,ref:p,"aria-autocomplete":"list","aria-controls":o,"aria-expanded":E,"aria-haspopup":"listbox",autoComplete:"off",className:e.inputClassName,disabled:e.disabled,maxLength:e.maxLength,name:e.name,onBlur:ft,onChange:n?ye:void 0,onFocus:dt,onKeyDown:n?Ce:void 0,onKeyPress:e.onKeyPress,onKeyUp:e.onKeyUp,placeholder:n?e.placeholder:void 0,readOnly:e.readOnly||!n,required:e.required,role:"combobox",style:e.inputStyle,tabIndex:e.tabIndex,type:e.type},ke),l("input"));return i.createElement("li",d,i.createElement("input",b))},ht=function(){var n=Ee(),o=gt(),d=bt(n),b=r({ref:I,className:c("container",{context:u}),onClick:n?pt:void 0,onContextMenu:e.onContextMenu,onMouseDown:e.onMouseDown,onDoubleClick:e.onDblClick,"data-p-focus":U,"data-p-disabled":e.disabled},l("container"));return i.createElement("ul",b,o,d)},Ct=function(){if(e.dropdown){var n=e.dropdownAriaLabel||e.placeholder||se("choose");return i.createElement(Fe,{type:"button",icon:e.dropdownIcon||i.createElement(Ue,null),className:c("dropdownButton"),disabled:e.disabled,onClick:ut,"aria-label":n,pt:l("dropdownButton"),__parentMetadata:{parent:V}})}return null},Ot=function(){if(N){var n=r({className:c("loadingIcon")},l("loadingIcon")),o=e.loadingIcon||i.createElement(Ne,R({},n,{spin:!0})),d=ce.getJSXIcon(o,fe({},n),{props:e});return d}return null},St=function(){return e.multiple?ht():yt()},wt=w+"_list",It=m.isNotEmpty(e.tooltip),xe=ne.getOtherProps(e),ke=m.reduceKeys(xe,y.ARIA_PROPS),Rt=Ot(),Et=St(),xt=Ct(),kt=r({id:w,ref:g,style:e.style,className:k(e.className,c("root",{focusedState:U}))},xe,l("root"));return i.createElement(i.Fragment,null,i.createElement("span",kt,Et,Rt,xt,i.createElement(Ze,R({hostName:"AutoComplete",ref:v,virtualScrollerRef:D},e,{listId:wt,onItemClick:Y,selectedItem:P,onClick:it,getOptionGroupLabel:vt,getOptionGroupChildren:Re,in:E,onEnter:nt,onEntering:rt,onEntered:ot,onExit:at,onExited:lt,ptm:l,cx:c,sx:O}))),It&&i.createElement(je,R({target:g,content:e.tooltip,pt:l("tooltip")},e.tooltipOptions)))}));Ye.displayName="AutoComplete";export{Ye as default};
