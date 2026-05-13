<!-- u251110 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>

  <h1>
    Tingen Web Service R25.9 Release Notes
  </h1>

</div>

> [!IMPORTANT]
> Many of the entries in this changelog are specific to [Outpost31](https://github.com/spectrum-health-systems/outpost31), but are documented here for organizational purposes.
>
> ***This documentation may be superseded by later releases.***

##### CONTENTS

* Core functionality
  * [Core.Logger](#corelogger)
  * [Web.config file](#webconfig-file)
* Module functionality
  * [Module.OpenIncident](#moduleopenincident)
* [Miscellaneous](#miscellaneous)

***

# Core

## Core.Logger

**`NEW`** **TraceLevel** and **TraceLogLimit**  
Trace logs now have an individual *TraceLevel* and a global *TraceLogLimit*, which allows you to specify which trace logs are created.

## Web.config file

* `NEW` **AvatarSystem**  
The Avatar *System* that the Tingen Web Service will interface with.
  > Values: **`SBOX`**, `UAT`, `LIVE`  

* `NEW` Mode
* `NEW` BaseWww
* `NEW` BaseData
* `NEW` BuildNumber

# Module functionality

## Module.OpenIncident

* `NEW` _VerifyOriginalAuthorIsOpening
* `NEW` _VerifyOriginalAuthorIsSubmitting
* If the AvatarUsername is not found in the translation table, the user a popup will appear instructing the user to contact the service desk

## Miscellaneous

* Web service can now be used in the SBOX, UAT, and LIVE system codes
* Session data now includes the current day/time, the Avatar UserName, and framework details
* Split the *Parser* class into separate, partial classes
* Renamed the *session* object is now *sess*
* Significant rework of logging functionality
* Standard blueprint files have a **.bp** extension, while embedded blueprint files have a **.embp** extension.
* Added non-standard trace logging in TingenWebservice.Runscript()
* Removed the popup when the Tingen Web Service is disabled, since that would actually cause havoc. 
* `REMOVED` AdminMode (functionality has been moved to the Administration Module)
* `REMOVED` The popup that appears when the Tingen Web Service is disabled.

***
