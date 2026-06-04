<div align="center">

![](../../.github/resources/images/logos/abatab-documentation-project-logo.png)

</div>

***

# About Abatab Source Code File Headers

All `.cs` files should have a file header comment.

All file headers have a maximum width of 80 characters, with the exception of URLs that are longer than 80 characters.

# Primary Header

Abatab.asmx.cs is the main entry point for Abatab, so it contains the primary header for Abatab:

```text
// =============================================================================
// Abatab: A custom web service/framework for Netsmart's myAvatar EHR.
// https://github.com/spectrum-health-systems/Abatab
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
//
// For details about this release, please see the local Source Code README.md:
//   Abatab/README.md
// =============================================================================
```

# Class Header

Each class has a simple header with the build number:

`// bYYMMDD.HHMM`

Example:

`// b231030.1043`

## Class details

All class details (description, etc.) should be contained in the XML documentation.

<!-- This footer should be at the bottom of every Abatab Documentation Project page -->
<br>

***

<div align="center">

This document is part of the
[Abatab Documentation Project](/README.md)<br>
	
<sub>
Last updated: December 5, 2023<br>
</sub>
</div>
