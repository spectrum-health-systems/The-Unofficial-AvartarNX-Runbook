<!-- u250924 -->

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h1>
    Diagram ❭ NS:TingenWebService
  </h1>

</div>

### CONTENTS

* asmx.cs
    * [GetVersion()](#getversion)
    * [RunScript()](#runscript)
    * [CriticalFailureOccurred()](#criticalfailureoccurred)

***

## GetVersion()

> Last updated 9/24/25

## RunScript()

> Last updated 9/24/25

<div align="center">

```mermaid
flowchart TD
    %% Components
    Start@{shape: sm-circ, label: ""}
    RuntimeConfig_Load@{shape: fr-rect, label: "RuntimeConfig.Load()"}
    CriticalFailureOccurred@{shape: rounded, label: "CriticalFailureOccurred()"}
    ReturnOriginalOptionObject@{shape: dbl-circ, label: "Return original\nOptionObject"}
    Mode@{shape: diam, label: "Mode"}
    Instance.Start@{shape: fr-rect, label: "Instance.Start()"}
    ParseParameter@{shape: fr-rect, label: "AvatarScriptParameter.ParseParameter()"}
    LogSession@{shape: fr-rect, label: "LogEvent.Session()"}
    ReturnUpdatedOptionObject@{shape: dbl-circ, label: "Return updated\nOptionObject"}
    %% Layout
    Start --> RuntimeConfig_Load:::E3_ --> CriticalFailureOccurred:::E3_
    CriticalFailureOccurred -- True --> ReturnOriginalOptionObject:::E3_
    CriticalFailureOccurred -- False --> Mode:::E3_
    Mode -- enabled --> Instance.Start:::U3_
    Mode -- passthrough --> Instance.Start
    Mode -- other --> ReturnOriginalOptionObject
    Instance.Start --> ParseParameter:::U3_
    ParseParameter --> LogSession:::U3_
    LogSession --> ReturnUpdatedOptionObject:::E3_
    %% Styles
    classDef E3_ stroke:#fdf2e9,stroke-width:2px,fill:#ca6f1e,color:#fdf2e9
    classDef U3_ stroke:#eaf2f8,stroke-width:2px,fill:#2471a3,color:#eaf2f8
    %% Links
    click RuntimeConfig_Load "https://github.com/spectrum-health-systems/tingen-documentation-project/blob/main/static/diagrams/TingenWebService.Configuration.md#tingenwebserviceconfigurationruntimeconfigcs"
    click CriticalFailureOccurred "https://github.com/spectrum-health-systems/tingen-documentation-project/blob/main/static/diagrams/TingenWebService.md#criticalfailureoccurred"
```

</div>

## CriticalFailureOccurred()

> Last updated 9/25/25

```mermaid
flowchart TD
    %% Content
    Start@{shape: sm-circ, label: ""}
    InvalidAvatarData:::E3_@{shape: diam, label: "Invalid data\nfrom Avatar?"}
    Mode:::E3_@{shape: diam, label: "Mode"}
    WriteTrueLog:::E3_@{shape: rect, label: "Write log"}
    WriteFalseLog:::E3_@{shape: rect, label: "Write log"}
    ReturnTrue:::E3_@{shape: rounded, label: "Return true"}
    ReturnFalse:::E3_@{shape: rounded, label: "Return false"}
    %% Layout
    Start --> InvalidAvatarData
    InvalidAvatarData -- Yes --> WriteFalseLog--> ReturnTrue
    InvalidAvatarData -- No --> Mode
    Mode -- enabled --> ReturnFalse
    Mode -- passthrough --> ReturnFalse
    Mode -- disabled --> WriteTrueLog
    Mode -- default --> WriteTrueLog
    WriteTrueLog --> ReturnTrue
    %% Styles
    classDef E3_ stroke:#fdf2e9,stroke-width:2px,fill:#ca6f1e,color:#fdf2e9
```

***

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)