// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.IO;
using System.Reflection;
using TingenWebService.Core.Logger;

namespace TingenWebService.Core.Parse
{
    public static class Request
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void Prototype(dynamic tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            // No prototype functionality yet.
        }
        internal static void TngnWsvc(dynamic tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            if (string.Equals(tngnWsvcSession.ScriptParameter.OriginalScriptParameter, "TngnWsvcTest", System.StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                //Module.TngnWsvc.Deployer.Test(tngnWsvcSession.Framework, tngnWsvcSession.LogSetting.TraceLogLimit);
                //LogEvent.Session(sess);
                tngnWsvcSession.Avatar.AvatarOptionObject.ToReturn(tngnWsvcSession, 3, "Testing complete.");
            }
            else if (string.Equals(tngnWsvcSession.ScriptParameter.OriginalScriptParameter, "TngnWsvcDeploy", System.StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                //Module.TngnWsvc.Deployer.Deploy(wsvcSession);
                LogEvent.Debug();
                //LogEvent.Session(sess);
                tngnWsvcSession.Avatar.AvatarOptionObject.ToReturn(tngnWsvcSession, 3, $"Deployment to {tngnWsvcSession.Runtime.AvatarSystem.ToUpper()} complete.");
                LogEvent.Debug();
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var template = File.ReadAllText($@"{tngnWsvcSession.Framework.TngnWsvcDataFolder.Blueprint}\Command\UnknownParameter.blueprint");
                var content  = template.Replace("~COMMAND~", tngnWsvcSession.ScriptParameter.OriginalScriptParameter)
                                       .Replace("~VERSION~", tngnWsvcSession.Runtime.Version)
                                       .Replace("~ERROR~CODE~", "7T7TV");
                tngnWsvcSession.Avatar.AvatarOptionObject.ToReturn(tngnWsvcSession, 3, content);
            }
        }
    }
}
