# Xml documentation callouts

```xml
/// <summary>
/// This shows the result of the various <c>note</c> types.
/// </summary>
/// <remarks>
/// <para>These are various examples of the different note types.</para>
///
/// <note>
/// This example demonstrates the handling of a <c>note</c> element with no
/// defined type. It defaults to the "note" style.
/// </note>
///
/// <note type="tip">
/// Always document your code to help others understand how it is used.
/// </note>
///
/// <note type="implement">
/// Override this method in a derived class to do something useful
/// </note>
///
/// <note type="caller">
/// Calling this implementation will have no effect at all
/// </note>
///
/// <note type="inherit">
/// Types inheriting this base method will have no use for it as it does nothing
/// </note>
///
/// <note type="caution">
/// Use of this method is not recommended.
/// </note>
///
/// <note type="warning">
/// XML is case-sensitive so the note type must be entered as shown in order for
/// it to be interpreted correctly.
/// </note>
///
/// <note type="important">
/// Calling this method excessively will only slow down your application.
/// </note>
///
/// <note type="security">
/// It is always safe to call this method.
/// </note>
///
/// <note type="security note">
/// This method requires no special privileges
/// </note>
///
/// <note type="C#">
/// Use parenthesis when calling this method in C#.
/// </note>
///
/// <note type="VB">
/// Parenthesis are not required when calling this method in Visual Basic.
/// </note>
///
/// <note type="C++">
/// Use parenthesis when calling this method in C++.
/// </note>
///
/// <note type="J#">
/// Use parenthesis when calling this method in J#.
/// </note>
///
/// <para>See the <conceptualLink target="4302a60f-e4f4-4b8d-a451-5f453c4ebd46" />
```
