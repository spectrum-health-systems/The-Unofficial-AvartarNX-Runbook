<!-- u251106 -->

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h1>
    Deploying the Tingen Web Service
  </h1>

</div>

> Last updated: November 6, 2025

# Overview

```mermaid
flowchart LR
    SBOX --> UAT --> LIVE
```

# SBOX

# UAT

# LIVE

Similar to how we modified the SBOX instance of the Tingen Web Service to deploy to UAT, we will use the UAT instance to deploy to LIVE.

It is recommended that you make a backup copy of the Web.config file before proceeding.

## Backup everything

Backup the following:

* Tingen_www\WebService\LIVE\\*
* Tingen_Data\WebService\LIVE\\*

## Modifying the UAT instance Web.config file

Make the following modifications to the `<TingenWebService.Properties.Settings>` section of the Web.config file:

### Avatar System

*Original*

```xml
<setting name="AvatarSystem" serializeAs="String">
  <value>UAT</value>
</setting>
```

*Modified*

```xml
<setting name="AvatarSystem" serializeAs="String">
  <value>LIVE</value>
</setting>
```

### Mode

In general, you can leave the Mode set to "Enabled".

<!-- should be "Disabled" when SBOX -> UAT for testing mode functionality. -->

### TraceLogLimit

It is recommended that you leave this set to "0" in your LIVE environment.

### BaseWww, BaseData, and BuildNumber

These values should not be changed.

### NtstWsvcUserName and NtstWsvcUserPass

These values must be valid in your Avatar LIVE system.

## Verify all ScriptLink Script Parameter changes have been made in your LIVE system

If there were any changes to any Script Parameters in your LIVE environment, they must be modified.

To modify a Script Paramater:

1. Open the form in Form Designer
2. Modify the Script Parameter
3. Disable the modified Script Parameter
4. After submitting the form, verify the Script Parameter has been modified and that it is disabled

## Delete the current LIVE instance of the Tingen Web Service

> For performance reasons, it is recommended that you do this on the server.

Delete it.

## Copy the SBOX instance of the Tingen Web Service to the LIVE location

> For performance reasons, it is recommended that you do this on the server.

Copy it.
