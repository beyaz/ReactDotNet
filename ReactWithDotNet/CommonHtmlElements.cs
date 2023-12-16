namespace ReactWithDotNet;
/// <summary>
///     Specifies independent, self-contained content.
/// </summary>
public sealed class article : HtmlElement
{
    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public article() { }

    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public article(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public article(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public static implicit operator article(string text) => new() { text = text };

    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public article(Style style) : base(style) { }

    /// <summary>
    ///     Specifies independent, self-contained content.
    /// </summary>
    public article(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<article> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class button : HtmlElement
{
    /// <summary>
    ///     Specifies the type of button. button, reset, submit
    /// </summary>
    [ReactProp]
    public string type { get; set; }

    /// <summary>
    ///     Specifies an initial value for the button
    /// </summary>
    [ReactProp]
    public string value { get; set; }

    /// <summary>
    ///     Specifies that the button should have input focus when the page loads. Only one element in a document can have this attribute.
    /// </summary>
    [ReactProp]
    public string autofocus { get; set; }

    /// <summary>
    ///     Specifies that the button should be disabled. A disabled button cannot be clicked.
    /// </summary>
    [ReactProp]
    public string disabled { get; set; }

    /// <summary>
    ///     Specifies the form that the button is associated with.
    /// </summary>
    [ReactProp]
    public string form { get; set; }

    /// <summary>
    ///     Specifies the URL of the form action when the button is clicked.
    /// </summary>
    [ReactProp]
    public string formaction { get; set; }

    /// <summary>
    ///     Specifies the form encoding method (e.g., application/x-www-form-urlencoded, multipart/form-data) when the button is clicked.
    /// </summary>
    [ReactProp]
    public string formenctype { get; set; }

    /// <summary>
    ///     Specifies the form submission method (e.g., GET, POST) when the button is clicked.
    /// </summary>
    [ReactProp]
    public string formmethod { get; set; }

    /// <summary>
    ///     Specifies that the form should not be validated before submission when the button is clicked.
    /// </summary>
    [ReactProp]
    public string formnovalidate { get; set; }

    /// <summary>
    ///     Specifies a name for the button. The name attribute is used to reference form-data after the form has been submitted, or to reference the element in JavaScript.
    /// </summary>
    [ReactProp]
    public string name { get; set; }

    public button() { }

    public button(params IModifier[] modifiers) : base(modifiers) { }

    public button(Style style) : base(style) { }

    public button(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<button> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     type = <paramref name="value"/>
    /// <br/>
    ///     Specifies the type of button. button, reset, submit
    /// </summary>
    public static HtmlElementModifier Type(string value) => Modify(x => x.type = value);

    /// <summary>
    ///     value = <paramref name="value"/>
    /// <br/>
    ///     Specifies an initial value for the button
    /// </summary>
    public static HtmlElementModifier Value(string value) => Modify(x => x.value = value);

    /// <summary>
    ///     autofocus = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the button should have input focus when the page loads. Only one element in a document can have this attribute.
    /// </summary>
    public static HtmlElementModifier Autofocus(string value) => Modify(x => x.autofocus = value);

    /// <summary>
    ///     disabled = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the button should be disabled. A disabled button cannot be clicked.
    /// </summary>
    public static HtmlElementModifier Disabled(string value) => Modify(x => x.disabled = value);

    /// <summary>
    ///     form = <paramref name="value"/>
    /// <br/>
    ///     Specifies the form that the button is associated with.
    /// </summary>
    public static HtmlElementModifier Form(string value) => Modify(x => x.form = value);

    /// <summary>
    ///     formaction = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL of the form action when the button is clicked.
    /// </summary>
    public static HtmlElementModifier Formaction(string value) => Modify(x => x.formaction = value);

    /// <summary>
    ///     formenctype = <paramref name="value"/>
    /// <br/>
    ///     Specifies the form encoding method (e.g., application/x-www-form-urlencoded, multipart/form-data) when the button is clicked.
    /// </summary>
    public static HtmlElementModifier Formenctype(string value) => Modify(x => x.formenctype = value);

    /// <summary>
    ///     formmethod = <paramref name="value"/>
    /// <br/>
    ///     Specifies the form submission method (e.g., GET, POST) when the button is clicked.
    /// </summary>
    public static HtmlElementModifier Formmethod(string value) => Modify(x => x.formmethod = value);

    /// <summary>
    ///     formnovalidate = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the form should not be validated before submission when the button is clicked.
    /// </summary>
    public static HtmlElementModifier Formnovalidate(string value) => Modify(x => x.formnovalidate = value);

    /// <summary>
    ///     name = <paramref name="value"/>
    /// <br/>
    ///     Specifies a name for the button. The name attribute is used to reference form-data after the form has been submitted, or to reference the element in JavaScript.
    /// </summary>
    public static HtmlElementModifier Name(string value) => Modify(x => x.name = value);

}

public sealed class div : HtmlElement
{
    public div() { }

    public div(params IModifier[] modifiers) : base(modifiers) { }

    public div(string innerText) : base(innerText) {  }

    public static implicit operator div(string text) => new() { text = text };

    public div(Style style) : base(style) { }

    public div(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<div> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Defines a paragraph
/// </summary>
public sealed class p : HtmlElement
{
    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public p() { }

    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public p(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public p(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public static implicit operator p(string text) => new() { text = text };

    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public p(Style style) : base(style) { }

    /// <summary>
    ///     Defines a paragraph
    /// </summary>
    public p(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<p> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Preformatted text
/// </summary>
public sealed class pre : HtmlElement
{
    /// <summary>
    ///     Preformatted text
    /// </summary>
    public pre() { }

    /// <summary>
    ///     Preformatted text
    /// </summary>
    public pre(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Preformatted text
    /// </summary>
    public pre(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Preformatted text
    /// </summary>
    public static implicit operator pre(string text) => new() { text = text };

    /// <summary>
    ///     Preformatted text
    /// </summary>
    public pre(Style style) : base(style) { }

    /// <summary>
    ///     Preformatted text
    /// </summary>
    public pre(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<pre> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Define some text as computer code in a document
/// </summary>
public sealed class code : HtmlElement
{
    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public code() { }

    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public code(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public code(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public static implicit operator code(string text) => new() { text = text };

    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public code(Style style) : base(style) { }

    /// <summary>
    ///     Define some text as computer code in a document
    /// </summary>
    public code(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<code> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Ordered list
/// </summary>
public sealed class ol : HtmlElement
{
    /// <summary>
    ///     Ordered list
    /// </summary>
    public ol() { }

    /// <summary>
    ///     Ordered list
    /// </summary>
    public ol(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Ordered list
    /// </summary>
    public ol(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Ordered list
    /// </summary>
    public static implicit operator ol(string text) => new() { text = text };

    /// <summary>
    ///     Ordered list
    /// </summary>
    public ol(Style style) : base(style) { }

    /// <summary>
    ///     Ordered list
    /// </summary>
    public ol(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<ol> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Unordered (bulleted) list
/// </summary>
public sealed class ul : HtmlElement
{
    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public ul() { }

    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public ul(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public ul(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public static implicit operator ul(string text) => new() { text = text };

    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public ul(Style style) : base(style) { }

    /// <summary>
    ///     Unordered (bulleted) list
    /// </summary>
    public ul(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<ul> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     List item
/// </summary>
public sealed class li : HtmlElement
{
    /// <summary>
    ///     List item
    /// </summary>
    public li() { }

    /// <summary>
    ///     List item
    /// </summary>
    public li(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     List item
    /// </summary>
    public li(string innerText) : base(innerText) {  }

    /// <summary>
    ///     List item
    /// </summary>
    public static implicit operator li(string text) => new() { text = text };

    /// <summary>
    ///     List item
    /// </summary>
    public li(Style style) : base(style) { }

    /// <summary>
    ///     List item
    /// </summary>
    public li(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<li> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h1 : HtmlElement
{
    public h1() { }

    public h1(params IModifier[] modifiers) : base(modifiers) { }

    public h1(string innerText) : base(innerText) {  }

    public static implicit operator h1(string text) => new() { text = text };

    public h1(Style style) : base(style) { }

    public h1(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h1> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h2 : HtmlElement
{
    public h2() { }

    public h2(params IModifier[] modifiers) : base(modifiers) { }

    public h2(string innerText) : base(innerText) {  }

    public static implicit operator h2(string text) => new() { text = text };

    public h2(Style style) : base(style) { }

    public h2(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h2> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h3 : HtmlElement
{
    public h3() { }

    public h3(params IModifier[] modifiers) : base(modifiers) { }

    public h3(string innerText) : base(innerText) {  }

    public static implicit operator h3(string text) => new() { text = text };

    public h3(Style style) : base(style) { }

    public h3(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h3> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h4 : HtmlElement
{
    public h4() { }

    public h4(params IModifier[] modifiers) : base(modifiers) { }

    public h4(string innerText) : base(innerText) {  }

    public static implicit operator h4(string text) => new() { text = text };

    public h4(Style style) : base(style) { }

    public h4(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h4> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h5 : HtmlElement
{
    public h5() { }

    public h5(params IModifier[] modifiers) : base(modifiers) { }

    public h5(string innerText) : base(innerText) {  }

    public static implicit operator h5(string text) => new() { text = text };

    public h5(Style style) : base(style) { }

    public h5(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h5> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class h6 : HtmlElement
{
    public h6() { }

    public h6(params IModifier[] modifiers) : base(modifiers) { }

    public h6(string innerText) : base(innerText) {  }

    public static implicit operator h6(string text) => new() { text = text };

    public h6(Style style) : base(style) { }

    public h6(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<h6> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class header : HtmlElement
{
    public header() { }

    public header(params IModifier[] modifiers) : base(modifiers) { }

    public header(string innerText) : base(innerText) {  }

    public static implicit operator header(string text) => new() { text = text };

    public header(Style style) : base(style) { }

    public header(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<header> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Inline container used to mark up a part of a text, or a part of a document.
/// </summary>
public sealed class span : HtmlElement
{
    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public span() { }

    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public span(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public span(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public static implicit operator span(string text) => new() { text = text };

    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public span(Style style) : base(style) { }

    /// <summary>
    ///     Inline container used to mark up a part of a text, or a part of a document.
    /// </summary>
    public span(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<span> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Superscript text
/// </summary>
public sealed class sup : HtmlElement
{
    /// <summary>
    ///     Superscript text
    /// </summary>
    public sup() { }

    /// <summary>
    ///     Superscript text
    /// </summary>
    public sup(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Superscript text
    /// </summary>
    public sup(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Superscript text
    /// </summary>
    public static implicit operator sup(string text) => new() { text = text };

    /// <summary>
    ///     Superscript text
    /// </summary>
    public sup(Style style) : base(style) { }

    /// <summary>
    ///     Superscript text
    /// </summary>
    public sup(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<sup> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Subscript text
/// </summary>
public sealed class sub : HtmlElement
{
    /// <summary>
    ///     Subscript text
    /// </summary>
    public sub() { }

    /// <summary>
    ///     Subscript text
    /// </summary>
    public sub(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Subscript text
    /// </summary>
    public sub(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Subscript text
    /// </summary>
    public static implicit operator sub(string text) => new() { text = text };

    /// <summary>
    ///     Subscript text
    /// </summary>
    public sub(Style style) : base(style) { }

    /// <summary>
    ///     Subscript text
    /// </summary>
    public sub(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<sub> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Inserted text
/// </summary>
public sealed class ins : HtmlElement
{
    /// <summary>
    ///     Inserted text
    /// </summary>
    public ins() { }

    /// <summary>
    ///     Inserted text
    /// </summary>
    public ins(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Inserted text
    /// </summary>
    public ins(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Inserted text
    /// </summary>
    public static implicit operator ins(string text) => new() { text = text };

    /// <summary>
    ///     Inserted text
    /// </summary>
    public ins(Style style) : base(style) { }

    /// <summary>
    ///     Inserted text
    /// </summary>
    public ins(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<ins> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Deleted text
/// </summary>
public sealed class del : HtmlElement
{
    /// <summary>
    ///     Deleted text
    /// </summary>
    public del() { }

    /// <summary>
    ///     Deleted text
    /// </summary>
    public del(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Deleted text
    /// </summary>
    public del(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Deleted text
    /// </summary>
    public static implicit operator del(string text) => new() { text = text };

    /// <summary>
    ///     Deleted text
    /// </summary>
    public del(Style style) : base(style) { }

    /// <summary>
    ///     Deleted text
    /// </summary>
    public del(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<del> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Smaller text
/// </summary>
public sealed class small : HtmlElement
{
    /// <summary>
    ///     Smaller text
    /// </summary>
    public small() { }

    /// <summary>
    ///     Smaller text
    /// </summary>
    public small(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Smaller text
    /// </summary>
    public small(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Smaller text
    /// </summary>
    public static implicit operator small(string text) => new() { text = text };

    /// <summary>
    ///     Smaller text
    /// </summary>
    public small(Style style) : base(style) { }

    /// <summary>
    ///     Smaller text
    /// </summary>
    public small(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<small> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Marked text
/// </summary>
public sealed class mark : HtmlElement
{
    /// <summary>
    ///     Marked text
    /// </summary>
    public mark() { }

    /// <summary>
    ///     Marked text
    /// </summary>
    public mark(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Marked text
    /// </summary>
    public mark(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Marked text
    /// </summary>
    public static implicit operator mark(string text) => new() { text = text };

    /// <summary>
    ///     Marked text
    /// </summary>
    public mark(Style style) : base(style) { }

    /// <summary>
    ///     Marked text
    /// </summary>
    public mark(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<mark> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Emphasized text
/// </summary>
public sealed class em : HtmlElement
{
    /// <summary>
    ///     Emphasized text
    /// </summary>
    public em() { }

    /// <summary>
    ///     Emphasized text
    /// </summary>
    public em(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Emphasized text
    /// </summary>
    public em(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Emphasized text
    /// </summary>
    public static implicit operator em(string text) => new() { text = text };

    /// <summary>
    ///     Emphasized text
    /// </summary>
    public em(Style style) : base(style) { }

    /// <summary>
    ///     Emphasized text
    /// </summary>
    public em(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<em> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Bold text
/// </summary>
public sealed class b : HtmlElement
{
    /// <summary>
    ///     Bold text
    /// </summary>
    public b() { }

    /// <summary>
    ///     Bold text
    /// </summary>
    public b(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Bold text
    /// </summary>
    public b(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Bold text
    /// </summary>
    public static implicit operator b(string text) => new() { text = text };

    /// <summary>
    ///     Bold text
    /// </summary>
    public b(Style style) : base(style) { }

    /// <summary>
    ///     Bold text
    /// </summary>
    public b(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<b> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Italic text
/// </summary>
public sealed class i : HtmlElement
{
    /// <summary>
    ///     Italic text
    /// </summary>
    public i() { }

    /// <summary>
    ///     Italic text
    /// </summary>
    public i(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Italic text
    /// </summary>
    public i(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Italic text
    /// </summary>
    public static implicit operator i(string text) => new() { text = text };

    /// <summary>
    ///     Italic text
    /// </summary>
    public i(Style style) : base(style) { }

    /// <summary>
    ///     Italic text
    /// </summary>
    public i(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<i> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
/// </summary>
public sealed class u : HtmlElement
{
    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public u() { }

    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public u(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public u(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public static implicit operator u(string text) => new() { text = text };

    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public u(Style style) : base(style) { }

    /// <summary>
    ///     Represents some text that is unarticulated and styled differently from normal text, such as misspelled words or proper names in Chinese text. The content inside is typically displayed with an underline.
    /// </summary>
    public u(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<u> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Important text
/// </summary>
public sealed class strong : HtmlElement
{
    /// <summary>
    ///     Important text
    /// </summary>
    public strong() { }

    /// <summary>
    ///     Important text
    /// </summary>
    public strong(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Important text
    /// </summary>
    public strong(string innerText) : base(innerText) {  }

    /// <summary>
    ///     Important text
    /// </summary>
    public static implicit operator strong(string text) => new() { text = text };

    /// <summary>
    ///     Important text
    /// </summary>
    public strong(Style style) : base(style) { }

    /// <summary>
    ///     Important text
    /// </summary>
    public strong(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<strong> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

/// <summary>
///     Section in a document
/// </summary>
public sealed class section : HtmlElement
{
    /// <summary>
    ///     Section in a document
    /// </summary>
    public section() { }

    /// <summary>
    ///     Section in a document
    /// </summary>
    public section(params IModifier[] modifiers) : base(modifiers) { }

    /// <summary>
    ///     Section in a document
    /// </summary>
    public section(Style style) : base(style) { }

    /// <summary>
    ///     Section in a document
    /// </summary>
    public section(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<section> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class aside : HtmlElement
{
    public aside() { }

    public aside(params IModifier[] modifiers) : base(modifiers) { }

    public aside(Style style) : base(style) { }

    public aside(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<aside> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class fieldset : HtmlElement
{
    public fieldset() { }

    public fieldset(params IModifier[] modifiers) : base(modifiers) { }

    public fieldset(Style style) : base(style) { }

    public fieldset(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<fieldset> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class legend : HtmlElement
{
    public legend() { }

    public legend(params IModifier[] modifiers) : base(modifiers) { }

    public legend(Style style) : base(style) { }

    public legend(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<legend> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class nav : HtmlElement
{
    public nav() { }

    public nav(params IModifier[] modifiers) : base(modifiers) { }

    public nav(Style style) : base(style) { }

    public nav(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<nav> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class main : HtmlElement
{
    public main() { }

    public main(params IModifier[] modifiers) : base(modifiers) { }

    public main(Style style) : base(style) { }

    public main(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<main> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class footer : HtmlElement
{
    public footer() { }

    public footer(params IModifier[] modifiers) : base(modifiers) { }

    public footer(Style style) : base(style) { }

    public footer(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<footer> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class figure : HtmlElement
{
    public figure() { }

    public figure(params IModifier[] modifiers) : base(modifiers) { }

    public figure(Style style) : base(style) { }

    public figure(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<figure> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class hr : HtmlElement
{
    public hr() { }

    public hr(params IModifier[] modifiers) : base(modifiers) { }

    public hr(Style style) : base(style) { }

    public hr(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<hr> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class figcaption : HtmlElement
{
    public figcaption() { }

    public figcaption(params IModifier[] modifiers) : base(modifiers) { }

    public figcaption(string innerText) : base(innerText) {  }

    public static implicit operator figcaption(string text) => new() { text = text };

    public figcaption(Style style) : base(style) { }

    public figcaption(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<figcaption> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class table : HtmlElement
{
    [ReactProp]
    public double? cellSpacing { get; set; }

    [ReactProp]
    public double? cellPadding { get; set; }

    public table() { }

    public table(params IModifier[] modifiers) : base(modifiers) { }

    public table(Style style) : base(style) { }

    public table(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<table> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier CellSpacing(double? value) => Modify(x => x.cellSpacing = value);

    public static HtmlElementModifier CellPadding(double? value) => Modify(x => x.cellPadding = value);

}

public sealed class thead : HtmlElement
{
    public thead() { }

    public thead(params IModifier[] modifiers) : base(modifiers) { }

    public thead(Style style) : base(style) { }

    public thead(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<thead> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class tbody : HtmlElement
{
    public tbody() { }

    public tbody(params IModifier[] modifiers) : base(modifiers) { }

    public tbody(Style style) : base(style) { }

    public tbody(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<tbody> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class tfoot : HtmlElement
{
    public tfoot() { }

    public tfoot(params IModifier[] modifiers) : base(modifiers) { }

    public tfoot(Style style) : base(style) { }

    public tfoot(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<tfoot> modifyAction) => CreateHtmlElementModifier(modifyAction);
}

public sealed class th : HtmlElement
{
    [ReactProp]
    public int? colSpan { get; set; }

    [ReactProp]
    public int? rowSpan { get; set; }

    public th() { }

    public th(params IModifier[] modifiers) : base(modifiers) { }

    public th(Style style) : base(style) { }

    public th(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<th> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier ColSpan(int? value) => Modify(x => x.colSpan = value);

    public static HtmlElementModifier RowSpan(int? value) => Modify(x => x.rowSpan = value);

}

public sealed class td : HtmlElement
{
    [ReactProp]
    public int? colSpan { get; set; }

    [ReactProp]
    public int? rowSpan { get; set; }

    public td() { }

    public td(params IModifier[] modifiers) : base(modifiers) { }

    public td(string innerText) : base(innerText) {  }

    public static implicit operator td(string text) => new() { text = text };

    public td(Style style) : base(style) { }

    public td(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<td> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier ColSpan(int? value) => Modify(x => x.colSpan = value);

    public static HtmlElementModifier RowSpan(int? value) => Modify(x => x.rowSpan = value);

}

public sealed class tr : HtmlElement
{
    [ReactProp]
    public int? colSpan { get; set; }

    [ReactProp]
    public int? rowSpan { get; set; }

    public tr() { }

    public tr(params IModifier[] modifiers) : base(modifiers) { }

    public tr(Style style) : base(style) { }

    public tr(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<tr> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier ColSpan(int? value) => Modify(x => x.colSpan = value);

    public static HtmlElementModifier RowSpan(int? value) => Modify(x => x.rowSpan = value);

}

public sealed class option : HtmlElement
{
    [ReactProp]
    public bool? selected { get; set; }

    [ReactProp]
    public string disabled { get; set; }

    [ReactProp]
    public string value { get; set; }

    public option() { }

    public option(params IModifier[] modifiers) : base(modifiers) { }

    public option(Style style) : base(style) { }

    public option(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<option> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier Selected(bool? value) => Modify(x => x.selected = value);

    public static HtmlElementModifier Disabled(string value) => Modify(x => x.disabled = value);

    public static HtmlElementModifier Value(string value) => Modify(x => x.value = value);

}

public sealed class ellipse : HtmlElement
{
    /// <summary>
    ///     The x-coordinate of the center of the ellipse.
    /// </summary>
    [ReactProp]
    public string cx { get; set; }

    /// <summary>
    ///     The y-coordinate of the center of the ellipse.
    /// </summary>
    [ReactProp]
    public string cy { get; set; }

    /// <summary>
    ///     The radius of the ellipse along the x-axis.
    /// </summary>
    [ReactProp]
    public string rx { get; set; }

    /// <summary>
    ///     The radius of the ellipse along the y-axis.
    /// </summary>
    [ReactProp]
    public string ry { get; set; }

    /// <summary>
    ///     The fill color of the ellipse.
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     The stroke color of the ellipse.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     The width of the stroke.
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    public ellipse() { }

    public ellipse(params IModifier[] modifiers) : base(modifiers) { }

    public ellipse(Style style) : base(style) { }

    public ellipse(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<ellipse> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     cx = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the center of the ellipse.
    /// </summary>
    public static HtmlElementModifier Cx(string value) => Modify(x => x.cx = value);

    /// <summary>
    ///     cy = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the center of the ellipse.
    /// </summary>
    public static HtmlElementModifier Cy(string value) => Modify(x => x.cy = value);

    /// <summary>
    ///     rx = <paramref name="value"/>
    /// <br/>
    ///     The radius of the ellipse along the x-axis.
    /// </summary>
    public static HtmlElementModifier Rx(string value) => Modify(x => x.rx = value);

    /// <summary>
    ///     ry = <paramref name="value"/>
    /// <br/>
    ///     The radius of the ellipse along the y-axis.
    /// </summary>
    public static HtmlElementModifier Ry(string value) => Modify(x => x.ry = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     The fill color of the ellipse.
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     The stroke color of the ellipse.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     The width of the stroke.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

}

public sealed class line : HtmlElement
{
    /// <summary>
    ///     The x-coordinate of the start point of the line.
    /// </summary>
    [ReactProp]
    public string x1 { get; set; }

    /// <summary>
    ///     The y-coordinate of the start point of the line.
    /// </summary>
    [ReactProp]
    public string y1 { get; set; }

    /// <summary>
    ///     The x-coordinate of the end point of the line.
    /// </summary>
    [ReactProp]
    public string x2 { get; set; }

    /// <summary>
    ///     The y-coordinate of the end point of the line.
    /// </summary>
    [ReactProp]
    public string y2 { get; set; }

    /// <summary>
    ///     The stroke (outline) color of the line.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     The width of the line's outline.
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    /// <summary>
    ///     Pattern of dashes and gaps used in the line's stroke.
    /// </summary>
    [ReactProp]
    public string strokeDasharray { get; set; }

    /// <summary>
    ///     The style of the line's endpoints.
    /// </summary>
    [ReactProp]
    public string strokeLinecap { get; set; }

    /// <summary>
    ///     The style of the line's corners.
    /// </summary>
    [ReactProp]
    public string strokeLinejoin { get; set; }

    /// <summary>
    ///     The opacity (transparency) of the line's stroke.
    /// </summary>
    [ReactProp]
    public string strokeOpacity { get; set; }

    public line() { }

    public line(params IModifier[] modifiers) : base(modifiers) { }

    public line(Style style) : base(style) { }

    public line(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<line> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     x1 = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the start point of the line.
    /// </summary>
    public static HtmlElementModifier X1(string value) => Modify(x => x.x1 = value);

    /// <summary>
    ///     y1 = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the start point of the line.
    /// </summary>
    public static HtmlElementModifier Y1(string value) => Modify(x => x.y1 = value);

    /// <summary>
    ///     x2 = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the end point of the line.
    /// </summary>
    public static HtmlElementModifier X2(string value) => Modify(x => x.x2 = value);

    /// <summary>
    ///     y2 = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the end point of the line.
    /// </summary>
    public static HtmlElementModifier Y2(string value) => Modify(x => x.y2 = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     The stroke (outline) color of the line.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     The width of the line's outline.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

    /// <summary>
    ///     strokeDasharray = <paramref name="value"/>
    /// <br/>
    ///     Pattern of dashes and gaps used in the line's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeDasharray(string value) => Modify(x => x.strokeDasharray = value);

    /// <summary>
    ///     strokeLinecap = <paramref name="value"/>
    /// <br/>
    ///     The style of the line's endpoints.
    /// </summary>
    public static HtmlElementModifier StrokeLinecap(string value) => Modify(x => x.strokeLinecap = value);

    /// <summary>
    ///     strokeLinejoin = <paramref name="value"/>
    /// <br/>
    ///     The style of the line's corners.
    /// </summary>
    public static HtmlElementModifier StrokeLinejoin(string value) => Modify(x => x.strokeLinejoin = value);

    /// <summary>
    ///     strokeOpacity = <paramref name="value"/>
    /// <br/>
    ///     The opacity (transparency) of the line's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeOpacity(string value) => Modify(x => x.strokeOpacity = value);

}

public sealed class polyline : HtmlElement
{
    /// <summary>
    ///     A list of points defining the vertices of the polyline.
    /// </summary>
    [ReactProp]
    public string points { get; set; }

    /// <summary>
    ///     The fill color of the polyline.
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     The stroke (outline) color of the polyline.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     The width of the polyline's outline.
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    public polyline() { }

    public polyline(params IModifier[] modifiers) : base(modifiers) { }

    public polyline(Style style) : base(style) { }

    public polyline(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<polyline> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     points = <paramref name="value"/>
    /// <br/>
    ///     A list of points defining the vertices of the polyline.
    /// </summary>
    public static HtmlElementModifier Points(string value) => Modify(x => x.points = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     The fill color of the polyline.
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     The stroke (outline) color of the polyline.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     The width of the polyline's outline.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

}

public sealed class circle : HtmlElement
{
    /// <summary>
    ///     The x-coordinate of the center of the circle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> cx { get; set; }

    /// <summary>
    ///     The y-coordinate of the center of the circle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> cy { get; set; }

    /// <summary>
    ///     The radius of the circle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> r { get; set; }

    /// <summary>
    ///     The fill color of the circle.
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     The stroke color of the circle.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     The width of the stroke of the circle.
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    public circle() { }

    public circle(params IModifier[] modifiers) : base(modifiers) { }

    public circle(Style style) : base(style) { }

    public circle(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<circle> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     cx = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the center of the circle.
    /// </summary>
    public static HtmlElementModifier Cx(UnionProp<string,double> value) => Modify(x => x.cx = value);

    /// <summary>
    ///     cy = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the center of the circle.
    /// </summary>
    public static HtmlElementModifier Cy(UnionProp<string,double> value) => Modify(x => x.cy = value);

    /// <summary>
    ///     r = <paramref name="value"/>
    /// <br/>
    ///     The radius of the circle.
    /// </summary>
    public static HtmlElementModifier R(UnionProp<string,double> value) => Modify(x => x.r = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     The fill color of the circle.
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     The stroke color of the circle.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     The width of the stroke of the circle.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

}

public sealed class polygon : HtmlElement
{
    /// <summary>
    ///     Specifies the coordinates of the polygon's vertices, in (x, y) pairs, separated by commas.
    /// </summary>
    [ReactProp]
    public string points { get; set; }

    /// <summary>
    ///     Specifies the fill color of the polygon.
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     Specifies the stroke color of the polygon.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     Specifies the width of the polygon's stroke, in pixels.
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    /// <summary>
    ///     Specifies the type of line cap used for the polygon's stroke.
    /// </summary>
    [ReactProp]
    public string strokeLinecap { get; set; }

    /// <summary>
    ///     Specifies the type of line join used for the polygon's stroke.
    /// </summary>
    [ReactProp]
    public string strokeLinejoin { get; set; }

    /// <summary>
    ///     Specifies how the polygon is filled.
    /// </summary>
    [ReactProp]
    public string fillRule { get; set; }

    public polygon() { }

    public polygon(params IModifier[] modifiers) : base(modifiers) { }

    public polygon(Style style) : base(style) { }

    public polygon(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<polygon> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     points = <paramref name="value"/>
    /// <br/>
    ///     Specifies the coordinates of the polygon's vertices, in (x, y) pairs, separated by commas.
    /// </summary>
    public static HtmlElementModifier Points(string value) => Modify(x => x.points = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     Specifies the fill color of the polygon.
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     Specifies the stroke color of the polygon.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     Specifies the width of the polygon's stroke, in pixels.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

    /// <summary>
    ///     strokeLinecap = <paramref name="value"/>
    /// <br/>
    ///     Specifies the type of line cap used for the polygon's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeLinecap(string value) => Modify(x => x.strokeLinecap = value);

    /// <summary>
    ///     strokeLinejoin = <paramref name="value"/>
    /// <br/>
    ///     Specifies the type of line join used for the polygon's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeLinejoin(string value) => Modify(x => x.strokeLinejoin = value);

    /// <summary>
    ///     fillRule = <paramref name="value"/>
    /// <br/>
    ///     Specifies how the polygon is filled.
    /// </summary>
    public static HtmlElementModifier FillRule(string value) => Modify(x => x.fillRule = value);

}

public sealed class rect : HtmlElement
{
    /// <summary>
    ///     The x-coordinate of the top-left corner of the rectangle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> x { get; set; }

    /// <summary>
    ///     The y-coordinate of the top-left corner of the rectangle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> y { get; set; }

    /// <summary>
    ///     The width of the rectangle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> width { get; set; }

    /// <summary>
    ///     The height of the rectangle.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> height { get; set; }

    /// <summary>
    ///     The border radius of the rectangle on the horizontal axis.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> rx { get; set; }

    /// <summary>
    ///     The border radius of the rectangle on the vertical axis.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> ry { get; set; }

    /// <summary>
    ///     The fill color of the rectangle.
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     The stroke color of the rectangle.
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     The width of the rectangle's stroke.
    /// </summary>
    [ReactProp]
    public UnionProp<string,double> strokeWidth { get; set; }

    /// <summary>
    ///     The linecap style of the rectangle's stroke.
    /// </summary>
    [ReactProp]
    public string strokeLinecap { get; set; }

    /// <summary>
    ///     The linejoin style of the rectangle's stroke.
    /// </summary>
    [ReactProp]
    public string strokeLinejoin { get; set; }

    public rect() { }

    public rect(params IModifier[] modifiers) : base(modifiers) { }

    public rect(Style style) : base(style) { }

    public rect(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<rect> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     x = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the top-left corner of the rectangle.
    /// </summary>
    public static HtmlElementModifier X(UnionProp<string,double> value) => Modify(x => x.x = value);

    /// <summary>
    ///     y = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the top-left corner of the rectangle.
    /// </summary>
    public static HtmlElementModifier Y(UnionProp<string,double> value) => Modify(x => x.y = value);

    /// <summary>
    ///     width = <paramref name="value"/>
    /// <br/>
    ///     The width of the rectangle.
    /// </summary>
    public static HtmlElementModifier Width(UnionProp<string,double> value) => Modify(x => x.width = value);

    /// <summary>
    ///     height = <paramref name="value"/>
    /// <br/>
    ///     The height of the rectangle.
    /// </summary>
    public static HtmlElementModifier Height(UnionProp<string,double> value) => Modify(x => x.height = value);

    /// <summary>
    ///     rx = <paramref name="value"/>
    /// <br/>
    ///     The border radius of the rectangle on the horizontal axis.
    /// </summary>
    public static HtmlElementModifier Rx(UnionProp<string,double> value) => Modify(x => x.rx = value);

    /// <summary>
    ///     ry = <paramref name="value"/>
    /// <br/>
    ///     The border radius of the rectangle on the vertical axis.
    /// </summary>
    public static HtmlElementModifier Ry(UnionProp<string,double> value) => Modify(x => x.ry = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     The fill color of the rectangle.
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     The stroke color of the rectangle.
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     The width of the rectangle's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeWidth(UnionProp<string,double> value) => Modify(x => x.strokeWidth = value);

    /// <summary>
    ///     strokeLinecap = <paramref name="value"/>
    /// <br/>
    ///     The linecap style of the rectangle's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeLinecap(string value) => Modify(x => x.strokeLinecap = value);

    /// <summary>
    ///     strokeLinejoin = <paramref name="value"/>
    /// <br/>
    ///     The linejoin style of the rectangle's stroke.
    /// </summary>
    public static HtmlElementModifier StrokeLinejoin(string value) => Modify(x => x.strokeLinejoin = value);

}

public sealed class radialGradient : HtmlElement
{
    /// <summary>
    ///     The x-coordinate of the center of the gradient.
    /// </summary>
    [ReactProp]
    public string cx { get; set; }

    /// <summary>
    ///     The y-coordinate of the center of the gradient.
    /// </summary>
    [ReactProp]
    public string cy { get; set; }

    /// <summary>
    ///     The x-coordinate of the focal point of the gradient.
    /// </summary>
    [ReactProp]
    public string fx { get; set; }

    /// <summary>
    ///     The y-coordinate of the focal point of the gradient.
    /// </summary>
    [ReactProp]
    public string fy { get; set; }

    /// <summary>
    ///     The radius of the gradient.
    /// </summary>
    [ReactProp]
    public string r { get; set; }

    /// <summary>
    ///     The method used to spread the gradient.
    /// </summary>
    [ReactProp]
    public string spreadMethod { get; set; }

    /// <summary>
    ///     The units used to specify the gradient.
    /// </summary>
    [ReactProp]
    public string gradientUnits { get; set; }

    /// <summary>
    ///     A transform to apply to the gradient.
    /// </summary>
    [ReactProp]
    public string gradientTransform { get; set; }

    public radialGradient() { }

    public radialGradient(params IModifier[] modifiers) : base(modifiers) { }

    public radialGradient(Style style) : base(style) { }

    public radialGradient(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<radialGradient> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     cx = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the center of the gradient.
    /// </summary>
    public static HtmlElementModifier Cx(string value) => Modify(x => x.cx = value);

    /// <summary>
    ///     cy = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the center of the gradient.
    /// </summary>
    public static HtmlElementModifier Cy(string value) => Modify(x => x.cy = value);

    /// <summary>
    ///     fx = <paramref name="value"/>
    /// <br/>
    ///     The x-coordinate of the focal point of the gradient.
    /// </summary>
    public static HtmlElementModifier Fx(string value) => Modify(x => x.fx = value);

    /// <summary>
    ///     fy = <paramref name="value"/>
    /// <br/>
    ///     The y-coordinate of the focal point of the gradient.
    /// </summary>
    public static HtmlElementModifier Fy(string value) => Modify(x => x.fy = value);

    /// <summary>
    ///     r = <paramref name="value"/>
    /// <br/>
    ///     The radius of the gradient.
    /// </summary>
    public static HtmlElementModifier R(string value) => Modify(x => x.r = value);

    /// <summary>
    ///     spreadMethod = <paramref name="value"/>
    /// <br/>
    ///     The method used to spread the gradient.
    /// </summary>
    public static HtmlElementModifier SpreadMethod(string value) => Modify(x => x.spreadMethod = value);

    /// <summary>
    ///     gradientUnits = <paramref name="value"/>
    /// <br/>
    ///     The units used to specify the gradient.
    /// </summary>
    public static HtmlElementModifier GradientUnits(string value) => Modify(x => x.gradientUnits = value);

    /// <summary>
    ///     gradientTransform = <paramref name="value"/>
    /// <br/>
    ///     A transform to apply to the gradient.
    /// </summary>
    public static HtmlElementModifier GradientTransform(string value) => Modify(x => x.gradientTransform = value);

}

public sealed class clipPath : HtmlElement
{
    /// <summary>
    ///     Specifies the fill rule for the clipping path.
    /// </summary>
    [ReactProp]
    public string clipRule { get; set; }

    /// <summary>
    ///     Specifies the reference box for the clipping path.
    /// </summary>
    [ReactProp]
    public string clipBox { get; set; }

    public clipPath() { }

    public clipPath(params IModifier[] modifiers) : base(modifiers) { }

    public clipPath(Style style) : base(style) { }

    public clipPath(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<clipPath> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     clipRule = <paramref name="value"/>
    /// <br/>
    ///     Specifies the fill rule for the clipping path.
    /// </summary>
    public static HtmlElementModifier ClipRule(string value) => Modify(x => x.clipRule = value);

    /// <summary>
    ///     clipBox = <paramref name="value"/>
    /// <br/>
    ///     Specifies the reference box for the clipping path.
    /// </summary>
    public static HtmlElementModifier ClipBox(string value) => Modify(x => x.clipBox = value);

}

public sealed class path : HtmlElement
{
    /// <summary>
    ///     Path data
    /// </summary>
    [ReactProp]
    public string d { get; set; }

    /// <summary>
    ///     Fill color
    /// </summary>
    [ReactProp]
    public string fill { get; set; }

    /// <summary>
    ///     Stroke color
    /// </summary>
    [ReactProp]
    public string stroke { get; set; }

    /// <summary>
    ///     Stroke width
    /// </summary>
    [ReactProp]
    public string strokeWidth { get; set; }

    [ReactProp]
    public string fillRule { get; set; }

    [ReactProp]
    public string clipRule { get; set; }

    [ReactProp]
    public string strokeLinecap { get; set; }

    [ReactProp]
    public string strokeLinejoin { get; set; }

    public path() { }

    public path(params IModifier[] modifiers) : base(modifiers) { }

    public path(Style style) : base(style) { }

    public path(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<path> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     d = <paramref name="value"/>
    /// <br/>
    ///     Path data
    /// </summary>
    public static HtmlElementModifier D(string value) => Modify(x => x.d = value);

    /// <summary>
    ///     fill = <paramref name="value"/>
    /// <br/>
    ///     Fill color
    /// </summary>
    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

    /// <summary>
    ///     stroke = <paramref name="value"/>
    /// <br/>
    ///     Stroke color
    /// </summary>
    public static HtmlElementModifier Stroke(string value) => Modify(x => x.stroke = value);

    /// <summary>
    ///     strokeWidth = <paramref name="value"/>
    /// <br/>
    ///     Stroke width
    /// </summary>
    public static HtmlElementModifier StrokeWidth(string value) => Modify(x => x.strokeWidth = value);

    public static HtmlElementModifier FillRule(string value) => Modify(x => x.fillRule = value);

    public static HtmlElementModifier ClipRule(string value) => Modify(x => x.clipRule = value);

    public static HtmlElementModifier StrokeLinecap(string value) => Modify(x => x.strokeLinecap = value);

    public static HtmlElementModifier StrokeLinejoin(string value) => Modify(x => x.strokeLinejoin = value);

}

public sealed class g : HtmlElement
{
    [ReactProp]
    public string opacity { get; set; }

    [ReactProp]
    public string clipPath { get; set; }

    [ReactProp]
    public string transform { get; set; }

    public g() { }

    public g(params IModifier[] modifiers) : base(modifiers) { }

    public g(Style style) : base(style) { }

    public g(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<g> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier Opacity(string value) => Modify(x => x.opacity = value);

    public static HtmlElementModifier ClipPath(string value) => Modify(x => x.clipPath = value);

    public static HtmlElementModifier Transform(string value) => Modify(x => x.transform = value);

}

public sealed class mask : HtmlElement
{
    /// <summary>
    ///     This attribute defines the height of the masking area. Value type: length ; Default value: 120%; Animatable: yes
    /// </summary>
    [ReactProp]
    public string height { get; set; }

    /// <summary>
    ///     This attribute defines the coordinate system for the contents of the mask. Value type: userSpaceOnUse|objectBoundingBox ; Default value: userSpaceOnUse; Animatable: yes
    /// </summary>
    [ReactProp]
    public string maskContentUnits { get; set; }

    /// <summary>
    ///     This attribute defines the coordinate system for attributes x, y, width and height on the mask. Value type: userSpaceOnUse|objectBoundingBox ; Default value: objectBoundingBox; Animatable: yes
    /// </summary>
    [ReactProp]
    public string maskUnits { get; set; }

    /// <summary>
    ///     This attribute defines the x-axis coordinate of the top-left corner of the masking area. Value type: 'coordinate' ; Default value: -10%; Animatable: yes
    /// </summary>
    [ReactProp]
    public string x { get; set; }

    /// <summary>
    ///     This attribute defines the y-axis coordinate of the top-left corner of the masking area. Value type: 'coordinate' ; Default value: -10%; Animatable: yes
    /// </summary>
    [ReactProp]
    public string y { get; set; }

    /// <summary>
    ///     This attribute defines the width of the masking area. Value type: 'length' ; Default value: 120%; Animatable: yes
    /// </summary>
    [ReactProp]
    public string width { get; set; }

    public mask() { }

    public mask(params IModifier[] modifiers) : base(modifiers) { }

    public mask(Style style) : base(style) { }

    public mask(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<mask> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     height = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the height of the masking area. Value type: length ; Default value: 120%; Animatable: yes
    /// </summary>
    public static HtmlElementModifier Height(string value) => Modify(x => x.height = value);

    /// <summary>
    ///     maskContentUnits = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the coordinate system for the contents of the mask. Value type: userSpaceOnUse|objectBoundingBox ; Default value: userSpaceOnUse; Animatable: yes
    /// </summary>
    public static HtmlElementModifier MaskContentUnits(string value) => Modify(x => x.maskContentUnits = value);

    /// <summary>
    ///     maskUnits = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the coordinate system for attributes x, y, width and height on the mask. Value type: userSpaceOnUse|objectBoundingBox ; Default value: objectBoundingBox; Animatable: yes
    /// </summary>
    public static HtmlElementModifier MaskUnits(string value) => Modify(x => x.maskUnits = value);

    /// <summary>
    ///     x = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the x-axis coordinate of the top-left corner of the masking area. Value type: 'coordinate' ; Default value: -10%; Animatable: yes
    /// </summary>
    public static HtmlElementModifier X(string value) => Modify(x => x.x = value);

    /// <summary>
    ///     y = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the y-axis coordinate of the top-left corner of the masking area. Value type: 'coordinate' ; Default value: -10%; Animatable: yes
    /// </summary>
    public static HtmlElementModifier Y(string value) => Modify(x => x.y = value);

    /// <summary>
    ///     width = <paramref name="value"/>
    /// <br/>
    ///     This attribute defines the width of the masking area. Value type: 'length' ; Default value: 120%; Animatable: yes
    /// </summary>
    public static HtmlElementModifier Width(string value) => Modify(x => x.width = value);

}

public sealed class meta : HtmlElement
{
    /// <summary>
    ///     Specifies the character encoding of the document.
    /// </summary>
    [ReactProp]
    public string charset { get; set; }

    /// <summary>
    ///     Specifies the name of the HTTP header that the meta tag should be equivalent to.
    /// </summary>
    [ReactProp]
    public string httpEquiv { get; set; }

    /// <summary>
    ///     Specifies the name of the metadata property.
    /// </summary>
    [ReactProp]
    public string name { get; set; }

    /// <summary>
    ///     Specifies the value of the metadata property.
    /// </summary>
    [ReactProp]
    public string content { get; set; }

    /// <summary>
    ///     Specifies the URL scheme for the content attribute of the meta tag.
    /// </summary>
    [ReactProp]
    public string scheme { get; set; }

    /// <summary>
    ///     Specifies the Microdata item property that the meta tag represents.
    /// </summary>
    [ReactProp]
    public string itemprop { get; set; }

    /// <summary>
    ///     Specifies the schema.org property that the meta tag represents.
    /// </summary>
    [ReactProp]
    public string property { get; set; }

    /// <summary>
    ///     Specifies the URL for a resource associated with the meta tag.
    /// </summary>
    [ReactProp]
    public string src { get; set; }

    public meta() { }

    public meta(params IModifier[] modifiers) : base(modifiers) { }

    public meta(Style style) : base(style) { }

    public meta(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<meta> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     charset = <paramref name="value"/>
    /// <br/>
    ///     Specifies the character encoding of the document.
    /// </summary>
    public static HtmlElementModifier Charset(string value) => Modify(x => x.charset = value);

    /// <summary>
    ///     httpEquiv = <paramref name="value"/>
    /// <br/>
    ///     Specifies the name of the HTTP header that the meta tag should be equivalent to.
    /// </summary>
    public static HtmlElementModifier HttpEquiv(string value) => Modify(x => x.httpEquiv = value);

    /// <summary>
    ///     name = <paramref name="value"/>
    /// <br/>
    ///     Specifies the name of the metadata property.
    /// </summary>
    public static HtmlElementModifier Name(string value) => Modify(x => x.name = value);

    /// <summary>
    ///     content = <paramref name="value"/>
    /// <br/>
    ///     Specifies the value of the metadata property.
    /// </summary>
    public static HtmlElementModifier Content(string value) => Modify(x => x.content = value);

    /// <summary>
    ///     scheme = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL scheme for the content attribute of the meta tag.
    /// </summary>
    public static HtmlElementModifier Scheme(string value) => Modify(x => x.scheme = value);

    /// <summary>
    ///     itemprop = <paramref name="value"/>
    /// <br/>
    ///     Specifies the Microdata item property that the meta tag represents.
    /// </summary>
    public static HtmlElementModifier Itemprop(string value) => Modify(x => x.itemprop = value);

    /// <summary>
    ///     property = <paramref name="value"/>
    /// <br/>
    ///     Specifies the schema.org property that the meta tag represents.
    /// </summary>
    public static HtmlElementModifier Property(string value) => Modify(x => x.property = value);

    /// <summary>
    ///     src = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL for a resource associated with the meta tag.
    /// </summary>
    public static HtmlElementModifier Src(string value) => Modify(x => x.src = value);

}

public sealed class body : HtmlElement
{
    /// <summary>
    ///     Specifies the URL of a background image to be displayed behind the document's content.
    /// </summary>
    [ReactProp]
    public string background { get; set; }

    /// <summary>
    ///     Specifies the background color of the document's body.
    /// </summary>
    [ReactProp]
    public string bgcolor { get; set; }

    /// <summary>
    ///     Specifies the color of unvisited links in the document's body.
    /// </summary>
    [ReactProp]
    public string link { get; set; }

    public body() { }

    public body(params IModifier[] modifiers) : base(modifiers) { }

    public body(Style style) : base(style) { }

    public body(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<body> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     background = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL of a background image to be displayed behind the document's content.
    /// </summary>
    public static HtmlElementModifier Background(string value) => Modify(x => x.background = value);

    /// <summary>
    ///     bgcolor = <paramref name="value"/>
    /// <br/>
    ///     Specifies the background color of the document's body.
    /// </summary>
    public static HtmlElementModifier Bgcolor(string value) => Modify(x => x.bgcolor = value);

    /// <summary>
    ///     link = <paramref name="value"/>
    /// <br/>
    ///     Specifies the color of unvisited links in the document's body.
    /// </summary>
    public static HtmlElementModifier Link(string value) => Modify(x => x.link = value);

}

public sealed class script : HtmlElement
{
    /// <summary>
    ///     Specifies that the script should be executed asynchronously. This means that the browser will not wait for the script to finish executing before continuing to parse the rest of the HTML.
    /// </summary>
    [ReactProp]
    public string async { get; set; }

    /// <summary>
    ///     Specifies that the script should be executed after the browser has finished parsing the rest of the HTML. This is similar to async, but it ensures that scripts are executed in the order they are specified in the HTML.
    /// </summary>
    [ReactProp]
    public string defer { get; set; }

    /// <summary>
    ///     Specifies a subresource integrity (SRI) hash for the script. This helps to protect against man-in-the-middle attacks.
    /// </summary>
    [ReactProp]
    public string integrity { get; set; }

    /// <summary>
    ///     Specifies the scripting language of the script. This is deprecated, but is still supported by most browsers.
    /// </summary>
    [ReactProp]
    public string language { get; set; }

    /// <summary>
    ///     Specifies that the script should be ignored if the browser does not support modules.
    /// </summary>
    [ReactProp]
    public string nomodule { get; set; }

    /// <summary>
    ///     Specifies the URL of an external script file.
    /// </summary>
    [ReactProp]
    public string src { get; set; }

    /// <summary>
    ///     Specifies the type of the script. The most common value is application/javascript.
    /// </summary>
    [ReactProp]
    public string type { get; set; }

    public script() { }

    public script(params IModifier[] modifiers) : base(modifiers) { }

    public script(Style style) : base(style) { }

    public script(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<script> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     async = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the script should be executed asynchronously. This means that the browser will not wait for the script to finish executing before continuing to parse the rest of the HTML.
    /// </summary>
    public static HtmlElementModifier Async(string value) => Modify(x => x.async = value);

    /// <summary>
    ///     defer = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the script should be executed after the browser has finished parsing the rest of the HTML. This is similar to async, but it ensures that scripts are executed in the order they are specified in the HTML.
    /// </summary>
    public static HtmlElementModifier Defer(string value) => Modify(x => x.defer = value);

    /// <summary>
    ///     integrity = <paramref name="value"/>
    /// <br/>
    ///     Specifies a subresource integrity (SRI) hash for the script. This helps to protect against man-in-the-middle attacks.
    /// </summary>
    public static HtmlElementModifier Integrity(string value) => Modify(x => x.integrity = value);

    /// <summary>
    ///     language = <paramref name="value"/>
    /// <br/>
    ///     Specifies the scripting language of the script. This is deprecated, but is still supported by most browsers.
    /// </summary>
    public static HtmlElementModifier Language(string value) => Modify(x => x.language = value);

    /// <summary>
    ///     nomodule = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the script should be ignored if the browser does not support modules.
    /// </summary>
    public static HtmlElementModifier Nomodule(string value) => Modify(x => x.nomodule = value);

    /// <summary>
    ///     src = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL of an external script file.
    /// </summary>
    public static HtmlElementModifier Src(string value) => Modify(x => x.src = value);

    /// <summary>
    ///     type = <paramref name="value"/>
    /// <br/>
    ///     Specifies the type of the script. The most common value is application/javascript.
    /// </summary>
    public static HtmlElementModifier Type(string value) => Modify(x => x.type = value);

}

public sealed class title : HtmlElement
{
    /// <summary>
    ///     Specifies the language of the title.
    /// </summary>
    [ReactProp]
    public string language { get; set; }

    public title() { }

    public title(params IModifier[] modifiers) : base(modifiers) { }

    public title(Style style) : base(style) { }

    public title(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<title> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     language = <paramref name="value"/>
    /// <br/>
    ///     Specifies the language of the title.
    /// </summary>
    public static HtmlElementModifier Language(string value) => Modify(x => x.language = value);

}

public sealed class head : HtmlElement
{
    /// <summary>
    ///     Provides a URL to a profile document for the current document.
    /// </summary>
    [ReactProp]
    public string profile { get; set; }

    /// <summary>
    ///     Provides a link to an external resource, such as a stylesheet or script file.
    /// </summary>
    [ReactProp]
    public string link { get; set; }

    /// <summary>
    ///     Provides metadata about the document, such as the character encoding, author, and keywords.
    /// </summary>
    [ReactProp]
    public string meta { get; set; }

    /// <summary>
    ///     Provides JavaScript code to be executed in the browser.
    /// </summary>
    [ReactProp]
    public string script { get; set; }

    /// <summary>
    ///     Provides content to be displayed if the browser does not support JavaScript.
    /// </summary>
    [ReactProp]
    public string noscript { get; set; }

    public head() { }

    public head(params IModifier[] modifiers) : base(modifiers) { }

    public head(Style style) : base(style) { }

    public head(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<head> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     profile = <paramref name="value"/>
    /// <br/>
    ///     Provides a URL to a profile document for the current document.
    /// </summary>
    public static HtmlElementModifier Profile(string value) => Modify(x => x.profile = value);

    /// <summary>
    ///     link = <paramref name="value"/>
    /// <br/>
    ///     Provides a link to an external resource, such as a stylesheet or script file.
    /// </summary>
    public static HtmlElementModifier Link(string value) => Modify(x => x.link = value);

    /// <summary>
    ///     meta = <paramref name="value"/>
    /// <br/>
    ///     Provides metadata about the document, such as the character encoding, author, and keywords.
    /// </summary>
    public static HtmlElementModifier Meta(string value) => Modify(x => x.meta = value);

    /// <summary>
    ///     script = <paramref name="value"/>
    /// <br/>
    ///     Provides JavaScript code to be executed in the browser.
    /// </summary>
    public static HtmlElementModifier Script(string value) => Modify(x => x.script = value);

    /// <summary>
    ///     noscript = <paramref name="value"/>
    /// <br/>
    ///     Provides content to be displayed if the browser does not support JavaScript.
    /// </summary>
    public static HtmlElementModifier Noscript(string value) => Modify(x => x.noscript = value);

}

public sealed class html : HtmlElement
{
    /// <summary>
    ///     Hides the element from display.
    /// </summary>
    [ReactProp]
    public string hidden { get; set; }

    /// <summary>
    ///     Specifies the URL of a manifest file, which provides information about the web app.
    /// </summary>
    [ReactProp]
    public string manifest { get; set; }

    /// <summary>
    ///     Specifies the namespace of the element.
    /// </summary>
    [ReactProp]
    public string xmlns { get; set; } = "http://www.w3.org/1999/xhtml";

    /// <summary>
    ///     Specifies the prefix of the element.
    /// </summary>
    [ReactProp]
    public string prefix { get; set; }

    /// <summary>
    ///     Specifies the version of the HTML specification to which the element conforms.
    /// </summary>
    [ReactProp]
    public string version { get; set; }

    public html() { }

    public html(params IModifier[] modifiers) : base(modifiers) { }

    public html(Style style) : base(style) { }

    public html(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<html> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     hidden = <paramref name="value"/>
    /// <br/>
    ///     Hides the element from display.
    /// </summary>
    public static HtmlElementModifier Hidden(string value) => Modify(x => x.hidden = value);

    /// <summary>
    ///     manifest = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL of a manifest file, which provides information about the web app.
    /// </summary>
    public static HtmlElementModifier Manifest(string value) => Modify(x => x.manifest = value);

    /// <summary>
    ///     xmlns = <paramref name="value"/>
    /// <br/>
    ///     Specifies the namespace of the element.
    /// </summary>
    public static HtmlElementModifier Xmlns(string value) => Modify(x => x.xmlns = value);

    /// <summary>
    ///     prefix = <paramref name="value"/>
    /// <br/>
    ///     Specifies the prefix of the element.
    /// </summary>
    public static HtmlElementModifier Prefix(string value) => Modify(x => x.prefix = value);

    /// <summary>
    ///     version = <paramref name="value"/>
    /// <br/>
    ///     Specifies the version of the HTML specification to which the element conforms.
    /// </summary>
    public static HtmlElementModifier Version(string value) => Modify(x => x.version = value);

}

public sealed class label : HtmlElement
{
    /// <summary>
    ///     Specifies which form element a label is bound to.
    /// </summary>
    [ReactProp]
    public string htmlFor { get; set; }

    /// <summary>
    ///     Specifies whether the element is a drop target.
    /// </summary>
    [ReactProp]
    public string dropzone { get; set; }

    /// <summary>
    ///     Hides the element from view.
    /// </summary>
    [ReactProp]
    public string hidden { get; set; }

    /// <summary>
    ///     Specifies the element's position in the tab order.
    /// </summary>
    [ReactProp]
    public string tabindex { get; set; }

    public label() { }

    public label(params IModifier[] modifiers) : base(modifiers) { }

    public label(string innerText) : base(innerText) {  }

    public static implicit operator label(string text) => new() { text = text };

    public label(Style style) : base(style) { }

    public label(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<label> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     htmlFor = <paramref name="value"/>
    /// <br/>
    ///     Specifies which form element a label is bound to.
    /// </summary>
    public static HtmlElementModifier HtmlFor(string value) => Modify(x => x.htmlFor = value);

    /// <summary>
    ///     dropzone = <paramref name="value"/>
    /// <br/>
    ///     Specifies whether the element is a drop target.
    /// </summary>
    public static HtmlElementModifier Dropzone(string value) => Modify(x => x.dropzone = value);

    /// <summary>
    ///     hidden = <paramref name="value"/>
    /// <br/>
    ///     Hides the element from view.
    /// </summary>
    public static HtmlElementModifier Hidden(string value) => Modify(x => x.hidden = value);

    /// <summary>
    ///     tabindex = <paramref name="value"/>
    /// <br/>
    ///     Specifies the element's position in the tab order.
    /// </summary>
    public static HtmlElementModifier Tabindex(string value) => Modify(x => x.tabindex = value);

}

public sealed class a : HtmlElement
{
    /// <summary>
    ///     The URL of the linked resource.
    /// </summary>
    [ReactProp]
    public string href { get; set; }

    /// <summary>
    ///     Specifies where the linked resource should be opened. Can be `_blank`, `_self`, `_parent`, or `_top`.
    /// </summary>
    [ReactProp]
    public string target { get; set; }

    /// <summary>
    ///     Specifies the relationship between the current document and the linked resource. Can be `alternate`, `author`, `bookmark`, `canonical`, `external`, `help`, `license`, `next`, `nofollow`, `noreferrer`, `noopener`, `prev`, `search`, `sponsored`, or `stylesheet`.
    /// </summary>
    [ReactProp]
    public string rel { get; set; }

    /// <summary>
    ///     Specifies the MIME type of the linked resource, if applicable.
    /// </summary>
    [ReactProp]
    public string type { get; set; }

    /// <summary>
    ///     Specifies whether the linked resource should be downloaded or opened in a new browser tab.
    /// </summary>
    [ReactProp]
    public string download { get; set; }

    /// <summary>
    ///     A list of URLs to which a ping should be sent when the user clicks on the link.
    /// </summary>
    [ReactProp]
    public string ping { get; set; }

    /// <summary>
    ///     Specifies the media types for which the link is relevant.
    /// </summary>
    [ReactProp]
    public string media { get; set; }

    /// <summary>
    ///     Specifies the language of the linked resource.
    /// </summary>
    [ReactProp]
    public string hreflang { get; set; }

    /// <summary>
    ///     Specifies a name for the link. This can be used to target the link with JavaScript.
    /// </summary>
    [ReactProp]
    public string name { get; set; }

    /// <summary>
    ///     Specifies the tab order of the link.
    /// </summary>
    [ReactProp]
    public string tabindex { get; set; }

    public a() { }

    public a(params IModifier[] modifiers) : base(modifiers) { }

    public a(Style style) : base(style) { }

    public a(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<a> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     href = <paramref name="value"/>
    /// <br/>
    ///     The URL of the linked resource.
    /// </summary>
    public static HtmlElementModifier Href(string value) => Modify(x => x.href = value);

    /// <summary>
    ///     target = <paramref name="value"/>
    /// <br/>
    ///     Specifies where the linked resource should be opened. Can be `_blank`, `_self`, `_parent`, or `_top`.
    /// </summary>
    public static HtmlElementModifier Target(string value) => Modify(x => x.target = value);

    /// <summary>
    ///     rel = <paramref name="value"/>
    /// <br/>
    ///     Specifies the relationship between the current document and the linked resource. Can be `alternate`, `author`, `bookmark`, `canonical`, `external`, `help`, `license`, `next`, `nofollow`, `noreferrer`, `noopener`, `prev`, `search`, `sponsored`, or `stylesheet`.
    /// </summary>
    public static HtmlElementModifier Rel(string value) => Modify(x => x.rel = value);

    /// <summary>
    ///     type = <paramref name="value"/>
    /// <br/>
    ///     Specifies the MIME type of the linked resource, if applicable.
    /// </summary>
    public static HtmlElementModifier Type(string value) => Modify(x => x.type = value);

    /// <summary>
    ///     download = <paramref name="value"/>
    /// <br/>
    ///     Specifies whether the linked resource should be downloaded or opened in a new browser tab.
    /// </summary>
    public static HtmlElementModifier Download(string value) => Modify(x => x.download = value);

    /// <summary>
    ///     ping = <paramref name="value"/>
    /// <br/>
    ///     A list of URLs to which a ping should be sent when the user clicks on the link.
    /// </summary>
    public static HtmlElementModifier Ping(string value) => Modify(x => x.ping = value);

    /// <summary>
    ///     media = <paramref name="value"/>
    /// <br/>
    ///     Specifies the media types for which the link is relevant.
    /// </summary>
    public static HtmlElementModifier Media(string value) => Modify(x => x.media = value);

    /// <summary>
    ///     hreflang = <paramref name="value"/>
    /// <br/>
    ///     Specifies the language of the linked resource.
    /// </summary>
    public static HtmlElementModifier Hreflang(string value) => Modify(x => x.hreflang = value);

    /// <summary>
    ///     name = <paramref name="value"/>
    /// <br/>
    ///     Specifies a name for the link. This can be used to target the link with JavaScript.
    /// </summary>
    public static HtmlElementModifier Name(string value) => Modify(x => x.name = value);

    /// <summary>
    ///     tabindex = <paramref name="value"/>
    /// <br/>
    ///     Specifies the tab order of the link.
    /// </summary>
    public static HtmlElementModifier Tabindex(string value) => Modify(x => x.tabindex = value);

}

public sealed class img : HtmlElement
{
    /// <summary>
    ///     The URL of the image file.
    /// </summary>
    [ReactProp]
    public string src { get; set; }

    /// <summary>
    ///     A list of image files to use in different situations, such as different screen sizes or device types.
    /// </summary>
    [ReactProp]
    public string srcset { get; set; }

    /// <summary>
    ///     Specifies an image as a client-side image map.
    /// </summary>
    [ReactProp]
    public string usemap { get; set; }

    /// <summary>
    ///     An alternate text for the image, if the image for some reason cannot be displayed.
    /// </summary>
    [ReactProp]
    public string alt { get; set; }

    /// <summary>
    ///     The width of the image, in pixels.
    /// </summary>
    [ReactProp]
    public string width { get; set; }

    /// <summary>
    ///     The height of the image, in pixels.
    /// </summary>
    [ReactProp]
    public string height { get; set; }

    /// <summary>
    ///     A Boolean attribute that indicates whether the image is an image map.
    /// </summary>
    [ReactProp]
    public string ismap { get; set; }

    /// <summary>
    ///     A longer description of the image, for use by screen readers and other assistive technologies.
    /// </summary>
    [ReactProp]
    public string longdesc { get; set; }

    /// <summary>
    ///     A string that specifies the CORS setting for the image.
    /// </summary>
    [ReactProp]
    public string crossorigin { get; set; }

    /// <summary>
    ///     A string that specifies how the image should be loaded.
    /// </summary>
    [ReactProp]
    public string loading { get; set; }

    /// <summary>
    ///     A string that specifies how the image should be decoded.
    /// </summary>
    [ReactProp]
    public string decoding { get; set; }

    /// <summary>
    ///     A string that specifies how much referrer information is sent with requests for the image.
    /// </summary>
    [ReactProp]
    public string referrerpolicy { get; set; }

    public img() { }

    public img(params IModifier[] modifiers) : base(modifiers) { }

    public img(Style style) : base(style) { }

    public img(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<img> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     src = <paramref name="value"/>
    /// <br/>
    ///     The URL of the image file.
    /// </summary>
    public static HtmlElementModifier Src(string value) => Modify(x => x.src = value);

    /// <summary>
    ///     srcset = <paramref name="value"/>
    /// <br/>
    ///     A list of image files to use in different situations, such as different screen sizes or device types.
    /// </summary>
    public static HtmlElementModifier Srcset(string value) => Modify(x => x.srcset = value);

    /// <summary>
    ///     usemap = <paramref name="value"/>
    /// <br/>
    ///     Specifies an image as a client-side image map.
    /// </summary>
    public static HtmlElementModifier Usemap(string value) => Modify(x => x.usemap = value);

    /// <summary>
    ///     alt = <paramref name="value"/>
    /// <br/>
    ///     An alternate text for the image, if the image for some reason cannot be displayed.
    /// </summary>
    public static HtmlElementModifier Alt(string value) => Modify(x => x.alt = value);

    /// <summary>
    ///     width = <paramref name="value"/>
    /// <br/>
    ///     The width of the image, in pixels.
    /// </summary>
    public static HtmlElementModifier Width(string value) => Modify(x => x.width = value);

    /// <summary>
    ///     height = <paramref name="value"/>
    /// <br/>
    ///     The height of the image, in pixels.
    /// </summary>
    public static HtmlElementModifier Height(string value) => Modify(x => x.height = value);

    /// <summary>
    ///     ismap = <paramref name="value"/>
    /// <br/>
    ///     A Boolean attribute that indicates whether the image is an image map.
    /// </summary>
    public static HtmlElementModifier Ismap(string value) => Modify(x => x.ismap = value);

    /// <summary>
    ///     longdesc = <paramref name="value"/>
    /// <br/>
    ///     A longer description of the image, for use by screen readers and other assistive technologies.
    /// </summary>
    public static HtmlElementModifier Longdesc(string value) => Modify(x => x.longdesc = value);

    /// <summary>
    ///     crossorigin = <paramref name="value"/>
    /// <br/>
    ///     A string that specifies the CORS setting for the image.
    /// </summary>
    public static HtmlElementModifier Crossorigin(string value) => Modify(x => x.crossorigin = value);

    /// <summary>
    ///     loading = <paramref name="value"/>
    /// <br/>
    ///     A string that specifies how the image should be loaded.
    /// </summary>
    public static HtmlElementModifier Loading(string value) => Modify(x => x.loading = value);

    /// <summary>
    ///     decoding = <paramref name="value"/>
    /// <br/>
    ///     A string that specifies how the image should be decoded.
    /// </summary>
    public static HtmlElementModifier Decoding(string value) => Modify(x => x.decoding = value);

    /// <summary>
    ///     referrerpolicy = <paramref name="value"/>
    /// <br/>
    ///     A string that specifies how much referrer information is sent with requests for the image.
    /// </summary>
    public static HtmlElementModifier Referrerpolicy(string value) => Modify(x => x.referrerpolicy = value);

}

public sealed partial class svg : HtmlElement
{
    [ReactProp]
    public string focusable { get; set; }

    [ReactProp]
    public string xlinkHref { get; set; }

    [ReactProp]
    public string xmlnsXlink { get; set; }

    /// <summary>
    ///     Specifies how the SVG element should be scaled and aligned to fit its viewport.
    /// </summary>
    [ReactProp]
    public string preserveAspectRatio { get; set; }

    /// <summary>
    ///     The width of the SVG element in pixels.
    /// </summary>
    [ReactProp]
    public string width { get; set; }

    /// <summary>
    ///     The height of the SVG element in pixels.
    /// </summary>
    [ReactProp]
    public string height { get; set; }

    /// <summary>
    ///     The namespace URI for the SVG element.
    /// </summary>
    [ReactProp]
    public string xmlns { get; set; } = "http://www.w3.org/2000/svg";

    /// <summary>
    ///     The SVG version of the element.
    /// </summary>
    [ReactProp]
    public string version { get; set; }

    [ReactProp]
    public string viewBox { get; set; }

    [ReactProp]
    public string fill { get; set; }

    public svg() { }

    public svg(params IModifier[] modifiers) : base(modifiers) { }

    public svg(Style style) : base(style) { }

    public svg(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<svg> modifyAction) => CreateHtmlElementModifier(modifyAction);
    public static HtmlElementModifier Focusable(string value) => Modify(x => x.focusable = value);

    public static HtmlElementModifier XlinkHref(string value) => Modify(x => x.xlinkHref = value);

    public static HtmlElementModifier XmlnsXlink(string value) => Modify(x => x.xmlnsXlink = value);

    /// <summary>
    ///     preserveAspectRatio = <paramref name="value"/>
    /// <br/>
    ///     Specifies how the SVG element should be scaled and aligned to fit its viewport.
    /// </summary>
    public static HtmlElementModifier PreserveAspectRatio(string value) => Modify(x => x.preserveAspectRatio = value);

    /// <summary>
    ///     width = <paramref name="value"/>
    /// <br/>
    ///     The width of the SVG element in pixels.
    /// </summary>
    public static HtmlElementModifier Width(string value) => Modify(x => x.width = value);

    /// <summary>
    ///     height = <paramref name="value"/>
    /// <br/>
    ///     The height of the SVG element in pixels.
    /// </summary>
    public static HtmlElementModifier Height(string value) => Modify(x => x.height = value);

    /// <summary>
    ///     xmlns = <paramref name="value"/>
    /// <br/>
    ///     The namespace URI for the SVG element.
    /// </summary>
    public static HtmlElementModifier Xmlns(string value) => Modify(x => x.xmlns = value);

    /// <summary>
    ///     version = <paramref name="value"/>
    /// <br/>
    ///     The SVG version of the element.
    /// </summary>
    public static HtmlElementModifier Version(string value) => Modify(x => x.version = value);

    public static HtmlElementModifier ViewBox(string value) => Modify(x => x.viewBox = value);

    public static HtmlElementModifier Fill(string value) => Modify(x => x.fill = value);

}

public sealed class form : HtmlElement
{
    /// <summary>
    ///     Specifies the URL of the page where the form data will be submitted.
    /// </summary>
    [ReactProp]
    public string action { get; set; }

    /// <summary>
    ///     Specifies how the form data will be sent to the server. Possible values are 'get' and 'post'.
    /// </summary>
    [ReactProp]
    public string method { get; set; }

    /// <summary>
    ///     Specifies the encoding type for form data. Possible values are 'application/x-www-form-urlencoded' and 'multipart/form-data'.
    /// </summary>
    [ReactProp]
    public string enctype { get; set; }

    /// <summary>
    ///     Specifies the name of the frame where the form will be submitted. The default value is '_self', which means the form will be submitted in the current frame.
    /// </summary>
    [ReactProp]
    public string target { get; set; }

    /// <summary>
    ///     Specifies a name for the form. This name is used to reference the form in JavaScript or to reference form data after a form is submitted.
    /// </summary>
    [ReactProp]
    public string name { get; set; }

    /// <summary>
    ///     Disables form validation. This attribute is useful when you want to submit the form without validating the user input.
    /// </summary>
    [ReactProp]
    public string novalidate { get; set; }

    /// <summary>
    ///     Specifies whether the browser should automatically fill in form fields based on the user's past input.
    /// </summary>
    [ReactProp]
    public string autocomplete { get; set; }

    public form() { }

    public form(params IModifier[] modifiers) : base(modifiers) { }

    public form(Style style) : base(style) { }

    public form(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<form> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     action = <paramref name="value"/>
    /// <br/>
    ///     Specifies the URL of the page where the form data will be submitted.
    /// </summary>
    public static HtmlElementModifier Action(string value) => Modify(x => x.action = value);

    /// <summary>
    ///     method = <paramref name="value"/>
    /// <br/>
    ///     Specifies how the form data will be sent to the server. Possible values are 'get' and 'post'.
    /// </summary>
    public static HtmlElementModifier Method(string value) => Modify(x => x.method = value);

    /// <summary>
    ///     enctype = <paramref name="value"/>
    /// <br/>
    ///     Specifies the encoding type for form data. Possible values are 'application/x-www-form-urlencoded' and 'multipart/form-data'.
    /// </summary>
    public static HtmlElementModifier Enctype(string value) => Modify(x => x.enctype = value);

    /// <summary>
    ///     target = <paramref name="value"/>
    /// <br/>
    ///     Specifies the name of the frame where the form will be submitted. The default value is '_self', which means the form will be submitted in the current frame.
    /// </summary>
    public static HtmlElementModifier Target(string value) => Modify(x => x.target = value);

    /// <summary>
    ///     name = <paramref name="value"/>
    /// <br/>
    ///     Specifies a name for the form. This name is used to reference the form in JavaScript or to reference form data after a form is submitted.
    /// </summary>
    public static HtmlElementModifier Name(string value) => Modify(x => x.name = value);

    /// <summary>
    ///     novalidate = <paramref name="value"/>
    /// <br/>
    ///     Disables form validation. This attribute is useful when you want to submit the form without validating the user input.
    /// </summary>
    public static HtmlElementModifier Novalidate(string value) => Modify(x => x.novalidate = value);

    /// <summary>
    ///     autocomplete = <paramref name="value"/>
    /// <br/>
    ///     Specifies whether the browser should automatically fill in form fields based on the user's past input.
    /// </summary>
    public static HtmlElementModifier Autocomplete(string value) => Modify(x => x.autocomplete = value);

}

public sealed partial class textarea : HtmlElement
{
    /// <summary>
    ///     Specifies a name for the textarea element.
    /// </summary>
    [ReactProp]
    public string name { get; set; }

    /// <summary>
    ///     Specifies the visible width of the textarea element in characters.
    /// </summary>
    [ReactProp]
    public UnionProp<string,int?> cols { get; set; }

    /// <summary>
    ///     Specifies the number of visible lines in the textarea element.
    /// </summary>
    [ReactProp]
    public UnionProp<string,int?> rows { get; set; }

    /// <summary>
    ///     Specifies a short hint that describes the expected value of the textarea element.
    /// </summary>
    [ReactProp]
    public string placeholder { get; set; }

    /// <summary>
    ///     Disables user input in the textarea element.
    /// </summary>
    [ReactProp]
    public UnionProp<string,bool> readOnly { get; set; }

    /// <summary>
    ///     Indicates that the textarea element must be filled out before the form is submitted.
    /// </summary>
    [ReactProp]
    public string required { get; set; }

    /// <summary>
    ///     Automatically gives focus to the textarea element when the page loads.
    /// </summary>
    [ReactProp]
    public string autofocus { get; set; }

    /// <summary>
    ///     Specifies that the user's browser should automatically complete the textarea element's value.
    /// </summary>
    [ReactProp]
    public string autocomplete { get; set; }

    /// <summary>
    ///     Specifies the directory to use as the default value for the 'file' input type.
    /// </summary>
    [ReactProp]
    public string dirname { get; set; }

    /// <summary>
    ///     Specifies the ID of the form that the textarea element belongs to.
    /// </summary>
    [ReactProp]
    public string form { get; set; }

    /// <summary>
    ///     Specifies the maximum number of characters that can be entered into the textarea element.
    /// </summary>
    [ReactProp]
    public string maxlength { get; set; }

    /// <summary>
    ///     Specifies the minimum number of characters that must be entered into the textarea element.
    /// </summary>
    [ReactProp]
    public string minlength { get; set; }

    /// <summary>
    ///     Specifies whether the text in the textarea element should wrap to the next line when it reaches the end of the visible area.
    /// </summary>
    [ReactProp]
    public string wrap { get; set; }

    /// <summary>
    ///     A string. Specifies the initial value for a text area.
    /// </summary>
    [ReactProp]
    public string defaultValue { get; set; }

    [ReactProp]
    public string value { get; set; }

    [ReactProp]
    public string disabled { get; set; }

    public textarea() { }

    public textarea(params IModifier[] modifiers) : base(modifiers) { }

    public textarea(Style style) : base(style) { }

    public textarea(StyleModifier[] styleModifiers) : base(styleModifiers) { }

    public static HtmlElementModifier Modify(Action<textarea> modifyAction) => CreateHtmlElementModifier(modifyAction);
    /// <summary>
    ///     name = <paramref name="value"/>
    /// <br/>
    ///     Specifies a name for the textarea element.
    /// </summary>
    public static HtmlElementModifier Name(string value) => Modify(x => x.name = value);

    /// <summary>
    ///     cols = <paramref name="value"/>
    /// <br/>
    ///     Specifies the visible width of the textarea element in characters.
    /// </summary>
    public static HtmlElementModifier Cols(UnionProp<string,int?> value) => Modify(x => x.cols = value);

    /// <summary>
    ///     rows = <paramref name="value"/>
    /// <br/>
    ///     Specifies the number of visible lines in the textarea element.
    /// </summary>
    public static HtmlElementModifier Rows(UnionProp<string,int?> value) => Modify(x => x.rows = value);

    /// <summary>
    ///     placeholder = <paramref name="value"/>
    /// <br/>
    ///     Specifies a short hint that describes the expected value of the textarea element.
    /// </summary>
    public static HtmlElementModifier Placeholder(string value) => Modify(x => x.placeholder = value);

    /// <summary>
    ///     readOnly = <paramref name="value"/>
    /// <br/>
    ///     Disables user input in the textarea element.
    /// </summary>
    public static HtmlElementModifier ReadOnly(UnionProp<string,bool> value) => Modify(x => x.readOnly = value);

    /// <summary>
    ///     required = <paramref name="value"/>
    /// <br/>
    ///     Indicates that the textarea element must be filled out before the form is submitted.
    /// </summary>
    public static HtmlElementModifier Required(string value) => Modify(x => x.required = value);

    /// <summary>
    ///     autofocus = <paramref name="value"/>
    /// <br/>
    ///     Automatically gives focus to the textarea element when the page loads.
    /// </summary>
    public static HtmlElementModifier Autofocus(string value) => Modify(x => x.autofocus = value);

    /// <summary>
    ///     autocomplete = <paramref name="value"/>
    /// <br/>
    ///     Specifies that the user's browser should automatically complete the textarea element's value.
    /// </summary>
    public static HtmlElementModifier Autocomplete(string value) => Modify(x => x.autocomplete = value);

    /// <summary>
    ///     dirname = <paramref name="value"/>
    /// <br/>
    ///     Specifies the directory to use as the default value for the 'file' input type.
    /// </summary>
    public static HtmlElementModifier Dirname(string value) => Modify(x => x.dirname = value);

    /// <summary>
    ///     form = <paramref name="value"/>
    /// <br/>
    ///     Specifies the ID of the form that the textarea element belongs to.
    /// </summary>
    public static HtmlElementModifier Form(string value) => Modify(x => x.form = value);

    /// <summary>
    ///     maxlength = <paramref name="value"/>
    /// <br/>
    ///     Specifies the maximum number of characters that can be entered into the textarea element.
    /// </summary>
    public static HtmlElementModifier Maxlength(string value) => Modify(x => x.maxlength = value);

    /// <summary>
    ///     minlength = <paramref name="value"/>
    /// <br/>
    ///     Specifies the minimum number of characters that must be entered into the textarea element.
    /// </summary>
    public static HtmlElementModifier Minlength(string value) => Modify(x => x.minlength = value);

    /// <summary>
    ///     wrap = <paramref name="value"/>
    /// <br/>
    ///     Specifies whether the text in the textarea element should wrap to the next line when it reaches the end of the visible area.
    /// </summary>
    public static HtmlElementModifier Wrap(string value) => Modify(x => x.wrap = value);

    /// <summary>
    ///     defaultValue = <paramref name="value"/>
    /// <br/>
    ///     A string. Specifies the initial value for a text area.
    /// </summary>
    public static HtmlElementModifier DefaultValue(string value) => Modify(x => x.defaultValue = value);

    public static HtmlElementModifier Value(string value) => Modify(x => x.value = value);

    public static HtmlElementModifier Disabled(string value) => Modify(x => x.disabled = value);

}

