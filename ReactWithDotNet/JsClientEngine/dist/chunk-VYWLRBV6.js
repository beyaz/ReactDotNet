import{a as ie}from"./chunk-DLL45UCJ.js";import{a as oe}from"./chunk-2W22VGCX.js";import{f as ne,h as Mt}from"./chunk-GYULANB4.js";var bt=ne(ut=>{"use strict";var At=ie();ut.createRoot=At.createRoot,ut.hydrateRoot=At.hydrateRoot;var Je});var U=Mt(oe()),Ft=Mt(bt()),b=U.default.createElement,v="$Type",J="$RootNode",M="$ClientTasks",I="$SyncId",K="$State",tt="$ComponentDidMountMethod",re="$ComponentWillUnmountMethod",C="$DotNetComponentUniqueIdentifier",N="$DotNetComponentUniqueIdentifiers",It="$ON_COMPONENT_DESTROY",Nt="$CUSTOM_EVENT_LISTENER_MAP",O="DotNetProperties";function $t(t){try{return{success:!0,fail:!1,value:t()}}catch(e){return{success:!1,fail:!0,exception:e}}}function se(t,e){if(t==null||t.length===0)return;let n=t.indexOf(e);return n>=0?(t.splice(n,1),!0):!1}var ft=class{constructor(){this.map={}}subscribe(e,n){let o=this.map[e];o||(this.map[e]=o=[]),o.push(n)}unsubscribe(e,n){se(this.map[e],n)}publish(e,n){if(n==null)throw h("Publish event arguments should be given in array. @Example: ReactWithDotNet.DispatchEvent('MovieActorNameChanged', ['Tom Hanks']);");let o=this.map[e];if(o==null||o.length===0)return;let r=o.slice(0);for(let c=0;c<r.length;c++)o.indexOf(r[c])>=0&&r[c].apply(null,[n])}},T={bus:new ft,On:function(t,e){T.bus.subscribe(t,e)},Dispatch:function(t,e){T.bus.publish(t,e)},Remove:function(t,e){T.bus.unsubscribe(t,e)}},dt=[];function ce(t){for(let e=0;e<dt.length;e++)dt[e](t)}function ae(t){dt.push(t)}var mt={};function ue(t,e){if(t==null)throw h("Missing argument. @dotNetFullNameOfThirdPartyComponent cannot be null.");if(e==null)throw h("Missing argument. @fn cannot be null.");let n=mt[t];n||(n=mt[t]=[]),n.push(e)}function le(t,e,n){if(t==null)throw h("Missing argument. @dotNetFullNameOfThirdPartyComponent cannot be null.");let o=mt[t];if(o)for(let r=0;r<o.length;r++)e=o[r](e,n);return e}function fe(t){let e=document.querySelector("head");if(e==null)return{error:"Head element not found in document."};if(e.querySelector('link[href*="'+t+'"]'))return{isAlreadyLoaded:!0};let o=document.createElement("link");return o.rel="stylesheet",o.href=t,o.type="text/css",e.appendChild(o),{loadStarted:!0}}function kt(t){let e=setInterval(function(){document.readyState==="complete"&&(clearInterval(e),setTimeout(t,1))},10)}function de(t){if(Oe(t))return!1;for(let e in t)if(Object.prototype.hasOwnProperty.call(t,e))return!1;return!0}function xt(t){let e=x.array;for(let n=0;n<e.length;n++){let o=e[n];o.uniqueName===t&&(o.status=V)}}var Wt=1,qt=2,_=3,V=4,Lt=5,x={array:[],timer:0};function me(){x.timer||(x.timer=setInterval(ye,5))}function pe(){clearInterval(x.timer),x.timer=0}function he(t){let e=x.array;t.priorityIsMore?e.splice(0,0,t):e.push(t),me()}function ye(){let t=x.array;for(let e=0;e<t.length;e++){let n=t[e];(n.status===V||n.status===_||n.status===Lt)&&(n.onCompleted&&n.onCompleted(),t.splice(e,1),e--)}if(t.length===0){pe();return}for(let e=0;e<t.length;e++){let n=t[e];if(n.status===qt)return;n.status===Wt&&Pe(n)}}var Ce=1;function w(t){t.status=Wt,t.id=Ce++,he(t)}function et(t,e,n){t.setState(e,n)}function Ht(t,e){e=typeof e=="string"?e.split("."):e;let n=e.length;for(let o=0;o<n;o++){if(t==null)return{success:!1,error:h("Path is not read. Path:"+e.join("."))};let r=e[o];r==="["&&(r=e[o+1],o++,o++),t=t[r]}return{success:!0,value:t}}function Pt(t,e){let n=Ht(t,e);if(n.success)return n.value;throw n.error}function ge(t,e,n){if(t==null)throw h("SetValueInPath->"+n);let o=e.length;for(let r=0;r<o;r++){let c=e[r];if(o===r+3&&e[r]==="["&&e[r+2]==="]"){t[e[r+1]]=n;return}t[c]==null&&(t[c]={}),r===o-1?t[c]=n:(c==="["&&(c=e[r+1],r++,r++),t=t[c])}}function y(t){if(t==null)throw h("value cannot be null.");return t}function G(t){if(typeof t=="number"&&!isNaN(t))return t;throw h("value should be number.")}function Se(t){return JSON.parse(JSON.stringify(t))}function Ie(t,e){return e===void 0?t:t==null?e:t}var _t=(t,e)=>{let n=t.breadcrumb;e.key!==null&&(n=n+","+e.key);let o={map:t.map,breadcrumb:n};if(e.type&&e.type[v]){let i=t.map;if(i[n]!==void 0)throw h("Problem when traversing nodes");i[n]={StateAsJson:JSON.stringify(e.stateNode.state[K]),FullTypeNameOfComponent:e.stateNode.state[v],ComponentUniqueIdentifier:e.stateNode.state[C]}}let c=e.child;for(;c;)_t(o,c),c=c.sibling},Jt=t=>{t.alternate&&t.actualStartTime<t.alternate.actualStartTime&&(t=t.alternate);let e=t.key,n={},o=t.stateNode.state;n[e]={StateAsJson:JSON.stringify(o[K])};let r={map:n,breadcrumb:e},c=t.child;for(;c;)_t(r,c),c=c.sibling;n[e][O]=Object.assign({},y(o[O]));{let i=Ht(t.stateNode,"props.$jsonNode.$LogicalChildrenCount");i.success&&(n[e][O].$LogicalChildrenCount=i.value)}return{stateTree:n,rootNodeKey:e}},z=(()=>{let t=1;return()=>t++})(),Ne=1;function Te(t){t.$DotNetComponentInstanceId=Ne++}var pt=class{constructor(e){this.data=e,this.next=null}},ht=class{constructor(){this.head=null,this.size=0}add(e){let n=new pt(e),o;if(this.head==null)this.head=n;else{for(o=this.head;o.next;)o=o.next;o.next=n}this.size++}removeFirst(e){let n=this.head,o=null;for(;n!=null;){if(e(n.data)===!0)return o==null?this.head=n.next:o.next=n.next,this.size--,n.data;o=n,n=n.next}return-1}first(e){let n=this.head;for(;n!=null;){if(e(n.data)===!0)return n.data;n=n.next}return null}},yt=class{constructor(){this.instanceArray=[],this.freeSpace={},this.freeSpace[Nt]={},this.freeSpace[It]=[]}},Ct=class{constructor(){this.linkedList=new ht}Register(e){y(e);{let n=r=>r.instanceArray.indexOf(e)>=0;if(this.linkedList.first(n))return}{let n=r=>{let c=r.instanceArray,i=e[N];for(let a=0;a<c.length;a++){let u=c[a][N];for(let d=0;d<i.length;d++)if(u.indexOf(i[d])>=0)return!0}return!1},o=this.linkedList.first(n);if(o){{let r=o.instanceArray,c=r.length,i=e[N];for(let a=0;a<c;a++){let u=r[a][N];for(let d=0;d<u.length;d++){let s=u[d];i.indexOf(s)<0&&i.push(s)}}}o.instanceArray.push(e);return}}{let n=new yt;n.instanceArray.push(e),this.linkedList.add(n)}}FindComponentByDotNetComponentUniqueIdentifier(e){var o,r;let n=this.FindFirstCacheItemByDotNetComponentUniqueIdentifier(e);return n?(r=(o=n.freeSpace.ref)==null?void 0:o.current)!=null?r:n.instanceArray[n.instanceArray.length-1]:null}GetFreeSpaceOfComponent(e){let n=this.FindFirstCacheItemByDotNetComponentUniqueIdentifier(e);if(n)return n.freeSpace;throw h("AccessToFreeSpace -> ComponentNotFound. dotNetComponentUniqueIdentifier:"+e)}FindFirstCacheItemByDotNetComponentUniqueIdentifier(e){let n=o=>{let r=o.instanceArray,c=r.length;for(let i=0;i<c;i++)if(r[i][N].indexOf(e)>=0)return!0;return!1};return this.linkedList.first(n)}Unregister(e){this.linkedList.removeFirst(n=>n.instanceArray.indexOf(e)>=0)}},W=new Ct;function H(t){return W.GetFreeSpaceOfComponent(t[N][0])}function D(t){let e=W.FindComponentByDotNetComponentUniqueIdentifier(t);if(e==null)throw h("Component not found. dotNetComponentUniqueIdentifier: "+t);return e}function B(t){return D(t)[N][0]}function j(t,e){if(t===e)return!0;if(t instanceof Date&&typeof e instanceof Date)return t.valueOf()===e.valueOf();if(typeof t=="object"&&typeof e=="object")return ve(t,e)}function ve(t,e){let n;for(n in t)if(t.hasOwnProperty(n)&&!j(t[n],e[n]))return!1;for(n in e)if(e.hasOwnProperty(n)&&!j(t[n],e[n]))return!1;return!0}function we(t){return t.state.$CachedMethods}function nt(t,e,n){let o=we(t);if(o==null)return null;let r=o.length;for(let c=0;c<r;c++){let i=o[c];if(i.MethodName===e&&i.IgnoreParameters||e==="componentDidMount"&&i.MethodName.endsWith("|componentDidMount")||e==="componentWillUnmount"&&i.MethodName.endsWith("|componentWillUnmount")||i.MethodName===e&&n.length===1&&j(n[0],i.Parameter))return i}return null}function Re(t,e){let n=e.remoteMethodName,o=e.HandlerComponentUniqueIdentifier,r=e.FunctionNameOfGrabEventArguments,c=e.StopPropagation,i=e.KeyboardEventCallOnly,a=e.DebounceTimeout;y(n),y(o);let u=t.$onClickPreview,d=null;return u&&(d=function(){let s=D(u.$DotNetComponentUniqueIdentifier),l=q(s.state,u);s.setState(l)}),function(){if(c){if(arguments.length===0)throw h("There is no event argument for applying StopPropagation");if(arguments[0]==null)throw h("Trying to call StopPropagation method bu event argument is null.");arguments[0].stopPropagation()}let s=Array.prototype.slice.call(arguments);if(i){let m=arguments[0].key;if(i.indexOf(m)<0)return;s[0].preventDefault(),s[0]=De(s[0])}let l=D(o);r&&(s=$(r)(s));let f=nt(l,n,s);if(f){let m=q(l.state,f.ElementAsJson);l.setState(m);return}if(a>0){let m=s[0]._reactName,g=m+"-debounce-"+B(o);xt(g);let F=m+"-debounceTimeoutId";clearTimeout(l.state[F]);let R={};R[F]=setTimeout(()=>{w({component:l,remoteMethodName:n,remoteMethodArguments:s,uniqueName:g})},a),R[I]=z(),l.setState(R);return}{let m={component:l,remoteMethodName:n,remoteMethodArguments:s,onPreviewHandler:d,isCacheable:e.Cacheable};w(m)}}}function Kt(t,e,n){if(e&&e.$FakeChild===t)return n;let o=e.$children,r=n.$children;if(o&&r&&o.length<=r.length){let c=o.length;for(let i=0;i<c;i++){let a=Kt(t,o[i],r[i]);if(a!=null)return a}}return null}function P(t,e){if(t==null)return null;if(typeof t=="string")return t;if(t.$FakeChild!=null&&(t=Kt(t.$FakeChild,e.state[J],e.props.$jsonNode[J])),t.$isPureComponent){let i=Vt(t),u={key:y(t.key),$jsonNode:t,$styles:S[t[C]]};return t.$props&&Object.assign(u,t.$props),b(i,u)}if(t[v]){let i=Bt(t),u={key:y(t.key),$jsonNode:t,$styles:S[t[C]]},d=t.$ReactAttributeNames;if(d)for(let l=0;l<d.length;l++){let f=d[l];u[f]=t[O][f]}let s=W.FindComponentByDotNetComponentUniqueIdentifier(t[C]);if(s){let l=G(s.state[I]),f=G(s.props[I]);u[I]=Math.max(f,l),u.ref=s.myRef,H(s).ref=s.myRef}else u[I]=z();return t.$props&&Object.assign(u,t.$props),b(i,u)}let n=null,o=t.$tag;if(!o)throw h("ReactNode is not recognized");let r=!1;if(o.indexOf(".")>0&&(ce(o),o=$(o),r=!0),o==="nbsp")return t&&t.length?Array(t.length).fill("\xA0").join(""):"\xA0";for(let i in t){if(!t.hasOwnProperty(i)||i[0]==="$")continue;n===null&&(n={});let a=t[i];if(a!=null){if(a.$isRemoteMethod){n[i]=Re(t,a);continue}if(a.$isBinding){let s=a.targetProp,l=a.eventName,f=a.sourcePath,m=a.sourceIsState,g=a.DebounceTimeout,F=a.DebounceHandler,R=a.jsValueAccess,ct=$(Ie(a.transformFunction,"ReactWithDotNet::Core::ReplaceEmptyStringWhenIsNull")),at=a.HandlerComponentUniqueIdentifier,X=O;m&&(X=K),n[s]=ct(Pt(D(at).state[X],f)),n[l]=function(ee){let Q=D(at),Ot=Se(Q.state[X]);ge(Ot,f,ct(Pt({e:ee},R)));let Z={};if(Z[X]=Ot,g>0){let Et=l+"-debounce-"+B(at);xt(Et);let Dt=l+"-debounceTimeoutId";clearTimeout(Q.state[Dt]),Z[Dt]=setTimeout(()=>{w({component:Q,remoteMethodName:F,remoteMethodArguments:[],uniqueName:Et})},g)}Z[I]=z(),Q.setState(Z)};continue}if(a.$isElement){n[i]=P(a.Element,e);continue}let u=a.___ItemTemplates___,d=a.___TemplateForNull___;if(u){n[i]=function(s){if(U.default.isValidElement(s))return s;if(s==null&&d)return P(d);let l=u.length;for(let f=0;f<l;f++){let m=u[f].Item,g=u[f].ElementAsJson;if(s&&s.key!=null&&m.key!=null&&m.key===s.key)return P(g)}for(let f=0;f<l;f++){let m=u[f].Item,g=u[f].ElementAsJson;if(JSON.stringify(m)===JSON.stringify(s))return P(g)}throw h("item template not found")};continue}if(a.$transformValueFunction){n[i]=$(a.$transformValueFunction)(a.RawValue);continue}}n[i]=t[i]}if(r===!0&&(n=le(t.$tag,n,e)),t.$text!=null)return b(o,n,t.$text);let c=t.$children;if(c){let i=c.length;if(i===1)return b(o,n,P(c[0],e));let a=[];for(let u=0;u<i;u++)a.push(P(c[u],e));return b(o,n,a)}return b(o,n)}function Oe(t){let e=typeof t;return e==="string"||e==="number"||e==="boolean"||t instanceof Date||t instanceof Array}function Tt(t){return{altKey:t.altKey,bubbles:t.bubbles,clientX:t.clientX,clientY:t.clientY,ctrlKey:t.ctrlKey,metaKey:t.metaKey,movementX:t.movementX,movementY:t.movementY,pageX:t.pageX,pageY:t.pageY,screenX:t.screenX,screenY:t.screenY,shiftKey:t.shiftKey,timeStamp:t.timeStamp,type:t.type,target:E(t.target),currentTarget:E(t.currentTarget)}}function Ee(t){return{currentTarget:E(t.currentTarget),target:E(t.target),timeStamp:t.timeStamp,type:t.type}}function De(t){return{currentTarget:E(t.currentTarget),target:E(t.target),timeStamp:t.timeStamp,type:t.type,keyCode:t.keyCode,key:t.key,shiftKey:t.shiftKey,ctrlKey:t.ctrlKey,altKey:t.altKey,which:t.which}}function Me(t){let e=E(t.target);return t._reactName==="onInput"&&(e.textContent=t.target.textContent),{bubbles:t.bubbles,target:e,timeStamp:t.timeStamp,type:t.type}}function E(t){if(t==null)return null;let e=null;t.value!=null&&typeof t.value=="string"&&(e=t.value);let n=null;t.selectedIndex!=null&&typeof t.selectedIndex=="number"&&(n=t.selectedIndex);let o=null;return t.selectionStart!=null&&typeof t.selectionStart=="number"&&(o=t.selectionStart),{id:t.id,offsetHeight:t.offsetHeight,offsetLeft:t.offsetLeft,offsetTop:t.offsetTop,offsetWidth:t.offsetWidth,selectedIndex:n,selectionStart:o,tagName:t.tagName,value:e,data:t.dataset,scrollHeight:t.scrollHeight,scrollLeft:t.scrollLeft,scrollTop:t.scrollTop,scrollWidth:t.scrollWidth}}function ot(t,e){if(t==null)return;let n=t.length;for(let o=0;o<n;o++){let r=t[o].JsFunctionPath,c=t[o].JsFunctionArguments;Gt(r,e,c)}}function Ae(t){try{return t.constructor.prototype.constructor.name==="SyntheticBaseEvent"}catch(e){return!1}}function be(t){if(t)for(let e=0;e<t.length;e++){let n=t[e];if(Ae(n)){let o=n._reactName;o&&(o.indexOf("Mouse")>0?t[e]=Tt(n):o==="onScroll"&&(t[e]=Ee(n)))}}}function Pe(t){let e=t.remoteMethodName,n=t.isComponentWillUnmount,o=y(t.component);if(o.ComponentWillUnmountIsCalled){t.status=_;return}if(o=D(o[N][0]),o._reactInternals==null)throw h("Component is not ready to send server.");let r=o[v]==="ReactWithDotNet.UIDesigner.ReactWithDotNetDesignerComponentPreview,ReactWithDotNet",c,i;if(n)c=t.capturedStateTree,i=t.capturedStateTreeRootNodeKey;else{let s=$t(()=>Jt(o._reactInternals));if(s.fail)throw r&&location.reload(),s.exception;c=s.value.stateTree,i=s.value.rootNodeKey}let a={MethodName:"HandleComponentEvent",EventHandlerMethodName:y(e),FullName:y(o.constructor)[v],CapturedStateTree:c,CapturedStateTreeRootNodeKey:i,ComponentKey:parseInt(y(o.props.$jsonNode.key)),LastUsedComponentUniqueIdentifier:Y,ComponentUniqueIdentifier:y(o.state[C]),CallFunctionId:t.id};if(be(t.remoteMethodArguments),t.isCacheable){let s=H(o),l=s.$CachedMethods=s.$CachedMethods||[];for(let f=0;f<l.length;f++){let m=l[f];if(m.MethodName!==e||m.MethodArguments.length!==t.remoteMethodArguments.length)continue;{let F=!0;for(let R=0;R<t.remoteMethodArguments.length;R++)if(!j(t.remoteMethodArguments[R],m.MethodArguments[R])){F=!1;break}if(!F)continue}let g=q(o.state,m.ElementAsJson);t.status=_,o.setState(g);return}t.onRemoteSuccess=function(f){s.$CachedMethods.push({MethodName:e,MethodArguments:Array.from(t.remoteMethodArguments),ElementAsJson:f.ElementAsJson})}}{let s=Array.from(t.remoteMethodArguments),l=s.length;for(let f=0;f<l;f++)s[f]=JSON.stringify(s[f]);a.EventArgumentsAsJsonArray=s}function u(s){if(t.status===V)return;if(s.ErrorMessage!=null)throw h(s.ErrorMessage);if(s.LastUsedComponentUniqueIdentifier>Y&&(Y=s.LastUsedComponentUniqueIdentifier),Qt(s.DynamicStyles),s.SkipRender){o.state[K]=s.NewState,o.state[O]=s.NewDotNetProperties,s.ClientTaskList&&(o.state[M]=s.ClientTaskList,gt(o)),t.status=_;return}t.onRemoteSuccess&&t.onRemoteSuccess(s);let l=q(o.state,s.ElementAsJson);et(o,l,()=>{t.status=_}),n&&(ot(l[M],o),t.status=_)}function d(s){if(r){setTimeout(()=>St(a,u,d),1e3);return}console.error(s),t.status=Lt}t.onPreviewHandler&&t.onPreviewHandler(),t.status=qt,St(a,u,d)}function q(t,e){if(y(t[C])!==y(e[C])){let n=W.FindComponentByDotNetComponentUniqueIdentifier(t[C]);n&&n[N].push(e[C])}return e[I]=z(),e}var it={};function Ue(t){let e=H(t)[It];for(let n=0;n<e.length;n++)e[n]()}function L(t,e){H(t)[It].push(e)}function lt(t){Ue(t),Zt(t[N]),W.Unregister(t)}function gt(t){let e=t.state[M];if(e==null||e.length===0||t.ComponentWillUnmountIsCalled===!0)return!1;let n=H(t);return n.lastProcessedClientTasks===e?!1:(n.lastProcessedClientTasks=e,ot(e,t),!0)}function Bt(t){let e=t[v];e==="ReactWithDotNet.FunctionalComponent,ReactWithDotNet"&&(e=t[O].RenderMethodNameWithToken);let n=it[e];if(n)return n;let o=t[v];class r extends U.default.Component{constructor(i){super(i||{}),this.myRef=U.default.createRef();let a=this,u={};i&&(Object.assign(u,i.$jsonNode),u[I]=G(i[I])),a.state=u,u[v]=a[v]=o,a[N]=[y(i.$jsonNode[C])],Te(a),W.Register(a)}render(){let i=this.props;{let a=i.$styles;if(a){let u=i.$jsonNode[C];S[u]!==a&&(S[u]=a,st())}}return P(this.state[J],this)}componentDidMount(){W.Register(this),this.state.$didMount=1;let i=this;gt(this);let a=i.state[tt];if(a==null)return;{let d=nt(i,"componentDidMount",[]);if(d){let s=q(i.state,d.ElementAsJson),l=s[M];s[tt]=null,s[M]=null,et(i,s,()=>{ot(l,i)});return}}let u={};u[tt]=null,et(i,u,()=>{w({component:i,remoteMethodName:a,remoteMethodArguments:[]})})}componentDidUpdate(i,a,u){gt(this)}componentWillUnmount(){if(!k.StrictMode&&!this.state.$isUnmounting){if(this.setState({$isUnmounting:1}),!this.state.$didMount)return;if(this.ComponentWillUnmountIsCalled===!0)throw"componentWillUnmount -> ComponentWillUnmountIsCalled called twice";let i=this,a=i.state[re];if(a==null){i.ComponentWillUnmountIsCalled=!0,lt(i);return}{let u=nt(i,"componentWillUnmount",[]);if(u){let l=function(){ot(s,i),i.ComponentWillUnmountIsCalled=!0,lt(i)},d=q(i.state,u.ElementAsJson),s=d[M];d[tt]=null,d[M]=null,et(i,d,l);return}}{let u=$t(()=>Jt(i._reactInternals));if(u.fail)throw u.exception;let d=u.value.stateTree,s=u.value.rootNodeKey;w({component:i,remoteMethodName:a,remoteMethodArguments:[],isComponentWillUnmount:1,capturedStateTree:d,capturedStateTreeRootNodeKey:s,onCompleted:()=>{i.ComponentWillUnmountIsCalled=!0,lt(i)}})}}}static getDerivedStateFromProps(i,a){let u=G(a[I]),d=G(i[I]);if(u>d){let s=y(a[C]),l=y(i.$jsonNode[C]);if(s!==l){D(s)[N].push(l);let m={};return m[C]=l,m}return null}if(u<d){let s={};s[I]=d,s[J]=i.$jsonNode[J],s[M]=i.$jsonNode[M],s[O]=y(i.$jsonNode[O]),s[K]=y(i.$jsonNode[K]);let l=y(a[C]),f=y(i.$jsonNode[C]);return l!==f&&D(l)[N].push(f),s[C]=f,s}return null}}return r[v]=o,it[e]=r,r.displayName=o.split(",")[0].split(".").pop(),r.displayName==="FunctionalComponent"&&(r.displayName=t[O].Name),r}function Vt(t){let e=t[v],n=it[e];if(n)return n;class o extends U.default.PureComponent{render(){let c=this.props;{let i=c.$styles;if(i){let a=c.$jsonNode[C];S[a]!==i&&(S[a]=i,st())}}return P(c.$jsonNode[J],this)}componentWillUnmount(){let c=y(this.props.$jsonNode[C]);Zt([c])}}return it[e]=o,o.displayName=e.split(",")[0].split(".").pop(),o}function St(t,e,n){t.ClientWidth=document.documentElement.clientWidth,t.ClientHeight=document.documentElement.clientHeight,t.QueryString=window.location.search;let o=k.RequestHandlerPath,r={method:"POST",headers:{Accept:"application/json","Content-Type":"application/json"},body:JSON.stringify(t)};k.BeforeSendRequest&&k.BeforeSendRequest(r),window.fetch(o,r).then(c=>c.json()).then(c=>e(c)).catch(n)}var Y=1;function Ut(t,e){if(e.ErrorMessage!=null)throw e.ErrorMessage;Qt(e.DynamicStyles);let n=e.ElementAsJson,o=n.$isPureComponent?Vt(n):Bt(n);Y=e.LastUsedComponentUniqueIdentifier;let r={key:"0",$jsonNode:n};r[I]=z();let c=b(o,r),i=(0,Ft.createRoot)(document.getElementById(t));k.StrictMode?i.render(b(U.default.StrictMode,null,c)):i.render(c)}function Fe(t){if(t.renderInfo){if(t.idOfContainerHtmlElement==null)throw h("idOfContainerHtmlElement cannot be null.");setTimeout(()=>Ut(t.idOfContainerHtmlElement,t.renderInfo),10);return}let e=t.fullTypeNameOfReactComponent,n=t.containerHtmlElementId;kt(function(){let o={MethodName:"FetchComponent",FullName:e,LastUsedComponentUniqueIdentifier:Y,ComponentUniqueIdentifier:1};function r(i){Ut(n,i)}function c(i){throw i}St(o,r,c)})}function Gt(t,e,n){return $(t).apply(e,n)}var rt={"React.Fragment":U.default.Fragment};function vt(t,e){return rt[t]!=null&&console.log(t+" already registered."),rt[t]=e}function $(t){let e=ke(t);if(e!=null){if(e.isCacheEnabled===!0){if(e.value==null)throw h(t+" ==> isCacheEnabled is true but value property is null.");return vt(t,e.value),e.value}return e}let n=rt[t];if(n==null)throw h(t+" External js object not not found. You should register by using method: ReactWithDotNet.RegisterExternalJsObject");return n}var Yt=[];function $e(t){Yt.push(t)}function ke(t){let e=Yt,n=e.length;for(let o=0;o<n;o++){let r=e[o](t);if(r!=null)return r}}function p(t,e){vt("ReactWithDotNet::Core::"+t,e)}rt["ReactWithDotNet.GetExternalJsObject"]=$;p("RegExp",t=>new RegExp(t));p("IsTwoObjectEquals",j);p("CopyToClipboard",function(t){if(navigator.clipboard&&navigator.clipboard.writeText){navigator.clipboard.writeText(t).then(()=>{});return}if(window.clipboardData&&window.clipboardData.setData)return window.clipboardData.setData("Text",t)});p("RunJavascript",t=>{window.eval(t)});p("ReplaceNullWhenEmpty",function(t){return de(t)?null:t});p("EmptyTransformFunction",function(t){return t});p("ReplaceEmptyStringWhenIsNull",function(t){return t==null?"":t});p("ListenWindowResizeEvent",function(t){let e=window.innerWidth,n=window.innerHeight,o=null;window.addEventListener("resize",function(){let r=window.innerWidth,c=window.innerHeight;(Math.abs(e-r)>50||Math.abs(n-c)>50)&&(clearTimeout(o),o=setTimeout(function(){wt("ReactWithDotNet::Core::OnWindowResize",[],0)},t)),e=r,n=c})});p("ConvertDotnetSerializedStringDateToJsDate",function(t){return t==null||t===""?null:new Date(t)});p("CalculateSyntheticMouseEventArguments",t=>[Tt(t[0])]);p("CalculateSyntheticChangeEventArguments",t=>[Me(t[0])]);p("CalculateSyntheticFocusEventArguments",t=>{let e=t[0];return[{bubbles:e.bubbles,cancelable:e.cancelable,currentTarget:E(e.currentTarget),defaultPrevented:e.defaultPrevented,detail:e.detail,eventPhase:e.eventPhase,isTrusted:e.isTrusted,target:E(e.target),relatedTarget:E(e.relatedTarget),timeStamp:e.timeStamp,type:e.type}]});function xe(t){if(t==null)return null;let e=[];for(let n=0;n<t.length;n++)e.push(t[n]);return e}p("CalculateRemoteMethodArguments",xe);function zt(t,e,n){let o=new Date;o.setDate(o.getDate()+n),document.cookie=[t+"="+encodeURI(e),"expires="+o.toUTCString(),"path=/"].join(";")}p("SetCookie",zt);p("HistoryBack",function(){window.history.back()});p("HistoryForward",function(){window.history.forward()});p("HistoryGo",function(t){window.history.go(t)});p("HistoryReplaceState",function(t,e,n){t==null&&(t={}),window.history.replaceState(t,e,n)});p("GotoMethod",function(t,e,n){let o=this;n=n||[],setTimeout(()=>{if(o.ComponentWillUnmountIsCalled)return;let r=nt(o,e,n);if(r){let i=q(o.state,r.ElementAsJson);o.setState(i);return}w({component:o,remoteMethodName:e,remoteMethodArguments:n})},t)});function wt(t,e,n){setTimeout(()=>{T.Dispatch(t,e||[])},n)}p("DispatchEvent",wt);function jt(t,e){return["senderPropertyFullName:"+t,"senderComponentUniqueIdentifier:"+e].join(",")}p("DispatchDotNetCustomEvent",function(t,e){let n=t.SenderPropertyFullName,o=B(t.SenderComponentUniqueIdentifier),r=jt(n,o);T.Dispatch(r,e)});p("ListenEvent",function(t,e){let n=this,o=r=>{if(n.ComponentWillUnmountIsCalled)return;let c={component:n,remoteMethodName:e,remoteMethodArguments:r,priorityIsMore:1};w(c),L(n,()=>{c.status=V})};L(n,()=>{T.Remove(t,o)}),T.On(t,o)});p("ListenEventOnlyOnce",function(t,e){let n=this,o=r=>{T.Remove(t,o);let c={component:n,remoteMethodName:e,remoteMethodArguments:r,priorityIsMore:1};w(c),L(n,()=>{c.status=V})};L(n,()=>{T.Remove(t,o)}),T.On(t,o)});p("InitializeDotnetComponentEventListener",function(t,e,n){let o=this;if(o.ComponentWillUnmountIsCalled)return;let r=H(o)[Nt],c=t.SenderPropertyFullName,i=B(t.SenderComponentUniqueIdentifier);n=B(n);let a=s=>{let l=D(n),f={component:l,remoteMethodName:e,remoteMethodArguments:s,priorityIsMore:1};w(f),L(l,()=>{f.status=V})},u=["senderPropertyFullName:"+c,"senderComponentUniqueIdentifier:"+i,"handlerComponentUniqueIdentifier:"+n].join(",");if(r[u])return;r[u]=a;let d=jt(c,i);L(o,()=>{T.Remove(d,a),r[u]=null}),T.On(d,a)});function We(t){let e=window.location;e.assign(e.origin+t)}p("NavigateTo",We);function Xt(t,e,n,o,r){let c=H(t)[Nt],i=e==="remove";r=B(r);function a(d){let s=document.getElementById(n);if(s==null)return;if(!s.contains(d.target)){let m={component:D(r),remoteMethodName:o,remoteMethodArguments:[Tt(d)]};w(m)}}let u="OnOutsideClicked(IdOfElement:"+n+", remoteMethodName:"+o+", @handlerComponentUniqueIdentifier:"+r+")";if(c[u]){i&&(document.removeEventListener("click",c[u]),c[u]=null);return}i||(c[u]=a,document.addEventListener("click",a),L(t,()=>{document.removeEventListener("click",a),c[u]=null}))}p("AddEventListener",function(t,e,n,o){if(e==="OutsideClick")Xt(this,"add",t,n,o);else throw h("InvalidUsageOfAddEventListener")});p("RemoveEventListener",function(t,e,n,o){if(e==="OutsideClick")Xt(this,"remove",t,n,o);else throw h("InvalidUsageOfRemoveEventListener")});function h(t){return new Error(`
ReactWithDotNet developer error occured.
`+t)}var S={},A=null;function Qt(t){if(t!=null){for(let e in t)t.hasOwnProperty(e)&&(S[e]=t[e]);st()}}function st(){if(A===null){let n="ReactWithDotNetDynamicCss";A=document.getElementById(n),A==null&&(A=document.createElement("style"),A.id=n,document.head.appendChild(A))}let t=[];for(let n in S)if(S.hasOwnProperty(n)){let o=S[n];if(o==null)continue;let r=o.length;for(let c=0;c<r;c++){let i=o[c],a=i[0],u=i[1],d=i[2],s=i[3];if(t.push("."+a),t.push("{"),t.push(u),t.push("}"),d){let l=d.length;for(let f=0;f<l;f++){let m=d[f][0],g=d[f][1];t.push("@media "+m+" {"),t.push("  ."+a+" {"),t.push(g),t.push("  }"),t.push("}")}}if(s){let l=s.length;for(let f=0;f<l;f++){let m=s[f][0],g=s[f][1];t.push("."+a+":"+m+"{"),t.push(g),t.push("}")}}}}let e=t.join(`
`);Le(A.innerHTML,e)||(A.innerHTML=e)}function qe(t){let e={};for(let n in t)t.hasOwnProperty(n)&&t[n]!=null&&(e[n]=t[n]);return e}setInterval(()=>{S=qe(S)},3e3);function Zt(t){let e=!1,n=t.length;for(let o=0;o<n;o++){let r=t[o];S[r]!=null&&(e=!0,S[r]=null)}e&&st()}function Le(t,e){if(t==null||e==null)return!1;let n=/\s/g;return t=t.replace(n,""),e=e.replace(n,""),t===e}function Rt(){return document.documentElement.clientWidth<=767}function te(){return document.documentElement.clientWidth<=1023&&Rt()===!1}function He(){return Rt()===!1&&te()===!1}var k={StrictMode:!1,RequestHandlerPath:"DeveloperError: missing RequestHandlerPath",OnDocumentReady:kt,StartAction:w,DispatchEvent:wt,RenderComponentIn:Fe,BeforeSendRequest:t=>t,RegisterExternalJsObject:vt,GetExternalJsObject:$,BeforeAnyThirdPartyComponentAccess:ae,TryLoadCssByHref:fe,OnThirdPartyComponentPropsCalculated:ue,OnFindExternalObject:$e,IsMediaMobile:Rt,IsMediaTablet:te,IsMediaDesktop:He,Call:Gt,Util:{SetCookie:zt}};window.ReactWithDotNet=k;var Be=k;export{Be as a};
