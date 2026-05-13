// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;

namespace TingenWebService.Core.Logger
{
    internal static class SessionLog
    {
        internal static void Create(dynamic wsvcSession)
        {
            var logName      = $"{wsvcSession.Runtime.AvatarUserId}.session";
            var logBlueprint = File.ReadAllText($@"{wsvcSession.Framework.TngnWsvcDataFolder.Blueprint}\session-log.blueprint");
            var logContent   = Outline(logBlueprint, wsvcSession.Runtime, wsvcSession.ScriptParameter.OriginalScriptParameter);
            LogUtility.WriteLocal($@"{wsvcSession.Framework.TngnWsvcDataFolder.Session}\{logName}", logContent);
        }
        internal static string Outline(string logBlueprint, dynamic sessionDetail, string sessionScriptParameter)
        {
            var endTime  = DateTime.Now.ToString("HHmmss");
            var duration = (DateTime.ParseExact(endTime, "HHmmss", null) - DateTime.ParseExact(sessionDetail.SessionTime, "HHmmss", null)).ToString(@"hh\:mm\:ss");
            return logBlueprint.Replace("~SESSION~DATE~", sessionDetail.SessionDate)
                               .Replace("~SESSION~START~", sessionDetail.SessionTime)
                               .Replace("~SESSION~END~", endTime)
                               .Replace("~SESSION~DURATION~", duration)
                               .Replace("~OPTIONID~", sessionDetail.AvatarUserId.ToUpper())
                               .Replace("~AVATAR~SYSTEM~", sessionDetail.AvatarSystem.ToUpper())
                               .Replace("~SCRIPT~PARAMETER~", sessionScriptParameter)
                               .Replace("~RUNNING~LOG~", sessionDetail.RunningLog);
        }
        internal static void AddToRunningLog(dynamic wsvcSession, string callerInfo, string runningTitle, string runningBody) =>
            wsvcSession.Runtime.RunningLog += $"[{DateTime.Now:mmssff}] [{callerInfo}]{Environment.NewLine}" +
                                                     $"{runningTitle}{Environment.NewLine}" +
                                                     $"{runningBody}{Environment.NewLine}" +
                                                     $"{Environment.NewLine}";
        internal static void AddToSessionLog(dynamic wsvcSession, string[] logContents) =>
            wsvcSession.Runtime.RunningLog += $"[{DateTime.Now:mmssff}] [{logContents[0]}]{Environment.NewLine}" +
                                                     $"{logContents[1]}{Environment.NewLine}" +
                                                     $"{logContents[2]}{Environment.NewLine}" +
                                                     $"{Environment.NewLine}";
    }
}
