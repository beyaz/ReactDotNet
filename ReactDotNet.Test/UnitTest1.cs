using System;
using System.IO;
using System.Text.Json;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ReactDotNet.Mixin;

namespace ReactDotNet
{
    [TestClass]
    public class UnitTest1
    {

        class View1 : ReactComponent<SampleModelA>
        {
            public string Prop1 { get; set; } = "PropValue1";
            public string Prop2 { get; set; } = "PropValue2";


            public override Element render()
            {
                return new div("A")
                {
                    text = "b"
                };
            }
        }

        class View2 : ReactComponent<SampleModelA>
        {
            public string Prop1 { get; set; } = "PropValue1";
            public string Prop2 { get; set; } = "PropValue2";

            public override Element render()
            {
                return new div("A")
                {
                    new View1 { Prop1 = "A" }
                };
            }
        }

        static string ReadTestFile(string name)
        {
            return File.ReadAllText(name);
        }

        [TestMethod]
        public void SerializeBasicDiv()
        {
            var div = new div("B");

            var actual = ToJson(div);

            var expected = @"
{
  ""tagName"": ""div"",
  ""className"": ""B"",
  ""reactAttributes"": [
    ""className""
  ]
}
";
            actual.Trim().Should().Be(expected.Trim());
        }

        [TestMethod]
        public void HPanelGravity()
        {
            var div = new HPanel { new div("B") { gravity = 4 }, new div("B") };

            var actual = ToJson(div);

            var expected = @"
{
  ""tagName"": ""div"",
  ""style"": {
    ""alignItems"": ""stretch"",
    ""display"": ""flex"",
    ""flexDirection"": ""row"",
    ""width"": ""100%""
  },
  ""reactAttributes"": [
    ""style""
  ],
  ""children"": [
    {
      ""tagName"": ""div"",
      ""className"": ""B"",
      ""gravity"": 4,
      ""key"": ""0"",
      ""style"": {
        ""width"": ""80%""
      },
      ""reactAttributes"": [
        ""className"",
        ""key"",
        ""style""
      ]
    },
    {
      ""tagName"": ""div"",
      ""className"": ""B"",
      ""key"": ""1"",
      ""style"": {
        ""width"": ""20%""
      },
      ""reactAttributes"": [
        ""className"",
        ""key"",
        ""style""
      ]
    }
  ]
}
";
            actual.Trim().Should().Be(expected.Trim());
        }


        [TestMethod]
        public void SerializeComponentWithProperties()
        {
            

            var state = new SampleModelAContainer();

            var div = new div("abc")
            {
                new div("B"),
                new div("C")
                {
                    style = { paddingLeft = "5px" }
                },
                new img { src                    = "a.png", width = 3, onClick = onClicked },
                new PrimeReact.InputText { value = "abc" },
                new PrimeReact.InputText { valueBind = ()=> state.InnerA.InnerB.Text },
                new View2 { Prop1                = "x", Prop2 = "y" }
            };

            var actual = ToJson(div);

            var expected = ReadTestFile("SerializeComponentWithProperties.txt");
            actual.Trim().Should().Be(expected.Trim());
        }


        


        [Serializable]
        public class SampleModelAContainer
        {
            public string Text { get; set; }
            public SampleModelA InnerA { get; set; }
        }

        [Serializable]
        public class SampleModelA
        {
            public string Text { get; set; }
            public SampleModelB InnerB { get; set; }
        }

        [Serializable]
        public class SampleModelB
        {
            public string Text { get; set; }
        }

        [Serializable]
        public class SampleModel
        {
            public int ClickCount { get; set; }
            public int Id { get; set; }
            public string Text { get; set; }
            public int DropdownSelectedValue { get; set; }


        }


        [TestMethod]
        public void Deserialize()
        {
            var json  = "{\r\n\"ClickCount\": 2}";
            var state = (SampleModel)JsonSerializer.Deserialize(json, typeof(SampleModel), new JsonSerializerOptions().ModifyForReactDotNet());

            state.ClickCount.Should().Be(2);
        }

        void onClicked()
        {

        }



    }
}
