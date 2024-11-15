import{a as et}from"./chunk-KRUAA7WP.js";import{A as D,B as Qe,a as oe,b as P,d as F,e as Xe,m as Ue,o as ke,q as Ke,u as Ye,v as Ze,x as qe,z as Ge}from"./chunk-NI4MO4TP.js";import{a as Ut}from"./chunk-2W22VGCX.js";import{h as Xt}from"./chunk-GYULANB4.js";var f=Xt(Ut());function be(){return be=Object.assign?Object.assign.bind():function(l){for(var i=1;i<arguments.length;i++){var c=arguments[i];for(var S in c)Object.prototype.hasOwnProperty.call(c,S)&&(l[S]=c[S])}return l},be.apply(this,arguments)}function Z(l){"@babel/helpers - typeof";return Z=typeof Symbol=="function"&&typeof Symbol.iterator=="symbol"?function(i){return typeof i}:function(i){return i&&typeof Symbol=="function"&&i.constructor===Symbol&&i!==Symbol.prototype?"symbol":typeof i},Z(l)}function kt(l,i){if(Z(l)!=="object"||l===null)return l;var c=l[Symbol.toPrimitive];if(c!==void 0){var S=c.call(l,i||"default");if(Z(S)!=="object")return S;throw new TypeError("@@toPrimitive must return a primitive value.")}return(i==="string"?String:Number)(l)}function Kt(l){var i=kt(l,"string");return Z(i)==="symbol"?i:String(i)}function nt(l,i,c){return i=Kt(i),i in l?Object.defineProperty(l,i,{value:c,enumerable:!0,configurable:!0,writable:!0}):l[i]=c,l}function Yt(l){if(Array.isArray(l))return l}function Zt(l,i){var c=l==null?null:typeof Symbol!="undefined"&&l[Symbol.iterator]||l["@@iterator"];if(c!=null){var S,e,x,_,R=[],m=!0,q=!1;try{if(x=(c=c.call(l)).next,i===0){if(Object(c)!==c)return;m=!1}else for(;!(m=(S=x.call(c)).done)&&(R.push(S.value),R.length!==i);m=!0);}catch(G){q=!0,e=G}finally{try{if(!m&&c.return!=null&&(_=c.return(),Object(_)!==_))return}finally{if(q)throw e}}return R}}function tt(l,i){(i==null||i>l.length)&&(i=l.length);for(var c=0,S=new Array(i);c<i;c++)S[c]=l[c];return S}function qt(l,i){if(l){if(typeof l=="string")return tt(l,i);var c=Object.prototype.toString.call(l).slice(8,-1);if(c==="Object"&&l.constructor&&(c=l.constructor.name),c==="Map"||c==="Set")return Array.from(l);if(c==="Arguments"||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(c))return tt(l,i)}}function Gt(){throw new TypeError(`Invalid attempt to destructure non-iterable instance.
In order to be iterable, non-array objects must have a [Symbol.iterator]() method.`)}function V(l,i){return Yt(l)||Zt(l,i)||qt(l,i)||Gt()}var Qt=`
.p-virtualscroller {
    position: relative;
    overflow: auto;
    contain: strict;
    transform: translateZ(0);
    will-change: scroll-position;
    outline: 0 none;
}

.p-virtualscroller-content {
    position: absolute;
    top: 0;
    left: 0;
    /*contain: content;*/
    min-height: 100%;
    min-width: 100%;
    will-change: transform;
}

.p-virtualscroller-spacer {
    position: absolute;
    top: 0;
    left: 0;
    height: 1px;
    width: 1px;
    transform-origin: 0 0;
    pointer-events: none;
}

.p-virtualscroller-loader {
    position: sticky;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
}

.p-virtualscroller-loader.p-component-overlay {
    display: flex;
    align-items: center;
    justify-content: center;
}

.p-virtualscroller-loading-icon {
    font-size: 2rem;
}

.p-virtualscroller-horizontal > .p-virtualscroller-content {
    display: flex;
}

/* Inline */
.p-virtualscroller-inline .p-virtualscroller-content {
    position: static;
}
`,se=Qe.extend({defaultProps:{__TYPE:"VirtualScroller",__parentMetadata:null,id:null,style:null,className:null,tabIndex:0,items:null,itemSize:0,scrollHeight:null,scrollWidth:null,orientation:"vertical",step:0,numToleratedItems:null,delay:0,resizeDelay:10,appendOnly:!1,inline:!1,lazy:!1,disabled:!1,loaderDisabled:!1,loadingIcon:null,columns:null,loading:void 0,autoSize:!1,showSpacer:!0,showLoader:!1,loadingTemplate:null,loaderIconTemplate:null,itemTemplate:null,contentTemplate:null,onScroll:null,onScrollIndexChange:null,onLazyLoad:null,children:void 0},css:{styles:Qt}});function rt(l,i){var c=Object.keys(l);if(Object.getOwnPropertySymbols){var S=Object.getOwnPropertySymbols(l);i&&(S=S.filter(function(e){return Object.getOwnPropertyDescriptor(l,e).enumerable})),c.push.apply(c,S)}return c}function J(l){for(var i=1;i<arguments.length;i++){var c=arguments[i]!=null?arguments[i]:{};i%2?rt(Object(c),!0).forEach(function(S){nt(l,S,c[S])}):Object.getOwnPropertyDescriptors?Object.defineProperties(l,Object.getOwnPropertyDescriptors(c)):rt(Object(c)).forEach(function(S){Object.defineProperty(l,S,Object.getOwnPropertyDescriptor(c,S))})}return l}var er=f.memo(f.forwardRef(function(l,i){var c=Ye(),S=f.useContext(Ue),e=se.getProps(l,S),x=ke(l)||{},_=e.orientation==="vertical",R=e.orientation==="horizontal",m=e.orientation==="both",q=f.useState(m?{rows:0,cols:0}:0),G=V(q,2),g=G[0],Ie=G[1],at=f.useState(m?{rows:0,cols:0}:0),ze=V(at,2),y=ze[0],Oe=ze[1],lt=f.useState(0),Ce=V(lt,2),Te=Ce[0],ot=Ce[1],st=f.useState(m?{rows:0,cols:0}:0),Pe=V(st,2),C=Pe[0],it=Pe[1],ct=f.useState(e.numToleratedItems),Le=V(ct,2),z=Le[0],ie=Le[1],ut=f.useState(e.loading||!1),Ee=V(ut,2),L=Ee[0],ce=Ee[1],ft=f.useState([]),Ne=V(ft,2),W=Ne[0],mt=Ne[1],vt=se.setMetaData({props:e,state:{first:g,last:y,page:Te,numItemsInViewport:C,numToleratedItems:z,loading:L,loaderArr:W}}),X=vt.ptm;Ge(se.css.styles,{name:"virtualscroller"});var h=f.useRef(null),w=f.useRef(null),xe=f.useRef(null),ue=f.useRef(null),H=f.useRef(m?{top:0,left:0}:0),fe=f.useRef(null),me=f.useRef(null),Q=f.useRef({}),ee=f.useRef({}),U=f.useRef(null),k=f.useRef(null),je=f.useRef(null),Fe=f.useRef(null),ve=f.useRef(!1),$=f.useRef(null),gt=qe({listener:function(t){return $e()},when:!e.disabled}),pt=V(gt,1),dt=pt[0],ht=Ke({target:"window",type:"orientationchange",listener:function(t){return $e()},when:!e.disabled}),St=V(ht,1),yt=St[0],Rt=function(){return h},te=function(t){return Math.floor((t+z*4)/(e.step||1))},wt=function(t){w.current=t||w.current||P.findSingle(h.current,".p-virtualscroller-content")},ge=function(t){return e.step?Te!==te(t):!0},pe=function(t){H.current=m?{top:0,left:0}:0,h.current&&h.current.scrollTo(t)},Ve=function(t){var r=arguments.length>1&&arguments[1]!==void 0?arguments[1]:"auto",n=He(),a=n.numToleratedItems,u=re(),o=function(){var T=arguments.length>0&&arguments[0]!==void 0?arguments[0]:0,E=arguments.length>1?arguments[1]:void 0;return T<=E?0:T},s=function(T,E,M){return T*E+M},d=function(){var T=arguments.length>0&&arguments[0]!==void 0?arguments[0]:0,E=arguments.length>1&&arguments[1]!==void 0?arguments[1]:0;return pe({left:T,top:E,behavior:r})},p=m?{rows:0,cols:0}:0,b=!1;m?(p={rows:o(t[0],a[0]),cols:o(t[1],a[1])},d(s(p.cols,e.itemSize[1],u.left),s(p.rows,e.itemSize[0],u.top)),b=g.rows!==p.rows||g.cols!==p.cols):(p=o(t,a),R?d(s(p,e.itemSize,u.left),0):d(0,s(p,e.itemSize,u.top)),b=g!==p),ve.current=b,Ie(p)},bt=function(t,r){var n=arguments.length>2&&arguments[2]!==void 0?arguments[2]:"auto";if(r){var a=_e(),u=a.first,o=a.viewport,s=function(){var E=arguments.length>0&&arguments[0]!==void 0?arguments[0]:0,M=arguments.length>1&&arguments[1]!==void 0?arguments[1]:0;return pe({left:E,top:M,behavior:n})},d=r==="to-start",p=r==="to-end";if(d){if(m)o.first.rows-u.rows>t[0]?s(o.first.cols*e.itemSize[1],(o.first.rows-1)*e.itemSize[0]):o.first.cols-u.cols>t[1]&&s((o.first.cols-1)*e.itemSize[1],o.first.rows*e.itemSize[0]);else if(o.first-u>t){var b=(o.first-1)*e.itemSize;R?s(b,0):s(0,b)}}else if(p){if(m)o.last.rows-u.rows<=t[0]+1?s(o.first.cols*e.itemSize[1],(o.first.rows+1)*e.itemSize[0]):o.last.cols-u.cols<=t[1]+1&&s((o.first.cols+1)*e.itemSize[1],o.first.rows*e.itemSize[0]);else if(o.last-u<=t+1){var O=(o.first+1)*e.itemSize;R?s(O,0):s(0,O)}}}else Ve(t,n)},It=function(){return L?e.loaderDisabled?W:[]:de()},zt=function(){return e.columns&&m||R?L&&e.loaderDisabled?m?W[0]:W:e.columns.slice(m?g.cols:g,m?y.cols:y):e.columns},_e=function(){var t=function(p,b){return Math.floor(p/(b||p))},r=g,n=0;if(h.current){var a=h.current,u=a.scrollTop,o=a.scrollLeft;if(m)r={rows:t(u,e.itemSize[0]),cols:t(o,e.itemSize[1])},n={rows:r.rows+C.rows,cols:r.cols+C.cols};else{var s=R?o:u;r=t(s,e.itemSize),n=r+C}}return{first:g,last:y,viewport:{first:r,last:n}}},He=function(){var t=re(),r=h.current?h.current.offsetWidth-t.left:0,n=h.current?h.current.offsetHeight-t.top:0,a=function(p,b){return Math.ceil(p/(b||p))},u=function(p){return Math.ceil(p/2)},o=m?{rows:a(n,e.itemSize[0]),cols:a(r,e.itemSize[1])}:a(R?r:n,e.itemSize),s=z||(m?[u(o.rows),u(o.cols)]:u(o));return{numItemsInViewport:o,numToleratedItems:s}},Ot=function(){var t=He(),r=t.numItemsInViewport,n=t.numToleratedItems,a=function(s,d,p){var b=arguments.length>3&&arguments[3]!==void 0?arguments[3]:!1;return Me(s+d+(s<p?2:3)*p,b)},u=m?{rows:a(g.rows,r.rows,n[0]),cols:a(g.cols,r.cols,n[1],!0)}:a(g,r,n);it(r),ie(n),Oe(u),e.showLoader&&mt(m?Array.from({length:r.rows}).map(function(){return Array.from({length:r.cols})}):Array.from({length:r})),e.lazy&&Promise.resolve().then(function(){$.current={first:e.step?m?{rows:0,cols:g.cols}:0:g,last:Math.min(e.step?e.step:u,(e.items||[]).length)},e.onLazyLoad&&e.onLazyLoad($.current)})},Ct=function(t){e.autoSize&&!t&&Promise.resolve().then(function(){if(w.current){w.current.style.minHeight=w.current.style.minWidth="auto",w.current.style.position="relative",h.current.style.contain="none";var r=[P.getWidth(h.current),P.getHeight(h.current)],n=r[0],a=r[1];(m||R)&&(h.current.style.width=(n<U.current?n:e.scrollWidth||U.current)+"px"),(m||_)&&(h.current.style.height=(a<k.current?a:e.scrollHeight||k.current)+"px"),w.current.style.minHeight=w.current.style.minWidth="",w.current.style.position="",h.current.style.contain=""}})},Me=function(){var t,r=arguments.length>0&&arguments[0]!==void 0?arguments[0]:0,n=arguments.length>1?arguments[1]:void 0;return e.items?Math.min(n?((t=e.columns||e.items[0])===null||t===void 0?void 0:t.length)||0:(e.items||[]).length,r):0},re=function(){if(w.current){var t=getComputedStyle(w.current),r=parseFloat(t.paddingLeft)+Math.max(parseFloat(t.left)||0,0),n=parseFloat(t.paddingRight)+Math.max(parseFloat(t.right)||0,0),a=parseFloat(t.paddingTop)+Math.max(parseFloat(t.top)||0,0),u=parseFloat(t.paddingBottom)+Math.max(parseFloat(t.bottom)||0,0);return{left:r,right:n,top:a,bottom:u,x:r+n,y:a+u}}return{left:0,right:0,top:0,bottom:0,x:0,y:0}},Tt=function(){if(h.current){var t=h.current.parentElement,r=e.scrollWidth||"".concat(h.current.offsetWidth||t.offsetWidth,"px"),n=e.scrollHeight||"".concat(h.current.offsetHeight||t.offsetHeight,"px"),a=function(o,s){return h.current.style[o]=s};m||R?(a("height",n),a("width",r)):a("height",n)}},Pt=function(){var t=e.items;if(t){var r=re(),n=function(u,o,s){var d=arguments.length>3&&arguments[3]!==void 0?arguments[3]:0;return ee.current=J(J({},ee.current),nt({},"".concat(u),(o||[]).length*s+d+"px"))};m?(n("height",t,e.itemSize[0],r.y),n("width",e.columns||t[1],e.itemSize[1],r.x)):R?n("width",e.columns||t,e.itemSize,r.x):n("height",t,e.itemSize,r.y)}},Lt=function(t){if(w.current&&!e.appendOnly){var r=t?t.first:g,n=function(s,d){return s*d},a=function(){var s=arguments.length>0&&arguments[0]!==void 0?arguments[0]:0,d=arguments.length>1&&arguments[1]!==void 0?arguments[1]:0;ue.current&&(ue.current.style.top="-".concat(d,"px")),Q.current=J(J({},Q.current),{transform:"translate3d(".concat(s,"px, ").concat(d,"px, 0)")})};if(m)a(n(r.cols,e.itemSize[1]),n(r.rows,e.itemSize[0]));else{var u=n(r,e.itemSize);R?a(u,0):a(0,u)}}},Ae=function(t){var r=t.target,n=re(),a=function(I,N){return I?I>N?I-N:I:0},u=function(I,N){return Math.floor(I/(N||I))},o=function(I,N,K,le,j,A){return I<=j?j:A?K-le-j:N+j-1},s=function(I,N,K,le,j,A,Y){return I<=A?0:Math.max(0,Y?I<N?K:I-A:I>N?K:I-2*A)},d=function(I,N,K,le,j,A){var Y=N+le+2*j;return I>=j&&(Y=Y+(j+1)),Me(Y,A)},p=a(r.scrollTop,n.top),b=a(r.scrollLeft,n.left),O=m?{rows:0,cols:0}:0,T=y,E=!1,M=H.current;if(m){var he=H.current.top<=p,Se=H.current.left<=b;if(!e.appendOnly||e.appendOnly&&(he||Se)){var B={rows:u(p,e.itemSize[0]),cols:u(b,e.itemSize[1])},Je={rows:o(B.rows,g.rows,y.rows,C.rows,z[0],he),cols:o(B.cols,g.cols,y.cols,C.cols,z[1],Se)};O={rows:s(B.rows,Je.rows,g.rows,y.rows,C.rows,z[0],he),cols:s(B.cols,Je.cols,g.cols,y.cols,C.cols,z[1],Se)},T={rows:d(B.rows,O.rows,y.rows,C.rows,z[0]),cols:d(B.cols,O.cols,y.cols,C.cols,z[1],!0)},E=O.rows!==g.rows||T.rows!==y.rows||O.cols!==g.cols||T.cols!==y.cols||ve.current,M={top:p,left:b}}}else{var ye=R?b:p,Re=H.current<=ye;if(!e.appendOnly||e.appendOnly&&Re){var we=u(ye,e.itemSize),Jt=o(we,g,y,C,z,Re);O=s(we,Jt,g,y,C,z,Re),T=d(we,O,y,C,z),E=O!==g||T!==y||ve.current,M=ye}}return{first:O,last:T,isRangeChanged:E,scrollPos:M}},We=function(t){var r=Ae(t),n=r.first,a=r.last,u=r.isRangeChanged,o=r.scrollPos;if(u){var s={first:n,last:a};if(Lt(s),Ie(n),Oe(a),H.current=o,e.onScrollIndexChange&&e.onScrollIndexChange(s),e.lazy&&ge(n)){var d={first:e.step?Math.min(te(n)*e.step,(e.items||[]).length-e.step):n,last:Math.min(e.step?(te(n)+1)*e.step:a,(e.items||[]).length)},p=!$.current||$.current.first!==d.first||$.current.last!==d.last;p&&e.onLazyLoad&&e.onLazyLoad(d),$.current=d}}},Et=function(t){if(e.onScroll&&e.onScroll(t),e.delay){if(fe.current&&clearTimeout(fe.current),ge(g)){if(!L&&e.showLoader){var r=Ae(t),n=r.isRangeChanged,a=n||(e.step?ge(g):!1);a&&ce(!0)}fe.current=setTimeout(function(){We(t),L&&e.showLoader&&(!e.lazy||e.loading===void 0)&&(ce(!1),ot(te(g)))},e.delay)}}else We(t)},$e=function(){me.current&&clearTimeout(me.current),me.current=setTimeout(function(){if(h.current){var t=[P.getWidth(h.current),P.getHeight(h.current)],r=t[0],n=t[1],a=r!==U.current,u=n!==k.current,o=m?a||u:R?a:_?u:!1;o&&(ie(e.numToleratedItems),U.current=r,k.current=n,je.current=P.getWidth(w.current),Fe.current=P.getHeight(w.current))}},e.resizeDelay)},Be=function(t){var r=(e.items||[]).length,n=m?g.rows+t:g+t;return{index:n,count:r,first:n===0,last:n===r-1,even:n%2===0,odd:n%2!==0,props:e}},De=function(t,r){var n=W.length||0;return J({index:t,count:n,first:t===0,last:t===n-1,even:t%2===0,odd:t%2!==0,props:e},r)},de=function(){var t=e.items;return t&&!L?m?t.slice(e.appendOnly?0:g.rows,y.rows).map(function(r){return e.columns?r:r.slice(e.appendOnly?0:g.cols,y.cols)}):R&&e.columns?t:t.slice(e.appendOnly?0:g,y):[]},Nt=function(){h.current&&P.isVisible(h.current)&&(wt(w.current),ne(),dt(),yt(),U.current=P.getWidth(h.current),k.current=P.getHeight(h.current),je.current=P.getWidth(w.current),Fe.current=P.getHeight(w.current))},ne=function(){e.disabled||(Tt(),Ot(),Pt())};Ze(function(){Nt()}),D(function(){ne()},[e.itemSize,e.scrollHeight,e.scrollWidth]),D(function(){e.numToleratedItems!==z&&ie(e.numToleratedItems)},[e.numToleratedItems]),D(function(){e.numToleratedItems===z&&ne()},[z]),D(function(){var v=x.items!==void 0&&x.items!==null,t=e.items!==void 0&&e.items!==null,r=v?x.items.length:0,n=t?e.items.length:0,a=r!==n;if(m&&!a){var u=v&&x.items.length>0?x.items[0].length:0,o=t&&e.items.length>0?e.items[0].length:0;a=u!==o}(!v||a)&&ne();var s=L;e.lazy&&x.loading!==e.loading&&e.loading!==L&&(ce(e.loading),s=e.loading),Ct(s)}),D(function(){H.current=m?{top:0,left:0}:0},[e.orientation]),f.useImperativeHandle(i,function(){return{props:e,getElementRef:Rt,scrollTo:pe,scrollToIndex:Ve,scrollInView:bt,getRenderedRange:_e}});var xt=function(t){var r=arguments.length>1&&arguments[1]!==void 0?arguments[1]:{},n=De(t,r),a=F.getJSXElement(e.loadingTemplate,n);return f.createElement(f.Fragment,{key:t},a)},jt=function(){var t="p-virtualscroller-loading-icon",r=c({className:t},X("loadingIcon")),n=e.loadingIcon||f.createElement(et,be({},r,{spin:!0})),a=Xe.getJSXIcon(n,J({},r),{props:e});if(!e.loaderDisabled&&e.showLoader&&L){var u=oe("p-virtualscroller-loader",{"p-component-overlay":!e.loadingTemplate}),o=a;if(e.loadingTemplate)o=W.map(function(p,b){return xt(b,m&&{numCols:C.cols})});else if(e.loaderIconTemplate){var s={iconClassName:t,element:o,props:e};o=F.getJSXElement(e.loaderIconTemplate,s)}var d=c({className:u},X("loader"));return f.createElement("div",d,o)}return null},Ft=function(){if(e.showSpacer){var t=c({ref:xe,style:ee.current,className:"p-virtualscroller-spacer"},X("spacer"));return f.createElement("div",t)}return null},Vt=function(t,r){var n=Be(r),a=F.getJSXElement(e.itemTemplate,t,n);return f.createElement(f.Fragment,{key:n.index},a)},_t=function(){var t=de();return t.map(Vt)},Ht=function(){var t=_t(),r=oe("p-virtualscroller-content",{"p-virtualscroller-loading":L}),n=c({ref:w,style:Q.current,className:r},X("content")),a=f.createElement("div",n,t);if(e.contentTemplate){var u={style:Q.current,className:r,spacerStyle:ee.current,contentRef:function(s){return w.current=F.getRefElement(s)},spacerRef:function(s){return xe.current=F.getRefElement(s)},stickyRef:function(s){return ue.current=F.getRefElement(s)},items:de(),getItemOptions:function(s){return Be(s)},children:t,element:a,props:e,loading:L,getLoaderOptions:function(s,d){return De(s,d)},loadingTemplate:e.loadingTemplate,itemSize:e.itemSize,rows:It(),columns:zt(),vertical:_,horizontal:R,both:m};return F.getJSXElement(e.contentTemplate,u)}return a};if(e.disabled){var Mt=F.getJSXElement(e.contentTemplate,{items:e.items,rows:e.items,columns:e.columns});return f.createElement(f.Fragment,null,e.children,Mt)}var At=oe("p-virtualscroller",{"p-virtualscroller-inline":e.inline,"p-virtualscroller-both p-both-scroll":m,"p-virtualscroller-horizontal p-horizontal-scroll":R},e.className),Wt=jt(),$t=Ht(),Bt=Ft(),Dt=c({ref:h,className:At,tabIndex:e.tabIndex,style:e.style,onScroll:function(t){return Et(t)}},se.getOtherProps(e),X("root"));return f.createElement("div",Dt,$t,Bt,Wt)}));er.displayName="VirtualScroller";export{er as a};
