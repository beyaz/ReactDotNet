using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ReactWithDotNet.Test;

[TestClass]
//[Ignore]
public class ExportStyleProperties
{
    static readonly string[] rezervedWords =  { "float" };
    [TestMethod]
    public void ExportCommonHtmlElements()
    {
        var propertyNames = GetPropertyNamesOfStyleClass();

        const string indent = "    ";
        
        var list = new List<string>
        {
            "namespace ReactWithDotNet;",
            "",
            "partial class Style",
            "{"
        };

        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}public string {propertyName} {{ get; set; }}");
        }

        static string getPropertyName(string name)
        {
            
            if (rezervedWords.Contains(name))
            {
                return "@" + name;
            }
            
            return name;
        }
        
        ////////////////////////////////////////
        // isEmpty
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static bool isEmpty(Style s)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (s.{propertyName} != null)");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}return false;");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}{indent}return true;");
        list.Add($"{indent}}}");
        
        ////////////////////////////////////////
        // getValueByName
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static string getByName(Style s, string name)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (nameof({propertyName}).Equals(name, StringComparison.OrdinalIgnoreCase))");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}return s.{propertyName};");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}{indent}throw CssParseException(name);");
        list.Add($"{indent}}}");
        
        
        ////////////////////////////////////////
        // setValueByName
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static void setByName(Style s, string name, string value)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (nameof({propertyName}).Equals(name, StringComparison.OrdinalIgnoreCase))");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}s.{propertyName} = value;");
            list.Add($"{indent}{indent}{indent}return;");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}{indent}throw CssParseException(name);");
        list.Add($"{indent}}}");
        
        
        
        ////////////////////////////////////////
        // transfer
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static void transfer(Style source, Style target)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (source.{propertyName} != null)");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}target.{propertyName} = source.{propertyName};");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}}}");
        ////////////////////////////////////////
        
        
        
        
        
        ////////////////////////////////////////
        // visitNotNullValues
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static void visitNotNullValues(Style s, Action<string, string> action)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (s.{propertyName} != null)");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}action(nameof({propertyName}), s.{propertyName});");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}}}");
        ////////////////////////////////////////
        
        
        ////////////////////////////////////////
        // toCss
        ////////////////////////////////////////
        list.Add("");
        list.Add($"{indent}static void toCss(Style s, System.Text.StringBuilder sb, string separator)");
        list.Add($"{indent}{{");
        
        foreach (var name in propertyNames)
        {
            var propertyName = getPropertyName(name);
            
            list.Add($"{indent}{indent}if (s.{propertyName} != null)");
            list.Add( $"{indent}{indent}{{");
            list.Add($"{indent}{indent}{indent}sb.Append(\"{ConvertCamelCaseToSnakeCase(propertyName)}\");");
            list.Add($"{indent}{indent}{indent}sb.Append(\":\");");
            list.Add($"{indent}{indent}{indent}sb.Append(s.{propertyName});");
            list.Add($"{indent}{indent}{indent}sb.Append(separator);");
            list.Add( $"{indent}{indent}}}");
            
        }
        
        list.Add($"{indent}}}");
        ////////////////////////////////////////
        
        
        
        
        list.Add("}");// end of class
        
        
        ////////////////////////////////////////
        // mixin
        ////////////////////////////////////////
        list.Add("");
        list.Add("partial class Mixin");
        list.Add("{");

        var propertyNamesForStyleModifiers = new []{"borderImageOutset"};
        
        foreach (var propertyName in propertyNamesForStyleModifiers)
        {
            list.Add($"{indent}public static StyleModifier {getStyleModifierName(propertyName)}(string value) => new(style => style.{propertyName} = value);");
        }
        list.Add("}");
        ////////////////////////////////////////
        

        var sb = new StringBuilder();

        foreach (var item in list)
        {
            sb.AppendLine(item);
        }

        File.WriteAllText(@"C:\github\ReactWithDotNet\ReactWithDotNet\Style.generated.cs", sb.ToString());

        static string getStyleModifierName(string propertyName)
        {
            return char.ToUpper(propertyName[0], new CultureInfo("en-US")) + propertyName.Substring(1);
        }
        
        static string ConvertCamelCaseToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var resultBuilder = new StringBuilder();
            bool lastCharWasUpper = false;

            foreach (char c in input.AsSpan())
            {
                if (char.IsUpper(c))
                {
                    if (!lastCharWasUpper)
                    {
                        if (resultBuilder.Length > 0)
                        {
                            resultBuilder.Append('-');
                        }

                        resultBuilder.Append(char.ToLower(c));
                    }
                    else
                    {
                        resultBuilder.Append(c);
                    }

                    lastCharWasUpper = true;
                }
                else
                {
                    resultBuilder.Append(c);
                    lastCharWasUpper = false;
                }
            }

            return resultBuilder.ToString();
        }
    }

    static IReadOnlyList<string> GetPropertyNamesOfStyleClass()
    {
        const string text = """
                            accentColor
                            additiveSymbols
                            alignContent
                            alignItems
                            alignSelf
                            alignmentBaseline
                            all
                            animation
                            animationComposition
                            animationDelay
                            animationDirection
                            animationDuration
                            animationFillMode
                            animationIterationCount
                            animationName
                            animationPlayState
                            animationRange
                            animationRangeEnd
                            animationRangeStart
                            animationTimeline
                            animationTimingFunction
                            appRegion
                            appearance
                            ascentOverride
                            aspectRatio
                            backdropFilter
                            backfaceVisibility
                            background
                            backgroundAttachment
                            backgroundBlendMode
                            backgroundClip
                            backgroundColor
                            backgroundImage
                            backgroundOrigin
                            backgroundPosition
                            backgroundPositionX
                            backgroundPositionY
                            backgroundRepeat
                            backgroundRepeatX
                            backgroundRepeatY
                            backgroundSize
                            basePalette
                            baselineShift
                            baselineSource
                            blockSize
                            border
                            borderBlock
                            borderBlockColor
                            borderBlockEnd
                            borderBlockEndColor
                            borderBlockEndStyle
                            borderBlockEndWidth
                            borderBlockStart
                            borderBlockStartColor
                            borderBlockStartStyle
                            borderBlockStartWidth
                            borderBlockStyle
                            borderBlockWidth
                            borderBottom
                            borderBottomColor
                            borderBottomLeftRadius
                            borderBottomRightRadius
                            borderBottomStyle
                            borderBottomWidth
                            borderCollapse
                            borderColor
                            borderEndEndRadius
                            borderEndStartRadius
                            borderImage
                            borderImageOutset
                            borderImageRepeat
                            borderImageSlice
                            borderImageSource
                            borderImageWidth
                            borderInline
                            borderInlineColor
                            borderInlineEnd
                            borderInlineEndColor
                            borderInlineEndStyle
                            borderInlineEndWidth
                            borderInlineStart
                            borderInlineStartColor
                            borderInlineStartStyle
                            borderInlineStartWidth
                            borderInlineStyle
                            borderInlineWidth
                            borderLeft
                            borderLeftColor
                            borderLeftStyle
                            borderLeftWidth
                            borderRadius
                            borderRight
                            borderRightColor
                            borderRightStyle
                            borderRightWidth
                            borderSpacing
                            borderStartEndRadius
                            borderStartStartRadius
                            borderStyle
                            borderTop
                            borderTopColor
                            borderTopLeftRadius
                            borderTopRightRadius
                            borderTopStyle
                            borderTopWidth
                            borderWidth
                            bottom
                            boxShadow
                            boxSizing
                            breakAfter
                            breakBefore
                            breakInside
                            bufferedRendering
                            captionSide
                            caretColor
                            clear
                            clip
                            clipPath
                            clipRule
                            color
                            colorInterpolation
                            colorInterpolationFilters
                            colorRendering
                            colorScheme
                            columnCount
                            columnFill
                            columnGap
                            columnRule
                            columnRuleColor
                            columnRuleStyle
                            columnRuleWidth
                            columnSpan
                            columnWidth
                            columns
                            contain
                            containIntrinsicBlockSize
                            containIntrinsicHeight
                            containIntrinsicInlineSize
                            containIntrinsicSize
                            containIntrinsicWidth
                            container
                            containerName
                            containerType
                            content
                            contentVisibility
                            counterIncrement
                            counterReset
                            counterSet
                            cursor
                            cx
                            cy
                            d
                            descentOverride
                            direction
                            display
                            dominantBaseline
                            emptyCells
                            fallback
                            fill
                            fillOpacity
                            fillRule
                            filter
                            flex
                            flexBasis
                            flexDirection
                            flexFlow
                            flexGrow
                            flexShrink
                            flexWrap
                            float
                            floodColor
                            floodOpacity
                            font
                            fontDisplay
                            fontFamily
                            fontFeatureSettings
                            fontKerning
                            fontOpticalSizing
                            fontPalette
                            fontSize
                            fontStretch
                            fontStyle
                            fontSynthesis
                            fontSynthesisSmallCaps
                            fontSynthesisStyle
                            fontSynthesisWeight
                            fontVariant
                            fontVariantAlternates
                            fontVariantCaps
                            fontVariantEastAsian
                            fontVariantLigatures
                            fontVariantNumeric
                            fontVariantPosition
                            fontVariationSettings
                            fontWeight
                            forcedColorAdjust
                            gap
                            grid
                            gridArea
                            gridAutoColumns
                            gridAutoFlow
                            gridAutoRows
                            gridColumn
                            gridColumnEnd
                            gridColumnGap
                            gridColumnStart
                            gridGap
                            gridRow
                            gridRowEnd
                            gridRowGap
                            gridRowStart
                            gridTemplate
                            gridTemplateAreas
                            gridTemplateColumns
                            gridTemplateRows
                            height
                            hyphenateCharacter
                            hyphenateLimitChars
                            hyphens
                            imageOrientation
                            imageRendering
                            inherits
                            initialLetter
                            initialValue
                            inlineSize
                            inset
                            insetBlock
                            insetBlockEnd
                            insetBlockStart
                            insetInline
                            insetInlineEnd
                            insetInlineStart
                            isolation
                            justifyContent
                            justifyItems
                            justifySelf
                            left
                            letterSpacing
                            lightingColor
                            lineBreak
                            lineGapOverride
                            lineHeight
                            listStyle
                            listStyleImage
                            listStylePosition
                            listStyleType
                            margin
                            marginBlock
                            marginBlockEnd
                            marginBlockStart
                            marginBottom
                            marginInline
                            marginInlineEnd
                            marginInlineStart
                            marginLeft
                            marginRight
                            marginTop
                            marker
                            markerEnd
                            markerMid
                            markerStart
                            mask
                            maskType
                            mathDepth
                            mathShift
                            mathStyle
                            maxBlockSize
                            maxHeight
                            maxInlineSize
                            maxWidth
                            minBlockSize
                            minHeight
                            minInlineSize
                            minWidth
                            mixBlendMode
                            negative
                            objectFit
                            objectPosition
                            objectViewBox
                            offset
                            offsetAnchor
                            offsetDistance
                            offsetPath
                            offsetPosition
                            offsetRotate
                            opacity
                            order
                            orphans
                            outline
                            outlineColor
                            outlineOffset
                            outlineStyle
                            outlineWidth
                            overflow
                            overflowAnchor
                            overflowClipMargin
                            overflowWrap
                            overflowX
                            overflowY
                            overlay
                            overrideColors
                            overscrollBehavior
                            overscrollBehaviorBlock
                            overscrollBehaviorInline
                            overscrollBehaviorX
                            overscrollBehaviorY
                            pad
                            padding
                            paddingBlock
                            paddingBlockEnd
                            paddingBlockStart
                            paddingBottom
                            paddingInline
                            paddingInlineEnd
                            paddingInlineStart
                            paddingLeft
                            paddingRight
                            paddingTop
                            page
                            pageBreakAfter
                            pageBreakBefore
                            pageBreakInside
                            pageOrientation
                            paintOrder
                            perspective
                            perspectiveOrigin
                            placeContent
                            placeItems
                            placeSelf
                            pointerEvents
                            position
                            prefix
                            quotes
                            r
                            range
                            resize
                            right
                            rotate
                            rowGap
                            rubyPosition
                            rx
                            ry
                            scale
                            scrollBehavior
                            scrollMargin
                            scrollMarginBlock
                            scrollMarginBlockEnd
                            scrollMarginBlockStart
                            scrollMarginBottom
                            scrollMarginInline
                            scrollMarginInlineEnd
                            scrollMarginInlineStart
                            scrollMarginLeft
                            scrollMarginRight
                            scrollMarginTop
                            scrollPadding
                            scrollPaddingBlock
                            scrollPaddingBlockEnd
                            scrollPaddingBlockStart
                            scrollPaddingBottom
                            scrollPaddingInline
                            scrollPaddingInlineEnd
                            scrollPaddingInlineStart
                            scrollPaddingLeft
                            scrollPaddingRight
                            scrollPaddingTop
                            scrollSnapAlign
                            scrollSnapStop
                            scrollSnapType
                            scrollTimeline
                            scrollTimelineAxis
                            scrollTimelineName
                            scrollbarGutter
                            shapeImageThreshold
                            shapeMargin
                            shapeOutside
                            shapeRendering
                            size
                            sizeAdjust
                            speak
                            speakAs
                            src
                            stopColor
                            stopOpacity
                            stroke
                            strokeDasharray
                            strokeDashoffset
                            strokeLinecap
                            strokeLinejoin
                            strokeMiterlimit
                            strokeOpacity
                            strokeWidth
                            suffix
                            symbols
                            syntax
                            system
                            tabSize
                            tableLayout
                            textAlign
                            textAlignLast
                            textAnchor
                            textCombineHorizontal
                            textCombineUpright
                            textDecoration
                            textDecorationColor
                            textDecorationLine
                            textDecorationSkipInk
                            textDecorationStyle
                            textDecorationThickness
                            textEmphasis
                            textEmphasisColor
                            textEmphasisPosition
                            textEmphasisStyle
                            textIndent
                            textOrientation
                            textOverflow
                            textRendering
                            textShadow
                            textSizeAdjust
                            textTransform
                            textUnderlineOffset
                            textUnderlinePosition
                            textWrap
                            timelineScope
                            top
                            touchAction
                            transform
                            transformBox
                            transformOrigin
                            transformStyle
                            transition
                            transitionBehavior
                            transitionDelay
                            transitionDuration
                            transitionProperty
                            transitionTimingFunction
                            translate
                            unicodeBidi
                            unicodeRange
                            userSelect
                            vectorEffect
                            verticalAlign
                            viewTimeline
                            viewTimelineAxis
                            viewTimelineInset
                            viewTimelineName
                            viewTransitionName
                            visibility
                            webkitAlignContent
                            webkitAlignItems
                            webkitAlignSelf
                            webkitAnimation
                            webkitAnimationDelay
                            webkitAnimationDirection
                            webkitAnimationDuration
                            webkitAnimationFillMode
                            webkitAnimationIterationCount
                            webkitAnimationName
                            webkitAnimationPlayState
                            webkitAnimationTimingFunction
                            webkitAppRegion
                            webkitAppearance
                            webkitBackfaceVisibility
                            webkitBackgroundClip
                            webkitBackgroundOrigin
                            webkitBackgroundSize
                            webkitBorderAfter
                            webkitBorderAfterColor
                            webkitBorderAfterStyle
                            webkitBorderAfterWidth
                            webkitBorderBefore
                            webkitBorderBeforeColor
                            webkitBorderBeforeStyle
                            webkitBorderBeforeWidth
                            webkitBorderBottomLeftRadius
                            webkitBorderBottomRightRadius
                            webkitBorderEnd
                            webkitBorderEndColor
                            webkitBorderEndStyle
                            webkitBorderEndWidth
                            webkitBorderHorizontalSpacing
                            webkitBorderImage
                            webkitBorderRadius
                            webkitBorderStart
                            webkitBorderStartColor
                            webkitBorderStartStyle
                            webkitBorderStartWidth
                            webkitBorderTopLeftRadius
                            webkitBorderTopRightRadius
                            webkitBorderVerticalSpacing
                            webkitBoxAlign
                            webkitBoxDecorationBreak
                            webkitBoxDirection
                            webkitBoxFlex
                            webkitBoxOrdinalGroup
                            webkitBoxOrient
                            webkitBoxPack
                            webkitBoxReflect
                            webkitBoxShadow
                            webkitBoxSizing
                            webkitClipPath
                            webkitColumnBreakAfter
                            webkitColumnBreakBefore
                            webkitColumnBreakInside
                            webkitColumnCount
                            webkitColumnGap
                            webkitColumnRule
                            webkitColumnRuleColor
                            webkitColumnRuleStyle
                            webkitColumnRuleWidth
                            webkitColumnSpan
                            webkitColumnWidth
                            webkitColumns
                            webkitFilter
                            webkitFlex
                            webkitFlexBasis
                            webkitFlexDirection
                            webkitFlexFlow
                            webkitFlexGrow
                            webkitFlexShrink
                            webkitFlexWrap
                            webkitFontFeatureSettings
                            webkitFontSmoothing
                            webkitHyphenateCharacter
                            webkitJustifyContent
                            webkitLineBreak
                            webkitLineClamp
                            webkitLocale
                            webkitLogicalHeight
                            webkitLogicalWidth
                            webkitMarginAfter
                            webkitMarginBefore
                            webkitMarginEnd
                            webkitMarginStart
                            webkitMask
                            webkitMaskBoxImage
                            webkitMaskBoxImageOutset
                            webkitMaskBoxImageRepeat
                            webkitMaskBoxImageSlice
                            webkitMaskBoxImageSource
                            webkitMaskBoxImageWidth
                            webkitMaskClip
                            webkitMaskComposite
                            webkitMaskImage
                            webkitMaskOrigin
                            webkitMaskPosition
                            webkitMaskPositionX
                            webkitMaskPositionY
                            webkitMaskRepeat
                            webkitMaskRepeatX
                            webkitMaskRepeatY
                            webkitMaskSize
                            webkitMaxLogicalHeight
                            webkitMaxLogicalWidth
                            webkitMinLogicalHeight
                            webkitMinLogicalWidth
                            webkitOpacity
                            webkitOrder
                            webkitPaddingAfter
                            webkitPaddingBefore
                            webkitPaddingEnd
                            webkitPaddingStart
                            webkitPerspective
                            webkitPerspectiveOrigin
                            webkitPerspectiveOriginX
                            webkitPerspectiveOriginY
                            webkitPrintColorAdjust
                            webkitRtlOrdering
                            webkitRubyPosition
                            webkitShapeImageThreshold
                            webkitShapeMargin
                            webkitShapeOutside
                            webkitTapHighlightColor
                            webkitTextCombine
                            webkitTextDecorationsInEffect
                            webkitTextEmphasis
                            webkitTextEmphasisColor
                            webkitTextEmphasisPosition
                            webkitTextEmphasisStyle
                            webkitTextFillColor
                            webkitTextOrientation
                            webkitTextSecurity
                            webkitTextSizeAdjust
                            webkitTextStroke
                            webkitTextStrokeColor
                            webkitTextStrokeWidth
                            webkitTransform
                            webkitTransformOrigin
                            webkitTransformOriginX
                            webkitTransformOriginY
                            webkitTransformOriginZ
                            webkitTransformStyle
                            webkitTransition
                            webkitTransitionDelay
                            webkitTransitionDuration
                            webkitTransitionProperty
                            webkitTransitionTimingFunction
                            webkitUserDrag
                            webkitUserModify
                            webkitUserSelect
                            webkitWritingMode
                            whiteSpace
                            whiteSpaceCollapse
                            widows
                            width
                            willChange
                            wordBreak
                            wordSpacing
                            wordWrap
                            writingMode
                            x
                            y
                            zIndex
                            zoom
                            mozOsxFontSmoothing
                            boxDecorationBreak
                            cssFloat
                            cssText
                            fontLanguageOverride
                            fontSizeAdjust
                            gridAutoPosition
                            icon
                            imageResolution
                            imeMode
                            marks
                            navDown
                            navIndex
                            navLeft
                            navRight
                            navUp
                            overflowClipBox
                            """;
        
        
        return text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
    }
    

}