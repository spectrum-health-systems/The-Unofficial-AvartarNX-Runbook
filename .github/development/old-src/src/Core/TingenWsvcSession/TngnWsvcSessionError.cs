// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================
using System;
using System.Reflection;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Logger;

namespace TingenWebServiceCore.TingenWsvcSession
{
    internal class TngnWsvcSessionError
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void HardError(dynamic wsvcSession, int errCode, string errMsg)
        {
            var runningLogContent = errMsg + Environment.NewLine +
                                    $"Parameter = {wsvcSession.ScriptParameter}{Environment.NewLine}";
            SessionLog.AddToRunningLog(wsvcSession, LogComponents.GetCallerInfo(), "HARD ERROR", runningLogContent);
            AvatarOptionObject.ToReturn(wsvcSession, errCode, errMsg);
        }
    }
}
