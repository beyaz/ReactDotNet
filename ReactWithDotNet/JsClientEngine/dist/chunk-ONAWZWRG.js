import{a as I}from"./chunk-MVVKVSJG.js";import{a as f}from"./chunk-T5JEUZ75.js";import{a as t}from"./chunk-GOCSXDI2.js";import{a as u}from"./chunk-2YBCIER7.js";import{a as B,e as R,f as h,j as d,v as z,y as C}from"./chunk-5XWBU6XQ.js";import{a as P}from"./chunk-SORH75JF.js";import{a as M}from"./chunk-G37S2DMD.js";import{a as E}from"./chunk-2W22VGCX.js";import{a as l,b as c,d as v,h as b}from"./chunk-GYULANB4.js";var n=b(E());function x(o){return R("MuiIconButton",o)}var U=h("MuiIconButton",["root","disabled","colorInherit","colorPrimary","colorSecondary","colorError","colorInfo","colorSuccess","colorWarning","edgeStart","edgeEnd","sizeSmall","sizeMedium","sizeLarge"]),O=U;var S=b(M());var N=o=>{let{classes:e,disabled:r,color:s,edge:a,size:i}=o,p={root:["root",r&&"disabled",s!=="default"&&`color${t(s)}`,a&&`edge${t(a)}`,`size${t(i)}`]};return B(p,x,e)},F=z(I,{name:"MuiIconButton",slot:"Root",overridesResolver:(o,e)=>{let{ownerState:r}=o;return[e.root,r.color!=="default"&&e[`color${t(r.color)}`],r.edge&&e[`edge${t(r.edge)}`],e[`size${t(r.size)}`]]}})(u(({theme:o})=>({textAlign:"center",flex:"0 0 auto",fontSize:o.typography.pxToRem(24),padding:8,borderRadius:"50%",color:(o.vars||o).palette.action.active,transition:o.transitions.create("background-color",{duration:o.transitions.duration.shortest}),variants:[{props:e=>!e.disableRipple,style:{"--IconButton-hoverBg":o.vars?`rgba(${o.vars.palette.action.activeChannel} / ${o.vars.palette.action.hoverOpacity})`:d(o.palette.action.active,o.palette.action.hoverOpacity),"&:hover":{backgroundColor:"var(--IconButton-hoverBg)","@media (hover: none)":{backgroundColor:"transparent"}}}},{props:{edge:"start"},style:{marginLeft:-12}},{props:{edge:"start",size:"small"},style:{marginLeft:-3}},{props:{edge:"end"},style:{marginRight:-12}},{props:{edge:"end",size:"small"},style:{marginRight:-3}}]})),u(({theme:o})=>({variants:[{props:{color:"inherit"},style:{color:"inherit"}},...Object.entries(o.palette).filter(f()).map(([e])=>({props:{color:e},style:{color:(o.vars||o).palette[e].main}})),...Object.entries(o.palette).filter(f()).map(([e])=>({props:{color:e},style:{"--IconButton-hoverBg":o.vars?`rgba(${(o.vars||o).palette[e].mainChannel} / ${o.vars.palette.action.hoverOpacity})`:d((o.vars||o).palette[e].main,o.palette.action.hoverOpacity)}})),{props:{size:"small"},style:{padding:5,fontSize:o.typography.pxToRem(18)}},{props:{size:"large"},style:{padding:12,fontSize:o.typography.pxToRem(28)}}],[`&.${O.disabled}`]:{backgroundColor:"transparent",color:(o.vars||o).palette.action.disabled}}))),L=n.forwardRef(function(e,r){let s=C({props:e,name:"MuiIconButton"}),T=s,{edge:a=!1,children:i,className:p,color:$="default",disabled:y=!1,disableFocusRipple:g=!1,size:j="medium"}=T,w=v(T,["edge","children","className","color","disabled","disableFocusRipple","size"]),m=c(l({},s),{edge:a,color:$,disabled:y,disableFocusRipple:g,size:j}),k=N(m);return(0,S.jsx)(F,c(l({className:P(k.root,p),centerRipple:!0,focusRipple:!g,disabled:y,ref:r},w),{ownerState:m,children:i}))}),V=L;export{V as a};
