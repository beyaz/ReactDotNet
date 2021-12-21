using System;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        class View2:ReactComponent<SampleModelA>
        {
            public string Prop1 { get; set; } = "PropValue1";
            public string Prop2 { get; set; } = "PropValue2";

            public override Element render()
            {
                return new div("A")
                {
                   new View1{ Prop1 = "A"}
                };
            }
        }

        [TestMethod]
        public void SerializeComponentWithProperties()
        {
            var view = new View2();

            var div = new div("abc")
            {
                new div("B"),
                new div("C")
                {
                    style = { PaddingLeft = "5px"}
                },
                new img{ src = "a.png", width = 3},
                new PrimeReact.InputText{ value = "abc"},
                new View2{ Prop1 = "x", Prop2 = "y"}
            };

            var actual = ToJson(div);

            var expected = @"
{
  ""tag"": ""div"",
  ""className"": ""abc"",
  ""reactAttributes"": [
    ""className""
  ],
  ""children"": [
    {
      ""tag"": ""div"",
      ""className"": ""B"",
      ""reactAttributes"": [
        ""className""
      ]
    },
    {
      ""tag"": ""div"",
      ""className"": ""C"",
      ""style"": {
        ""paddingLeft"": ""5px""
      },
      ""reactAttributes"": [
        ""className"",
        ""style""
      ]
    },
    {
      ""src"": ""a.png"",
      ""width"": 3,
      ""height"": 0,
      ""tag"": ""img"",
      ""reactAttributes"": [
        ""src"",
        ""width"",
        ""height""
      ]
    },
    {
      ""value"": ""abc"",
      ""jsLocation"": [
        ""primereact"",
        ""InputText""
      ],
      ""reactAttributes"": [
        ""value""
      ]
    },
    {
      ""prop1"": ""x"",
      ""prop2"": ""y"",
      ""rootElement"": {
        ""tag"": ""div"",
        ""className"": ""A"",
        ""reactAttributes"": [
          ""className""
        ],
        ""children"": [
          {
            ""prop1"": ""A"",
            ""prop2"": ""PropValue2"",
            ""rootElement"": {
              ""tag"": ""div"",
              ""className"": ""A"",
              ""text"": ""b"",
              ""reactAttributes"": [
                ""className""
              ]
            },
            ""fullName"": ""ReactDotNet.UnitTest1\u002BView1,ReactDotNet.Test""
          }
        ]
      },
      ""fullName"": ""ReactDotNet.UnitTest1\u002BView2,ReactDotNet.Test""
    }
  ]
}
";
            actual.Trim().Should().Be(expected.Trim());
        }


        [TestMethod]
        public void BindingPath()
        {
            var state = new SampleModelAContainer();

            var result = ToJson(Bind(() => state.InnerA.InnerB.Text));

            result.Should().Be(@"""innerA.innerB.text""".Trim());
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
            var json  = "{\r\n\"clickCount\": 2}";
            var state = (SampleModel)JsonSerializer.Deserialize(json, typeof(SampleModel), new JsonSerializerOptions().ModifyForReactDotNet());

            state.ClickCount.Should().Be(2);
        }

        void onClicked()
        {

        }

        [TestMethod]
        public void ActionSerialization()
        {
            ReactElement model = new button
            {
                text = "Aloha",
                onClick = onClicked
            };

            var result = JsonSerializer.Serialize(model, (new JsonSerializerOptions()).ModifyForReactDotNet());

            result.Should().Be(@"
{
  ""tag"": ""button"",
  ""text"": ""Aloha"",
  ""props"": {
    ""onClick"": ""$remote$onClicked"",
    ""style"": {}
  },
  ""children"": []
}
".Trim());
        }

        [TestMethod]
        public void TestMethod1()
        {
            ReactElement model = new div("C4")
            {
                text = "Aloha",
                style =
                {
                    AlignContent = AlignContent.FlexStart,
                    Width        = "5px",
                    Display      = Display.Flex,
                    
                    
                }
            };

            var result = JsonSerializer.Serialize(model,(new JsonSerializerOptions()).ModifyForReactDotNet());

            result.Should().Be(@"
{
  ""tag"": ""div"",
  ""text"": ""Aloha"",
  ""props"": {
    ""className"": ""C4"",
    ""style"": {
      ""display"": ""flex"",
      ""width"": ""5px"",
      ""alignContent"": ""flex-start""
    }
  },
  ""children"": []
}
".Trim());
        }
    }
}
