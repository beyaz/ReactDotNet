
(function (global, React)
{
    var createElement = React.createElement;

    function OnReady(callback)
    {
        document.addEventListener('DOMContentLoaded', callback);
    }

    function IterateObject(obj, fn)
    {
        for (var key in obj)
        {
            if (obj.hasOwnProperty(key))
            {
                fn(key, obj[key]);
            }
        }
    }

    function GetValueInPath(obj, steps)
    {
        var len = steps.length;

        for (var i = 0; i < len; i++)
        {
            if (obj == null)
            {
                throw 'Path is not read. Path:' + steps.join('.');
            }

            obj = obj[steps[i]];
        }

        return obj;
    }

    function SetValueInPath(obj, steps, value)
    {
        if (obj == null)
        {
            throw Error('SetValueInPath->' + value);
        }

        var len = steps.length;

        for (var i = 0; i < len; i++)
        {
            var step = steps[i];

            if (obj[step] == null)
            {
                obj[step] = {};
            }

            if (i === len - 1)
            {
                obj[step] = value;
            }
            else
            {
                obj = obj[step];
            }
        }
    }
    
    function NotNull(value)
    {
        if (value == null)
        {
            throw Error('value cannot be null.');
        }

        return value;
    }

    function NotFrozen(value)
    {
        if (Object.isFrozen(value))
        {
            throw Error('value cannot be frozen.');
        }

        return value;
    }

    

    function Clone(obj)
    {
        return JSON.parse(JSON.stringify(obj));
    }

    function ConvertToReactElement(jsonNode, component)
    {
        // is ReactDotNet component
        if (jsonNode.fullName)
        {
            var cmp = DefineComponent(jsonNode);

            return createElement(cmp, {key: NotNull(jsonNode.key)});
        }

        var i;

        var reactAttributes = jsonNode.reactAttributes;

        var reactAttributesLength = 0;

        var props = null;

        if (reactAttributes)
        {
            reactAttributesLength = reactAttributes.length;
        }

        if (reactAttributesLength > 0)
        {
            props = {};
        }

        var constructorFunction = jsonNode.tagName;
        if (jsonNode.jsLocation)
        {
            constructorFunction = GetValueInPath(window, jsonNode.jsLocation);
        }

        var children = jsonNode.children;

        var childrenLength = 0;
        if (children)
        {
            childrenLength = children.length;
        }

        // collect props

        function tryProcessAsEventHandler(propName)
        {
            var value = jsonNode[propName];
            if (value.$isRemoteMethod === true)
            {
                var remoteMethodName = value.remoteMethodName;

                props[propName] = function ()
                {
                    HandleAction({ remoteMethodName: remoteMethodName, component: component, eventArguments: Array.prototype.slice.call(arguments) });
                }

                return true;
            }

            return false;
        }

        function tryProcessAsElement(propName)
        {
            var value = jsonNode[propName];
            if (value.$isElement === true)
            {
                props[propName] = ConvertToReactElement(value.Element, component);

                return true;
            }

            return false;
        }

        function IfNull(value, defaultValue)
        {
            if (defaultValue === undefined)
            {
                return value;
            }

            if (value == null)
            {
                return defaultValue;
            }

            return value;
        }

        function tryProcessAsBinding(propName)
        {
            /*
            "valueBind": {
                "eventName": "onChange",
                "$isBinding": true,
                "jsValueAccess": ["e","target","value"],
                "sourcePath": ["innerA","innerB","text"],
                "targetProp": "value"
              }
             */

            var value = jsonNode[propName];

            if (value.$isBinding === true)
            {
                var targetProp    = value.targetProp;
                var eventName     = value.eventName;
                var sourcePath    = value.sourcePath;
                var jsValueAccess = value.jsValueAccess;
                var defaultValue  = value.defaultValue;

                props[targetProp] = IfNull(GetValueInPath(component.state.$state, sourcePath), defaultValue);
                props[eventName] = function (e)
                {
                    var state = component.$stateAsJsProperty;

                    SetValueInPath(state, sourcePath, IfNull(GetValueInPath({ e: e }, jsValueAccess)), defaultValue);

                    component.setState({ $state: Clone(state) });
                }

                return true;
            }

            return false;
        }

        for (i = 0; i < reactAttributesLength; i++)
        {
            var propName = reactAttributes[i];

            var isProcessedAsEvent = tryProcessAsEventHandler(propName);
            if (isProcessedAsEvent)
            {
                continue;
            }

            var isProcessedAsBinding = tryProcessAsBinding(propName);
            if (isProcessedAsBinding)
            {
                continue;
            }

            var processedAsTemplate = tryProcessAsElement(propName);
            if (processedAsTemplate)
            {
                continue;
            }
            

            if (name.indexOf('bind$') === 0)
            {
                continue;
            }

            props[propName] = jsonNode[propName];
        }

        if (jsonNode.text != null)
        {
            return createElement(constructorFunction, props, jsonNode.text);
        }

        if (childrenLength > 0)
        {
            var newChildren = [];

            for (i = 0; i < childrenLength; i++)
            {
                newChildren.push(ConvertToReactElement(children[i], component));
            }

            return createElement(constructorFunction, props, newChildren);
        }

        return createElement(constructorFunction, props);
    }

    function NormalizeEventArguments(eventArguments)
    {
        function normalizeEventArgument(obj)
        {
            if (typeof obj === 'string')
            {
                return obj;
            }

            if (obj && obj._reactName === 'onClick')
            {
                return null;
            }

            var eventArgument = {};

            var hasArgument = false;
            IterateObject(obj, function (key, value)
            {
                if (key === 'originalEvent')
                {
                    return;
                }

                eventArgument[key] = value;

                hasArgument = true;
            });

            if (hasArgument === false)
            {
                return null;
            }

            return eventArgument;
        }

        var length = eventArguments.length;

        for (var i = 0; i < length; i++)
        {
            eventArguments[i] = normalizeEventArgument(eventArguments[i]);
        }

        if (length === 1)
        {
            if (eventArguments[0] === null)
            {
                return [];
            }
        }

        return eventArguments;
    }

    var GetNextUniqueNumber = (function()
    {
        var nextValue = 0;

        return function()
        {
            return nextValue++;
        }
    })();

    var StateCache = 
    {

    };

    var unAvailableStateIdList = [];

    function CollectStates(component)
    {
        var map = {};

        map["0"] = component.state.$state;

        visitChilderen(component.$rootJsonNodeForUI, "0");

        console.log("posing states", map);

        return stringifyValuesInMap(map);

        function stringifyValuesInMap(map)
        {
            function modify(key, value)
            {
                unAvailableStateIdList.push(key);
                map[key] = JSON.stringify(value);
            }
            IterateObject(map,modify);

            return map;
        }

        function isComponent(jsonUiNode)
        {
            if (jsonUiNode != null)
            {
                if (jsonUiNode.RootElement != null)
                {
                    if (jsonUiNode.fullName != null)
                    {
                        if (jsonUiNode.state != null)
                        {
                            return true;
                        }
                    }
                } 
            }

            return false;
        }
        
        function visitChilderen(node, path)
        {
            if (node.children == null)
            {
                return;
            }

            for (var i = 0; i < node.children.length; i++)
            {
                var child = node.children[i];

                var location = path + "," + i;

                if(isComponent(child))
                {
                    map[location] = child.state;

                    if (child.UniqueIdForState > 0)
                    {
                        map[location] = StateCache[child.UniqueIdForState];
                    }
                    
                    visitChilderen(child.RootElement, location);
                    
                    continue;
                }

                visitChilderen(child, location);
            }
        }
    }

    function HandleAction(data)
    {
        var remoteMethodName = data.remoteMethodName;
        var component = data.component;
        
        function getStateAsJson()
        {
            var state = component.state.$state;

            var beforePostingState = TryGetComponentAction(component, 'beforePostingState');
            if (beforePostingState)
            {
                state = beforePostingState(Clone(state));
            }

            return JSON.stringify(state);
        }

        var request =
        {
            MethodName: "HandleComponentEvent",

            EventHandlerMethodName: remoteMethodName,
            FullName   : component.constructor.fullName,
            StateAsJson: getStateAsJson(),
            ChildStates: CollectStates(component)
        };

        

        var eventArguments = NormalizeEventArguments(data.eventArguments);

        if (eventArguments.length > 0)
        {
            var length = eventArguments.length;

            for (var i = 0; i < length; i++)
            {
                eventArguments[i] = JSON.stringify(eventArguments[i]);
            }

            request.eventArgumentsAsJsonArray = eventArguments;
        }

        function onSuccess(response)
        {
            if (response.ErrorMessage != null)
            {
                throw response.ErrorMessage;
            }

            var element = JSON.parse(response.ElementAsJsonString);

            console.log("Incoming Element", element);

            function restoreState(onStateReady)
            {
                for (var j = 0; j < unAvailableStateIdList.length; j++)
                {
                    StateCache[unAvailableStateIdList[j]] = null;
                }
                unAvailableStateIdList.length = 0;

                if (!(element.UniqueIdForState > 0))
                {
                    element.UniqueIdForState = data.component.$UniqueIdForState;
                }

                StateCache[element.UniqueIdForState] = element.state;

                data.component.$stateAsJsProperty = element.state;
                data.component.$rootJsonNodeForUI = element.RootElement;

                data.component.setState({
                    $rootNode: Clone(data.component.$rootJsonNodeForUI),
                    $state   : Clone(data.component.$stateAsJsProperty)
                }, onStateReady);
            }

            var clientTask = element.state.ClientTask;
            if (clientTask)
            {
                element.state.ClientTask = null;

                if (clientTask.ComebackWithLastAction)
                {
                    var afterSetState = function()
                    {
                        request.StateAsJson = JSON.stringify(component.state.$state);
                        global.ReactDotNet.SendRequest(request, onSuccess);
                    };

                    restoreState(afterSetState);

                    return;
                }

                if (clientTask.HistoryPushState)
                {
                    window.history.replaceState({}, clientTask.HistoryPushStateTitle, clientTask.HistoryPushStateUrl);
                }
            }

            restoreState();
        }
        global.ReactDotNet.SendRequest(request, onSuccess);
    }

    var componentActions = {};
  
    function GetComponentActionLocation(fullName, actionName)
    {
        return fullName + "$" + actionName;
    }

    function RegisterActionToComponent(parameterObject)
    {
        componentActions[GetComponentActionLocation(parameterObject.typeNameOfComponent, parameterObject.actionName)] = parameterObject.handlerFunction;
    }

    function TryGetComponentAction(component, actionName)
    {
        return componentActions[GetComponentActionLocation(component.fullName, actionName)];
    }

    function TryDispatchComponentAction(component, actionName)
    {
        var fn = TryGetComponentAction(component, actionName);
        if (fn)
        {
            fn(component);
        }
    }

    function DefineComponent(componentDeclaration)
    {
        class NewComponent extends React.Component
        {
            constructor(props)
            {
                super(props||{});

                // register stateId
                {
                    NotFrozen(componentDeclaration);
                    
                    if (!(componentDeclaration.UniqueIdForState > 0))
                    {
                        this.$UniqueIdForState = componentDeclaration.UniqueIdForState = GetNextUniqueNumber();

                        StateCache[componentDeclaration.UniqueIdForState] = componentDeclaration.state;
                    }
                }


                this.$stateAsJsProperty = componentDeclaration.state;
                this.$rootJsonNodeForUI = componentDeclaration.RootElement;

                this.state =
                {
                    $rootNode: Clone(this.$rootJsonNodeForUI),
                    $state   : Clone(this.$stateAsJsProperty)
                };

                this.fullName = componentDeclaration.fullName;
            }

            render()
            {
                NotFrozen(this.$rootJsonNodeForUI);

                return ConvertToReactElement(this.$rootJsonNodeForUI, this);
            }

            componentDidMount()
            {
                TryDispatchComponentAction(this, 'componentDidMount');
            }

            componentWillUnmount()
            {
                TryDispatchComponentAction(this, 'componentWillUnmount');
            }
        }

        NewComponent.fullName = componentDeclaration.fullName;

        return NewComponent;
    }

    function FetchComponent(fullNameOfComponent, callback)
    {
        var request =
        {
            MethodName: "FetchComponent",
            FullName  : fullNameOfComponent
        };

        function onSuccess(response)
        {
            if (response.ErrorMessage != null)
            {
                throw response.ErrorMessage;
            }

            var element = response.Element;

            var component = DefineComponent(element);

            callback(React.createElement(component));
        }
        global.ReactDotNet.SendRequest(request, onSuccess);
    }


    global.ReactDotNet =
    {
        OnReady: OnReady,
        DefineComponent: DefineComponent,
        FetchComponent: FetchComponent,
        RegisterActionToComponent: RegisterActionToComponent,
        HandleAction: HandleAction
    };

})(window,React);


