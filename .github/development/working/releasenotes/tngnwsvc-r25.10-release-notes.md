<!-- u251110 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>

  <h1>
    Tingen Web Service R25.10 Release Notes
  </h1>

</div>

> [!IMPORTANT]
> Many of the entries in this changelog are specific to [Outpost31](https://github.com/spectrum-health-systems/outpost31), but are documented here for organizational purposes.
>
> ***This documentation may be superseded by later releases.***

# Core

## Core.Maintenance.DailyMaintenance.cs

### The daily system folder

When any function of the web service is called, the existence of the `AppData/Log/YYMMMDD` folder is confirmed. If the folder does **not** exist, it is created, and:

  1. A `YYMMDD.log` file is created
  2. Translation tables are refreshed

### Updating translation tables

When the daily maintenance is executed, the translation tables are updated.

## Core.Logger

Trace logs now have an individual **traceLevel** and a global **traceLevelLimit**, which allows you to specify which trace logs are created.

The *traceLevel* is defined on a per-log basis, and the *traceLevelLimit* is defined in Web.config.
 is defined on a per-log basis, and the *traceLevelLimit* is defined in Web.config.
 is defined on a per-log basis, and the *traceLevelLimit* is defined in Web.config.

Setting the *traceLogLimit* to "0" will disable all trace logs, regardless of their *traceLevel*.

If a trace log has a  *traceLimit* of "1" , it will always be created regardless of the *traceLogLimit*. Otherwise, a trace log will be created if it has a *traceLimit* that is less than the *traceLogLimit*

## Core.Translation.UserId.cs

* The generated `USERID_UserDescription_Active.txt` file is recompiled to `USERID_UserDescription_Active.translation`
* The `OptionUserId` is trimmed to avoid mis-matches due to leading/trailing whitespace

# Modules

* Modules now have three default ScriptLink events:
  * `_FormLoadEvent`
  * `_PreFileEvent`
  * `_PostFileEvent`

### Module.OpenIncident

* Added `ProgramOfIncidentFieldId`, `InvalidProgramOfIncidentMsg`, and `InvalidProgramOfIncidentErrCode` to OpenIncidentConfig.cs
* Fixed issue where a blank line in the USERID_User Description.txt file caused an error with the translation table.
