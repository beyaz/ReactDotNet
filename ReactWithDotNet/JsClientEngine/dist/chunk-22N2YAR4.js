import{a as O}from"./chunk-2YBCIER7.js";import{a as b,e as g,f as x,j as l,p as v,s as w,v as C,y as $}from"./chunk-5XWBU6XQ.js";import{a as h}from"./chunk-SORH75JF.js";import{a as k}from"./chunk-G37S2DMD.js";import{a as M}from"./chunk-2W22VGCX.js";import{a as t,b as p,d as P,h as T}from"./chunk-GYULANB4.js";var j=T(M());function R(e){return g("MuiPaper",e)}var A=x("MuiPaper",["root","rounded","outlined","elevation","elevation0","elevation1","elevation2","elevation3","elevation4","elevation5","elevation6","elevation7","elevation8","elevation9","elevation10","elevation11","elevation12","elevation13","elevation14","elevation15","elevation16","elevation17","elevation18","elevation19","elevation20","elevation21","elevation22","elevation23","elevation24"]);var N=T(k());var q=e=>{let{square:o,elevation:r,variant:n,classes:a}=e,i={root:["root",n,!o&&"rounded",n==="elevation"&&`elevation${r}`]};return b(i,R,a)},S=C("div",{name:"MuiPaper",slot:"Root",overridesResolver:(e,o)=>{let{ownerState:r}=e;return[o.root,o[r.variant],!r.square&&o.rounded,r.variant==="elevation"&&o[`elevation${r.elevation}`]]}})(O(({theme:e})=>({backgroundColor:(e.vars||e).palette.background.paper,color:(e.vars||e).palette.text.primary,transition:e.transitions.create("box-shadow"),variants:[{props:({ownerState:o})=>!o.square,style:{borderRadius:e.shape.borderRadius}},{props:{variant:"outlined"},style:{border:`1px solid ${(e.vars||e).palette.divider}`}},{props:{variant:"elevation"},style:{boxShadow:"var(--Paper-shadow)",backgroundImage:"var(--Paper-overlay)"}}]}))),D=j.forwardRef(function(o,r){var y;let n=$({props:o,name:"MuiPaper"}),a=w(),u=n,{className:i,component:d="div",elevation:s=1,square:U=!1,variant:f="elevation"}=u,c=P(u,["className","component","elevation","square","variant"]),m=p(t({},n),{component:d,elevation:s,square:U,variant:f}),E=q(m);return(0,N.jsx)(S,p(t({as:d,ownerState:m,className:h(E.root,i),ref:r},c),{style:t(t({},f==="elevation"&&t(t({"--Paper-shadow":(a.vars||a).shadows[s]},a.vars&&{"--Paper-overlay":(y=a.vars.overlays)==null?void 0:y[s]}),!a.vars&&a.palette.mode==="dark"&&{"--Paper-overlay":`linear-gradient(${l("#fff",v(s))}, ${l("#fff",v(s))})`})),c.style)}))}),I=D;export{I as a};
