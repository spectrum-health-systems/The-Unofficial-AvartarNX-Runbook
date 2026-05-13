<!-- u250924 -->

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h1>
    Diagram ❭ NS:TingenWebService.Configuration
  </h1>

</div>

### CONTENTS

* asmx.cs
    * [GetVersion()]()
    * [RunScript()]()
* Configuration
    * [TingenWebService.Configuration.RuntimeConfig.cs](#tingenwebserviceconfigurationruntimeconfigcs)  

***

## TingenWebService.asmx.cs

> Last updated 9/24/25

```mermaid
flowchart TD
    A[TingenWebService.RunScript] --> B[RuntimeConfig.Load]
    B --> C{TingenWebService.CriticalFailureOccurred}
    C -- True --> D[Return origOptObj.ToReturnOptionObject]
    C -- False --> E{Mode}
    E -- enabled --> F[Instance.Start]
    E -- passthrough --> F
    E -- other --> J[Return origOptObj.ToReturnOptionObject]
    F --> G[AvatarScriptParameter.ParseParameter]
    G --> H[LogEvent.Session]
    H --> I[Return sess.OptObj.Completed]
```

## TingenWebService.Configuration.RuntimeConfig.cs

> Last updated 9/24/25

```mermaid
flowchart TD
    A[RuntimeConfig.Load] --> B[Receive webConfig and tngnWsvcVer]
    B --> C[Create new Dictionary]
    C --> D[Add Version]
    D --> E[Add BuildNumber]
    E --> F[Add AvatarSys]
    F --> G[Add Mode]
    G --> H[Add BaseWww]
    H --> I[Add BaseData]
    I --> J[Add TraceLogLimit]
    J --> K[Return Dictionary]
```

***

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)
