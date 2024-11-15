import{a as le}from"./chunk-QLU5VSCI.js";import{a as Be,b as He}from"./chunk-UC2NT545.js";import{a as Me}from"./chunk-TKETXIRB.js";import{a as Ne,b as ke}from"./chunk-SNL2ZE3B.js";import{b as Oe,d as ie}from"./chunk-3ZYJDGDK.js";import{a as We}from"./chunk-2RGZXOVO.js";import{a as se}from"./chunk-LX5LFF4Z.js";import{b as Ie}from"./chunk-LVBOJNA3.js";import{a as q}from"./chunk-GOCSXDI2.js";import{a as pe}from"./chunk-2YBCIER7.js";import{a as ve,b as Ce,e as Ee,f as ze,v as ae,w as Fe,y as Ae}from"./chunk-5XWBU6XQ.js";import{a as ne}from"./chunk-SORH75JF.js";import{a as Se}from"./chunk-G37S2DMD.js";import{a as we}from"./chunk-2W22VGCX.js";import{a as r,b as g,d as $,h as K}from"./chunk-GYULANB4.js";var a=K(we());var f=K(we());var H=K(Se());function G(o){return parseInt(o,10)||0}var eo={shadow:{visibility:"hidden",position:"absolute",overflow:"hidden",height:0,top:0,left:0,transform:"translateZ(0)"}};function oo(o){return o==null||Object.keys(o).length===0||o.outerHeightStyle===0&&!o.overflowing}var to=f.forwardRef(function(e,t){let j=e,{onChange:l,maxRows:m,minRows:u=1,style:z,value:O}=j,W=$(j,["onChange","maxRows","minRows","style","value"]),{current:v}=f.useRef(O!=null),T=f.useRef(null),I=Ie(t,T),b=f.useRef(null),C=f.useRef(null),w=f.useCallback(()=>{let p=T.current,c=ie(p).getComputedStyle(p);if(c.width==="0px")return{outerHeightStyle:0,overflowing:!1};let d=C.current;d.style.width=c.width,d.value=p.value||e.placeholder||"x",d.value.slice(-1)===`
`&&(d.value+=" ");let F=c.boxSizing,A=G(c.paddingBottom)+G(c.paddingTop),P=G(c.borderBottomWidth)+G(c.borderTopWidth),_=d.scrollHeight;d.value="x";let R=d.scrollHeight,y=_;u&&(y=Math.max(Number(u)*R,y)),m&&(y=Math.min(Number(m)*R,y)),y=Math.max(y,R);let D=y+(F==="border-box"?A+P:0),L=Math.abs(y-_)<=1;return{outerHeightStyle:D,overflowing:L}},[m,u,e.placeholder]),S=f.useCallback(()=>{let p=w();if(oo(p))return;let s=p.outerHeightStyle,c=T.current;b.current!==s&&(b.current=s,c.style.height=`${s}px`),c.style.overflow=p.overflowing?"hidden":""},[w]);return se(()=>{let p=()=>{S()},s,c=()=>{cancelAnimationFrame(s),s=requestAnimationFrame(()=>{p()})},d=Oe(p),F=T.current,A=ie(F);A.addEventListener("resize",d);let P;return typeof ResizeObserver!="undefined"&&(P=new ResizeObserver(p),P.observe(F)),()=>{d.clear(),cancelAnimationFrame(s),A.removeEventListener("resize",d),P&&P.disconnect()}},[w,S]),se(()=>{S()}),(0,H.jsxs)(f.Fragment,{children:[(0,H.jsx)("textarea",r({value:O,onChange:p=>{v||S(),l&&l(p)},ref:I,rows:u,style:z},W)),(0,H.jsx)("textarea",{"aria-hidden":!0,className:e.className,readOnly:!0,ref:C,tabIndex:-1,style:g(r(r({},eo.shadow),z),{paddingTop:0,paddingBottom:0})})]})}),ue=to;function je(o){return Ee("MuiInputBase",o)}var ro=ze("MuiInputBase",["root","formControl","focused","disabled","adornedStart","adornedEnd","error","sizeSmall","multiline","colorSecondary","fullWidth","hiddenLabel","readOnly","input","inputSizeSmall","inputMultiline","inputTypeSearch","inputAdornedStart","inputAdornedEnd","inputHiddenLabel"]),M=ro;var E=K(Se());var _e,no=(o,e)=>{let{ownerState:t}=o;return[e.root,t.formControl&&e.formControl,t.startAdornment&&e.adornedStart,t.endAdornment&&e.adornedEnd,t.error&&e.error,t.size==="small"&&e.sizeSmall,t.multiline&&e.multiline,t.color&&e[`color${q(t.color)}`],t.fullWidth&&e.fullWidth,t.hiddenLabel&&e.hiddenLabel]},so=(o,e)=>{let{ownerState:t}=o;return[e.input,t.size==="small"&&e.inputSizeSmall,t.multiline&&e.inputMultiline,t.type==="search"&&e.inputTypeSearch,t.startAdornment&&e.inputAdornedStart,t.endAdornment&&e.inputAdornedEnd,t.hiddenLabel&&e.inputHiddenLabel]},io=o=>{let{classes:e,color:t,disabled:l,error:m,endAdornment:u,focused:z,formControl:O,fullWidth:W,hiddenLabel:v,multiline:T,readOnly:I,size:b,startAdornment:C,type:w}=o,S={root:["root",`color${q(t)}`,l&&"disabled",m&&"error",W&&"fullWidth",z&&"focused",O&&"formControl",b&&b!=="medium"&&`size${q(b)}`,T&&"multiline",C&&"adornedStart",u&&"adornedEnd",v&&"hiddenLabel",I&&"readOnly"],input:["input",l&&"disabled",w==="search"&&"inputTypeSearch",T&&"inputMultiline",b==="small"&&"inputSizeSmall",v&&"inputHiddenLabel",C&&"inputAdornedStart",u&&"inputAdornedEnd",I&&"readOnly"]};return ve(S,je,e)},ao=ae("div",{name:"MuiInputBase",slot:"Root",overridesResolver:no})(pe(({theme:o})=>g(r({},o.typography.body1),{color:(o.vars||o).palette.text.primary,lineHeight:"1.4375em",boxSizing:"border-box",position:"relative",cursor:"text",display:"inline-flex",alignItems:"center",[`&.${M.disabled}`]:{color:(o.vars||o).palette.text.disabled,cursor:"default"},variants:[{props:({ownerState:e})=>e.multiline,style:{padding:"4px 0 5px"}},{props:({ownerState:e,size:t})=>e.multiline&&t==="small",style:{paddingTop:1}},{props:({ownerState:e})=>e.fullWidth,style:{width:"100%"}}]}))),po=ae("input",{name:"MuiInputBase",slot:"Input",overridesResolver:so})(pe(({theme:o})=>{let e=o.palette.mode==="light",t=g(r({color:"currentColor"},o.vars?{opacity:o.vars.opacity.inputPlaceholder}:{opacity:e?.42:.5}),{transition:o.transitions.create("opacity",{duration:o.transitions.duration.shorter})}),l={opacity:"0 !important"},m=o.vars?{opacity:o.vars.opacity.inputPlaceholder}:{opacity:e?.42:.5};return{font:"inherit",letterSpacing:"inherit",color:"currentColor",padding:"4px 0 5px",border:0,boxSizing:"content-box",background:"none",height:"1.4375em",margin:0,WebkitTapHighlightColor:"transparent",display:"block",minWidth:0,width:"100%","&::-webkit-input-placeholder":t,"&::-moz-placeholder":t,"&::-ms-input-placeholder":t,"&:focus":{outline:0},"&:invalid":{boxShadow:"none"},"&::-webkit-search-decoration":{WebkitAppearance:"none"},[`label[data-shrink=false] + .${M.formControl} &`]:{"&::-webkit-input-placeholder":l,"&::-moz-placeholder":l,"&::-ms-input-placeholder":l,"&:focus::-webkit-input-placeholder":m,"&:focus::-moz-placeholder":m,"&:focus::-ms-input-placeholder":m},[`&.${M.disabled}`]:{opacity:1,WebkitTextFillColor:(o.vars||o).palette.text.disabled},variants:[{props:({ownerState:u})=>!u.disableInjectingGlobalStyles,style:{animationName:"mui-auto-fill-cancel",animationDuration:"10ms","&:-webkit-autofill":{animationDuration:"5000s",animationName:"mui-auto-fill"}}},{props:{size:"small"},style:{paddingTop:1}},{props:({ownerState:u})=>u.multiline,style:{height:"auto",resize:"none",padding:0,paddingTop:0}},{props:{type:"search"},style:{MozAppearance:"textfield"}}]}})),De=Fe({"@keyframes mui-auto-fill":{from:{display:"block"}},"@keyframes mui-auto-fill-cancel":{from:{display:"block"}}}),lo=a.forwardRef(function(e,t){var Pe;let l=Ae({props:e,name:"MuiInputBase"}),ge=l,{"aria-describedby":m,autoComplete:u,autoFocus:z,className:O,color:W,components:v={},componentsProps:T={},defaultValue:I,disabled:b,disableInjectingGlobalStyles:C,endAdornment:w,error:S,fullWidth:ce=!1,id:j,inputComponent:p="input",inputProps:s={},inputRef:c,margin:d,maxRows:F,minRows:A,multiline:P=!1,name:_,onBlur:R,onChange:y,onClick:D,onFocus:L,onKeyDown:Le,onKeyUp:Ue,placeholder:Ve,readOnly:Y,renderSuffix:de,rows:U,size:co,slotProps:fe={},slots:me={},startAdornment:k,type:ye="text",value:$e}=ge,Ke=$(ge,["aria-describedby","autoComplete","autoFocus","className","color","components","componentsProps","defaultValue","disabled","disableInjectingGlobalStyles","endAdornment","error","fullWidth","id","inputComponent","inputProps","inputRef","margin","maxRows","minRows","multiline","name","onBlur","onChange","onClick","onFocus","onKeyDown","onKeyUp","placeholder","readOnly","renderSuffix","rows","size","slotProps","slots","startAdornment","type","value"]),V=s.value!=null?s.value:$e,{current:Z}=a.useRef(V!=null),N=a.useRef(),qe=a.useCallback(n=>{},[]),Ge=We(N,c,s.ref,qe),[J,Q]=a.useState(!1),i=ke(),h=Be({props:l,muiFormControl:i,states:["color","disabled","error","hiddenLabel","size","required","filled"]});h.focused=i?i.focused:J,a.useEffect(()=>{!i&&b&&J&&(Q(!1),R&&R())},[i,b,J,R]);let X=i&&i.onFilled,ee=i&&i.onEmpty,B=a.useCallback(n=>{He(n)?X&&X():ee&&ee()},[X,ee]);Me(()=>{Z&&B({value:V})},[V,B,Z]);let Ye=n=>{L&&L(n),s.onFocus&&s.onFocus(n),i&&i.onFocus?i.onFocus(n):Q(!0)},Ze=n=>{R&&R(n),s.onBlur&&s.onBlur(n),i&&i.onBlur?i.onBlur(n):Q(!1)},Je=(n,...Re)=>{if(!Z){let xe=n.target||N.current;if(xe==null)throw new Error(Ce(1));B({value:xe.value})}s.onChange&&s.onChange(n,...Re),y&&y(n,...Re)};a.useEffect(()=>{B(N.current)},[]);let Qe=n=>{N.current&&n.currentTarget===n.target&&N.current.focus(),D&&D(n)},oe=p,x=s;P&&oe==="input"&&(U?x=r({type:void 0,minRows:U,maxRows:U},x):x=r({type:void 0,maxRows:F,minRows:A},x),oe=ue);let Xe=n=>{B(n.animationName==="mui-auto-fill-cancel"?N.current:{value:"x"})};a.useEffect(()=>{i&&i.setAdornedStart(!!k)},[i,k]);let te=g(r({},l),{color:h.color||"primary",disabled:h.disabled,endAdornment:w,error:h.error,focused:h.focused,formControl:i,fullWidth:ce,hiddenLabel:h.hiddenLabel,multiline:P,size:h.size,startAdornment:k,type:ye}),he=io(te),Te=me.root||v.Root||ao,re=fe.root||T.root||{},be=me.input||v.Input||po;return x=r(r({},x),(Pe=fe.input)!=null?Pe:T.input),(0,E.jsxs)(a.Fragment,{children:[!C&&typeof De=="function"&&(_e||(_e=(0,E.jsx)(De,{}))),(0,E.jsxs)(Te,g(r(r(g(r({},re),{ref:t,onClick:Qe}),Ke),!le(Te)&&{ownerState:r(r({},te),re.ownerState)}),{className:ne(he.root,re.className,O,Y&&"MuiInputBase-readOnly"),children:[k,(0,E.jsx)(Ne.Provider,{value:null,children:(0,E.jsx)(be,g(r(r({"aria-invalid":h.error,"aria-describedby":m,autoComplete:u,autoFocus:z,defaultValue:I,disabled:h.disabled,id:j,onAnimationStart:Xe,name:_,placeholder:Ve,readOnly:Y,required:h.required,rows:U,value:V,onKeyDown:Le,onKeyUp:Ue,type:ye},x),!le(be)&&{as:oe,ownerState:r(r({},te),x.ownerState)}),{ref:Ge,className:ne(he.input,x.className,Y&&"MuiInputBase-readOnly"),onBlur:Ze,onChange:Je,onFocus:Ye}))}),w,de?de(g(r({},h),{startAdornment:k})):null]}))]})}),uo=lo;export{M as a,no as b,so as c,ao as d,po as e,uo as f};
