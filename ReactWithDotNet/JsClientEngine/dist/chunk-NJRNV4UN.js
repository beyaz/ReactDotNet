import{a as m}from"./chunk-WFGI6QUH.js";import{b as F,c as V}from"./chunk-UC2NT545.js";import{a as L}from"./chunk-SNL2ZE3B.js";import{a as h}from"./chunk-GOCSXDI2.js";import{a as w,e as A,f as z,v as _,y as q}from"./chunk-5XWBU6XQ.js";import{a as D}from"./chunk-SORH75JF.js";import{a as Y}from"./chunk-G37S2DMD.js";import{a as X}from"./chunk-2W22VGCX.js";import{a as n,b as C,d as U,h as B}from"./chunk-GYULANB4.js";var e=B(X());function $(r){return A("MuiFormControl",r)}var ie=z("MuiFormControl",["root","marginNone","marginNormal","marginDense","fullWidth","disabled"]);var b=B(Y());var Z=r=>{let{classes:t,margin:p,fullWidth:a}=r,s={root:["root",p!=="none"&&`margin${h(p)}`,a&&"fullWidth"]};return w(s,$,t)},ee=_("div",{name:"MuiFormControl",slot:"Root",overridesResolver:({ownerState:r},t)=>n(n(n({},t.root),t[`margin${h(r.margin)}`]),r.fullWidth&&t.fullWidth)})({display:"inline-flex",flexDirection:"column",position:"relative",minWidth:0,padding:0,margin:0,border:0,verticalAlign:"top",variants:[{props:{margin:"normal"},style:{marginTop:16,marginBottom:8}},{props:{margin:"dense"},style:{marginTop:8,marginBottom:4}},{props:{fullWidth:!0},style:{width:"100%"}}]}),oe=e.forwardRef(function(t,p){let a=q({props:t,name:"MuiFormControl"}),M=a,{children:s,className:k,color:f="primary",component:v="div",disabled:i=!1,error:u=!1,focused:x,fullWidth:c=!1,hiddenLabel:d=!1,margin:G="none",required:y=!1,size:T="medium",variant:g="outlined"}=M,H=U(M,["children","className","color","component","disabled","error","focused","fullWidth","hiddenLabel","margin","required","size","variant"]),R=C(n({},a),{color:f,component:v,disabled:i,error:u,fullWidth:c,hiddenLabel:d,margin:G,required:y,size:T,variant:g}),J=Z(R),[S,K]=e.useState(()=>{let l=!1;return s&&e.Children.forEach(s,o=>{if(!m(o,["Input","Select"]))return;let j=m(o,["Select"])?o.props.input:o;j&&V(j.props)&&(l=!0)}),l}),[O,E]=e.useState(()=>{let l=!1;return s&&e.Children.forEach(s,o=>{m(o,["Input","Select"])&&(F(o.props,!0)||F(o.props.inputProps,!0))&&(l=!0)}),l}),[I,P]=e.useState(!1);i&&I&&P(!1);let N=x!==void 0&&!i?x:I,W,te=e.useRef(!1),Q=e.useMemo(()=>({adornedStart:S,setAdornedStart:K,color:f,disabled:i,error:u,filled:O,focused:N,fullWidth:c,hiddenLabel:d,size:T,onBlur:()=>{P(!1)},onEmpty:()=>{E(!1)},onFilled:()=>{E(!0)},onFocus:()=>{P(!0)},registerEffect:W,required:y,variant:g}),[S,f,i,u,O,N,c,d,W,y,T,g]);return(0,b.jsx)(L.Provider,{value:Q,children:(0,b.jsx)(ee,C(n({as:v,ownerState:R,className:D(J.root,k),ref:p},H),{children:s}))})}),re=oe;export{re as a};
