// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Runtime.CompilerServices;

namespace TingenWebService.Core.Logger
{
    public static class LogEvent
    {
        public static void Debug(string logMsg = "", [CallerFilePath] string classPath = "", [CallerMemberName] string methodName = "", [CallerLineNumber] int lineNumber = 0)
        {
            DebugLog.Create(logMsg, classPath, methodName, lineNumber);
        }
        public static void Session(dynamic wsvcSession)
        {
            SessionLog.Create(wsvcSession);
        }
        internal static void Critical(string avatarUserId, dynamic tngnWsvcDataFolder, string exeAsm, string logTitle = "Unknown", string logMsg = "Unknown", [CallerFilePath] string classPath = "", [CallerMemberName] string methodName = "", [CallerLineNumber] int lineNumber = 0)
        {
            CriticalLog.Create(avatarUserId, tngnWsvcDataFolder, logTitle, logMsg, exeAsm, classPath, methodName, lineNumber);
        }
        internal static void Error(string avatarUserId, dynamic tngnWsvcDataFolder, string exeAsm, string errCode = "E###", string errMsg = "Unknown error.", [CallerFilePath] string classPath = "", [CallerMemberName] string methodName = "", [CallerLineNumber] int lineNumber = 0)
        {
            ErrorLog.Create(avatarUserId, tngnWsvcDataFolder, exeAsm, errCode, errMsg, classPath, methodName, lineNumber);
        }
        internal static void Trace(int traceLevel, int traceLogLimit, string sessionFolder, string exeAsm, [CallerFilePath] string classPath = "", [CallerMemberName] string methodName = "", [CallerLineNumber] int lineNumber = 0)
        {
            TraceLog.Create(traceLevel, traceLogLimit, sessionFolder, exeAsm, classPath, methodName, lineNumber);
        }
        internal static void History(string logFolder, string sessionDate, string logMsg)
        {
            HistoryLog.Create(logFolder, sessionDate, logMsg);
        }
    }
}
