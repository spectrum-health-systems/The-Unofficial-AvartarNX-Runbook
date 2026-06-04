<!-- u250530 -->

[View [Markdown version](https://github.com/spectrum-health-systems/tingen-documentation/blob/main/docs/static/project-guidelines.md)]

# Project Guidelines

* [Source code comments](#source-code-comments)
* [Versioning](#versioning)

***

## Source code

* [XML documentation guidelines](https://github.com/APrettyCoolProgram/aprettycoolprogram/blob/main/profile/development-guidelines/xml-documentation.md)
* [Source code comment guidelines](https://github.com/APrettyCoolProgram/aprettycoolprogram/blob/main/profile/development-guidelines/comments.md)
* [Source code syntax and formatting](https://github.com/APrettyCoolProgram/aprettycoolprogram/blob/main/profile/development-guidelines/syntax-and-formatting.md)

***

## Versioning

The Tingen projects use `MM.DD.patch` versioning, where:

* `MM` is the the release year
* `DD` is the release month
* `patch` is an optional patch number

For example: `25.02.1`

This isn't 'Nam, there are rules:

* The **YY** is two digits (e.g., 2025 would be `25`)
* The **MM** component is two digits (e.g., July would be `07`)
* The **Patch** component is a single digit, and is `0` if there are no patches
* The `Revision` component in the <i>AssemblyInfo.cs</i> file) is always `0`

For each release of Tingen the following lines:

```csharp
[assembly: AssemblyVersion("Major.Minor.Build.Revision")]
[assembly: AssemblyFileVersion("Major.Minor.Build.Revision")]
```

Need to be modified as so:

```csharp
[assembly: AssemblyVersion("YY.MM.Patch.0")]
[assembly: AssemblyFileVersion("YY.MM.Patch.0")]
```

So, for example the December 2024 release, without a patch, would look like this:

```csharp
[assembly: AssemblyVersion("24.12.0.0")]
[assembly: AssemblyFileVersion("24.12.0.0")]
```
