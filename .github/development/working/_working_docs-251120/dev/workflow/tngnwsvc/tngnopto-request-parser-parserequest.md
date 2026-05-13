<!-- u250908 -->

# Outpost31.Core.Request.Parser.ParseRequest()

```mermaid
flowchart LR
  %% Content
  From_TingenWebService.asmx.cs@{ shape: stadium, label: "TingenWebService.asmx.cs" }
  ScriptParameterStartsWith@{ shape: diam, label: "Script Parameter\nstarts with[1]" }
  To_Outpost31.Core.Request.Parser.ParseStandardRequest@{ shape: stadium, label: "Outpost31.Core.Request.Parser.ParseStandardRequest()" }
  To_Outpost31.Core.Request.Parser.ParseAdminRequest@{ shape: stadium, label: "Outpost31.Core.Request.Administrative()" }
  To_Outpost31.Core.Request.Parser.ParsePrototypeRequest@{ shape: stadium, label: "Outpost31.Core.Request.Parser.ParsePrototypeRequest()" }
  %% Layout
  From_TingenWebService.asmx.cs --> ScriptParameterStartsWith
  ScriptParameterStartsWith --> To_Outpost31.Core.Request.Parser.ParseStandardRequest
  ScriptParameterStartsWith --_a --> To_Outpost31.Core.Request.Parser.ParseAdminRequest
  ScriptParameterStartsWith --_p --> To_Outpost31.Core.Request.Parser.ParsePrototypeRequest
```

> NOTES:  
> [1] There are three types of requests:
> * Standard requests do not have a prefix  
> * Administrative requests start with **"_a"**
> * Prototype requests start with **"_p"**
