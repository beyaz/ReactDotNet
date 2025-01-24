import{a as g,c as C,d as q}from"./chunk-FXFK3YHI.js";import{a as J}from"./chunk-DLL45UCJ.js";import{a as R}from"./chunk-SI5MANRI.js";import{a as _}from"./chunk-2W22VGCX.js";import{h as x}from"./chunk-GYULANB4.js";var P=x(_()),b=x(J());var L={disabled:!1};var X=x(_()),T=X.default.createContext(null);var D=function(s){return s.scrollTop};var S="unmounted",h="exited",E="entering",y="entered",k="exiting",m=function(i){C(s,i);function s(t,n){var e;e=i.call(this,t,n)||this;var r=n,o=r&&!r.isMounting?t.enter:t.appear,a;return e.appearStatus=null,t.in?o?(a=h,e.appearStatus=E):a=y:t.unmountOnExit||t.mountOnEnter?a=S:a=h,e.state={status:a},e.nextCallback=null,e}s.getDerivedStateFromProps=function(n,e){var r=n.in;return r&&e.status===S?{status:h}:null};var p=s.prototype;return p.componentDidMount=function(){this.updateStatus(!0,this.appearStatus)},p.componentDidUpdate=function(n){var e=null;if(n!==this.props){var r=this.state.status;this.props.in?r!==E&&r!==y&&(e=E):(r===E||r===y)&&(e=k)}this.updateStatus(!1,e)},p.componentWillUnmount=function(){this.cancelNextCallback()},p.getTimeouts=function(){var n=this.props.timeout,e,r,o;return e=r=o=n,n!=null&&typeof n!="number"&&(e=n.exit,r=n.enter,o=n.appear!==void 0?n.appear:r),{exit:e,enter:r,appear:o}},p.updateStatus=function(n,e){if(n===void 0&&(n=!1),e!==null)if(this.cancelNextCallback(),e===E){if(this.props.unmountOnExit||this.props.mountOnEnter){var r=this.props.nodeRef?this.props.nodeRef.current:b.default.findDOMNode(this);r&&D(r)}this.performEnter(n)}else this.performExit();else this.props.unmountOnExit&&this.state.status===h&&this.setState({status:S})},p.performEnter=function(n){var e=this,r=this.props.enter,o=this.context?this.context.isMounting:n,a=this.props.nodeRef?[o]:[b.default.findDOMNode(this),o],l=a[0],u=a[1],f=this.getTimeouts(),d=o?f.appear:f.enter;if(!n&&!r||L.disabled){this.safeSetState({status:y},function(){e.props.onEntered(l)});return}this.props.onEnter(l,u),this.safeSetState({status:E},function(){e.props.onEntering(l,u),e.onTransitionEnd(d,function(){e.safeSetState({status:y},function(){e.props.onEntered(l,u)})})})},p.performExit=function(){var n=this,e=this.props.exit,r=this.getTimeouts(),o=this.props.nodeRef?void 0:b.default.findDOMNode(this);if(!e||L.disabled){this.safeSetState({status:h},function(){n.props.onExited(o)});return}this.props.onExit(o),this.safeSetState({status:k},function(){n.props.onExiting(o),n.onTransitionEnd(r.exit,function(){n.safeSetState({status:h},function(){n.props.onExited(o)})})})},p.cancelNextCallback=function(){this.nextCallback!==null&&(this.nextCallback.cancel(),this.nextCallback=null)},p.safeSetState=function(n,e){e=this.setNextCallback(e),this.setState(n,e)},p.setNextCallback=function(n){var e=this,r=!0;return this.nextCallback=function(o){r&&(r=!1,e.nextCallback=null,n(o))},this.nextCallback.cancel=function(){r=!1},this.nextCallback},p.onTransitionEnd=function(n,e){this.setNextCallback(e);var r=this.props.nodeRef?this.props.nodeRef.current:b.default.findDOMNode(this),o=n==null&&!this.props.addEndListener;if(!r||o){setTimeout(this.nextCallback,0);return}if(this.props.addEndListener){var a=this.props.nodeRef?[this.nextCallback]:[r,this.nextCallback],l=a[0],u=a[1];this.props.addEndListener(l,u)}n!=null&&setTimeout(this.nextCallback,n)},p.render=function(){var n=this.state.status;if(n===S)return null;var e=this.props,r=e.children,o=e.in,a=e.mountOnEnter,l=e.unmountOnExit,u=e.appear,f=e.enter,d=e.exit,j=e.timeout,ne=e.addEndListener,re=e.onEnter,oe=e.onEntering,ie=e.onEntered,se=e.onExit,ae=e.onExiting,pe=e.onExited,le=e.nodeRef,W=g(e,["children","in","mountOnEnter","unmountOnExit","appear","enter","exit","timeout","addEndListener","onEnter","onEntering","onEntered","onExit","onExiting","onExited","nodeRef"]);return P.default.createElement(T.Provider,{value:null},typeof r=="function"?r(n,W):P.default.cloneElement(P.default.Children.only(r),W))},s}(P.default.Component);m.contextType=T;m.propTypes={};function N(){}m.defaultProps={in:!1,mountOnEnter:!1,unmountOnExit:!1,appear:!1,enter:!0,exit:!0,onEnter:N,onEntering:N,onEntered:N,onExit:N,onExiting:N,onExited:N};m.UNMOUNTED=S;m.EXITED=h;m.ENTERING=E;m.ENTERED=y;m.EXITING=k;var A=m;function V(i,s){return i.classList?!!s&&i.classList.contains(s):(" "+(i.className.baseVal||i.className)+" ").indexOf(" "+s+" ")!==-1}function F(i,s){i.classList?i.classList.add(s):V(i,s)||(typeof i.className=="string"?i.className=i.className+" "+s:i.setAttribute("class",(i.className&&i.className.baseVal||"")+" "+s))}function z(i,s){return i.replace(new RegExp("(^|\\s)"+s+"(?:\\s|$)","g"),"$1").replace(/\s+/g," ").replace(/^\s*|\s*$/g,"")}function I(i,s){i.classList?i.classList.remove(s):typeof i.className=="string"?i.className=z(i.className,s):i.setAttribute("class",z(i.className&&i.className.baseVal||"",s))}var $=x(_());var Q=function(s,p){return s&&p&&p.split(" ").forEach(function(t){return F(s,t)})},w=function(s,p){return s&&p&&p.split(" ").forEach(function(t){return I(s,t)})},G=function(i){C(s,i);function s(){for(var t,n=arguments.length,e=new Array(n),r=0;r<n;r++)e[r]=arguments[r];return t=i.call.apply(i,[this].concat(e))||this,t.appliedClasses={appear:{},enter:{},exit:{}},t.onEnter=function(o,a){var l=t.resolveArguments(o,a),u=l[0],f=l[1];t.removeClasses(u,"exit"),t.addClass(u,f?"appear":"enter","base"),t.props.onEnter&&t.props.onEnter(o,a)},t.onEntering=function(o,a){var l=t.resolveArguments(o,a),u=l[0],f=l[1],d=f?"appear":"enter";t.addClass(u,d,"active"),t.props.onEntering&&t.props.onEntering(o,a)},t.onEntered=function(o,a){var l=t.resolveArguments(o,a),u=l[0],f=l[1],d=f?"appear":"enter";t.removeClasses(u,d),t.addClass(u,d,"done"),t.props.onEntered&&t.props.onEntered(o,a)},t.onExit=function(o){var a=t.resolveArguments(o),l=a[0];t.removeClasses(l,"appear"),t.removeClasses(l,"enter"),t.addClass(l,"exit","base"),t.props.onExit&&t.props.onExit(o)},t.onExiting=function(o){var a=t.resolveArguments(o),l=a[0];t.addClass(l,"exit","active"),t.props.onExiting&&t.props.onExiting(o)},t.onExited=function(o){var a=t.resolveArguments(o),l=a[0];t.removeClasses(l,"exit"),t.addClass(l,"exit","done"),t.props.onExited&&t.props.onExited(o)},t.resolveArguments=function(o,a){return t.props.nodeRef?[t.props.nodeRef.current,o]:[o,a]},t.getClassNames=function(o){var a=t.props.classNames,l=typeof a=="string",u=l&&a?a+"-":"",f=l?""+u+o:a[o],d=l?f+"-active":a[o+"Active"],j=l?f+"-done":a[o+"Done"];return{baseClassName:f,activeClassName:d,doneClassName:j}},t}var p=s.prototype;return p.addClass=function(n,e,r){var o=this.getClassNames(e)[r+"ClassName"],a=this.getClassNames("enter"),l=a.doneClassName;e==="appear"&&r==="done"&&l&&(o+=" "+l),r==="active"&&n&&D(n),o&&(this.appliedClasses[e][r]=o,Q(n,o))},p.removeClasses=function(n,e){var r=this.appliedClasses[e],o=r.base,a=r.active,l=r.done;this.appliedClasses[e]={},o&&w(n,o),a&&w(n,a),l&&w(n,l)},p.render=function(){var n=this.props,e=n.classNames,r=g(n,["classNames"]);return $.default.createElement(A,R({},r,{onEnter:this.onEnter,onEntered:this.onEntered,onEntering:this.onEntering,onExit:this.onExit,onExiting:this.onExiting,onExited:this.onExited}))},s}($.default.Component);G.defaultProps={classNames:""};G.propTypes={};var Y=G;var O=x(_());var c=x(_());function M(i,s){var p=function(e){return s&&(0,c.isValidElement)(e)?s(e):e},t=Object.create(null);return i&&c.Children.map(i,function(n){return n}).forEach(function(n){t[n.key]=p(n)}),t}function Z(i,s){i=i||{},s=s||{};function p(u){return u in s?s[u]:i[u]}var t=Object.create(null),n=[];for(var e in i)e in s?n.length&&(t[e]=n,n=[]):n.push(e);var r,o={};for(var a in s){if(t[a])for(r=0;r<t[a].length;r++){var l=t[a][r];o[t[a][r]]=p(l)}o[a]=p(a)}for(r=0;r<n.length;r++)o[n[r]]=p(n[r]);return o}function v(i,s,p){return p[s]!=null?p[s]:i.props[s]}function H(i,s){return M(i.children,function(p){return(0,c.cloneElement)(p,{onExited:s.bind(null,p),in:!0,appear:v(p,"appear",i),enter:v(p,"enter",i),exit:v(p,"exit",i)})})}function B(i,s,p){var t=M(i.children),n=Z(s,t);return Object.keys(n).forEach(function(e){var r=n[e];if((0,c.isValidElement)(r)){var o=e in s,a=e in t,l=s[e],u=(0,c.isValidElement)(l)&&!l.props.in;a&&(!o||u)?n[e]=(0,c.cloneElement)(r,{onExited:p.bind(null,r),in:!0,exit:v(r,"exit",i),enter:v(r,"enter",i)}):!a&&o&&!u?n[e]=(0,c.cloneElement)(r,{in:!1}):a&&o&&(0,c.isValidElement)(l)&&(n[e]=(0,c.cloneElement)(r,{onExited:p.bind(null,r),in:l.props.in,exit:v(r,"exit",i),enter:v(r,"enter",i)}))}}),n}var K=Object.values||function(i){return Object.keys(i).map(function(s){return i[s]})},ee={component:"div",childFactory:function(s){return s}},U=function(i){C(s,i);function s(t,n){var e;e=i.call(this,t,n)||this;var r=e.handleExited.bind(q(e));return e.state={contextValue:{isMounting:!0},handleExited:r,firstRender:!0},e}var p=s.prototype;return p.componentDidMount=function(){this.mounted=!0,this.setState({contextValue:{isMounting:!1}})},p.componentWillUnmount=function(){this.mounted=!1},s.getDerivedStateFromProps=function(n,e){var r=e.children,o=e.handleExited,a=e.firstRender;return{children:a?H(n,o):B(n,r,o),firstRender:!1}},p.handleExited=function(n,e){var r=M(this.props.children);n.key in r||(n.props.onExited&&n.props.onExited(e),this.mounted&&this.setState(function(o){var a=R({},o.children);return delete a[n.key],{children:a}}))},p.render=function(){var n=this.props,e=n.component,r=n.childFactory,o=g(n,["component","childFactory"]),a=this.state.contextValue,l=K(this.state.children).map(r);return delete o.appear,delete o.enter,delete o.exit,e===null?O.default.createElement(T.Provider,{value:a},l):O.default.createElement(T.Provider,{value:a},O.default.createElement(e,o,l))},s}(O.default.Component);U.propTypes={};U.defaultProps=ee;var te=U;export{A as a,Y as b,te as c};
