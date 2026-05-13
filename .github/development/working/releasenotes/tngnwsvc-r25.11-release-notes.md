<!-- u251110 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>

  <h1>
    Tingen Web Service R25.11 Release Notes
  </h1>

</div>

> [!IMPORTANT]  
> Many of the entries in this changelog are specific to [Outpost31](https://github.com/spectrum-health-systems/outpost31), but are documented here for organizational purposes.
>
> ***This documentation may be superseded by later releases.***

***THIS DOCUMENT IS A WORK IN PROGRESS AND WILL NOT BE OFFICIAL UNTIL R25.11 IS RELEASED***

# Core

## Query

### Query UserId

.Quesry.WEBSVC.Query

The Tingen Web Service now can query the Avatar database directly, using the Netsmart WEBSVC.Query web service.

Currently this is being used to:

* Get the `User Description` for a `User ID`
* Get a list of `User Roles` for a user

## OpenIncident Mode

## Catch and export OptionObjects

A new Script Parameter called `CatchOptionObject` calls `Module.TngnWsvc.OptObjUtility.CatchOptionObject()`, which then exports the original OptionObject as both `.html` and `.json` files to the `AppData\Exports` folder.

The `.json` file, unfortunately, is not formatted nicely (that's on the roadmap).

## DoseChangeEvaluationOtp Module

This module has logic, but is currently not implemented.

* OptionObject catcher
* Export OptObj
* DoseChangeEvaluationOtp

## Core

* UserRole query
* UserDefinition query
* Depreciate translation tables

## Module

## Misc

* Split the Framework namespace into three seperate classes:
  * TngnWsvcFramework.cs  
    High-level logic and common methods for the Tingen Web Service framework.

  * TngnWsvcDataFolders.cs

  * TngnWsvcWwwFolders.cs


* Fixed broken links in Project.xml


* Refactor/cleanup
* XML documentation complete
