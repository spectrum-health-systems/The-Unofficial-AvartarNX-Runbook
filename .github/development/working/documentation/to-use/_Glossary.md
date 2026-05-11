<!--
  u240814_work-in-progress
-->

<div align="center">

  ![logo](./.github/image/logos/TingenDevelopmentDocumentation_logo_320x420.png)

  <h1>
    Tingen Glossary
  </h1>

</div>

- [Tingen](#tingen)
  - [Logging](#logging)
  - [Modules](#modules)
- [Avatar](#avatar)
- [Outpost31](#outpost31)

# Tingen

**Tingen** is a custom web service for Avatar, and is called via a ScriptLink event on a form.  

Perhaps surprisingly, Tingen doesn’t actually do any work, it just accepts data sent from Avatar, and passes it along to [Outpost31](#outpost31).

## Tingen Configuration <!-- omit in toc -->

Information about configuring Tingen goes here.

## Tingen Modes <!-- omit in toc -->

Tingen operates in one of the following *modes*:

| Mode | Description |
| ---- | ----------- |
| `enabled` | Tingen functions normally. |
| `disabled` | Tingen is disabled, and doesn't do anything. |

## Logging

### Trace logs <!-- omit in toc -->

Trace logs calls include a *log level* parameter.

If the log level of the call is *less than or equal* to the TraceLogLevel, the log will be written. Otherwise, the log will be skipped.

This allows you to place log calls throughout the code, and then control the amount of logging that is done when Tingen is executed.

### Primeval logs <!-- omit in toc -->

TBD

## Modules

### Module Modes <!-- omit in toc -->

Tingen modules operate in one of the following *modes*:

| Mode | Description |
| ---- | ----------- |
| `enabled` | The module functions normally. |
| `disabled` | The module is disabled, and doesn't do anything. |

Disabling a module only affects that specific module, other modules/components of Tingen will function according to their specific mode.

### Open Indicent Module <!-- omit in toc -->

# Avatar

## Avatar System Codes <!-- omit in toc -->

Information about the Avatar System Code goes here.

## Avatar Script Parameter <!-- omit in toc -->

Information about the Avatar Script Parameter goes here.

## Avatar OptionObject <!-- omit in toc -->

Information about Avatar OptionObjects go here.

### OptionObject error codes <!-- omit in toc -->

Information about OptionObject error messages go here.

# Outpost31

When Tigen is called via a ScriptLink event, a [Script Parameter](URL) is passed to Tingen. That Script Parameter is then passed to Outpost31, which does most of the work.
