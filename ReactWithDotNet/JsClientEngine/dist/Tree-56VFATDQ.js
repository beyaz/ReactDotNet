import{a as tn}from"./chunk-HHHF7C2S.js";import{a as Fe}from"./chunk-FM7MEQI2.js";import{a as nn}from"./chunk-NLI5V4OM.js";import{a as en}from"./chunk-LOM5F4P7.js";import{a as Ze}from"./chunk-TP2CMYTS.js";import{a as We}from"./chunk-Q4HHYYXZ.js";import"./chunk-35DEAE55.js";import{a as Ge}from"./chunk-X2CFC4CS.js";import{a as Qe}from"./chunk-73MOHHDI.js";import"./chunk-3Q5HW2ZY.js";import{A as ze,B as je,C as Ue,a as N,b as D,d as T,e as Z,k as qe,m as Le,u as ye,v as Ye}from"./chunk-MY5M2XOA.js";import"./chunk-DLL45UCJ.js";import{a as mn}from"./chunk-2W22VGCX.js";import{h as vn}from"./chunk-GYULANB4.js";var f=vn(mn());function ae(){return ae=Object.assign?Object.assign.bind():function(e){for(var o=1;o<arguments.length;o++){var r=arguments[o];for(var d in r)({}).hasOwnProperty.call(r,d)&&(e[d]=r[d])}return e},ae.apply(null,arguments)}function $e(e,o){(o==null||o>e.length)&&(o=e.length);for(var r=0,d=Array(o);r<o;r++)d[r]=e[r];return d}function hn(e){if(Array.isArray(e))return $e(e)}function bn(e){if(typeof Symbol!="undefined"&&e[Symbol.iterator]!=null||e["@@iterator"]!=null)return Array.from(e)}function dn(e,o){if(e){if(typeof e=="string")return $e(e,o);var r={}.toString.call(e).slice(8,-1);return r==="Object"&&e.constructor&&(r=e.constructor.name),r==="Map"||r==="Set"?Array.from(e):r==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r)?$e(e,o):void 0}}function yn(){throw new TypeError(`Invalid attempt to spread non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function re(e){return hn(e)||bn(e)||dn(e)||yn()}function ge(e){"@babel/helpers - typeof";return ge=typeof Symbol=="function"&&typeof Symbol.iterator=="symbol"?function(o){return typeof o}:function(o){return o&&typeof Symbol=="function"&&o.constructor===Symbol&&o!==Symbol.prototype?"symbol":typeof o},ge(e)}function pn(e,o){if(ge(e)!="object"||!e)return e;var r=e[Symbol.toPrimitive];if(r!==void 0){var d=r.call(e,o||"default");if(ge(d)!="object")return d;throw new TypeError("@@toPrimitive must return a primitive value.")}return(o==="string"?String:Number)(e)}function xn(e){var o=pn(e,"string");return ge(o)=="symbol"?o:o+""}function Ve(e,o,r){return(o=xn(o))in e?Object.defineProperty(e,o,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[o]=r,e}function Sn(e){if(Array.isArray(e))return e}function Cn(e,o){var r=e==null?null:typeof Symbol!="undefined"&&e[Symbol.iterator]||e["@@iterator"];if(r!=null){var d,t,k,I,y=[],h=!0,m=!1;try{if(k=(r=r.call(e)).next,o===0){if(Object(r)!==r)return;h=!1}else for(;!(h=(d=k.call(r)).done)&&(y.push(d.value),y.length!==o);h=!0);}catch(E){m=!0,t=E}finally{try{if(!h&&r.return!=null&&(I=r.return(),Object(I)!==I))return}finally{if(m)throw t}}return y}}function En(){throw new TypeError(`Invalid attempt to destructure non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function Be(e,o){return Sn(e)||Cn(e,o)||dn(e,o)||En()}var kn=function(o,r){var d=f.useRef(!1);return f.useEffect(function(){if(!d.current){d.current=!0;return}return o&&o()},r)},Dn={root:function(o){var r=o.props;return N("p-tree p-component",{"p-tree-selectable":r.selectionMode,"p-tree-loading":r.loading,"p-disabled":r.disabled})},loadingOverlay:"p-tree-loading-overlay p-component-overlay",loadingIcon:"p-tree-loading-icon",filterContainer:"p-tree-filter-container",input:"p-tree-filter p-inputtext p-component",searchIcon:"p-tree-filter-icon",container:"p-tree-container",node:function(o){var r=o.isLeaf;return N("p-treenode",{"p-treenode-leaf":r})},content:function(o){var r=o.nodeProps,d=o.checked,t=o.selected,k=o.isCheckboxSelectionMode;return N("p-treenode-content",{"p-treenode-selectable":r.selectionMode&&r.node.selectable!==!1,"p-highlight":k()?d:t,"p-highlight-contextmenu":r.contextMenuSelectionKey&&r.contextMenuSelectionKey===r.node.key,"p-disabled":r.disabled})},toggler:"p-tree-toggler p-link",togglerIcon:"p-tree-toggler-icon",nodeCheckbox:function(o){var r=o.partialChecked;return N({"p-indeterminate":r})},nodeIcon:"p-treenode-icon",label:"p-treenode-label",subgroup:"p-treenode-children",checkIcon:"p-checkbox-icon",emptyMessage:"p-treenode p-tree-empty-message",droppoint:"p-treenode-droppoint",header:"p-tree-header",footer:"p-tree-footer"},fe=je.extend({defaultProps:{__TYPE:"Tree",__parentMetadata:null,id:null,value:null,ariaLabel:null,ariaLabelledBy:null,checkboxIcon:null,className:null,collapseIcon:null,contentClassName:null,contentStyle:null,contextMenuSelectionKey:null,disabled:!1,dragdropScope:null,emptyMessage:null,expandIcon:null,expandedKeys:null,filter:!1,filterBy:"label",filterIcon:null,filterLocale:void 0,filterMode:"lenient",filterPlaceholder:null,filterTemplate:null,filterValue:null,footer:null,header:null,level:0,loading:!1,loadingIcon:null,metaKeySelection:!1,nodeTemplate:null,onCollapse:null,onContextMenu:null,onContextMenuSelectionChange:null,onDragDrop:null,onExpand:null,onFilterValueChange:null,onNodeClick:null,onNodeDoubleClick:null,onSelect:null,onSelectionChange:null,onToggle:null,onUnselect:null,propagateSelectionDown:!0,propagateSelectionUp:!0,selectionKeys:null,selectionMode:null,showHeader:!0,style:null,togglerTemplate:null,children:void 0},css:{classes:Dn}}),In={box:"p-checkbox-box",input:"p-checkbox-input",icon:"p-checkbox-icon",root:function(o){var r=o.props,d=o.checked,t=o.context;return N("p-checkbox p-component",{"p-highlight":d,"p-disabled":r.disabled,"p-invalid":r.invalid,"p-variant-filled":r.variant?r.variant==="filled":t&&t.inputStyle==="filled"})}},pe=je.extend({defaultProps:{__TYPE:"Checkbox",autoFocus:!1,checked:!1,className:null,disabled:!1,falseValue:!1,icon:null,id:null,inputId:null,inputRef:null,invalid:!1,variant:null,name:null,onChange:null,onContextMenu:null,onMouseDown:null,readOnly:!1,required:!1,style:null,tabIndex:null,tooltip:null,tooltipOptions:null,trueValue:!0,value:null,children:void 0},css:{classes:In}});function rn(e,o){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var d=Object.getOwnPropertySymbols(e);o&&(d=d.filter(function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable})),r.push.apply(r,d)}return r}function an(e){for(var o=1;o<arguments.length;o++){var r=arguments[o]!=null?arguments[o]:{};o%2?rn(Object(r),!0).forEach(function(d){Ve(e,d,r[d])}):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):rn(Object(r)).forEach(function(d){Object.defineProperty(e,d,Object.getOwnPropertyDescriptor(r,d))})}return e}var fn=f.memo(f.forwardRef(function(e,o){var r=ye(),d=f.useContext(Le),t=pe.getProps(e,d),k=f.useState(!1),I=Be(k,2),y=I[0],h=I[1],m=pe.setMetaData({props:t,state:{focused:y},context:{checked:t.checked===t.trueValue,disabled:t.disabled}}),E=m.ptm,B=m.cx,oe=m.isUnstyled;Ue(pe.css.styles,oe,{name:"checkbox"});var j=f.useRef(null),R=f.useRef(t.inputRef),x=function(){return t.checked===t.trueValue},V=function(p){if(!(t.disabled||t.readonly)&&t.onChange){var L,F=x(),w=F?t.falseValue:t.trueValue,ee={originalEvent:p,value:t.value,checked:w,stopPropagation:function(){p==null||p.stopPropagation()},preventDefault:function(){p==null||p.preventDefault()},target:{type:"checkbox",name:t.name,id:t.id,value:t.value,checked:w}};if(t==null||(L=t.onChange)===null||L===void 0||L.call(t,ee),p.defaultPrevented)return;D.focus(R.current)}},U=function(){var p;h(!0),t==null||(p=t.onFocus)===null||p===void 0||p.call(t)},X=function(){var p;h(!1),t==null||(p=t.onBlur)===null||p===void 0||p.call(t)};f.useImperativeHandle(o,function(){return{props:t,focus:function(){return D.focus(R.current)},getElement:function(){return j.current},getInput:function(){return R.current}}}),f.useEffect(function(){T.combinedRefs(R,t.inputRef)},[R,t.inputRef]),ze(function(){R.current.checked=x()},[t.checked,t.trueValue]),Ye(function(){t.autoFocus&&D.focus(R.current,t.autoFocus)});var M=x(),H=T.isNotEmpty(t.tooltip),O=pe.getOtherProps(t),P=r({id:t.id,className:N(t.className,B("root",{checked:M,context:d})),style:t.style,"data-p-highlight":M,"data-p-disabled":t.disabled,onContextMenu:t.onContextMenu,onMouseDown:t.onMouseDown},O,E("root")),W=function(){var p=T.reduceKeys(O,D.ARIA_PROPS),L=r(an({id:t.inputId,type:"checkbox",className:B("input"),name:t.name,tabIndex:t.tabIndex,onFocus:function(w){return U()},onBlur:function(w){return X()},onChange:function(w){return V(w)},disabled:t.disabled,readOnly:t.readOnly,required:t.required,"aria-invalid":t.invalid,checked:M},p),E("input"));return f.createElement("input",ae({ref:R},L))},le=function(){var p=r({className:B("icon")},E("icon")),L=r({className:B("box",{checked:M}),"data-p-highlight":M,"data-p-disabled":t.disabled},E("box")),F=M?t.icon||f.createElement(Fe,p):null,w=Z.getJSXIcon(F,an({},p),{props:t,checked:M});return f.createElement("div",L,w)};return f.createElement(f.Fragment,null,f.createElement("div",ae({ref:j},P),W(),le()),H&&f.createElement(We,ae({target:j,content:t.tooltip,pt:E("tooltip")},t.tooltipOptions)))}));fn.displayName="Checkbox";function Rn(e,o){var r=typeof Symbol!="undefined"&&e[Symbol.iterator]||e["@@iterator"];if(!r){if(Array.isArray(e)||(r=Tn(e))||o&&e&&typeof e.length=="number"){r&&(e=r);var d=0,t=function(){};return{s:t,n:function(){return d>=e.length?{done:!0}:{done:!1,value:e[d++]}},e:function(m){throw m},f:t}}throw new TypeError(`Invalid attempt to iterate non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}var k,I=!0,y=!1;return{s:function(){r=r.call(e)},n:function(){var m=r.next();return I=m.done,m},e:function(m){y=!0,k=m},f:function(){try{I||r.return==null||r.return()}finally{if(y)throw k}}}}function Tn(e,o){if(e){if(typeof e=="string")return on(e,o);var r={}.toString.call(e).slice(8,-1);return r==="Object"&&e.constructor&&(r=e.constructor.name),r==="Map"||r==="Set"?Array.from(e):r==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r)?on(e,o):void 0}}function on(e,o){(o==null||o>e.length)&&(o=e.length);for(var r=0,d=Array(o);r<o;r++)d[r]=e[r];return d}function ln(e,o){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var d=Object.getOwnPropertySymbols(e);o&&(d=d.filter(function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable})),r.push.apply(r,d)}return r}function $(e){for(var o=1;o<arguments.length;o++){var r=arguments[o]!=null?arguments[o]:{};o%2?ln(Object(r),!0).forEach(function(d){Ve(e,d,r[d])}):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):ln(Object(r)).forEach(function(d){Object.defineProperty(e,d,Object.getOwnPropertyDescriptor(r,d))})}return e}var He=f.memo(function(e){var o=f.useRef(null),r=f.useRef(null),d=f.useRef(!1),t=ye(),k=e.isNodeLeaf(e.node),I=e.node.label,y=(e.expandedKeys?e.expandedKeys[e.node.key]!==void 0:!1)||e.node.expanded,h=e.ptm,m=e.cx,E=function(n){return h(n,{hostName:e.hostName,context:{selected:G()?!1:Y(),expanded:y||!1,checked:G()?_():!1,isLeaf:k}})},B=function(n){var a=arguments.length>1&&arguments[1]!==void 0?arguments[1]:!1,i=e.expandedKeys?$({},e.expandedKeys):{};i[e.node.key]=!0,e.onToggle({originalEvent:n,value:i,navigateFocusToChild:a}),R(n,!0)},oe=function(n){var a=$({},e.expandedKeys);delete a[e.node.key],e.onToggle({originalEvent:n,value:a}),R(n,!1)},j=function(n){e.disabled||(y?oe(n):B(n,!1),n.preventDefault(),n.stopPropagation())},R=function(n,a){a?e.onExpand&&e.onExpand({originalEvent:n,node:e.node}):e.onCollapse&&e.onCollapse({originalEvent:n,node:e.node})},x=function(n){var a=n.nextSibling;if(a){var i=a.getAttribute("data-pc-section")==="droppoint";return i?a.nextElementSibling?a.nextElementSibling:null:a}return null},V=function(n){var a=X(n);return a?x(a)||V(a):null},U=function(n){var a=n.children[1];if(a){var i=e.dragdropScope?2:1,g=a.children[a.children.length-i];return U(g)}return n},X=function(n){var a=n.parentElement.parentElement;return D.hasClass(a,"p-treenode")?a:null},M=function(n){n&&n.focus()},H=function(n){e.onClick&&e.onClick({originalEvent:n,node:e.node});var a=n.target.nodeName;if(!(e.disabled||a==="INPUT"||a==="BUTTON"||a==="A"||D.hasClass(n.target,"p-clickable"))){if(e.selectionMode&&e.node.selectable!==!1){var i;if(G()){var g=_();i=e.selectionKeys?$({},e.selectionKeys):{},g?(e.propagateSelectionDown?ne(e.node,!1,i):delete i[e.node.key],e.propagateSelectionUp&&e.onPropagateUp&&e.onPropagateUp({originalEvent:n,check:!1,selectionKeys:i}),e.onUnselect&&e.onUnselect({originalEvent:n,node:e.node})):(e.propagateSelectionDown?ne(e.node,!0,i):i[e.node.key]={checked:!0},e.propagateSelectionUp&&e.onPropagateUp&&e.onPropagateUp({originalEvent:n,check:!0,selectionKeys:i}),e.onSelect&&e.onSelect({originalEvent:n,node:e.node}))}else{var C=Y(),K=d.current?!1:e.metaKeySelection;if(K){var J=n.metaKey||n.ctrlKey;C&&J?(z()?i=null:(i=$({},e.selectionKeys),delete i[e.node.key]),e.onUnselect&&e.onUnselect({originalEvent:n,node:e.node})):(z()?i=e.node.key:ue()&&(i=J?e.selectionKeys?$({},e.selectionKeys):{}:{},i[e.node.key]=!0),e.onSelect&&e.onSelect({originalEvent:n,node:e.node}))}else z()?C?(i=null,e.onUnselect&&e.onUnselect({originalEvent:n,node:e.node})):(i=e.node.key,e.onSelect&&e.onSelect({originalEvent:n,node:e.node})):C?(i=$({},e.selectionKeys),delete i[e.node.key],e.onUnselect&&e.onUnselect({originalEvent:n,node:e.node})):(i=e.selectionKeys?$({},e.selectionKeys):{},i[e.node.key]=!0,e.onSelect&&e.onSelect({originalEvent:n,node:e.node}))}e.onSelectionChange&&e.onSelectionChange({originalEvent:n,value:i})}d.current=!1}},O=function(n){e.onDoubleClick&&e.onDoubleClick({originalEvent:n,node:e.node})},P=function(n){e.disabled||(D.clearSelection(),e.onContextMenuSelectionChange&&e.onContextMenuSelectionChange({originalEvent:n,value:e.node.key}),e.onContextMenu&&e.onContextMenu({originalEvent:n,node:e.node}))},W=function(n){if(Se(n))switch(n.code){case"Tab":ie();break;case"ArrowDown":le(n);break;case"ArrowUp":L(n);break;case"ArrowRight":F(n);break;case"ArrowLeft":w(n);break;case"Enter":case"NumpadEnter":ee(n);break;case"Space":["INPUT"].includes(n.target.nodeName)||ee(n);break}},le=function(n){var a=n.target.getAttribute("data-pc-section")==="toggler"?n.target.closest('[role="treeitem"]'):n.target,i=a.children[1],g=p(a);if(i)q(a,e.dragdropScope?i.children[1]:i.children[0]);else if(g)q(a,g);else{var C=V(a);C&&q(a,C)}n.preventDefault()},A=function(n){var a=n.previousElementSibling;return a?e.dragdropScope?a.previousElementSibling:a:null},p=function(n){var a=n.nextElementSibling;return a?e.dragdropScope?a.nextElementSibling:a:null},L=function(n){var a=n.target,i=A(a);if(i)q(a,i,U(i));else{var g=X(a);g&&q(a,g)}n.preventDefault()},F=function(n){k||y||(n.currentTarget.tabIndex=-1,B(n,!0))},w=function(n){var a=D.findSingle(n.currentTarget,'[data-pc-section="toggler"]');if(e.level===0&&!y)return!1;if(y&&!k)return a.click(),!1;var i=ce(n.currentTarget);i&&q(n.currentTarget,i)},ee=function(n){xe(n,d.current),H(n),n.preventDefault()},ie=function(){ve()},ve=function(){var n=D.find(o.current.closest('[data-pc-section="container"]'),'[role="treeitem"]'),a=re(n).some(function(g){return g.getAttribute("aria-selected")==="true"||g.getAttribute("aria-checked")==="true"});if(re(n).forEach(function(g){g.tabIndex=-1}),a){var i=re(n).filter(function(g){return g.getAttribute("aria-selected")==="true"||g.getAttribute("aria-checked")==="true"});i[0].tabIndex=0;return}re(n)[0].tabIndex=0},xe=function(n,a){if(e.selectionMode!==null){var i=re(D.find(r.current.parentElement,'[role="treeitem"]'));n.currentTarget.tabIndex=a===!1?-1:0,i.every(function(g){return g.tabIndex===-1})&&(i[0].tabIndex=0)}},q=function(n,a,i){n.tabIndex="-1",a.tabIndex="0",M(i||a)},ce=function(n){var a=n.closest("ul").closest("li");if(a){var i=D.findSingle(a,"button");return i&&i.style.visibility!=="hidden"?a:ce(n.previousElementSibling)}return null},Q=function(n){var a=n.check,i=n.selectionKeys,g=0,C=Rn(e.node.children),K;try{for(C.s();!(K=C.n()).done;){var J=K.value;i[J.key]&&i[J.key].checked&&g++}}catch(te){C.e(te)}finally{C.f()}var de=e.node.key,Je=T.findChildrenByKey(e.originalOptions,de),gn=Je.some(function(te){return te.key in i}),Xe=Je.every(function(te){return te.key in i&&i[te.key].checked});gn&&!Xe?i[de]={checked:!1,partialChecked:!0}:Xe?i[de]={checked:!0,partialChecked:!1}:a?i[de]={checked:!1,partialChecked:!1}:delete i[de],e.propagateSelectionUp&&e.onPropagateUp&&e.onPropagateUp(n)},ne=function(n,a,i){if(a?i[n.key]={checked:!0,partialChecked:!1}:delete i[n.key],n.children&&n.children.length)for(var g=0;g<n.children.length;g++)ne(n.children[g],a,i)},Y=function(){return e.selectionMode&&e.selectionKeys?z()?e.selectionKeys===e.node.key:e.selectionKeys[e.node.key]!==void 0:!1},_=function(){return(e.selectionKeys?e.selectionKeys[e.node.key]&&e.selectionKeys[e.node.key].checked:!1)||!1},Se=function(n){return n.currentTarget&&(n.currentTarget.isSameNode(n.target)||n.currentTarget.isSameNode(n.target.closest('[role="treeitem"]')))},me=function(){return e.selectionKeys?e.selectionKeys[e.node.key]&&e.selectionKeys[e.node.key].partialChecked:!1},z=function(){return e.selectionMode&&e.selectionMode==="single"},ue=function(){return e.selectionMode&&e.selectionMode==="multiple"},G=function(){return e.selectionMode&&e.selectionMode==="checkbox"},Ce=function(){d.current=!0},Ee=function(n,a){if(n.preventDefault(),D.removeClass(n.target,"p-treenode-droppoint-active"),e.onDropPoint){var i=a===-1?e.index:e.index+1;e.onDropPoint({originalEvent:n,path:e.path,index:i,position:a})}},he=function(n){e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&(n.dataTransfer.dropEffect="move",n.preventDefault())},ke=function(n){e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&D.addClass(n.target,"p-treenode-droppoint-active")},De=function(n){e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&D.removeClass(n.target,"p-treenode-droppoint-active")},Ie=function(n){e.dragdropScope&&e.node.droppable!==!1&&(D.removeClass(o.current,"p-treenode-dragover"),n.preventDefault(),n.stopPropagation(),e.onDrop&&e.onDrop({originalEvent:n,path:e.path,index:e.index}))},Re=function(n){e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&e.node.droppable!==!1&&(n.dataTransfer.dropEffect="move",n.preventDefault(),n.stopPropagation())},Te=function(n){e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&e.node.droppable!==!1&&D.addClass(o.current,"p-treenode-dragover")},Oe=function(n){if(e.dragdropScope&&n.dataTransfer.types[1]===e.dragdropScope.toLocaleLowerCase()&&e.node.droppable!==!1){var a=n.currentTarget.getBoundingClientRect();(n.nativeEvent.x>a.left+a.width||n.nativeEvent.x<a.left||n.nativeEvent.y>=Math.floor(a.top+a.height)||n.nativeEvent.y<a.top)&&D.removeClass(o.current,"p-treenode-dragover")}},Pe=function(n){n.dataTransfer.setData("text",e.dragdropScope),n.dataTransfer.setData(e.dragdropScope,e.dragdropScope),e.onDragStart&&e.onDragStart({originalEvent:n,path:e.path,index:e.index})},we=function(n){e.onDragEnd&&e.onDragEnd({originalEvent:n})},Me=function(){var n=t({className:m("label")},E("label")),a=f.createElement("span",n,I);if(e.nodeTemplate){var i={onTogglerClick:j,className:"p-treenode-label",element:a,props:e,expanded:y};a=T.getJSXElement(e.nodeTemplate,e.node,i)}return a},Ne=function(){if(G()&&e.node.selectable!==!1){var n,a=_(),i=me(),g=t({className:m("checkIcon")}),C=a?e.checkboxIcon||f.createElement(Fe,g):i?e.checkboxIcon||f.createElement(tn,g):null,K=Z.getJSXIcon(C,$({},g),e),J=t({className:m("nodeCheckbox",{partialChecked:i}),checked:a||i,icon:K,tabIndex:-1,unstyled:e==null||(n=e.isUnstyled)===null||n===void 0?void 0:n.call(e),"data-p-checked":a,"data-p-partialchecked":i,onChange:H},E("nodeCheckbox"));return f.createElement(fn,J)}return null},Ae=function(){var n=e.node.icon||(y?e.node.expandedIcon:e.node.collapsedIcon);if(n){var a=t({className:N(n,m("nodeIcon"))},E("nodeIcon"));return Z.getJSXIcon(n,$({},a),{props:e})}return null},Ke=function(){var n=t({className:m("togglerIcon"),"aria-hidden":!0},E("togglerIcon")),a=y?e.collapseIcon||f.createElement(nn,n):e.expandIcon||f.createElement(Ge,n),i=Z.getJSXIcon(a,$({},n),{props:e,expanded:y}),g=t({type:"button",className:m("toggler"),tabIndex:-1,"aria-hidden":!1,onClick:j},E("toggler")),C=f.createElement("button",g,i,f.createElement(Qe,null));if(e.togglerTemplate){var K={onClick:j,containerClassName:"p-tree-toggler p-link",iconClassName:"p-tree-toggler-icon",element:C,props:e,expanded:y};C=T.getJSXElement(e.togglerTemplate,e.node,K)}return C},be=function(n){if(e.dragdropScope){var a=t({className:m("droppoint"),role:"treeitem",onDrop:function(g){return Ee(g,n)},onDragOver:he,onDragEnter:ke,onDragLeave:De},E("droppoint"));return f.createElement("li",a)}return null},v=function(){var n=Y(),a=_(),i=Ke(),g=Ne(),C=Ae(),K=Me(),J=t({ref:o,className:N(e.node.className,m("content",{checked:a,selected:n,nodeProps:e,isCheckboxSelectionMode:G})),style:e.node.style,onClick:H,onDoubleClick:O,onContextMenu:P,onTouchEnd:Ce,draggable:e.dragdropScope&&e.node.draggable!==!1&&!e.disabled,onDrop:Ie,onDragOver:Re,onDragEnter:Te,onDragLeave:Oe,onDragStart:Pe,onDragEnd:we,"data-p-highlight":G()?a:n},E("content"));return f.createElement("div",J,i,g,C,K)},l=function(){var n=t({className:m("subgroup"),role:"group"},E("subgroup"));return T.isNotEmpty(e.node.children)&&y?f.createElement("ul",n,e.node.children.map(function(a,i){return f.createElement(He,{key:a.key||a.label,node:a,checkboxIcon:e.checkboxIcon,collapseIcon:e.collapseIcon,contextMenuSelectionKey:e.contextMenuSelectionKey,cx:m,disabled:e.disabled,dragdropScope:e.dragdropScope,expandIcon:e.expandIcon,expandedKeys:e.expandedKeys,index:i,isNodeLeaf:e.isNodeLeaf,last:i===e.node.children.length-1,metaKeySelection:e.metaKeySelection,nodeTemplate:e.nodeTemplate,onClick:e.onClick,onCollapse:e.onCollapse,onContextMenu:e.onContextMenu,onContextMenuSelectionChange:e.onContextMenuSelectionChange,onDoubleClick:e.onDoubleClick,onDragEnd:e.onDragEnd,onDragStart:e.onDragStart,onDrop:e.onDrop,onDropPoint:e.onDropPoint,onExpand:e.onExpand,onPropagateUp:Q,onSelect:e.onSelect,onSelectionChange:e.onSelectionChange,onToggle:e.onToggle,onUnselect:e.onUnselect,originalOptions:e.originalOptions,parent:e.node,path:e.path+"-"+i,propagateSelectionDown:e.propagateSelectionDown,propagateSelectionUp:e.propagateSelectionUp,ptm:h,selectionKeys:e.selectionKeys,selectionMode:e.selectionMode,togglerTemplate:e.togglerTemplate})})):null},c=function(){var n=e.disabled||e.index!==0?-1:0,a=Y(),i=_(),g=v(),C=l(),K=t({ref:r,className:N(e.node.className,m("node",{isLeaf:k})),style:e.node.style,tabIndex:n,role:"treeitem","aria-label":I,"aria-level":e.level,"aria-expanded":y,"aria-checked":i,"aria-setsize":e.node.children?e.node.children.length:0,"aria-posinset":e.index+1,onKeyDown:W,"aria-selected":i||a},E("node"));return f.createElement("li",K,g,C)},s=c();if(e.dragdropScope&&!e.disabled&&(!e.parent||e.parent.droppable!==!1)){var b=be(-1),S=e.last?be(1):null;return f.createElement(f.Fragment,null,b,s,S)}return s});He.displayName="UITreeNode";function cn(e,o){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var d=Object.getOwnPropertySymbols(e);o&&(d=d.filter(function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable})),r.push.apply(r,d)}return r}function se(e){for(var o=1;o<arguments.length;o++){var r=arguments[o]!=null?arguments[o]:{};o%2?cn(Object(r),!0).forEach(function(d){Ve(e,d,r[d])}):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):cn(Object(r)).forEach(function(d){Object.defineProperty(e,d,Object.getOwnPropertyDescriptor(r,d))})}return e}function _e(e,o){var r=typeof Symbol!="undefined"&&e[Symbol.iterator]||e["@@iterator"];if(!r){if(Array.isArray(e)||(r=On(e))||o&&e&&typeof e.length=="number"){r&&(e=r);var d=0,t=function(){};return{s:t,n:function(){return d>=e.length?{done:!0}:{done:!1,value:e[d++]}},e:function(m){throw m},f:t}}throw new TypeError(`Invalid attempt to iterate non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}var k,I=!0,y=!1;return{s:function(){r=r.call(e)},n:function(){var m=r.next();return I=m.done,m},e:function(m){y=!0,k=m},f:function(){try{I||r.return==null||r.return()}finally{if(y)throw k}}}}function On(e,o){if(e){if(typeof e=="string")return un(e,o);var r={}.toString.call(e).slice(8,-1);return r==="Object"&&e.constructor&&(r=e.constructor.name),r==="Map"||r==="Set"?Array.from(e):r==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(r)?un(e,o):void 0}}function un(e,o){(o==null||o>e.length)&&(o=e.length);for(var r=0,d=Array(o);r<o;r++)d[r]=e[r];return d}var sn=f.memo(f.forwardRef(function(e,o){var r=ye(),d=f.useContext(Le),t=fe.getProps(e,d),k=f.useState(""),I=Be(k,2),y=I[0],h=I[1],m=f.useState(t.expandedKeys),E=Be(m,2),B=E[0],oe=E[1],j=f.useRef(null),R=f.useRef([]),x=f.useRef(null),V=f.useRef(!1),U=t.onFilterValueChange?t.filterValue:y,X=t.onToggle?t.expandedKeys:B,M=f.useRef(null),H=fe.setMetaData({props:t,state:{filterValue:U,expandedKeys:X}}),O=H.ptm,P=H.cx,W=H.isUnstyled;Ue(fe.css.styles,W,{name:"tree"});var le={filter:function(l){return _(l)},reset:function(){return G()}},A=function(){return t.filter&&R.current?R.current:t.value},p=function(l){var c=l.originalEvent,s=l.value,b=l.navigateFocusToChild;t.onToggle?t.onToggle({originalEvent:c,value:s}):(b&&(M.current=c),oe(s))};kn(function(){if(M.current){var v=M.current,l=v.target.getAttribute("data-pc-section")==="toggler"?v.target.closest('[role="treeitem"]'):v.target,c=l.children[1];if(c){l&&(l.tabIndex="-1");var s=t.dragdropScope?c.children[1]:c.children[0];s&&(s.tabIndex="0",s.focus())}M.current=null}},[X]);var L=function(l){x.current={path:l.path,index:l.index}},F=function(){x.current=null},w=function(l){if(Array.isArray(l))return l.map(w);if(l&&Object.getPrototypeOf(l)===Object.prototype){var c={};for(var s in l)s!=="data"?c[s]=w(l[s]):c[s]=l[s];return c}return l},ee=function(l){var c;if(xe((c=x.current)===null||c===void 0?void 0:c.path,l.path)){var s=w(t.value),b=x.current.path.split("-");b.pop();var S=Q(s,b),u=S?S.children[x.current.index]:s[x.current.index],n=Q(s,l.path.split("-"));n.children?n.children.push(u):n.children=[u],S?S.children.splice(x.current.index,1):s.splice(x.current.index,1),t.onDragDrop&&t.onDragDrop({originalEvent:l.originalEvent,value:s,dragNode:u,dropNode:n,dropIndex:l.index})}},ie=function(l){if(q(l)){var c=w(t.value),s=x.current.path.split("-");s.pop();var b=l.path.split("-");b.pop();var S=Q(c,s),u=Q(c,b),n=S?S.children[x.current.index]:c[x.current.index],a=ce(x.current.path,l.path);if(S?S.children.splice(x.current.index,1):c.splice(x.current.index,1),l.position<0){var i=a?x.current.index>l.index?l.index:l.index-1:l.index;u?u.children.splice(i,0,n):c.splice(i,0,n)}else u?u.children.push(n):c.push(n);t.onDragDrop&&t.onDragDrop({originalEvent:l.originalEvent,value:c,dragNode:n,dropNode:u,dropIndex:l.index})}},ve=function(l,c){return!(!l||l===c||c.indexOf(l)===0)},xe=function(l,c){var s=ve(l,c);return s?!(l.indexOf("-")>0&&l.substring(0,l.lastIndexOf("-"))===c):!1},q=function(l){var c,s=ve((c=x.current)===null||c===void 0?void 0:c.path,l.path);return s?!(l.position===-1&&ce(x.current.path,l.path)&&x.current.index+1===l.index):!1},ce=function(l,c){return l.length===1&&c.length===1?!0:l.substring(0,l.lastIndexOf("-"))===c.substring(0,c.lastIndexOf("-"))},Q=function(l,c){if(c.length===0)return null;var s=parseInt(c[0],10),b=l.children?l.children[s]:l[s];return c.length===1?b:(c.shift(),Q(b,c))},ne=function(l){return l.leaf===!1?!1:!(l.children&&l.children.length)},Y=function(l){l.which===13&&l.preventDefault()},_=function(l){V.current=!0;var c=l.target.value;t.onFilterValueChange?t.onFilterValueChange({originalEvent:l,value:c}):h(c)},Se=function(l){h(T.isNotEmpty(l)?l:""),me()},me=function(){if(V.current){if(T.isEmpty(U))R.current=t.value;else{R.current=[];var l=t.filterBy.split(","),c=U.toLocaleLowerCase(t.filterLocale),s=t.filterMode==="strict",b=_e(t.value),S;try{for(b.s();!(S=b.n()).done;){var u=S.value,n=se({},u),a={searchFields:l,filterText:c,isStrictMode:s};(s&&(z(n,a)||ue(n,a))||!s&&(ue(n,a)||z(n,a)))&&R.current.push(n)}}catch(i){b.e(i)}finally{b.f()}}V.current=!1}},z=function(l,c){if(l){var s=!1;if(l.children){var b=re(l.children);l.children=[];var S=_e(b),u;try{for(S.s();!(u=S.n()).done;){var n=u.value,a=se({},n);ue(a,c)&&(s=!0,l.children.push(a))}}catch(i){S.e(i)}finally{S.f()}}if(s)return l.expanded=!0,!0}},ue=function(l,c){var s=c.searchFields,b=c.filterText,S=c.isStrictMode,u=!1,n=_e(s),a;try{for(n.s();!(a=n.n()).done;){var i=a.value,g=String(T.resolveFieldData(l,i)).toLocaleLowerCase(t.filterLocale);g.indexOf(b)>-1&&(u=!0)}}catch(C){n.e(C)}finally{n.f()}return(!u||S&&!ne(l))&&(u=z(l,{searchFields:s,filterText:b,isStrictMode:S})||u),u},G=function(){h("")};f.useImperativeHandle(o,function(){return{props:t,filter:Se,getElement:function(){return j.current}}});var Ce=function(l,c,s){return f.createElement(He,{hostName:"Tree",key:l.key||l.label,node:l,level:t.level+1,originalOptions:t.value,index:c,last:s,path:String(c),checkboxIcon:t.checkboxIcon,collapseIcon:t.collapseIcon,contextMenuSelectionKey:t.contextMenuSelectionKey,cx:P,disabled:t.disabled,dragdropScope:t.dragdropScope,expandIcon:t.expandIcon,expandedKeys:X,isNodeLeaf:ne,metaKeySelection:t.metaKeySelection,nodeTemplate:t.nodeTemplate,onClick:t.onNodeClick,onCollapse:t.onCollapse,onContextMenu:t.onContextMenu,onContextMenuSelectionChange:t.onContextMenuSelectionChange,onDoubleClick:t.onNodeDoubleClick,onDragEnd:F,onDragStart:L,onDrop:ee,onDropPoint:ie,onExpand:t.onExpand,onSelect:t.onSelect,onSelectionChange:t.onSelectionChange,onToggle:p,onUnselect:t.onUnselect,propagateSelectionDown:t.propagateSelectionDown,propagateSelectionUp:t.propagateSelectionUp,ptm:O,selectionKeys:t.selectionKeys,selectionMode:t.selectionMode,togglerTemplate:t.togglerTemplate,isUnstyled:W})},Ee=function(){var l=r({className:N(t.contentClassName,P("emptyMessage")),role:"treeitem"},O("emptyMessage")),c=T.getJSXElement(t.emptyMessage,t)||qe("emptyMessage");return f.createElement("li",l,f.createElement("span",{className:"p-treenode-content"},c))},he=function(l){var c=r(se({className:N(t.contentClassName,P("container")),role:"tree","aria-label":t.ariaLabel,"aria-labelledby":t.ariaLabelledBy,style:t.contentStyle},we),O("container"));return f.createElement("ul",c,l)},ke=function(l){return l.map(function(c,s){return Ce(c,s,s===l.length-1)})},De=function(){if(t.value){t.filter&&(V.current=!0,me());var l=A();if(l.length>0){var c=ke(l);return he(c)}var s=Ee();return he(s)}return null},Ie=function(){if(t.loading){var l=r({className:P("loadingIcon")},O("loadingIcon")),c=t.loadingIcon||f.createElement(Ze,ae({},l,{spin:!0})),s=Z.getJSXIcon(c,se({},l),{props:t}),b=r({className:P("loadingOverlay")},O("loadingOverlay"));return f.createElement("div",b,s)}return null},Re=function(){if(t.filter){var l=T.isNotEmpty(U)?U:"",c=r({className:P("searchIcon")},O("searchIcon")),s=t.filterIcon||f.createElement(en,c),b=Z.getJSXIcon(s,se({},c),{props:t}),S=r({className:P("filterContainer")},O("filterContainer")),u=r({type:"text",value:l,autoComplete:"off",className:P("input"),placeholder:t.filterPlaceholder,"aria-label":t.filterPlaceholder,onKeyDown:Y,onChange:_,disabled:t.disabled},O("input")),n=f.createElement("div",S,f.createElement("input",u),b);if(t.filterTemplate){var a={className:"p-tree-filter-container",element:n,filterOptions:le,filterInputKeyDown:Y,filterInputChange:_,filterIconClassName:"p-dropdown-filter-icon",props:t};n=T.getJSXElement(t.filterTemplate,a)}return f.createElement(f.Fragment,null,n)}return null},Te=function(){if(t.showHeader){var l=Re(),c=l;if(t.header){var s={filterContainerClassName:"p-tree-filter-container",filterIconClassName:"p-tree-filter-icon",filterInput:{className:"p-tree-filter p-inputtext p-component",onKeyDown:Y,onChange:_},filterElement:l,element:c,props:t};c=T.getJSXElement(t.header,s)}var b=r({className:P("header")},O("header"));return f.createElement("div",b,c)}return null},Oe=function(){var l=T.getJSXElement(t.footer,t),c=r({className:P("footer")},O("footer"));return f.createElement("div",c,l)},Pe=fe.getOtherProps(t),we=T.reduceKeys(Pe,D.ARIA_PROPS),Me=Ie(),Ne=De(),Ae=Te(),Ke=Oe(),be=r({ref:j,className:N(t.className,P("root")),style:t.style,id:t.id},fe.getOtherProps(t),O("root"));return f.createElement("div",be,Me,Ae,Ne,Ke)}));sn.displayName="Tree";export{sn as default};
