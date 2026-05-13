<!-- u251110 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>

  <h1>
    Tingen Web Service R25.8 Release Notes
  </h1>

</div>

> [!IMPORTANT]
> Many of the entries in this changelog are specific to [Outpost31](https://github.com/spectrum-health-systems/outpost31), but are documented here for organizational purposes.
>
> ***This documentation may be superseded by later releases.***

## AdminMode

* Created **AdminMode**, defined in Web.config, to perform the following administrative functions:
  * **Deploy**  - Deploy a new instance of the Tingen Web Service
  * **Refresh** - Refresh the AppData contents
  * **Regress** - Regression tests

## Logging functionality

* Updating the logging functionality to include the following types of logs:
  * Critical
  * Trace
  * Debuggler
  * Error
  * Primeval
