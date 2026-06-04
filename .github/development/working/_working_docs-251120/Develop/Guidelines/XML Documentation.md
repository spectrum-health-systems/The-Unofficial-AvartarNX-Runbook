<div align="center">

![](../../.github/resources/images/logos/abatab-documentation-project-logo.png)

</div>

***

# About Abatab XML Documentation

Abatab uses XML documentation to:
- Provide IntelliSense content
- Generate API documentation via [DocFX](https://dotnet.github.io/docfx/)

# Standards

In addition to [Microsoft's XML documentation standards](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/):

- XML documentation comments are in the source code, and not in external files
- All publicly visible types and their public members are documented.
- It is recommended that private members also be documented.
- XML documentation are written using complete sentences ending, with full stops.
- XML documentation has a maximum width of 120 characters

# Formatting

## Text Formatting

XML documentation comments can using the following formatting tags:

- `<b>bold</b>`
- `<i>italic</i>`
- `<u>underline</u>`

## Special Characters

XML documentation can include the following special characters:

- Greater than: `&gt;`
- Lesser than: `&lt;`
- Space: `&nbsp;`

# Tags

Abatab XML documentation use [Microsoft's recommended XML tags for C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags).

## &lt;summary&gt;

`<summary>` should be a single line, and is a short description of whatever they precede (e.g., classes and methods).

Example:

```csharp
/// <summary>Compares two numbers to determine if they are the same.</summary>
```

## &lt;param&gt;

`<param` tags should describe each parameter, and be contained on a single line.

Example:

```csharp
/// <param name="numberOne">The first number.</param>
/// <param name="numberTwo">The second number.</param>
```

## &lt;remarks&gt;

`<remarks>` are optional, and should give additional, important information.

Remarks should be enclosed in `<remarks></remarks>` tags, even if they are a single line.

Lengthy remarks should be split into paragraphs using the `<para>` tag.

In general, remarks should be a simple bullet list:

```csharp
/// <remarks>
///     - Item 1
///     - Item 2
/// </remarks>
```

Remarks can contain complex lists:

```csharp
/// <remarks>
///     <para>
///         This method needs two things:
///         <list type="number">
///             <item>A number</item>
///             <item>Another number</item>
///         </list>
///     </para>
///     <para>
///         Numbers to be compared <u>must</u>:
///         <list type="bullet">
///             <item>
///                 Be &gt;= zero
///             </item>
///             <item>
///                 Be <i>less</i> than <c>100</c>
///             </item>
///             <item>
///                 Not be an <b>even</b> number
///             </item>
///         </list>
///     </para>
/// </remarks>
```

Remarks can contain tables, but they kind of look wonky in Visual Studio (but look good in DocFX):

```csharp
/// <remarks>
///     <para>
///         Keep in mind:
///         <list type="table">
///             <listheader>
///                 <term>Number</term>
///                 <description>Validity</description>
///             </listheader>
///             <item>
///                 <term>1</term>
///                 <description>Valid.</description>
///             </item>
///             <item>
///                 <term>2</term>
///                 <description>Invalid</description>
///             </item>
///             <item>
///                 <term>200</term>
///                 <description>Invalid</description>
///             </item>
///         </list>
///     </para>
/// </remarks>
```

## &lt;c&gt; and &lt;code&gt;

To insert a single line of code, or inline code, `<c>just put the code between these</c>`

To create a code block

```csharp
<code>
	Put the code
	in
	a code block  
<code>
```

## &lt;example&gt;

Example comments don't show in Visual Studio (?), but look fine in DocFX.

An example of...uh...an example XML comment:

```csharp
/// <example>
///     Here is an example of the code:
///     <code>
///     if(numberOne == numberTwo)
///     {
///         return true;
///     }
///     else
///     {
///         return false;
///     }
///     </code>
/// </example>
```

## &lt;returns&gt;

The `<returns>` content should be short, and contained to a single line.

Example:

```csharp
/// <returns>A boolean value.</returns>
```

## &lt;value&gt;

The `<value>` tag defines a value for something.

Example:

```csharp
/// <value>Default value is <c>false</c></value>
```

# Example

This example of an XML documentation comment details the correct tag order:

```csharp
/// <summary>Compares two numbers to determine if they are the same.</summary>
/// <param name="numberOne">The first number.</param>
/// <param name="numberTwo">The second number.</param>
/// <remarks>
///     <para>
///         This method needs two things:
///         <list type="number">
///             <item>A number</item>
///             <item>Another number</item>
///         </list>
///     </para>
///     <para>
///         Numbers to be compared <u>must</u>:
///         <list type="bullet">
///             <item>
///                 Be &gt;= zero
///             </item>
///             <item>
///                 Be <i>less</i> than <c>100</c>
///             </item>
///             <item>
///                 Not be an <b>even</b> number
///             </item>
///         </list>
///     </para>
///     <para>
///         Keep in mind:
///         <list type="table">
///             <listheader>
///                 <term>Number</term>
///                 <description>Validity</description>
///             </listheader>
///             <item>
///                 <term>1</term>
///                 <description>Valid.</description>
///             </item>
///             <item>
///                 <term>2</term>
///                 <description>Invalid</description>
///             </item>
///             <item>
///                 <term>200</term>
///                 <description>Invalid</description>
///             </item>
///         </list>
///     </para>
///     <para>
///         For more information please review the <see href="../link/GoesHere.html#Anchor">Abatab Documentation Project</see>.
///     </para>
/// </remarks>
/// <example>
///     Here is an example of the code:
///     <code>
///     if(numberOne == numberTwo)
///     {
///         return true;
///     }
///     else
///     {
///         return false;
///     }
///     </code>
/// </example>
/// <returns>A boolean of true or false.</returns>
/// <value>Default value is <c>false</c></value>
```

This belongs somewhere:

```csharp
/// <summary>Executing assembly name for log files.</summary>
/// <remarks>
///     - The executing assembly is defined at the start of the class so it can be easily used throughout the
///       method when creating log files.
/// </remarks>
``````


<br>
<br>

***

<div align="center">
	<h6>
		This document is part of the <a href="https://spectrum-health-systems.github.io/Abatab-Documentation-Project/">Abatab Documentation Project</a>
		<br>
		<sub style="color:DarkSlateGrey;">
			Last updated: <b>November 6, 2023</b> [b231106.1057]
		</sub>
	</h6>
</div>