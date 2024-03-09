using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReactWithDotNet.Test;

[TestClass]
public class DelegatePropertyTest
{
    class MyComponent : Component
    {

        public Func<string,Task> SampleDelegateProperty1 { get; set; }
        
    }
    
    [TestMethod]
    public void CreationTest()
    {
        
        MyComponent myComponent = new MyComponent();

        var propertyValue = DelegatePropertyHelper.ReCalculatePropertyValue(myComponent, typeof(MyComponent).GetProperty(nameof(myComponent.SampleDelegateProperty1)));

        var delegateFunc = (Func<string, Task>)propertyValue;

        delegateFunc("abC");

        myComponent.Client.TaskList.Count.Should().Be(1);
    }
}