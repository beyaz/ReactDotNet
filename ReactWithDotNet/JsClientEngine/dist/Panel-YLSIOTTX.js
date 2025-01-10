import {
  PlusIcon
} from "./chunk-Q6GPDLBV.js";
import {
  MinusIcon
} from "./chunk-QMKDTUKP.js";
import {
  CSSTransition
} from "./chunk-GBAKNBNU.js";
import {
  Ripple
} from "./chunk-56TI4EJO.js";
import "./chunk-2FIYIUK5.js";
import {
  ComponentBase,
  IconUtils,
  ObjectUtils,
  PrimeReactContext,
  UniqueComponentId,
  classNames,
  useHandleStyle,
  useMergeProps,
  useMountEffect
} from "./chunk-NBA33TRK.js";
import "./chunk-M4ZKUW6V.js";
import "./chunk-A6RS5VZJ.js";
import "./chunk-QNQS7X5M.js";
import "./chunk-SEPJ2F45.js";
import "./chunk-FLAFLVMN.js";
import "./chunk-IHPEMKKY.js";
import {
  require_react
} from "./chunk-XDFXK7K5.js";
import {
  __toESM
} from "./chunk-QRPWKJ4C.js";

// node_modules/primereact/panel/panel.esm.js
var React = __toESM(require_react());
function _extends() {
  return _extends = Object.assign ? Object.assign.bind() : function(n) {
    for (var e = 1; e < arguments.length; e++) {
      var t = arguments[e];
      for (var r in t) ({}).hasOwnProperty.call(t, r) && (n[r] = t[r]);
    }
    return n;
  }, _extends.apply(null, arguments);
}
function _arrayWithHoles(r) {
  if (Array.isArray(r)) return r;
}
function _iterableToArrayLimit(r, l) {
  var t = null == r ? null : "undefined" != typeof Symbol && r[Symbol.iterator] || r["@@iterator"];
  if (null != t) {
    var e, n, i, u, a = [], f = true, o = false;
    try {
      if (i = (t = t.call(r)).next, 0 === l) {
        if (Object(t) !== t) return;
        f = false;
      } else for (; !(f = (e = i.call(t)).done) && (a.push(e.value), a.length !== l); f = true) ;
    } catch (r2) {
      o = true, n = r2;
    } finally {
      try {
        if (!f && null != t["return"] && (u = t["return"](), Object(u) !== u)) return;
      } finally {
        if (o) throw n;
      }
    }
    return a;
  }
}
function _arrayLikeToArray(r, a) {
  (null == a || a > r.length) && (a = r.length);
  for (var e = 0, n = Array(a); e < a; e++) n[e] = r[e];
  return n;
}
function _unsupportedIterableToArray(r, a) {
  if (r) {
    if ("string" == typeof r) return _arrayLikeToArray(r, a);
    var t = {}.toString.call(r).slice(8, -1);
    return "Object" === t && r.constructor && (t = r.constructor.name), "Map" === t || "Set" === t ? Array.from(r) : "Arguments" === t || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t) ? _arrayLikeToArray(r, a) : void 0;
  }
}
function _nonIterableRest() {
  throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
}
function _slicedToArray(r, e) {
  return _arrayWithHoles(r) || _iterableToArrayLimit(r, e) || _unsupportedIterableToArray(r, e) || _nonIterableRest();
}
var PanelBase = ComponentBase.extend({
  defaultProps: {
    __TYPE: "Panel",
    id: null,
    header: null,
    headerTemplate: null,
    footer: null,
    footerTemplate: null,
    toggleable: null,
    style: null,
    className: null,
    collapsed: null,
    expandIcon: null,
    collapseIcon: null,
    icons: null,
    transitionOptions: null,
    onExpand: null,
    onCollapse: null,
    onToggle: null,
    children: void 0
  },
  css: {
    classes: {
      root: function root(_ref) {
        var props = _ref.props;
        return classNames("p-panel p-component", {
          "p-panel-toggleable": props.toggleable
        });
      },
      header: "p-panel-header",
      title: "p-panel-title",
      icons: "p-panel-icons",
      toggler: "p-panel-header-icon p-panel-toggler p-link",
      togglerIcon: "p-panel-header-icon p-panel-toggler p-link",
      toggleableContent: "p-toggleable-content",
      content: "p-panel-content",
      footer: "p-panel-footer",
      transition: "p-toggleable-content"
    },
    styles: "\n        @layer primereact {\n            .p-panel-header {\n              display: flex;\n              justify-content: space-between;\n              align-items: center;\n            }\n            \n            .p-panel-title {\n              line-height: 1;\n            }\n            \n            .p-panel-header-icon {\n              display: inline-flex;\n              justify-content: center;\n              align-items: center;\n              cursor: pointer;\n              text-decoration: none;\n              overflow: hidden;\n              position: relative;\n            }\n        }\n        "
  }
});
var Panel = /* @__PURE__ */ React.forwardRef(function(inProps, ref) {
  var mergeProps = useMergeProps();
  var context = React.useContext(PrimeReactContext);
  var props = PanelBase.getProps(inProps, context);
  var _React$useState = React.useState(props.id), _React$useState2 = _slicedToArray(_React$useState, 2), idState = _React$useState2[0], setIdState = _React$useState2[1];
  var _React$useState3 = React.useState(props.collapsed), _React$useState4 = _slicedToArray(_React$useState3, 2), collapsedState = _React$useState4[0], setCollapsedState = _React$useState4[1];
  var elementRef = React.useRef(null);
  var contentRef = React.useRef(null);
  var collapsed = props.toggleable ? props.onToggle ? props.collapsed : collapsedState : false;
  var headerId = idState + "_header";
  var contentId = idState + "_content";
  var _PanelBase$setMetaDat = PanelBase.setMetaData({
    props,
    state: {
      id: idState,
      collapsed
    }
  }), ptm = _PanelBase$setMetaDat.ptm, cx = _PanelBase$setMetaDat.cx, isUnstyled = _PanelBase$setMetaDat.isUnstyled;
  useHandleStyle(PanelBase.css.styles, isUnstyled, {
    name: "panel"
  });
  var toggle = function toggle2(event) {
    if (!props.toggleable) {
      return;
    }
    collapsed ? expand(event) : collapse(event);
    if (event) {
      if (props.onToggle) {
        props.onToggle({
          originalEvent: event,
          value: !collapsed
        });
      }
      event.preventDefault();
    }
  };
  var expand = function expand2(event) {
    if (!props.onToggle) {
      setCollapsedState(false);
    }
    props.onExpand && event && props.onExpand(event);
  };
  var collapse = function collapse2(event) {
    if (!props.onToggle) {
      setCollapsedState(true);
    }
    props.onCollapse && event && props.onCollapse(event);
  };
  React.useImperativeHandle(ref, function() {
    return {
      props,
      toggle,
      expand,
      collapse,
      getElement: function getElement() {
        return elementRef.current;
      },
      getContent: function getContent() {
        return contentRef.current;
      }
    };
  });
  useMountEffect(function() {
    if (!idState) {
      setIdState(UniqueComponentId());
    }
  });
  var createToggleIcon = function createToggleIcon2() {
    if (props.toggleable) {
      var buttonId = idState + "_label";
      var togglerProps = mergeProps({
        className: cx("toggler"),
        onClick: toggle,
        id: buttonId,
        "aria-controls": contentId,
        "aria-expanded": !collapsed,
        type: "button",
        role: "button",
        "aria-label": props.header
      }, ptm("toggler"));
      var togglerIconProps = mergeProps(ptm("togglericon"));
      var icon = collapsed ? props.expandIcon || /* @__PURE__ */ React.createElement(PlusIcon, togglerIconProps) : props.collapseIcon || /* @__PURE__ */ React.createElement(MinusIcon, togglerIconProps);
      var toggleIcon = IconUtils.getJSXIcon(icon, togglerIconProps, {
        props,
        collapsed
      });
      return /* @__PURE__ */ React.createElement("button", togglerProps, toggleIcon, /* @__PURE__ */ React.createElement(Ripple, null));
    }
    return null;
  };
  var createHeader = function createHeader2() {
    var header2 = ObjectUtils.getJSXElement(props.header, props);
    var icons = ObjectUtils.getJSXElement(props.icons, props);
    var togglerElement = createToggleIcon();
    var titleProps = mergeProps({
      id: headerId,
      className: cx("title")
    }, ptm("title"));
    var titleElement = /* @__PURE__ */ React.createElement("span", titleProps, header2);
    var iconsProps = mergeProps({
      className: cx("icons")
    }, ptm("icons"));
    var iconsElement = /* @__PURE__ */ React.createElement("div", iconsProps, icons, togglerElement);
    var headerProps = mergeProps({
      className: cx("header")
    }, ptm("header"));
    var content2 = /* @__PURE__ */ React.createElement("div", headerProps, titleElement, iconsElement);
    if (props.headerTemplate) {
      var defaultContentOptions = {
        className: "p-panel-header",
        titleClassName: "p-panel-title",
        iconsClassName: "p-panel-icons",
        togglerClassName: "p-panel-header-icon p-panel-toggler p-link",
        onTogglerClick: toggle,
        titleElement,
        iconsElement,
        togglerElement,
        element: content2,
        id: idState + "_header",
        props,
        collapsed
      };
      return ObjectUtils.getJSXElement(props.headerTemplate, defaultContentOptions);
    } else if (props.header || props.toggleable) {
      return content2;
    }
    return null;
  };
  var createFooter = function createFooter2() {
    var footer2 = ObjectUtils.getJSXElement(props.footer, props);
    var footerProps = mergeProps({
      className: cx("footer")
    }, ptm("footer"));
    var content2 = /* @__PURE__ */ React.createElement("div", footerProps, footer2);
    if (props.footerTemplate) {
      var defaultContentOptions = {
        className: cx("footer"),
        element: content2,
        props
      };
      return ObjectUtils.getJSXElement(props.footerTemplate, defaultContentOptions);
    } else if (props.footer) {
      return content2;
    }
    return null;
  };
  var createContent = function createContent2() {
    var toggleableContentProps = mergeProps({
      ref: contentRef,
      className: cx("toggleableContent"),
      "aria-hidden": collapsed,
      role: "region",
      id: contentId,
      "aria-labelledby": headerId
    }, ptm("toggleablecontent"));
    var contentProps = mergeProps({
      className: cx("content")
    }, ptm("content"));
    var transitionProps = mergeProps({
      classNames: cx("transition"),
      timeout: {
        enter: 1e3,
        exit: 450
      },
      "in": !collapsed,
      unmountOnExit: true,
      options: props.transitionOptions
    }, ptm("transition"));
    return /* @__PURE__ */ React.createElement(CSSTransition, _extends({
      nodeRef: contentRef
    }, transitionProps), /* @__PURE__ */ React.createElement("div", toggleableContentProps, /* @__PURE__ */ React.createElement("div", contentProps, props.children)));
  };
  var rootProps = mergeProps({
    id: idState,
    ref: elementRef,
    style: props.style,
    className: classNames(props.className, cx("root"))
  }, PanelBase.getOtherProps(props), ptm("root"));
  var header = createHeader();
  var content = createContent();
  var footer = createFooter();
  return /* @__PURE__ */ React.createElement("div", rootProps, header, content, footer);
});
Panel.displayName = "Panel";
export {
  Panel as default
};
