import{f as b}from"./chunk-GYULANB4.js";var a=b(t=>{"use strict";var d=Symbol.for("react.element"),S=Symbol.for("react.portal"),o=Symbol.for("react.fragment"),n=Symbol.for("react.strict_mode"),c=Symbol.for("react.profiler"),s=Symbol.for("react.provider"),f=Symbol.for("react.context"),x=Symbol.for("react.server_context"),u=Symbol.for("react.forward_ref"),i=Symbol.for("react.suspense"),l=Symbol.for("react.suspense_list"),y=Symbol.for("react.memo"),m=Symbol.for("react.lazy"),C=Symbol.for("react.offscreen"),$;$=Symbol.for("react.module.reference");function r(e){if(typeof e=="object"&&e!==null){var p=e.$$typeof;switch(p){case d:switch(e=e.type,e){case o:case c:case n:case i:case l:return e;default:switch(e=e&&e.$$typeof,e){case x:case f:case u:case m:case y:case s:return e;default:return p}}case S:return p}}}t.ContextConsumer=f;t.ContextProvider=s;t.Element=d;t.ForwardRef=u;t.Fragment=o;t.Lazy=m;t.Memo=y;t.Portal=S;t.Profiler=c;t.StrictMode=n;t.Suspense=i;t.SuspenseList=l;t.isAsyncMode=function(){return!1};t.isConcurrentMode=function(){return!1};t.isContextConsumer=function(e){return r(e)===f};t.isContextProvider=function(e){return r(e)===s};t.isElement=function(e){return typeof e=="object"&&e!==null&&e.$$typeof===d};t.isForwardRef=function(e){return r(e)===u};t.isFragment=function(e){return r(e)===o};t.isLazy=function(e){return r(e)===m};t.isMemo=function(e){return r(e)===y};t.isPortal=function(e){return r(e)===S};t.isProfiler=function(e){return r(e)===c};t.isStrictMode=function(e){return r(e)===n};t.isSuspense=function(e){return r(e)===i};t.isSuspenseList=function(e){return r(e)===l};t.isValidElementType=function(e){return typeof e=="string"||typeof e=="function"||e===o||e===c||e===n||e===i||e===l||e===C||typeof e=="object"&&e!==null&&(e.$$typeof===m||e.$$typeof===y||e.$$typeof===s||e.$$typeof===f||e.$$typeof===u||e.$$typeof===$||e.getModuleId!==void 0)};t.typeOf=r});var M=b((w,v)=>{"use strict";v.exports=a()});export{M as a};
/*! Bundled license information:

react-is/cjs/react-is.production.min.js:
  (**
   * @license React
   * react-is.production.min.js
   *
   * Copyright (c) Facebook, Inc. and its affiliates.
   *
   * This source code is licensed under the MIT license found in the
   * LICENSE file in the root directory of this source tree.
   *)
*/
