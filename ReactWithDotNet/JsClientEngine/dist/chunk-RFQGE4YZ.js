import {
  ComponentBase,
  DomHandler,
  ObjectUtils,
  PrimeReactContext,
  UniqueComponentId,
  classNames,
  useEventListener,
  useHandleStyle,
  useMergeProps,
  useMountEffect
} from "./chunk-NBA33TRK.js";
import {
  require_react
} from "./chunk-XDFXK7K5.js";
import {
  __toESM
} from "./chunk-QRPWKJ4C.js";

// node_modules/primereact/splitter/splitter.esm.js
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
function _arrayLikeToArray(r, a) {
  (null == a || a > r.length) && (a = r.length);
  for (var e = 0, n = Array(a); e < a; e++) n[e] = r[e];
  return n;
}
function _arrayWithoutHoles(r) {
  if (Array.isArray(r)) return _arrayLikeToArray(r);
}
function _iterableToArray(r) {
  if ("undefined" != typeof Symbol && null != r[Symbol.iterator] || null != r["@@iterator"]) return Array.from(r);
}
function _unsupportedIterableToArray(r, a) {
  if (r) {
    if ("string" == typeof r) return _arrayLikeToArray(r, a);
    var t = {}.toString.call(r).slice(8, -1);
    return "Object" === t && r.constructor && (t = r.constructor.name), "Map" === t || "Set" === t ? Array.from(r) : "Arguments" === t || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t) ? _arrayLikeToArray(r, a) : void 0;
  }
}
function _nonIterableSpread() {
  throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
}
function _toConsumableArray(r) {
  return _arrayWithoutHoles(r) || _iterableToArray(r) || _unsupportedIterableToArray(r) || _nonIterableSpread();
}
function _typeof(o) {
  "@babel/helpers - typeof";
  return _typeof = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function(o2) {
    return typeof o2;
  } : function(o2) {
    return o2 && "function" == typeof Symbol && o2.constructor === Symbol && o2 !== Symbol.prototype ? "symbol" : typeof o2;
  }, _typeof(o);
}
function toPrimitive(t, r) {
  if ("object" != _typeof(t) || !t) return t;
  var e = t[Symbol.toPrimitive];
  if (void 0 !== e) {
    var i = e.call(t, r || "default");
    if ("object" != _typeof(i)) return i;
    throw new TypeError("@@toPrimitive must return a primitive value.");
  }
  return ("string" === r ? String : Number)(t);
}
function toPropertyKey(t) {
  var i = toPrimitive(t, "string");
  return "symbol" == _typeof(i) ? i : i + "";
}
function _defineProperty(e, r, t) {
  return (r = toPropertyKey(r)) in e ? Object.defineProperty(e, r, {
    value: t,
    enumerable: true,
    configurable: true,
    writable: true
  }) : e[r] = t, e;
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
function _nonIterableRest() {
  throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
}
function _slicedToArray(r, e) {
  return _arrayWithHoles(r) || _iterableToArrayLimit(r, e) || _unsupportedIterableToArray(r, e) || _nonIterableRest();
}
var classes = {
  root: function root(_ref) {
    var props = _ref.props;
    return classNames("p-splitter p-component p-splitter-".concat(props.layout));
  },
  gutter: "p-splitter-gutter",
  gutterHandler: "p-splitter-gutter-handle",
  panel: {
    root: "p-splitter-panel"
  }
};
var styles = "\n@layer primereact {\n    .p-splitter {\n        display: flex;\n        flex-wrap: nowrap;\n    }\n\n    .p-splitter-vertical {\n        flex-direction: column;\n    }\n\n    .p-splitter-panel {\n        flex-grow: 1;\n    }\n\n    .p-splitter-panel-nested {\n        display: flex;\n    }\n\n    .p-splitter-panel .p-splitter {\n        flex-grow: 1;\n        border: 0 none;\n    }\n\n    .p-splitter-gutter {\n        flex-grow: 0;\n        flex-shrink: 0;\n        display: flex;\n        align-items: center;\n        justify-content: center;\n        cursor: col-resize;\n    }\n\n    .p-splitter-horizontal.p-splitter-resizing {\n        cursor: col-resize;\n        user-select: none;\n    }\n\n    .p-splitter-horizontal > .p-splitter-gutter > .p-splitter-gutter-handle {\n        height: 24px;\n        width: 100%;\n    }\n\n    .p-splitter-horizontal > .p-splitter-gutter {\n        cursor: col-resize;\n    }\n\n    .p-splitter-vertical.p-splitter-resizing {\n        cursor: row-resize;\n        user-select: none;\n    }\n\n    .p-splitter-vertical > .p-splitter-gutter {\n        cursor: row-resize;\n    }\n\n    .p-splitter-vertical > .p-splitter-gutter > .p-splitter-gutter-handle {\n        width: 24px;\n        height: 100%;\n    }\n}\n\n";
var SplitterBase = ComponentBase.extend({
  defaultProps: {
    __TYPE: "Splitter",
    className: null,
    gutterSize: 4,
    id: null,
    step: 5,
    layout: "horizontal",
    onResizeEnd: null,
    stateKey: null,
    stateStorage: "session",
    style: null,
    children: void 0
  },
  css: {
    classes,
    styles
  }
});
var SplitterPanelBase = ComponentBase.extend({
  defaultProps: {
    __TYPE: "SplitterPanel",
    className: null,
    minSize: null,
    size: null,
    style: null,
    children: void 0
  },
  getCProps: function getCProps(panel) {
    return ObjectUtils.getComponentProps(panel, SplitterPanelBase.defaultProps);
  },
  getCOtherProps: function getCOtherProps(panel) {
    return ObjectUtils.getComponentDiffProps(panel, SplitterPanelBase.defaultProps);
  },
  getCProp: function getCProp(panel, name) {
    return ObjectUtils.getComponentProp(panel, name, SplitterPanelBase.defaultProps);
  }
});
function ownKeys(e, r) {
  var t = Object.keys(e);
  if (Object.getOwnPropertySymbols) {
    var o = Object.getOwnPropertySymbols(e);
    r && (o = o.filter(function(r2) {
      return Object.getOwnPropertyDescriptor(e, r2).enumerable;
    })), t.push.apply(t, o);
  }
  return t;
}
function _objectSpread(e) {
  for (var r = 1; r < arguments.length; r++) {
    var t = null != arguments[r] ? arguments[r] : {};
    r % 2 ? ownKeys(Object(t), true).forEach(function(r2) {
      _defineProperty(e, r2, t[r2]);
    }) : Object.getOwnPropertyDescriptors ? Object.defineProperties(e, Object.getOwnPropertyDescriptors(t)) : ownKeys(Object(t)).forEach(function(r2) {
      Object.defineProperty(e, r2, Object.getOwnPropertyDescriptor(t, r2));
    });
  }
  return e;
}
var SplitterPanel = function SplitterPanel2() {
};
var Splitter = /* @__PURE__ */ React.memo(/* @__PURE__ */ React.forwardRef(function(inProps, ref) {
  var mergeProps = useMergeProps();
  var context = React.useContext(PrimeReactContext);
  var props = SplitterBase.getProps(inProps, context);
  var idState = React.useRef("");
  var elementRef = React.useRef(null);
  var gutterRef = React.useRef();
  var gutterRefs = React.useRef({});
  var size = React.useRef(null);
  var dragging = React.useRef(null);
  var startPos = React.useRef(null);
  var prevPanelElement = React.useRef(null);
  var nextPanelElement = React.useRef(null);
  var prevPanelSize = React.useRef(null);
  var prevSize = React.useRef(null);
  var prevPanelSizeNew = React.useRef(null);
  var nextPanelSize = React.useRef(null);
  var nextPanelSizeNew = React.useRef(null);
  var prevPanelIndex = React.useRef(null);
  var timer = React.useRef(null);
  var _React$useState = React.useState([]), _React$useState2 = _slicedToArray(_React$useState, 2), panelSizes = _React$useState2[0], setPanelSizes = _React$useState2[1];
  var _React$useState3 = React.useState(false), _React$useState4 = _slicedToArray(_React$useState3, 2), nested = _React$useState4[0], setNested = _React$useState4[1];
  var isStateful = props.stateKey != null;
  var childrenLength = props.children && props.children.length || 1;
  var panelSize = function panelSize2(sizes, index) {
    return index in sizes ? sizes[index] : props.children && [].concat(props.children)[index].props.size || 100 / childrenLength;
  };
  var horizontal = props.layout === "horizontal";
  var metaData = {
    props,
    state: {
      panelSizes,
      nested: DomHandler.getAttribute(elementRef.current && elementRef.current.parentElement, "data-p-splitter-panel-nested") === true
    }
  };
  var _SplitterBase$setMeta = SplitterBase.setMetaData(_objectSpread({}, metaData)), ptm = _SplitterBase$setMeta.ptm, cx = _SplitterBase$setMeta.cx, isUnstyled = _SplitterBase$setMeta.isUnstyled;
  useHandleStyle(SplitterBase.css.styles, isUnstyled, {
    name: "splitter"
  });
  var getPanelPT = function getPanelPT2(key) {
    return ptm(key, {
      context: {
        nested
      }
    });
  };
  var _useEventListener = useEventListener({
    type: "mousemove",
    listener: function listener(event) {
      return onResize(event);
    }
  }), _useEventListener2 = _slicedToArray(_useEventListener, 2), bindDocumentMouseMoveListener = _useEventListener2[0], unbindDocumentMouseMoveListener = _useEventListener2[1];
  var _useEventListener3 = useEventListener({
    type: "mouseup",
    listener: function listener(event) {
      onResizeEnd(event);
      unbindMouseListeners();
    }
  }), _useEventListener4 = _slicedToArray(_useEventListener3, 2), bindDocumentMouseUpListener = _useEventListener4[0], unbindDocumentMouseUpListener = _useEventListener4[1];
  var bindMouseListeners = function bindMouseListeners2() {
    bindDocumentMouseMoveListener();
    bindDocumentMouseUpListener();
  };
  var unbindMouseListeners = function unbindMouseListeners2() {
    unbindDocumentMouseMoveListener();
    unbindDocumentMouseUpListener();
  };
  var getPanelProp = function getPanelProp2(panel, name) {
    return SplitterPanelBase.getCProp(panel, name);
  };
  var validateResize = function validateResize2(newPrevPanelSize, newNextPanelSize) {
    if (newPrevPanelSize > 100 || newPrevPanelSize < 0) {
      return false;
    }
    if (newNextPanelSize > 100 || newNextPanelSize < 0) {
      return false;
    }
    if (props.children[prevPanelIndex.current].props && props.children[prevPanelIndex.current].props.minSize && props.children[prevPanelIndex.current].props.minSize > newPrevPanelSize) {
      return false;
    }
    if (props.children[prevPanelIndex.current + 1].props && props.children[prevPanelIndex.current + 1].props.minSize && props.children[prevPanelIndex.current + 1].props.minSize > newNextPanelSize) {
      return false;
    }
    return true;
  };
  var clear = function clear2() {
    dragging.current = false;
    size.current = null;
    startPos.current = null;
    prevPanelElement.current = null;
    nextPanelElement.current = null;
    prevPanelSize.current = null;
    prevPanelSizeNew.current = null;
    nextPanelSize.current = null;
    nextPanelSizeNew.current = null;
    prevPanelIndex.current = null;
  };
  var getStorage = React.useCallback(function() {
    switch (props.stateStorage) {
      case "local":
        return window.localStorage;
      case "session":
        return window.sessionStorage;
      default:
        throw new Error(props.stateStorage + ' is not a valid value for the state storage, supported values are "local" and "session".');
    }
  }, [props.stateStorage]);
  var saveState = function saveState2(sizes) {
    if (ObjectUtils.isArray(sizes)) {
      getStorage().setItem(props.stateKey, JSON.stringify(sizes));
    }
  };
  var restoreState = React.useCallback(function() {
    var stateString = getStorage().getItem(props.stateKey);
    if (stateString) {
      setPanelSizes(JSON.parse(stateString));
    }
  }, [getStorage, props.stateKey]);
  var onResizeStart = function onResizeStart2(event, index, isKeyDown) {
    var pageX = event.type === "touchstart" ? event.touches[0].pageX : event.pageX;
    var pageY = event.type === "touchstart" ? event.touches[0].pageY : event.pageY;
    gutterRef.current = gutterRefs.current[index];
    size.current = horizontal ? DomHandler.getWidth(elementRef.current) : DomHandler.getHeight(elementRef.current);
    dragging.current = true;
    startPos.current = horizontal ? pageX : pageY;
    prevPanelElement.current = gutterRef.current.previousElementSibling;
    nextPanelElement.current = gutterRef.current.nextElementSibling;
    if (isKeyDown) {
      prevPanelSize.current = horizontal ? DomHandler.getOuterWidth(prevPanelElement.current, true) : DomHandler.getOuterHeight(prevPanelElement.current, true);
      nextPanelSize.current = horizontal ? DomHandler.getOuterWidth(nextPanelElement.current, true) : DomHandler.getOuterHeight(nextPanelElement.current, true);
    } else {
      prevPanelSize.current = 100 * (horizontal ? DomHandler.getOuterWidth(prevPanelElement.current, true) : DomHandler.getOuterHeight(prevPanelElement.current, true)) / size.current;
      nextPanelSize.current = 100 * (horizontal ? DomHandler.getOuterWidth(nextPanelElement.current, true) : DomHandler.getOuterHeight(nextPanelElement.current, true)) / size.current;
    }
    prevPanelSizeNew.current = prevPanelSize.current;
    nextPanelSizeNew.current = nextPanelSize.current;
    prevPanelIndex.current = index;
    !isUnstyled() && DomHandler.addClass(gutterRef.current, "p-splitter-gutter-resizing");
    gutterRef.current.setAttribute("data-p-splitter-gutter-resizing", true);
    !isUnstyled() && DomHandler.addClass(elementRef.current, "p-splitter-resizing");
    elementRef.current.setAttribute("data-p-splitter-resizing", true);
  };
  var onResize = function onResize2(event) {
    var step = arguments.length > 1 && arguments[1] !== void 0 ? arguments[1] : 0;
    var isKeyDown = arguments.length > 2 && arguments[2] !== void 0 ? arguments[2] : false;
    var newPos;
    var newNextPanelSize;
    var newPrevPanelSize;
    var pageX = event.type === "touchmove" ? event.touches[0].pageX : event.pageX;
    var pageY = event.type === "touchmove" ? event.touches[0].pageY : event.pageY;
    if (isKeyDown) {
      if (horizontal) {
        newPrevPanelSize = 100 * (prevPanelSize.current + step) / size.current;
        newNextPanelSize = 100 * (nextPanelSize.current - step) / size.current;
      } else {
        newPrevPanelSize = 100 * (prevPanelSize.current - step) / size.current;
        newNextPanelSize = 100 * (nextPanelSize.current + step) / size.current;
      }
    } else {
      if (horizontal) {
        newPos = pageX * 100 / size.current - startPos.current * 100 / size.current;
      } else {
        newPos = pageY * 100 / size.current - startPos.current * 100 / size.current;
      }
      newPrevPanelSize = prevPanelSize.current + newPos;
      newNextPanelSize = nextPanelSize.current - newPos;
    }
    resizePanel(prevPanelIndex.current, newPrevPanelSize, newNextPanelSize);
  };
  var onResizeEnd = function onResizeEnd2(event) {
    var sizes = _toConsumableArray(panelSizes);
    sizes[prevPanelIndex.current] = prevPanelSizeNew.current;
    sizes[prevPanelIndex.current + 1] = nextPanelSizeNew.current;
    if (props.onResizeEnd) {
      props.onResizeEnd({
        originalEvent: event,
        sizes
      });
    }
    if (isStateful) {
      saveState(sizes);
    }
    setPanelSizes(sizes);
    !isUnstyled() && DomHandler.removeClass(gutterRef.current, "p-splitter-gutter-resizing");
    gutterRefs.current && Object.keys(gutterRefs.current).forEach(function(key) {
      return gutterRefs.current[key].setAttribute("data-p-splitter-gutter-resizing", false);
    });
    !isUnstyled() && DomHandler.removeClass(elementRef.current, "p-splitter-resizing");
    elementRef.current.setAttribute("data-p-splitter-resizing", false);
    clear();
  };
  var onGutterKeyUp = function onGutterKeyUp2() {
    clearTimer();
    onResizeEnd();
  };
  var onGutterKeyDown = function onGutterKeyDown2(event, index) {
    var minSize = props.children[index].props && props.children[index].props.minSize || 0;
    switch (event.code) {
      case "ArrowLeft": {
        if (horizontal) {
          setTimer(event, index, props.step * -1);
        }
        event.preventDefault();
        break;
      }
      case "ArrowRight": {
        if (horizontal) {
          setTimer(event, index, props.step);
        }
        event.preventDefault();
        break;
      }
      case "ArrowDown": {
        if (!horizontal) {
          setTimer(event, index, props.step * -1);
        }
        event.preventDefault();
        break;
      }
      case "ArrowUp": {
        if (!horizontal) {
          setTimer(event, index, props.step);
        }
        event.preventDefault();
        break;
      }
      case "Home": {
        resizePanel(index, 100 - minSize, minSize);
        event.preventDefault();
        break;
      }
      case "End": {
        resizePanel(index, minSize, 100 - minSize);
        event.preventDefault();
        break;
      }
      case "NumpadEnter":
      case "Enter": {
        if (prevSize.current >= 100 - (minSize || 5)) {
          resizePanel(index, minSize, 100 - minSize);
        } else {
          resizePanel(index, 100 - minSize, minSize);
        }
        event.preventDefault();
        break;
      }
    }
  };
  var resizePanel = function resizePanel2(index, newPrevPanelSize, newNextPanelSize) {
    prevPanelIndex.current = index;
    gutterRef.current = gutterRefs.current[index];
    size.current = horizontal ? DomHandler.getWidth(elementRef.current) : DomHandler.getHeight(elementRef.current);
    prevPanelElement.current = gutterRef.current.previousElementSibling;
    nextPanelElement.current = gutterRef.current.nextElementSibling;
    if (validateResize(newPrevPanelSize, newNextPanelSize)) {
      prevPanelSizeNew.current = newPrevPanelSize;
      nextPanelSizeNew.current = newNextPanelSize;
      prevPanelElement.current.style.flexBasis = "calc(" + newPrevPanelSize + "% - " + (props.children.length - 1) * props.gutterSize + "px)";
      nextPanelElement.current.style.flexBasis = "calc(" + newNextPanelSize + "% - " + (props.children.length - 1) * props.gutterSize + "px)";
      prevSize.current = parseFloat(newPrevPanelSize).toFixed(4);
    }
  };
  var repeat = function repeat2(event, index, step) {
    onResizeStart(event, index, true);
    onResize(event, step, true);
  };
  var setTimer = function setTimer2(event, index, step) {
    if (!timer.current) {
      timer.current = setInterval(function() {
        repeat(event, index, step);
      }, 40);
    }
  };
  var clearTimer = function clearTimer2() {
    if (timer.current) {
      clearInterval(timer.current);
      timer.current = null;
    }
  };
  var onGutterMouseDown = function onGutterMouseDown2(event, index) {
    onResizeStart(event, index, false);
    bindMouseListeners();
  };
  var onGutterTouchStart = function onGutterTouchStart2(event, index) {
    onResizeStart(event, index, false);
    window.addEventListener("touchmove", onGutterTouchMove, {
      passive: false,
      cancelable: false
    });
    window.addEventListener("touchend", _onGutterTouchEnd);
  };
  var onGutterTouchMove = function onGutterTouchMove2(event) {
    onResize(event);
  };
  var _onGutterTouchEnd = function onGutterTouchEnd(event) {
    onResizeEnd(event);
    window.removeEventListener("touchmove", onGutterTouchMove);
    window.removeEventListener("touchend", _onGutterTouchEnd);
  };
  React.useImperativeHandle(ref, function() {
    return {
      props,
      getElement: function getElement() {
        return elementRef.current;
      }
    };
  });
  useMountEffect(function() {
    if (elementRef.current) {
      idState.current = UniqueComponentId();
    }
  });
  React.useEffect(function() {
    var panelElements = _toConsumableArray(elementRef.current.children).filter(function(child) {
      return DomHandler.getAttribute(child, "data-pc-section") === "splitterpanel.root";
    });
    var _panelSizes = [];
    panelElements.map(function(panelElement, i) {
      prevSize.current = panelSize(panelSizes, 0);
      _panelSizes[i] = panelSize(panelSizes, i);
      if (panelElement.childNodes && ObjectUtils.isNotEmpty(DomHandler.find(panelElement, "[data-pc-name='splitter']") && DomHandler.find(panelElement, "[data-pc-section='root']"))) {
        !isUnstyled() && DomHandler.addClass(panelElement, "p-splitter-panel-nested");
        panelElement.setAttribute("data-p-splitter-panel-nested", true);
        setNested(true);
      }
    });
    setPanelSizes(_panelSizes);
  }, []);
  React.useEffect(function() {
    if (isStateful) {
      restoreState();
    }
  }, [restoreState, isStateful]);
  var createPanel = function createPanel2(panel, index) {
    var panelId = getPanelProp(panel, "id") || "".concat(idState.current, "_").concat(index);
    var panelClassName = classNames(getPanelProp(panel, "className"), cx("panel.root"));
    var gutterProps = mergeProps({
      ref: function ref2(el) {
        return gutterRefs.current[index] = el;
      },
      className: cx("gutter"),
      style: horizontal ? {
        width: props.gutterSize + "px"
      } : {
        height: props.gutterSize + "px"
      },
      onMouseDown: function onMouseDown(event) {
        return onGutterMouseDown(event, index);
      },
      onKeyDown: function onKeyDown(event) {
        return onGutterKeyDown(event, index);
      },
      onKeyUp: onGutterKeyUp,
      onTouchStart: function onTouchStart(event) {
        return onGutterTouchStart(event, index);
      },
      onTouchMove: function onTouchMove(event) {
        return onGutterTouchMove(event);
      },
      onTouchEnd: function onTouchEnd(event) {
        return _onGutterTouchEnd(event);
      },
      "data-p-splitter-gutter-resizing": false
    }, ptm("gutter"));
    var gutterHandlerProps = mergeProps({
      tabIndex: getPanelProp(panel, "tabIndex") || 0,
      className: cx("gutterHandler"),
      role: "separator",
      "aria-orientation": horizontal ? "vertical" : "horizontal",
      "aria-controls": panelId,
      "aria-label": getPanelProp(panel, "aria-label"),
      "aria-labelledby": getPanelProp(panel, "aria-labelledby"),
      "aria-valuenow": prevSize.current,
      "aria-valuetext": parseFloat(prevSize.current).toFixed(0) + "%",
      "aria-valuemin": getPanelProp(panel, "minSize") || "0",
      "aria-valuemax": "100"
    }, ptm("gutterHandler"));
    var gutter = index !== props.children.length - 1 && /* @__PURE__ */ React.createElement("div", gutterProps, /* @__PURE__ */ React.createElement("div", gutterHandlerProps));
    var flexBasis = "calc(" + panelSize(panelSizes, index) + "% - " + (childrenLength - 1) * props.gutterSize + "px)";
    var rootProps2 = mergeProps({
      key: index,
      id: panelId,
      className: panelClassName,
      style: _objectSpread(_objectSpread({}, getPanelProp(panel, "style")), {}, {
        flexBasis
      }),
      role: "presentation",
      "data-p-splitter-panel-nested": false,
      onClick: getPanelProp(panel, "onClick")
    }, getPanelPT("splitterpanel.root"));
    return /* @__PURE__ */ React.createElement(React.Fragment, null, /* @__PURE__ */ React.createElement("div", rootProps2, getPanelProp(panel, "children")), gutter);
  };
  var createPanels = function createPanels2() {
    return React.Children.map(props.children, createPanel);
  };
  var rootProps = mergeProps({
    id: props.id,
    style: props.style,
    className: classNames(props.className, cx("root")),
    "data-p-splitter-resizing": false
  }, SplitterBase.getOtherProps(props), ptm("root"));
  var panels = createPanels();
  return /* @__PURE__ */ React.createElement("div", _extends({
    ref: elementRef
  }, rootProps), panels);
}));
SplitterPanel.displayName = "SplitterPanel";
Splitter.displayName = "Splitter";

export {
  SplitterPanel,
  Splitter
};
