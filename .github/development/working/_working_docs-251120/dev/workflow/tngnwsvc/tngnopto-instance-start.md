<!-- u250908 -->

# Outpost31.Core.Session.Instance.Start()

```mermaid
flowchart TB
  %% Content
  From_TingenWebService.asmx.cs@{ shape: stadium, label: "TingenWebService.asmx.cs" }
  CreateSessionFolder@{ shape: rounded, label: "Create session folder" }
  To_ParseRequest@{ shape: stadium, label: "Outpost31.Core.Request.Parser.ParseRequest()" }
  subgraph CreateNewSessionInstance ["Create session object[1]"]
    direction LR
      %% Content
      SetCurrentStamp@{ shape: rect, label: "Set current\ndate/time" }
      SetAvatarInfo@{ shape: rect, label: "Set Avatar System\nand User ID" }
      SetServiceInfo@{ shape: rect, label: "Set service version,\nmode, and framework" }
      SetLoggingInfo@{ shape: rect, label: "Set log\nsettings" }    
      SetOptionObjects@{ shape: rect, label: "Set\nOptionObjects" }
      SetScriptParameter@{ shape: rect, label: "Set Script\nParameter details" }
      %% Layout
      SetCurrentStamp --> SetAvatarInfo --> SetServiceInfo --> SetLoggingInfo --> SetOptionObjects --> SetScriptParameter
      %% Styles
  end
  %% Layout
  From_TingenWebService.asmx.cs --> CreateNewSessionInstance --> CreateSessionFolder --TingenWebService.asmx.cs--> To_ParseRequest
  %% Styles 
```

> NOTES:  
> [1] Some of these use existing Web.config settings, some are set when the session starts.

## Next

[Outpost31.Core.Request.Parser.ParseRequest()](tngnopto-parser-parserequest.md)