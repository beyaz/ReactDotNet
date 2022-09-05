﻿namespace ReactWithDotNet.StateTests.PropSerializationTests;

class ModelA
{
    public string StateValueA { get; set; }
    
    public int ClickCount { get; set; }

}

class ComponentA : ReactComponent<ModelA>
{
    public string A_Prop_1 { get; set; }

    public string A_Prop_2 { get; set; }


    

    protected override void constructor()
    {
        state = new ModelA { StateValueA = "A" };
    }

    protected override Element render()
    {
        return new div
        {
            style =
            {
                border     = "1px solid blue", 
                padding = "20px"
            },
            text    = "state.A: " + state.StateValueA + ", state.ClickCount: "+ state.ClickCount + ", A_Prop_1:"+ A_Prop_1 + ", A_Prop_2:"+ A_Prop_2,
            onClick = _ => state.ClickCount++,
        };
    }
}

class ModelB
{
    public string StateValueB { get; set; }
    public int ClickCount { get; set; }
}

class ComponentB : ReactComponent<ModelB>
{
    public string B_Prop_1 { get; set; }

    public string B_Prop_2 { get; set; }

    public bool ShouldContainsA { get; set; }
   

    protected override void constructor()
    {
        state = new ModelB { StateValueB = "B" };
    }

    protected override Element render()
    {
        if (ShouldContainsA)
        {
            return new div
            {
                new div
                {
                    style =
                    {
                        border  = "1px solid green",
                        padding = "10px"
                    },
                    children =
                    {
                        new ComponentA { A_Prop_1 = "p1AInB", A_Prop_2 = "p2AInB" }
                    }
                }
            };
        }
        return new div
        {
            style =
            {
                border  = "1px solid red",
                padding = "20px"
            },
            text    = "state.B: " + state.StateValueB + ", state.ClickCount: " + state.ClickCount + ", B_Prop_1:" + B_Prop_1 + ", B_Prop_2:" + B_Prop_2,
            onClick = _ => state.ClickCount++,
        };
    }
}

class RedBorderModel
{
    public int BorderWidth { get; set; } = 5;
}

class RedBorder:ReactComponent<RedBorderModel>
{
    protected override void constructor()
    {
        state = new RedBorderModel();
    }

    protected override Element render()
    {
        return new div
        {
            style    = { border = state.BorderWidth + "px solid red" },
            Children = children,

            onClick = _ => state.BorderWidth++
        };
    }
}

class ModelContainer1
{
    public int ClickCount { get; set; }
}

class Container1 : ReactComponent<ModelContainer1>
{
    protected override void constructor()
    {
        state = new ModelContainer1();
    }

    protected override Element render()
    {
        return new div
        {
            style = 
            {  
                border = "1px solid green",
                padding        = "20px" 
            },
            children =
            {
                new div
                {
                    new ComponentA{A_Prop_1 = "A_Prop_1", A_Prop_2 = "A_Prop_2"},
                    new div{text            = state.ClickCount.ToString()},
                    new div{text            = state.ClickCount.ToString()},
                    new div
                    {
                        new div
                        {
                            new div(),
                            new div(),
                            new div(),
                            new div(),
                            new div(),
                            new ComponentB{B_Prop_1 = "B_Prop_1", B_Prop_2 = "B_Prop_2"},
                            new div(),
                            new div(),
                            new div(),
                            new ComponentB{B_Prop_1 = "B_Prop_1", B_Prop_2 = "B_Prop_2"},
                            new div(),
                            new div
                            {
                                new ComponentB{B_Prop_1 = "B_Prop_1", B_Prop_2 = "B_Prop_2", ShouldContainsA = true}
                            }
                            
                        }
                    }
                }
              
            },
            onClick = _ => state.ClickCount++
        };
    }
}


/*
 https://jsfiddle.net/boilerplate/react-jsx

class ComponentA extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = { StateValueA: "A", ClickCount: 0 };

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() 
    {
        this.setState({ClickCount: this.state.ClickCount + 1});
    }
    
    render()
    {
        return (
          <div style={{ border : "1px solid blue", padding: "20px" }} onClick={this.handleClick}>
              { "state.A:"+ this.state.StateValueA 
              + "state.ClickCount:" +this.state.ClickCount 
              + " A_Prop_1:" + this.props.A_Prop_1 
              + " A_Prop_2:" + this.props.A_Prop_2}
          </div>
        );        
    }
}

class ComponentB extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = { StateValueB: "B", ClickCount: 0 };

        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() 
    {
        this.setState({ClickCount: this.state.ClickCount + 1});
    }
    
    render()
    {
         return (
          <div style={{ border : "1px solid red", padding: "20px" }} onClick={this.handleClick}>
              { "state.B:"+ this.state.StateValueB 
              + "state.ClickCount:" +this.state.ClickCount 
              + " B_Prop_1:" + this.props.B_Prop_1 
              + " B_Prop_2:" + this.props.B_Prop_2}
          </div>
        );         
    }
}

class Container extends React.Component
{
    constructor(props) 
    {
        super(props);

        this.state = {  };

    }
    
    render()
    {
        return (
          <div style={{ display: "flex" }} >
              <ComponentA   A_Prop_1='propA' A_Prop_2 = 'propA2'/>
              <ComponentB   B_Prop_1='propB' B_Prop_2 = 'propB2'/>
          </div>
        );        
    }
}


ReactDOM.render(<Container />, document.querySelector("#app"))



 */