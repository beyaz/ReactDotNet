import{a as v}from"./chunk-E5HSOGJD.js";import{a as k}from"./chunk-6OM2ZAQE.js";import{a as B,e as U,f as V,s as _,v as D}from"./chunk-HI6IROIK.js";import{a as A}from"./chunk-SORH75JF.js";import{a as M}from"./chunk-G37S2DMD.js";import{a as $}from"./chunk-2W22VGCX.js";import{a as l,b as g,d as E,h as z}from"./chunk-GYULANB4.js";var b=z($());var I=z($());function F(o){return U("MuiSvgIcon",o)}var Q=V("MuiSvgIcon",["root","colorPrimary","colorSecondary","colorAction","colorError","colorDisabled","fontSizeInherit","fontSizeSmall","fontSizeMedium","fontSizeLarge"]);var C=z(M());var q=o=>{let{color:e,fontSize:r,classes:s}=o,t={root:["root",e!=="inherit"&&`color${v(e)}`,`fontSize${v(r)}`]};return B(t,F,s)},G=_("svg",{name:"MuiSvgIcon",slot:"Root",overridesResolver:(o,e)=>{let{ownerState:r}=o;return[e.root,r.color!=="inherit"&&e[`color${v(r.color)}`],e[`fontSize${v(r.fontSize)}`]]}})(k(({theme:o})=>{var e,r,s,t,T,a,m,c,P,i,n,y,x,f,d,u,h,S;return{userSelect:"none",width:"1em",height:"1em",display:"inline-block",flexShrink:0,transition:(T=(e=o.transitions)==null?void 0:e.create)==null?void 0:T.call(e,"fill",{duration:(t=(s=((r=o.vars)!=null?r:o).transitions)==null?void 0:s.duration)==null?void 0:t.shorter}),variants:[{props:p=>!p.hasSvgAsChild,style:{fill:"currentColor"}},{props:{fontSize:"inherit"},style:{fontSize:"inherit"}},{props:{fontSize:"small"},style:{fontSize:((m=(a=o.typography)==null?void 0:a.pxToRem)==null?void 0:m.call(a,20))||"1.25rem"}},{props:{fontSize:"medium"},style:{fontSize:((P=(c=o.typography)==null?void 0:c.pxToRem)==null?void 0:P.call(c,24))||"1.5rem"}},{props:{fontSize:"large"},style:{fontSize:((n=(i=o.typography)==null?void 0:i.pxToRem)==null?void 0:n.call(i,35))||"2.1875rem"}},...Object.entries(((y=o.vars)!=null?y:o).palette).filter(([,p])=>p&&p.main).map(([p])=>{var N,j,O;return{props:{color:p},style:{color:(O=(j=((N=o.vars)!=null?N:o).palette)==null?void 0:j[p])==null?void 0:O.main}}}),{props:{color:"action"},style:{color:(d=(f=((x=o.vars)!=null?x:o).palette)==null?void 0:f.action)==null?void 0:d.active}},{props:{color:"disabled"},style:{color:(S=(h=((u=o.vars)!=null?u:o).palette)==null?void 0:h.action)==null?void 0:S.disabled}},{props:{color:"inherit"},style:{color:void 0}}]}})),w=I.forwardRef(function(e,r){let s=D({props:e,name:"MuiSvgIcon"}),S=s,{children:t,className:T,color:a="inherit",component:m="svg",fontSize:c="medium",htmlColor:P,inheritViewBox:i=!1,titleAccess:n,viewBox:y="0 0 24 24"}=S,x=E(S,["children","className","color","component","fontSize","htmlColor","inheritViewBox","titleAccess","viewBox"]),f=I.isValidElement(t)&&t.type==="svg",d=g(l({},s),{color:a,component:m,fontSize:c,instanceFontSize:e.fontSize,inheritViewBox:i,viewBox:y,hasSvgAsChild:f}),u={};i||(u.viewBox=y);let h=q(d);return(0,C.jsxs)(G,g(l(l(l({as:m,className:A(h.root,T),focusable:"false",color:P,"aria-hidden":n?void 0:!0,role:n?"img":void 0,ref:r},u),x),f&&t.props),{ownerState:d,children:[f?t.props.children:t,n?(0,C.jsx)("title",{children:n}):null]}))});w&&(w.muiName="SvgIcon");var R=w;var L=z(M());function H(o,e){function r(s,t){return(0,L.jsx)(R,g(l({"data-testid":`${e}Icon`,ref:t},s),{children:o}))}return r.muiName=R.muiName,b.memo(b.forwardRef(r))}export{H as a};
