# Common source code stuff

## File headers

```csharp
// =============================================================================
// https://github.com/spectrum-health-systems/outpost31
// u251112_code
// u251112_documentation
// =============================================================================
```

## Class headers

```csharp
/// <summary>Description</summary>
/// <remarks>For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.</remarks>
```





## Executing assembly

```csharp
/// <summary>Required for logging functionality.</summary>
public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
```

## Parameter XML

```csharp

/// <param name="avatarSystem">The <see cref="Core.Avatar.AvatarEnvironment.AvatarSystem"/> that the Tingen Web Service will interface with.</param>

/// <param name="avatarSystemCode">The <see cref="Core.Avatar.AvatarEnvironment.AvatarSystemCode"/> Used to login to Avatar.</param>

/// <param name="errCode">The OptionObject <see cref="ErrorCode"/>.</param>

/// <param name="errMsg">The OptionObject Error Message that is displayed to the user.</param>

/// <param name="avatarUserId">The Avatar username that is interfacing with the Tingen Web Service.</param>

/// <param name="origOptObj">The original <see cref="AvatarOptionObject"/> sent from Avatar.</param>

/// <param name="origScriptParam">The original <see cref="AvatarScriptParameter"/> sent from Avatar.</param>

/// <param name="serverDataPath">The path to the server data folder.</param>

/// <param name="serverWwwPath">The path to the server www folder.</param>

/// <param name="sessionDate">The date of the current session.</param>

/// <param name="sessionFolder">The current session folder.</param>

/// <param name="sessionStartTime">The start time of the session.</param>

/// <param name="tngnWsvcFramework">The Tingen Web Service Framework object.</param>

/// <param name="tngnWsvcMode">The Tingen Web Service <c>Mode</c>.</param>

/// <param name="tngnWsvcSession">The <see cref="TngnWsvcSession"/> that contains all the information for this session.</param>

/// <param name="tngnWsvcVersion">The current <see cref="TingenWebService.TngnWsvcVersion"/> of the Tingen Web Service.</param>

/// <param name="traceLogLimit">The global <see cref="Core.Logger.LogSettings.TraceLogLimit"/>.</param>




















## Signature order

tngnWsvcSession
    tngnWsvcSessionRuntime
    TngnWsvcFramework
    LogSettings
    AvatarOptionObject
    AvatarScriptParameter

traceLogLimit
avatarSystem
optionId
sessionDate
sessionStartTime






/// <param name="origOptObj">The <see cref="OptionObject2015"/> sent from Avatar.</param>
/// <param name="origScriptParam">The original <see cref="AvatarScriptParameter"/>sent from Avatar.</param>

/// <param name="runtimeConfig">A dictionary containing runtime configuration settings for the session.</param>

/// <param name="tngnWsvcMode">The Tingen Web Service mode.</param>

/// <param name="openIncidentConfig">The Open Incident module confituration.</param>
/// <param name="errCode">The OptionObject error code.</param>
/// <param name="errMsg">The OptionObject error message.</param>

/// <param name="errCode">The error code identifying the type of error.</param>
/// <param name="errMsg">The error message providing details about the error.</param>

/// <param name="logTitle">The log title.</param>
/// <param name="logMsg">The log Message.</param>
/// <param name="avatarUserName">The <see cref="AvatarUserName"/> username.</param>
/// <param name="tngnWsvcFolder">The Tingen Web Service folder framework.</param>
/// <param name="exeAsm">The executing assembly that caused the error.</param>
/// <param name="classPath">The path to the class that caused the error.</param>
/// <param name="methodName">The method that caused the error.</param>
/// <param name="lineNumber">The line of code that caused the error.</param>

/// <param name="logBlueprint">A string containing placeholders to be replaced with log details.</param>

/// <param name="traceLevel">The trace level of the requested log.</param>





/// <param name="sessionDetail">Current session details.</param>
/// <param name="sessionScriptParameter">Current session ScriptParameter.</param>
/// <param name="newEntry">The new entry to add to the session running log.</param>

/// <param name="version">The current <see cref="Version"/> of the Tingen Web Service.</param>

/// <param name="mode">The Tingen Web Service <see cref="Mode"/>.</param>

/// <param name="generatedDataPath">The path to the directory containing the generated data files.</param>
/// 
/// <param name="translationPath">The path to the directory where translation files are stored.</param>

/// <param name="avatarSystem">The <see cref="AvatarSystem"/> that the Tingen Web Service will interface with.</param>

/// <param name="avatarUserName">The <see cref="AvatarUserName"/>.</param>

/// <param name="ntstWsvcUserName">The Avatar UserName that will be used to authenticate with Netsmart web services.</param>

/// <param name="ntstWsvcUserPass">The password for the Avatar UserName that will be used to authenticate with Netsmart web services.</param>

/// <param name="dailyLogPath">The path to the daily logs.</param>

```

```csharp
/* For more information about Tingen Web Service logging, please see:
 * https://github.com/spectrum-health-systems/tingen-documentation-project/blob/main/static/logger.md
 */

/// <remarks>For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.</remarks>

```

// <https://github.com/spectrum-health-systems/tingen-web-service>
// u251106_code
// u251106_documentation






