// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;

namespace TingenWebService.Core.Logger
{
    internal static class CriticalLog
    {
        internal static void Create(string avatarUserId, dynamic tngnWsvcDataFolder, string logTitle, string logMsg, string exeAsm, string classPath, string methodName, int lineNumber)
        {
            var logName      = $"{logTitle}-{avatarUserId}.critical";
            var logBlueprint = File.ReadAllText($@"{tngnWsvcDataFolder.Blueprint}\critical-error.blueprint");
            var logContent   = LogContent(logBlueprint, logMsg, exeAsm, classPath, methodName, lineNumber);
            LogUtility.WriteLocal($@"{tngnWsvcDataFolder.Session}\{logName}", logContent);
            LogUtility.WriteLocal($@"{tngnWsvcDataFolder.Log}\{logName}", logContent);
        }
        internal static string LogContent(string logBlueprint, string logMsg, string exeAsm, string classPath, string methodName, int lineNumber) =>
           logBlueprint.Replace("~SESSION~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                       .Replace("~LOG~MESSAGE~", logMsg)
                       .Replace("~ASSEMBLY~", exeAsm)
                       .Replace("~CLASS~", LogUtility.GetClassName(classPath))
                       .Replace("~METHOD~", methodName)
                       .Replace("~LINE~", lineNumber.ToString());
    }
}
