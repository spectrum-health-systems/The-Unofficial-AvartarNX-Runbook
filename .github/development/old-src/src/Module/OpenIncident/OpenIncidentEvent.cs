// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Reflection;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Logger;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.OpenIncident
{
    /// <summary>Handles OpenIncident Module events.</summary>
    internal class OpenIncidentEvent
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void Parse(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var configFileName     = "OpenIncident.config";
            var configAbsolutePath = $@"{tngnWsvcSession.Framework.TngnWsvcDataFolder.Config}\{configFileName}";
            var openIncidentConfig = OpenIncidentConfig.Load(configAbsolutePath, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session);
            if (openIncidentConfig.Mode.Equals("enabled", System.StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                switch (tngnWsvcSession.ScriptParameter.OriginalScriptParameter.ToLower())
                {
                    case "_formload":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        FormLoad(tngnWsvcSession, openIncidentConfig);
                        break;
                    case "_prefile":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        PreFile(tngnWsvcSession, openIncidentConfig);
                        break;
                    case "_postfile":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        OpenIncidentRequest.PostFileEvent(tngnWsvcSession, openIncidentConfig);
                        break;
                    default:
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        // TODO Hard error for unsupported script parameter?
                        break;
                }
            }
        }
        internal static void FormLoad(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            bool newIncident = string.IsNullOrWhiteSpace(tngnWsvcSession.OptObj.Worker.GetFieldValue(openIncidentConfig.BriefIncidentDescriptionFieldId));
            if (newIncident)
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = $"A new Incident report was created by {tngnWsvcSession.Runtime.AvatarUserId}";
                var runningBody  = "";
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 0);
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                if (tngnWsvcSession.OptObj.Completed == null)
                {
                    OpenIncidentLogic.VerifyAccess(tngnWsvcSession, openIncidentConfig);
                }
            }
        }
        internal static void PreFile(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            if (tngnWsvcSession.OptObj.Completed == null)
            {
                var programOfIncidentIsValid = OpenIncidentLogic.IsProgramOfIncidentValid(tngnWsvcSession, openIncidentConfig);
                var isOriginalAuthor             = OpenIncidentLogic.IsOriginalAuthor(tngnWsvcSession, openIncidentConfig);
                if (programOfIncidentIsValid && isOriginalAuthor)
                {
                    LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                    AvatarOptionObject.ToReturn(tngnWsvcSession, 0);
                }
                else if (!programOfIncidentIsValid)
                {
                    LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                    AvatarOptionObject.ToReturn(tngnWsvcSession, openIncidentConfig.InvalidProgramOfIncidentErrCode, openIncidentConfig.InvalidProgramOfIncidentMsg);
                }
                else if (programOfIncidentIsValid && !isOriginalAuthor)
                {
                    LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                    AvatarOptionObject.ToReturn(tngnWsvcSession, openIncidentConfig.NotOriginalAuthorSubmitErrCode, openIncidentConfig.NotOriginalAuthorSubmitMsg);
                }
            }
        }
    }
}
