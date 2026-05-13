// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;

namespace TingenWebService.Core.Logger
{
    internal static class ErrorLog
    {
        internal static void Create(string avatarUserId, dynamic tngnWsvcDataFolder, string exeAsm, string errCode, string errMsg, string classPath, string methodName, int lineNumber)
        {
            var logName      = $"{errCode}-{avatarUserId}.error";
            var logBlueprint = File.ReadAllText($@"{tngnWsvcDataFolder.Blueprint}\error.blueprint");
            var logContent   = LogContent(logBlueprint, errCode, errMsg, exeAsm, classPath, methodName, lineNumber);
            LogUtility.WriteLocal($@"{tngnWsvcDataFolder.Session}\{logName}", logContent);
            LogUtility.WriteLocal($@"{tngnWsvcDataFolder.Log}\{logName}", logContent);
        }
        internal static string LogContent(string logBlueprint, string errCode, string errMsg, string exeAsm, string classPath, string methodName, int lineNumber) =>
            logBlueprint.Replace("~SESSION~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                        .Replace("~ERROR~CODE~", errCode)
                        .Replace("~ERROR~MESSAGE~", errMsg)
                        .Replace("~ASSEMBLY~", exeAsm)
                        .Replace("~CLASS~", LogUtility.GetClassName(classPath))
                        .Replace("~METHOD~", methodName)
                        .Replace("~LINE~", lineNumber.ToString());
    }
}
