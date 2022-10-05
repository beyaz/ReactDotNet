﻿namespace ReactWithDotNet.CallParentHandlerTest;

class ModelA
{
    public string PropA { get; set; }
    
    public int ClickCount { get; set; }
}

class ComponentA : ReactComponent<ModelA>
{
    protected override void constructor()
    {
        state = new ModelA { PropA = "A" };
    }

    [React]
    public Action<int> OnCountMod3 { get; set; }

   

    protected override Element render()
    {
        return new div
        {
            style =
            {
                width     = "200px",
                height    = "100px",
                border    = "1px solid blue", 
                textAlign = "center",
                padding   = "50px"
            },
            innerText    = state.PropA + state.ClickCount,
            onClick      = OnClick,
        };
    }

    
    void OnClick(MouseEvent _)
    {
        state.ClickCount++;

        if (state.ClickCount % 3 == 0)
        {
            this.FireEvent(nameof(OnCountMod3), OnCountMod3, state.ClickCount);
           
        }
    }
}

class ModelB
{
    public string PropB { get; set; }
    
    public int ClickCount { get; set; }
}

class ComponentB : ReactComponent<ModelB>
{
   

    protected override void constructor()
    {
        state = new ModelB { PropB = "B" };
    }

    protected override Element render()
    {
        return new div
        {
            style     = { 
                width = "250px", 
                height = "150px", 
                border = "1px solid brown", 
                textAlign = "center", 
                padding = "50px"
            },
            innerText = state.PropB + state.ClickCount,
            onClick   = _ => state.ClickCount++
        };
    }
}

class ContainerModel
{
    public int ClickCount { get; set; }
    public string CalledFromChild { get; set; } = "Waiting";
}
class Container : ReactComponent<ContainerModel>
{
    protected override Element render()
    {
        return new div
        {
            style = { display = "flex" },
            children =
            {
                new ComponentA{ OnCountMod3 = OnCountMod3},
                new ComponentB(),
                new div{text = state.CalledFromChild}
            }
        };
    }
    

    void OnCountMod3(int arg1)
    {
        state.CalledFromChild = "Called:" + arg1;

    }
}


/*
 https://jsfiddle.net/boilerplate/react-jsx

class ComponentA extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = { PropA: "A", ClickCount: 0 };

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() 
    {
        this.setState({ClickCount: this.state.ClickCount + 1});
    }
    
    render()
    {
        return (
          <div style={{ width: "200px", height : "100px", border : "1px solid blue", textAlign : "center", paddingTop: "20px" }} onClick={this.handleClick}>
              {this.state.PropA + this.state.ClickCount}
          </div>
        );        
    }
}

class ComponentB extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = { PropB: "B", ClickCount: 0 };

        this.handleClick = this.handleClick.bind(this);

console.log("B created");
    }

    handleClick() 
    {
        this.setState({ClickCount: this.state.ClickCount + 1});
    }
    
    render()
    {
        return (
          <div style={{ width: "250px", height : "150px", border : "1px solid blue", textAlign : "center", paddingTop: "40px" }} onClick={this.handleClick}>
              {this.state.PropB + this.state.ClickCount}
          </div>
        );        
    }
}



class Container extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = { Container1Text: "Container1Text", ClickCount: 0 };

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() 
    {
        this.setState({ClickCount: this.state.ClickCount + 1});
    }
        
    render()
    {
        return (
          <div style={{ display: "flex" }} onClick={this.handleClick}>
              <ComponentA />
              { this.state.ClickCount % 3 === 0 ? null :  <ComponentB /> }
          </div>
        );        
    }
}



ReactDOM.render(<Container />, document.querySelector("#app"))


 */