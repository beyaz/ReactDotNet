import {
  VirtualScroller
} from "./chunk-G7G43RN5.js";
import {
  SearchIcon
} from "./chunk-JB3TRCHR.js";
import "./chunk-TEWXDFAB.js";
import {
  InputText
} from "./chunk-JAM7SNCO.js";
import "./chunk-WPUEZBIL.js";
import {
  Tooltip
} from "./chunk-2PX4WDKA.js";
import "./chunk-CMYF6AIZ.js";
import {
  Ripple
} from "./chunk-56TI4EJO.js";
import "./chunk-2FIYIUK5.js";
import {
  ComponentBase,
  DomHandler,
  FilterService,
  IconUtils,
  ObjectUtils,
  PrimeReactContext,
  UniqueComponentId,
  classNames,
  localeOption,
  useHandleStyle,
  useMergeProps,
  useMountEffect
} from "./chunk-NBA33TRK.js";
import "./chunk-QNQS7X5M.js";
import {
  require_react
} from "./chunk-XDFXK7K5.js";
import {
  __toESM
} from "./chunk-QRPWKJ4C.js";

// node_modules/primereact/listbox/listbox.esm.js
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
function _arrayLikeToArray$1(r, a) {
  (null == a || a > r.length) && (a = r.length);
  for (var e = 0, n = Array(a); e < a; e++) n[e] = r[e];
  return n;
}
function _arrayWithoutHoles(r) {
  if (Array.isArray(r)) return _arrayLikeToArray$1(r);
}
function _iterableToArray(r) {
  if ("undefined" != typeof Symbol && null != r[Symbol.iterator] || null != r["@@iterator"]) return Array.from(r);
}
function _unsupportedIterableToArray$1(r, a) {
  if (r) {
    if ("string" == typeof r) return _arrayLikeToArray$1(r, a);
    var t = {}.toString.call(r).slice(8, -1);
    return "Object" === t && r.constructor && (t = r.constructor.name), "Map" === t || "Set" === t ? Array.from(r) : "Arguments" === t || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t) ? _arrayLikeToArray$1(r, a) : void 0;
  }
}
function _nonIterableSpread() {
  throw new TypeError("Invalid attempt to spread non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
}
function _toConsumableArray(r) {
  return _arrayWithoutHoles(r) || _iterableToArray(r) || _unsupportedIterableToArray$1(r) || _nonIterableSpread();
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
  return _arrayWithHoles(r) || _iterableToArrayLimit(r, e) || _unsupportedIterableToArray$1(r, e) || _nonIterableRest();
}
var classes = {
  itemGroup: "p-listbox-item-group",
  emptyMessage: "p-listbox-empty-message",
  list: "p-listbox-list",
  wrapper: function wrapper(_ref) {
    var props = _ref.props;
    return classNames("p-listbox-list-wrapper", props.listClassName);
  },
  root: function root(_ref2) {
    var props = _ref2.props;
    return classNames("p-listbox p-component", {
      "p-disabled": props.disabled,
      "p-invalid": props.invalid
    }, props.className);
  },
  item: function item(_ref3) {
    var props = _ref3.props;
    return classNames("p-listbox-item", {
      "p-highlight": props.selected,
      "p-focus": props.focusedOptionIndex === props.index,
      "p-disabled": props.disabled
    }, props.option.className);
  },
  filterContainer: "p-listbox-filter-container",
  filterIcon: "p-listbox-filter-icon",
  filterInput: "p-listbox-filter",
  header: "p-listbox-header"
};
var styles = "\n@layer primereact {\n    .p-listbox-list-wrapper {\n        overflow: auto;\n    }\n    \n    .p-listbox-list {\n        list-style-type: none;\n        margin: 0;\n        padding: 0;\n    }\n    \n    .p-listbox-item {\n        cursor: pointer;\n        position: relative;\n        overflow: hidden;\n        outline: none;\n    }\n    \n    .p-listbox-filter-container {\n        position: relative;\n    }\n    \n    .p-listbox-filter-icon {\n        position: absolute;\n        top: 50%;\n        margin-top: -.5rem;\n    }\n    \n    .p-listbox-filter {\n        width: 100%;\n    }\n}\n";
var inlineStyles = {
  itemGroup: function itemGroup(_ref4) {
    var scrollerOptions = _ref4.scrollerOptions;
    return {
      height: scrollerOptions.props ? scrollerOptions.props.itemSize : void 0
    };
  },
  list: function list(_ref5) {
    var options = _ref5.options, props = _ref5.props;
    return props.virtualScrollerOptions ? options.style : void 0;
  }
};
var ListBoxBase = ComponentBase.extend({
  defaultProps: {
    __TYPE: "ListBox",
    className: null,
    dataKey: null,
    disabled: null,
    emptyFilterMessage: null,
    emptyMessage: null,
    filter: false,
    filterIcon: null,
    filterBy: null,
    filterInputProps: null,
    filterLocale: void 0,
    filterMatchMode: "contains",
    filterPlaceholder: null,
    filterTemplate: null,
    filterValue: null,
    focusOnHover: true,
    id: null,
    itemTemplate: null,
    invalid: false,
    listClassName: null,
    listStyle: null,
    metaKeySelection: false,
    selectOnFocus: false,
    autoOptionFocus: false,
    multiple: false,
    onChange: null,
    onFilterValueChange: null,
    optionDisabled: null,
    optionGroupChildren: null,
    optionGroupLabel: null,
    optionGroupTemplate: null,
    optionLabel: null,
    optionValue: null,
    options: null,
    style: null,
    tabIndex: 0,
    tooltip: null,
    tooltipOptions: null,
    value: null,
    virtualScrollerOptions: null,
    children: void 0
  },
  css: {
    classes,
    styles,
    inlineStyles
  }
});
function ownKeys$1(e, r) {
  var t = Object.keys(e);
  if (Object.getOwnPropertySymbols) {
    var o = Object.getOwnPropertySymbols(e);
    r && (o = o.filter(function(r2) {
      return Object.getOwnPropertyDescriptor(e, r2).enumerable;
    })), t.push.apply(t, o);
  }
  return t;
}
function _objectSpread$1(e) {
  for (var r = 1; r < arguments.length; r++) {
    var t = null != arguments[r] ? arguments[r] : {};
    r % 2 ? ownKeys$1(Object(t), true).forEach(function(r2) {
      _defineProperty(e, r2, t[r2]);
    }) : Object.getOwnPropertyDescriptors ? Object.defineProperties(e, Object.getOwnPropertyDescriptors(t)) : ownKeys$1(Object(t)).forEach(function(r2) {
      Object.defineProperty(e, r2, Object.getOwnPropertyDescriptor(t, r2));
    });
  }
  return e;
}
var ListBoxHeader = /* @__PURE__ */ React.memo(function(props) {
  var mergeProps = useMergeProps();
  var _props$ptCallbacks = props.ptCallbacks, ptm = _props$ptCallbacks.ptm, cx = _props$ptCallbacks.cx;
  var getPTOptions = function getPTOptions2(key, options) {
    return ptm(key, _objectSpread$1({
      hostName: props.hostName
    }, options));
  };
  var filterOptions = {
    filter: function filter(e) {
      return onFilter(e);
    },
    reset: function reset() {
      return props.resetFilter();
    }
  };
  var onFilter = function onFilter2(event) {
    if (props.onFilter) {
      props.onFilter({
        originalEvent: event,
        value: event.target.value
      });
    }
  };
  var createHeader = function createHeader2() {
    var filterIconProps = mergeProps({
      className: cx("filterIcon")
    }, getPTOptions("filterIcon"));
    var icon = props.filterIcon || /* @__PURE__ */ React.createElement(SearchIcon, filterIconProps);
    var filterIcon = IconUtils.getJSXIcon(icon, _objectSpread$1({}, filterIconProps), {
      props
    });
    var headerProps = mergeProps({
      className: cx("header")
    }, getPTOptions("header"));
    var filterContainerProps = mergeProps({
      className: cx("filterContainer")
    }, getPTOptions("filterContainer"));
    var content2 = /* @__PURE__ */ React.createElement("div", filterContainerProps, /* @__PURE__ */ React.createElement(InputText, _extends({
      type: "text",
      value: props.filter,
      onChange: onFilter,
      className: cx("filterInput"),
      disabled: props.disabled,
      placeholder: props.filterPlaceholder
    }, props.filterInputProps, {
      pt: ptm("filterInput"),
      unstyled: props.unstyled,
      __parentMetadata: {
        parent: props.metaData
      }
    })), filterIcon);
    if (props.filterTemplate) {
      var defaultContentOptions = {
        className: "p-listbox-filter-container",
        element: content2,
        filterOptions,
        filterInputChange: onFilter,
        filterIconClassName: "p-dropdown-filter-icon",
        props
      };
      content2 = ObjectUtils.getJSXElement(props.filterTemplate, defaultContentOptions);
    }
    return /* @__PURE__ */ React.createElement("div", headerProps, content2);
  };
  var content = createHeader();
  return /* @__PURE__ */ React.createElement(React.Fragment, null, content);
});
ListBoxHeader.displayName = "ListBoxHeader";
var ListBoxItem = /* @__PURE__ */ React.memo(function(props) {
  var _React$useState = React.useState(false), _React$useState2 = _slicedToArray(_React$useState, 2), focusedState = _React$useState2[0], setFocusedState = _React$useState2[1];
  var mergeProps = useMergeProps();
  var _props$ptCallbacks = props.ptCallbacks, ptm = _props$ptCallbacks.ptm, cx = _props$ptCallbacks.cx;
  var getPTOptions = function getPTOptions2(key) {
    return ptm(key, {
      hostName: props.hostName,
      context: {
        selected: props.selected,
        disabled: props.disabled,
        focused: focusedState,
        focusedOptionIndex: props.focusedOptionIndex
      }
    });
  };
  var onFocus = function onFocus2(event) {
    setFocusedState(true);
  };
  var onBlur = function onBlur2(event) {
    setFocusedState(false);
  };
  var onTouchEnd = function onTouchEnd2(event) {
    if (props.onTouchEnd) {
      props.onTouchEnd({
        originalEvent: event,
        option: props.option
      });
    }
  };
  var content = props.template ? ObjectUtils.getJSXElement(props.template, props.option) : props.label;
  var itemProps = mergeProps({
    id: props.id,
    className: cx("item", {
      props
    }),
    style: props.style,
    onClick: function onClick(event) {
      return props.onClick(event, props.option, props.index);
    },
    onTouchEnd,
    onFocus,
    onBlur,
    tabIndex: "-1",
    onMouseDown: function onMouseDown(event) {
      return props.onOptionMouseDown(event, props.index);
    },
    onMouseMove: function onMouseMove(event) {
      return props.onOptionMouseMove(event, props.index);
    },
    "aria-label": props.label,
    role: "option",
    "aria-selected": props.selected,
    "aria-disabled": props.disabled,
    "data-p-disabled": props.disabled
  }, getPTOptions("item"));
  return /* @__PURE__ */ React.createElement("li", _extends({}, itemProps, {
    key: props.optionKey
  }), content, /* @__PURE__ */ React.createElement(Ripple, null));
});
ListBoxItem.displayName = "ListBoxItem";
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
function _createForOfIteratorHelper(r, e) {
  var t = "undefined" != typeof Symbol && r[Symbol.iterator] || r["@@iterator"];
  if (!t) {
    if (Array.isArray(r) || (t = _unsupportedIterableToArray(r)) || e && r && "number" == typeof r.length) {
      t && (r = t);
      var _n = 0, F = function F2() {
      };
      return { s: F, n: function n() {
        return _n >= r.length ? { done: true } : { done: false, value: r[_n++] };
      }, e: function e2(r2) {
        throw r2;
      }, f: F };
    }
    throw new TypeError("Invalid attempt to iterate non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
  }
  var o, a = true, u = false;
  return { s: function s() {
    t = t.call(r);
  }, n: function n() {
    var r2 = t.next();
    return a = r2.done, r2;
  }, e: function e2(r2) {
    u = true, o = r2;
  }, f: function f() {
    try {
      a || null == t["return"] || t["return"]();
    } finally {
      if (u) throw o;
    }
  } };
}
function _unsupportedIterableToArray(r, a) {
  if (r) {
    if ("string" == typeof r) return _arrayLikeToArray(r, a);
    var t = {}.toString.call(r).slice(8, -1);
    return "Object" === t && r.constructor && (t = r.constructor.name), "Map" === t || "Set" === t ? Array.from(r) : "Arguments" === t || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t) ? _arrayLikeToArray(r, a) : void 0;
  }
}
function _arrayLikeToArray(r, a) {
  (null == a || a > r.length) && (a = r.length);
  for (var e = 0, n = Array(a); e < a; e++) n[e] = r[e];
  return n;
}
var ListBox = /* @__PURE__ */ React.memo(/* @__PURE__ */ React.forwardRef(function(inProps, ref) {
  var mergeProps = useMergeProps();
  var context = React.useContext(PrimeReactContext);
  var props = ListBoxBase.getProps(inProps, context);
  var _React$useState = React.useState(null), _React$useState2 = _slicedToArray(_React$useState, 2), focusedOptionIndex = _React$useState2[0], setFocusedOptionIndex = _React$useState2[1];
  var searchTimeout = React.useRef(null);
  var firstHiddenFocusableElement = React.useRef(null);
  var lastHiddenFocusableElement = React.useRef(null);
  var _React$useState3 = React.useState(-1), _React$useState4 = _slicedToArray(_React$useState3, 2), startRangeIndex = _React$useState4[0], setStartRangeIndex = _React$useState4[1];
  var _React$useState5 = React.useState(false), _React$useState6 = _slicedToArray(_React$useState5, 2), focused = _React$useState6[0], setFocused = _React$useState6[1];
  var _React$useState7 = React.useState(""), _React$useState8 = _slicedToArray(_React$useState7, 2), filterValueState = _React$useState8[0], setFilterValueState = _React$useState8[1];
  var _React$useState9 = React.useState(""), _React$useState10 = _slicedToArray(_React$useState9, 2), searchValue = _React$useState10[0], setSearchValue = _React$useState10[1];
  var elementRef = React.useRef(null);
  var virtualScrollerRef = React.useRef(null);
  var id = React.useRef(null);
  var listRef = React.useRef(null);
  var optionTouched = React.useRef(false);
  var filteredValue = (props.onFilterValueChange ? props.filterValue : filterValueState) || "";
  var hasFilter = filteredValue && filteredValue.trim().length > 0;
  var metaData = {
    props,
    state: {
      filterValue: filteredValue
    }
  };
  var ptCallbacks = ListBoxBase.setMetaData(metaData);
  useHandleStyle(ListBoxBase.css.styles, ptCallbacks.isUnstyled, {
    name: "listbox"
  });
  var onOptionSelect = function onOptionSelect2(event, option) {
    var index = arguments.length > 2 && arguments[2] !== void 0 ? arguments[2] : -1;
    if (props.disabled || isOptionDisabled(option)) {
      return;
    }
    props.multiple ? onOptionSelectMultiple(event.originalEvent, option) : onOptionSelectSingle(event.originalEvent, option);
    optionTouched.current = false;
    index !== -1 && setFocusedOptionIndex(index);
  };
  var onOptionMouseDown = function onOptionMouseDown2(event, index) {
    changeFocusedOptionIndex(event, index);
  };
  var onOptionMouseMove = function onOptionMouseMove2(event, index) {
    if (props.focusOnHover && focused) {
      changeFocusedOptionIndex(event, index);
    }
  };
  var onOptionTouchEnd = function onOptionTouchEnd2() {
    if (props.disabled) {
      return;
    }
    optionTouched.current = true;
  };
  var onOptionSelectSingle = function onOptionSelectSingle2(event, option) {
    var selected = isSelected(option);
    var valueChanged = false;
    var value = null;
    var metaSelection = optionTouched.current ? false : props.metaKeySelection;
    if (metaSelection) {
      var metaKey = event.metaKey || event.ctrlKey;
      if (selected) {
        if (metaKey) {
          value = null;
          valueChanged = true;
        }
      } else {
        value = getOptionValue(option);
        valueChanged = true;
      }
    } else {
      value = selected ? null : getOptionValue(option);
      valueChanged = true;
    }
    if (valueChanged) {
      updateModel(event, value);
    }
  };
  var onOptionSelectMultiple = function onOptionSelectMultiple2(event, option) {
    var selected = isSelected(option);
    var valueChanged = false;
    var value = null;
    var metaSelection = optionTouched ? false : props.metaKeySelection;
    if (metaSelection) {
      var metaKey = event.metaKey || event.ctrlKey;
      if (selected) {
        if (metaKey) {
          value = removeOption(option);
        } else {
          value = [getOptionValue(option)];
        }
        valueChanged = true;
      } else {
        value = metaKey ? props.value || [] : [];
        value = [].concat(_toConsumableArray(value), [getOptionValue(option)]);
        valueChanged = true;
      }
    } else {
      if (selected) {
        value = removeOption(option);
      } else {
        value = [].concat(_toConsumableArray(props.value || []), [getOptionValue(option)]);
      }
      valueChanged = true;
    }
    if (valueChanged) {
      props.onChange({
        originalEvent: event,
        value,
        stopPropagation: function stopPropagation() {
          event === null || event === void 0 || event.stopPropagation();
        },
        preventDefault: function preventDefault() {
          event === null || event === void 0 || event.preventDefault();
        },
        target: {
          name: props.name,
          id: props.id,
          value
        }
      });
    }
  };
  var hasSelectedOption = function hasSelectedOption2() {
    return ObjectUtils.isNotEmpty(props.value);
  };
  var isOptionGroup = function isOptionGroup2(option) {
    return props.optionGroupLabel && option.optionGroup && option.group;
  };
  var isValidOption = function isValidOption2(option) {
    return ObjectUtils.isNotEmpty(option) && !(isOptionDisabled(option) || isOptionGroup(option));
  };
  var isValidSelectedOption = function isValidSelectedOption2(option) {
    return isValidOption(option) && isSelected(option);
  };
  var findFirstOptionIndex = function findFirstOptionIndex2() {
    return visibleOptions.findIndex(function(option) {
      return isValidOption(option);
    });
  };
  var findLastSelectedOptionIndex = function findLastSelectedOptionIndex2() {
    return hasSelectedOption() ? ObjectUtils.findLastIndex(visibleOptions, function(option) {
      return isValidSelectedOption(option);
    }) : -1;
  };
  var findSelectedOptionIndex = function findSelectedOptionIndex2() {
    if (hasSelectedOption()) {
      if (props.multiple) {
        var _loop = function _loop2() {
          var value = props.value[index];
          var matchedOptionIndex = visibleOptions.findIndex(function(option) {
            return isValidSelectedOption(option) && isEquals(value, getOptionValue(option));
          });
          if (matchedOptionIndex > -1) {
            return {
              v: matchedOptionIndex
            };
          }
        }, _ret;
        for (var index = props.value.length - 1; index >= 0; index--) {
          _ret = _loop();
          if (_ret) return _ret.v;
        }
      } else {
        return visibleOptions.findIndex(function(option) {
          return isValidSelectedOption(option);
        });
      }
    }
    return -1;
  };
  var findFirstSelectedOptionIndex = function findFirstSelectedOptionIndex2() {
    return hasSelectedOption() ? visibleOptions.findIndex(function(option) {
      return isValidSelectedOption(option);
    }) : -1;
  };
  var findLastOptionIndex = function findLastOptionIndex2() {
    return ObjectUtils.findLastIndex(visibleOptions, function(option) {
      return isValidOption(option);
    });
  };
  var findNextOptionIndex = function findNextOptionIndex2(index) {
    var matchedOptionIndex = index < visibleOptions.length - 1 ? visibleOptions.slice(index + 1).findIndex(function(option) {
      return isValidOption(option);
    }) : -1;
    return matchedOptionIndex > -1 ? matchedOptionIndex + index + 1 : index;
  };
  var findPrevOptionIndex = function findPrevOptionIndex2(index) {
    var matchedOptionIndex = index > 0 ? ObjectUtils.findLastIndex(visibleOptions.slice(0, index), function(option) {
      return isValidOption(option);
    }) : -1;
    return matchedOptionIndex > -1 ? matchedOptionIndex : index;
  };
  var focusedOptionId = function focusedOptionId2() {
    return focusedOptionIndex !== -1 ? "".concat(id.current, "_").concat(focusedOptionIndex) : null;
  };
  var findNearestSelectedOptionIndex = function findNearestSelectedOptionIndex2(index) {
    var firstCheckUp = arguments.length > 1 && arguments[1] !== void 0 ? arguments[1] : false;
    var matchedOptionIndex = -1;
    if (hasSelectedOption()) {
      if (firstCheckUp) {
        matchedOptionIndex = findPrevSelectedOptionIndex(index);
        matchedOptionIndex = matchedOptionIndex === -1 ? findNextSelectedOptionIndex(index) : matchedOptionIndex;
      } else {
        matchedOptionIndex = findNextSelectedOptionIndex(index);
        matchedOptionIndex = matchedOptionIndex === -1 ? findPrevSelectedOptionIndex(index) : matchedOptionIndex;
      }
    }
    return matchedOptionIndex > -1 ? matchedOptionIndex : index;
  };
  var isOptionMatched = function isOptionMatched2(option) {
    var _getOptionLabel;
    return isValidOption(option) && ((_getOptionLabel = getOptionLabel(option)) === null || _getOptionLabel === void 0 ? void 0 : _getOptionLabel.toLocaleLowerCase(props.filterLocale).startsWith(searchValue.toLocaleLowerCase(props.filterLocale)));
  };
  var searchOptions = function searchOptions2(event, _char) {
    setSearchValue((searchValue || "") + _char);
    var optionIndex = -1;
    if (ObjectUtils.isNotEmpty(searchValue)) {
      if (focusedOptionIndex !== -1) {
        optionIndex = visibleOptions.slice(focusedOptionIndex).findIndex(function(option) {
          return isOptionMatched(option);
        });
        optionIndex = optionIndex === -1 ? visibleOptions.slice(0, focusedOptionIndex).findIndex(function(option) {
          return isOptionMatched(option);
        }) : optionIndex + focusedOptionIndex;
      } else {
        optionIndex = visibleOptions.findIndex(function(option) {
          return isOptionMatched(option);
        });
      }
      if (optionIndex === -1 && focusedOptionIndex === -1) {
        optionIndex = findFirstFocusedOptionIndex();
      }
      if (optionIndex !== -1) {
        changeFocusedOptionIndex(event, optionIndex);
      }
    }
    if (searchTimeout.current) {
      clearTimeout(searchTimeout.current);
    }
    searchTimeout.current = setTimeout(function() {
      setSearchValue("");
      searchTimeout.current = null;
    }, 500);
  };
  var findNextSelectedOptionIndex = function findNextSelectedOptionIndex2(index) {
    var matchedOptionIndex = hasSelectedOption() && index < visibleOptions.length - 1 ? visibleOptions.slice(index + 1).findIndex(function(option) {
      return isValidSelectedOption(option);
    }) : -1;
    return matchedOptionIndex > -1 ? matchedOptionIndex + index + 1 : -1;
  };
  var findPrevSelectedOptionIndex = function findPrevSelectedOptionIndex2(index) {
    var matchedOptionIndex = hasSelectedOption() && index > 0 ? ObjectUtils.findLastIndex(visibleOptions.slice(0, index), function(option) {
      return isValidSelectedOption(option);
    }) : -1;
    return matchedOptionIndex > -1 ? matchedOptionIndex : -1;
  };
  var onOptionSelectRange = function onOptionSelectRange2(event) {
    var start = arguments.length > 1 && arguments[1] !== void 0 ? arguments[1] : -1;
    var end = arguments.length > 2 && arguments[2] !== void 0 ? arguments[2] : -1;
    start === -1 && (start = findNearestSelectedOptionIndex(end, true));
    end === -1 && (end = findNearestSelectedOptionIndex(start));
    if (start !== -1 && end !== -1) {
      var rangeStart = Math.min(start, end);
      var rangeEnd = Math.max(start, end);
      var value = visibleOptions.slice(rangeStart, rangeEnd + 1).filter(function(option) {
        return isValidOption(option);
      }).map(function(option) {
        return getOptionValue(option);
      });
      updateModel(event, value);
    }
  };
  var findFirstFocusedOptionIndex = function findFirstFocusedOptionIndex2() {
    var selectedIndex = findFirstSelectedOptionIndex();
    return selectedIndex < 0 ? findFirstOptionIndex() : selectedIndex;
  };
  var findLastFocusedOptionIndex = function findLastFocusedOptionIndex2() {
    var selectedIndex = findLastSelectedOptionIndex();
    return selectedIndex < 0 ? findLastOptionIndex() : selectedIndex;
  };
  var changeFocusedOptionIndex = function changeFocusedOptionIndex2(event, index) {
    if (focusedOptionIndex !== index) {
      setFocusedOptionIndex(index);
      scrollInView();
      if (event && props.selectOnFocus && !props.multiple) {
        onOptionSelect(event, visibleOptions[index]);
      }
    }
  };
  var onArrowDownKey = function onArrowDownKey2(event) {
    var optionIndex = focusedOptionIndex !== -1 ? findNextOptionIndex(focusedOptionIndex) : findFirstFocusedOptionIndex();
    if (props.multiple && event.shiftKey) {
      onOptionSelectRange(event, startRangeIndex, optionIndex);
    }
    changeFocusedOptionIndex(event, optionIndex);
    event.preventDefault();
  };
  var onArrowUpKey = function onArrowUpKey2(event) {
    var optionIndex = focusedOptionIndex !== -1 ? findPrevOptionIndex(focusedOptionIndex) : findLastFocusedOptionIndex();
    if (props.multiple && event.shiftKey) {
      onOptionSelectRange(event, optionIndex, startRangeIndex);
    }
    changeFocusedOptionIndex(event, optionIndex);
    event.preventDefault();
  };
  var onEnterKey = function onEnterKey2(event) {
    if (focusedOptionIndex !== -1) {
      if (props.multiple && event.shiftKey) {
        onOptionSelectRange(event, focusedOptionIndex);
      } else {
        onOptionSelect(event, visibleOptions[focusedOptionIndex]);
      }
    }
    event.preventDefault();
  };
  var onSpaceKey = function onSpaceKey2(event) {
    onEnterKey(event);
  };
  var onShiftKey = function onShiftKey2() {
    setStartRangeIndex(focusedOptionIndex);
  };
  var onHomeKey = function onHomeKey2(event) {
    var pressedInInputText = arguments.length > 1 && arguments[1] !== void 0 ? arguments[1] : false;
    if (pressedInInputText) {
      event.currentTarget.setSelectionRange(0, 0);
      setFocusedOptionIndex(-1);
    } else {
      var metaKey = event.metaKey || event.ctrlKey;
      var optionIndex = findFirstOptionIndex();
      if (props.multiple && event.shiftKey && metaKey) {
        onOptionSelectRange(event, optionIndex, startRangeIndex);
      }
      changeFocusedOptionIndex(event, optionIndex);
    }
    event.preventDefault();
  };
  var onEndKey = function onEndKey2(event) {
    var pressedInInputText = arguments.length > 1 && arguments[1] !== void 0 ? arguments[1] : false;
    if (pressedInInputText) {
      var target = event.currentTarget;
      var len = target.value.length;
      target.setSelectionRange(len, len);
      setFocusedOptionIndex(-1);
    } else {
      var metaKey = event.metaKey || event.ctrlKey;
      var optionIndex = findLastOptionIndex();
      if (props.multiple && event.shiftKey && metaKey) {
        onOptionSelectRange(event, startRangeIndex, optionIndex);
      }
      changeFocusedOptionIndex(event, optionIndex);
    }
    event.preventDefault();
  };
  var onPageUpKey = function onPageUpKey2(event) {
    scrollInView(0);
    event.preventDefault();
  };
  var onPageDownKey = function onPageDownKey2(event) {
    scrollInView(visibleOptions.length - 1);
    event.preventDefault();
  };
  var onListKeyDown = function onListKeyDown2(event) {
    var metaKey = event.metaKey || event.ctrlKey;
    switch (event.code) {
      case "ArrowDown":
        onArrowDownKey(event);
        break;
      case "ArrowUp":
        onArrowUpKey(event);
        break;
      case "Home":
        onHomeKey(event);
        break;
      case "End":
        onEndKey(event);
        break;
      case "PageDown":
        onPageDownKey(event);
        break;
      case "PageUp":
        onPageUpKey(event);
        break;
      case "Enter":
      case "NumpadEnter":
      case "Space":
        onSpaceKey(event);
        event.preventDefault();
        break;
      case "Tab":
        break;
      case "ShiftLeft":
      case "ShiftRight":
        onShiftKey();
        break;
      default:
        if (props.multiple && event.key === "a" && metaKey) {
          var value = visibleOptions.filter(function(option) {
            return isValidOption(option);
          }).map(function(option) {
            return getOptionValue(option);
          });
          updateModel(event, value);
          event.preventDefault();
          break;
        }
        if (!metaKey && ObjectUtils.isPrintableCharacter(event.key)) {
          searchOptions(event, event.key);
          event.preventDefault();
        }
        break;
    }
  };
  var scrollInView = function scrollInView2() {
    var index = arguments.length > 0 && arguments[0] !== void 0 ? arguments[0] : -1;
    setTimeout(function() {
      if (!listRef.current) return;
      var idx = index !== -1 ? "".concat(id.current, "_").concat(index) : focusedOptionId();
      var element = listRef.current.querySelector('li[id="'.concat(idx, '"]'));
      if (element) {
        element.scrollIntoView({
          block: "nearest",
          inline: "nearest",
          behavior: "smooth"
        });
      } else if (props.virtualScrollerOptions) {
        virtualScrollerRef.current && virtualScrollerRef.current.scrollToIndex(index !== -1 ? index : focusedOptionIndex);
      }
    }, 0);
  };
  var onFilter = function onFilter2(event) {
    virtualScrollerRef.current && virtualScrollerRef.current.scrollToIndex(0);
    var originalEvent = event.originalEvent, value = event.value;
    if (props.onFilterValueChange) {
      props.onFilterValueChange({
        originalEvent,
        value
      });
    } else {
      setFilterValueState(value);
    }
  };
  var resetFilter = function resetFilter2() {
    setFilterValueState("");
    props.onFilter && props.onFilter({
      filter: ""
    });
  };
  var autoUpdateModel = function autoUpdateModel2() {
    var isFocus = arguments.length > 0 && arguments[0] !== void 0 ? arguments[0] : focused;
    if (props.selectOnFocus && props.autoOptionFocus && !hasSelectedOption() && !props.multiple && isFocus) {
      var currentFocusOptionIndex = findFirstFocusedOptionIndex();
      onOptionSelect(null, visibleOptions[currentFocusOptionIndex]);
      setFocusedOptionIndex(currentFocusOptionIndex);
    }
  };
  var updateModel = function updateModel2(event, value) {
    if (props.onChange) {
      props.onChange({
        originalEvent: event,
        value,
        stopPropagation: function stopPropagation() {
          event === null || event === void 0 || event.stopPropagation();
        },
        preventDefault: function preventDefault() {
          event === null || event === void 0 || event.preventDefault();
        },
        target: {
          name: props.name,
          id: props.id,
          value
        }
      });
    }
  };
  var removeOption = function removeOption2(option) {
    return props.value.filter(function(val) {
      return !ObjectUtils.equals(val, getOptionValue(option), props.dataKey);
    });
  };
  var getSelectedOptionIndex = function getSelectedOptionIndex2() {
    if (props.value != null && visibleOptions) {
      if (props.optionGroupLabel) {
        for (var i = 0; i < visibleOptions.length; i++) {
          var selectedOptionIndex = findOptionIndexInList(props.value, getOptionGroupChildren(visibleOptions[i]));
          if (selectedOptionIndex !== -1) {
            return {
              group: i,
              option: selectedOptionIndex
            };
          }
        }
      } else {
        return findOptionIndexInList(props.value, visibleOptions);
      }
    }
    return -1;
  };
  var equalityKey = function equalityKey2() {
    return props.optionValue ? null : props.dataKey;
  };
  var findOptionIndexInList = function findOptionIndexInList2(value, list3) {
    var key = equalityKey();
    return list3.findIndex(function(item2) {
      return ObjectUtils.equals(value, getOptionValue(item2), key);
    });
  };
  var isEquals = function isEquals2(value1, value2) {
    return ObjectUtils.equals(value1, value2, equalityKey());
  };
  var isSelected = function isSelected2(option) {
    var optionValue = getOptionValue(option);
    if (props.multiple) {
      return (props.value || []).some(function(value) {
        return isEquals(value, optionValue);
      });
    }
    return isEquals(props.value, optionValue);
  };
  var getOptionLabel = function getOptionLabel2(option) {
    return props.optionLabel ? ObjectUtils.resolveFieldData(option, props.optionLabel) : option && option.label !== void 0 ? option.label : option;
  };
  var getOptionValue = function getOptionValue2(option) {
    return props.optionValue ? ObjectUtils.resolveFieldData(option, props.optionValue) : option && option.value !== void 0 ? option.value : option;
  };
  var getOptionRenderKey = function getOptionRenderKey2(option) {
    return props.dataKey ? ObjectUtils.resolveFieldData(option, props.dataKey) : getOptionLabel(option);
  };
  var isOptionDisabled = function isOptionDisabled2(option) {
    if (props.optionDisabled) {
      return ObjectUtils.isFunction(props.optionDisabled) ? props.optionDisabled(option) : ObjectUtils.resolveFieldData(option, props.optionDisabled);
    }
    return option && option.disabled !== void 0 ? option.disabled : false;
  };
  var onFirstHiddenFocus = function onFirstHiddenFocus2() {
    DomHandler.focus(listRef.current);
    var firstFocusableEl = DomHandler.getFirstFocusableElement(elementRef.current, ':not([data-p-hidden-focusable="true"])');
    lastHiddenFocusableElement.current.tabIndex = DomHandler.isElement(firstFocusableEl) ? void 0 : -1;
    firstHiddenFocusableElement.current.tabIndex = -1;
    changeFocusedOptionIndex(null, 0);
  };
  var onLastHiddenFocus = function onLastHiddenFocus2(event) {
    var relatedTarget = event.relatedTarget;
    if (relatedTarget === listRef.current) {
      var firstFocusableEl = DomHandler.getFirstFocusableElement(elementRef.current, ':not([data-p-hidden-focusable="true"])');
      DomHandler.focus(firstFocusableEl);
      firstHiddenFocusableElement.current.tabIndex = void 0;
    } else {
      DomHandler.focus(firstHiddenFocusableElement.current);
    }
    lastHiddenFocusableElement.current.tabIndex = -1;
  };
  var onListFocus = function onListFocus2() {
    setFocused(true);
    setFocusedOptionIndex(focusedOptionIndex !== -1 ? focusedOptionIndex : props.autoOptionFocus ? findFirstFocusedOptionIndex() : findSelectedOptionIndex());
    autoUpdateModel(true);
  };
  var onListBlur = function onListBlur2() {
    setFocused(false);
    setFocusedOptionIndex(-1);
    setStartRangeIndex(-1);
    setSearchValue("");
  };
  var getOptionGroupRenderKey = function getOptionGroupRenderKey2(optionGroup) {
    return ObjectUtils.resolveFieldData(optionGroup, props.optionGroupLabel);
  };
  var getOptionGroupLabel = function getOptionGroupLabel2(optionGroup) {
    return ObjectUtils.resolveFieldData(optionGroup, props.optionGroupLabel);
  };
  var getOptionGroupChildren = function getOptionGroupChildren2(optionGroup) {
    return ObjectUtils.resolveFieldData(optionGroup, props.optionGroupChildren);
  };
  var flatOptions = function flatOptions2(options) {
    return (options || []).reduce(function(result, option, index) {
      result.push({
        optionGroup: option,
        group: true,
        index,
        code: option.code,
        label: option.label
      });
      var optionGroupChildren = getOptionGroupChildren(option);
      optionGroupChildren && optionGroupChildren.forEach(function(o) {
        return result.push(o);
      });
      return result;
    }, []);
  };
  var getVisibleOptions = function getVisibleOptions2() {
    var options = props.optionGroupLabel ? flatOptions(props.options) : props.options;
    if (hasFilter) {
      var filterValue = filteredValue.trim().toLocaleLowerCase(props.filterLocale);
      var searchFields = props.filterBy ? props.filterBy.split(",") : [props.optionLabel || "label"];
      if (props.optionGroupLabel) {
        var filteredGroups = [];
        var _iterator = _createForOfIteratorHelper(props.options), _step;
        try {
          for (_iterator.s(); !(_step = _iterator.n()).done; ) {
            var optgroup = _step.value;
            var filteredSubOptions = FilterService.filter(getOptionGroupChildren(optgroup), searchFields, filterValue, props.filterMatchMode, props.filterLocale);
            if (filteredSubOptions && filteredSubOptions.length) {
              filteredGroups.push(_objectSpread(_objectSpread({}, optgroup), {
                items: filteredSubOptions
              }));
            }
          }
        } catch (err) {
          _iterator.e(err);
        } finally {
          _iterator.f();
        }
        return flatOptions(filteredGroups);
      }
      return FilterService.filter(options, searchFields, filterValue, props.filterMatchMode, props.filterLocale);
    }
    return options;
  };
  var scrollToSelectedIndex = function scrollToSelectedIndex2() {
    if (virtualScrollerRef.current) {
      var selectedIndex = getSelectedOptionIndex();
      if (selectedIndex !== -1) {
        setTimeout(function() {
          return virtualScrollerRef.current.scrollToIndex(selectedIndex);
        }, 0);
      }
    }
  };
  React.useImperativeHandle(ref, function() {
    return {
      props,
      focus: function focus() {
        return DomHandler.focusFirstElement(elementRef.current);
      },
      getElement: function getElement() {
        return elementRef.current;
      },
      getVirtualScroller: function getVirtualScroller() {
        return virtualScrollerRef.current;
      }
    };
  });
  useMountEffect(function() {
    scrollToSelectedIndex();
    id.current = UniqueComponentId();
  });
  var createHeader = function createHeader2() {
    return props.filter ? /* @__PURE__ */ React.createElement(ListBoxHeader, {
      hostName: "ListBox",
      filter: filteredValue,
      filterIcon: props.filterIcon,
      onFilter,
      resetFilter,
      filterTemplate: props.filterTemplate,
      disabled: props.disabled,
      filterPlaceholder: props.filterPlaceholder,
      filterInputProps: props.filterInputProps,
      ptCallbacks,
      metaData
    }) : null;
  };
  var createItem = function createItem2(option, index) {
    var scrollerOptions = arguments.length > 2 && arguments[2] !== void 0 ? arguments[2] : {};
    var style = {
      height: scrollerOptions.props ? scrollerOptions.props.itemSize : void 0
    };
    if (option.group && option.optionGroup && props.optionGroupLabel) {
      var groupContent = props.optionGroupTemplate ? ObjectUtils.getJSXElement(props.optionGroupTemplate, option, index) : getOptionGroupLabel(option);
      var key = index + "_" + getOptionGroupRenderKey(option);
      var itemGroupProps = mergeProps({
        className: ptCallbacks.cx("itemGroup"),
        style: ptCallbacks.sx("itemGroup", {
          scrollerOptions
        }),
        role: "group"
      }, ptCallbacks.ptm("itemGroup"));
      return /* @__PURE__ */ React.createElement("li", _extends({}, itemGroupProps, {
        key
      }), groupContent);
    }
    var optionLabel = getOptionLabel(option);
    var optionKey = index + "_" + getOptionRenderKey(option);
    var disabled = isOptionDisabled(option);
    return /* @__PURE__ */ React.createElement(ListBoxItem, {
      id: id.current + "_" + index,
      hostName: "ListBox",
      optionKey,
      key: optionKey,
      label: optionLabel,
      index,
      onOptionMouseDown,
      onOptionMouseMove,
      focusedOptionIndex,
      option,
      style,
      template: props.itemTemplate,
      selected: isSelected(option),
      onClick: onOptionSelect,
      onTouchEnd: onOptionTouchEnd,
      disabled,
      ptCallbacks,
      metaData
    });
  };
  var createItems = function createItems2() {
    if (ObjectUtils.isNotEmpty(visibleOptions)) {
      return visibleOptions.map(createItem);
    } else if (hasFilter) {
      return createEmptyMessage(props.emptyFilterMessage, true);
    }
    return createEmptyMessage(props.emptyMessage);
  };
  var createEmptyMessage = function createEmptyMessage2(emptyMessage, isFilter) {
    var emptyMessageProps = mergeProps({
      className: ptCallbacks.cx("emptyMessage")
    }, ptCallbacks.ptm("emptyMessage"));
    var message = ObjectUtils.getJSXElement(emptyMessage, props) || localeOption(isFilter ? "emptyFilterMessage" : "emptyMessage");
    return /* @__PURE__ */ React.createElement("li", emptyMessageProps, message);
  };
  var createList = function createList2() {
    if (props.virtualScrollerOptions) {
      var virtualScrollerProps = _objectSpread(_objectSpread({}, props.virtualScrollerOptions), {
        items: visibleOptions,
        onLazyLoad: function onLazyLoad(event) {
          return props.virtualScrollerOptions.onLazyLoad(_objectSpread(_objectSpread({}, event), {
            filter: visibleOptions
          }));
        },
        itemTemplate: function itemTemplate(item2, options) {
          return item2 && createItem(item2, options.index, options);
        },
        contentTemplate: function contentTemplate(options) {
          var listProps2 = mergeProps(_objectSpread({
            ref: listRef,
            style: ptCallbacks.sx("list", {
              options
            }),
            className: ptCallbacks.cx("list", {
              options
            }),
            role: "listbox",
            tabIndex: "-1",
            "aria-multiselectable": props.multiple,
            onFocus: onListFocus,
            onBlur: onListBlur,
            onKeyDown: onListKeyDown
          }, ariaProps), ptCallbacks.ptm("list"));
          return /* @__PURE__ */ React.createElement("ul", listProps2, options.children);
        }
      });
      return /* @__PURE__ */ React.createElement(VirtualScroller, _extends({
        ref: virtualScrollerRef
      }, virtualScrollerProps, {
        pt: ptCallbacks.ptm("virtualScroller")
      }));
    }
    var items = createItems();
    var listProps = mergeProps(_objectSpread({
      ref: listRef,
      className: ptCallbacks.cx("list"),
      role: "listbox",
      "aria-multiselectable": props.multiple,
      tabIndex: "-1",
      onFocus: onListFocus,
      onBlur: onListBlur,
      onKeyDown: onListKeyDown
    }, ariaProps), ptCallbacks.ptm("list"));
    return /* @__PURE__ */ React.createElement("ul", listProps, items);
  };
  var visibleOptions = getVisibleOptions();
  var hasTooltip = ObjectUtils.isNotEmpty(props.tooltip);
  var otherProps = ListBoxBase.getOtherProps(props);
  var ariaProps = ObjectUtils.reduceKeys(otherProps, DomHandler.ARIA_PROPS);
  var list2 = createList();
  var header = createHeader();
  var wrapperProps = mergeProps({
    className: ptCallbacks.cx("wrapper"),
    style: props.listStyle
  }, ptCallbacks.ptm("wrapper"));
  var rootProps = mergeProps({
    ref: elementRef,
    id: props.id,
    className: ptCallbacks.cx("root"),
    style: props.style
  }, ListBoxBase.getOtherProps(props), ptCallbacks.ptm("root"));
  var hiddenFirstElement = mergeProps({
    ref: firstHiddenFocusableElement,
    role: "presentation",
    "aria-hidden": "true",
    className: "p-hidden-accessible p-hidden-focusable",
    tabIndex: !props.disabled ? props.tabIndex : -1,
    onFocus: onFirstHiddenFocus,
    "data-p-hidden-accessible": true,
    "data-p-hidden-focusable": true
  }, ptCallbacks.ptm("hiddenFirstFocusableEl"));
  var hiddenLastElement = mergeProps({
    ref: lastHiddenFocusableElement,
    role: "presentation",
    "aria-hidden": "true",
    className: "p-hidden-accessible p-hidden-focusable",
    tabIndex: !props.disabled ? props.tabIndex : -1,
    onFocus: onLastHiddenFocus,
    "data-p-hidden-accessible": true,
    "data-p-hidden-focusable": true
  }, ptCallbacks.ptm("hiddenLastFocusableEl"));
  return /* @__PURE__ */ React.createElement(React.Fragment, null, /* @__PURE__ */ React.createElement("div", rootProps, /* @__PURE__ */ React.createElement("span", hiddenFirstElement), header, /* @__PURE__ */ React.createElement("div", wrapperProps, list2), /* @__PURE__ */ React.createElement("span", hiddenLastElement)), hasTooltip && /* @__PURE__ */ React.createElement(Tooltip, _extends({
    target: elementRef,
    content: props.tooltip,
    pt: ptCallbacks.ptm("tooltip")
  }, props.tooltipOptions)));
}));
ListBox.displayName = "ListBox";
export {
  ListBox as default
};
