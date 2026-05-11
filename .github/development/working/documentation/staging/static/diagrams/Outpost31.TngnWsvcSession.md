<!-- u251002 -->

[[🏠︎](../../README.md)] ❬ [Static documentation](../README.md) ❬ [Diagrams](README.md)

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h1>
    Diagram ❭ NS:Outpost31.TngnWsvcSession
  </h1>

</div>
### CONTENTS

* Instance.cs  
  * [Instance.Load()](#instanceload)  
  * [Instance Start()](#instancestart)  
* Detail.cs  
  * [Detail.Load()](#detailload)

***

# Instance.cs

## Instance.Load()

> Last updated 9/24/25

```mermaid
flowchart TD
    A[Instance.Load] --> B[Call Details.Load]
    B --> C[Call Folders.Load]
    C --> D[Call LogSettings.Load]
    D --> E[Create AvatarOptionObject]
    E --> F[Create AvatarScriptParameter ]
    F --> G[Return new Instance]
```

## Instance.Start()

> Last updated 9/24/25

```mermaid
flowchart TD
    A[Instance.Start] --> B[Instance.Load]
    B --> C[Instance created]
    C --> D[Folders.CreateSessionFolder]
    D --> E[Return session]
```

# Detail.cs

## Detail.Load()

> Last updated 9/24/25

```mermaid
flowchart TD
    A[Details.Load] --> B[Get current date ]
    B --> C[Get current time]
    C --> D[Set Version]
    D --> E[Set Mode]
    E --> F[Set AvatarSystem]
    F --> G[Set AvatarUserName]
    G --> H[Set RunningLog]
    H --> I[Return new Details object]
```
