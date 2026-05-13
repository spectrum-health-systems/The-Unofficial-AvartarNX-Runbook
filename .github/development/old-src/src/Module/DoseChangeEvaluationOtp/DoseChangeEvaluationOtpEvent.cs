// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251113_code
// u251113_documentation
// =============================================================================

using System;
using System.Reflection;
using TingenWebServiceCore.Catalog;
using TingenWebService.Core.Logger;
using TingenWebService.Core.Query;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.DoseChangeEvaluationOtp
{
    internal class DoseChangeEvaluationOtpEvent
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        internal static void Parse(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);

            var moduleConfigName = "DoseChangeEvaluationOtp.config";
            var moduleConfigPath = $@"{tngnWsvcSession.Framework.TngnWsvcDataFolder.Config}\{moduleConfigName}";
            var moduleConfig     = DoseChangeEvaluationOtpConfig.Load(moduleConfigPath, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session);

            if (moduleConfig.Mode.Equals("enabled", System.StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);

                switch (tngnWsvcSession.ScriptParameter.OriginalScriptParameter.ToLower())
                {
                    case "_formload":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        FormLoad(tngnWsvcSession, moduleConfig);
                        break;
                    case "_prefile":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        PreFile(tngnWsvcSession, moduleConfig);
                        break;
                    case "_postfile":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        PostFile(tngnWsvcSession, moduleConfig);
                        break;
                    case "_prescriberisauthorizing":
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        PrescriberIsAuthorizing(tngnWsvcSession, moduleConfig);
                        break;
                    default:
                        LogEvent.Trace(3, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                        // TODO Hard error for unsupported script parameter?
                        break;
                }
            }
        }

        internal static void FormLoad(TngnWsvcSession tngnWsvcSession, DoseChangeEvaluationOtpConfig moduleConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
        }

        internal static void PreFile(TngnWsvcSession tngnWsvcSession, DoseChangeEvaluationOtpConfig moduleConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
        }

        internal static void PostFile(TngnWsvcSession tngnWsvcSession, DoseChangeEvaluationOtpConfig moduleConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
        }

        internal static void PrescriberIsAuthorizing(TngnWsvcSession tngnWsvcSession, DoseChangeEvaluationOtpConfig moduleConfig)
        {
            LogEvent.Debug();
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            LogEvent.Debug(moduleConfig.PhysicianApproverFieldId);
            var thing = tngnWsvcSession.OptObj.Original.GetFieldValue(moduleConfig.PhysicianApproverFieldId);
            LogEvent.Debug();
            if (string.IsNullOrEmpty(thing))
            {
                LogEvent.Debug("Physician Approver field is empty.");
            }
            else
            {
                LogEvent.Debug(thing);
            }
            var userIdQuery = QueryUserId.ToStaffMemberId(tngnWsvcSession);
            LogEvent.Debug($"userIdQuery: {userIdQuery}{Environment.NewLine}" +
                           $"physicianApprover: {thing}");
            var physicianApprover = tngnWsvcSession.OptObj.Original.GetFieldValue(moduleConfig.PhysicianApproverFieldId);
            SessionLog.AddToSessionLog(tngnWsvcSession, log_DoseChangeEval.PrescriberIsAuthorizing(LogComponents.GetCallerInfo(), userIdQuery, physicianApprover));
            LogEvent.Debug($"userIdQuery: {userIdQuery}{Environment.NewLine}" +
                           $"physicianApprover: {physicianApprover}");
            if (userIdQuery.Contains($"val=\"{physicianApprover}\""))
            {
                LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 0);
            }
            else
            {
                LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 1, moduleConfig.NotAllowedToAuthorizeOptObjMsg);
            }
        }
    }
}
