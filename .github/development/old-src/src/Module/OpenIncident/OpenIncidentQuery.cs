// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Reflection;
using System.Xml.Linq;
using SuperLive;
using NtstWsvcUatNxQuery;
using NtstWsvcSboxQuery;
using NtstWsvcLiveQuery;
using NtstWsvcUatQuery;
using TingenWebService.Core.Logger;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.OpenIncident
{
    internal class OpenIncidentQuery
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static string GetCurrentUserRoles(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var querySyntax = $"SELECT USERROLE FROM RADplus_users WHERE '{tngnWsvcSession.Runtime.AvatarUserId.ToUpper()}' = USERID";
            var queryUser   = tngnWsvcSession.Runtime.NtstWsvcUserName;
            var queryPass   = tngnWsvcSession.Runtime.NtstWsvcUserPass;
            var testr = new SuperLive.Query().SubmitQuery("LIVE", queryUser, queryPass, querySyntax);
            LogEvent.Debug($"SuperLIVE! OpenIncidentQuery.UserRoles{Environment.NewLine}" +
                           $"queryUser: {queryUser}" +
                           $"queryPass: {queryPass}" +
                           $"querySyntax: {querySyntax}{Environment.NewLine}" +
                           $"Result: {FormatXmlQuery(testr)}");
            if (tngnWsvcSession.Runtime.AvatarSystem.Equals("LIVE", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new SuperLive.Query().SubmitQuery("LIVE", queryUser, queryPass, querySyntax);
            }
            else if (tngnWsvcSession.Runtime.AvatarSystem.Equals("UAT", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new NtstWsvcUatNxQuery.Query().SubmitQuery("UAT", queryUser, queryPass, querySyntax);
            }
            else if (tngnWsvcSession.Runtime.AvatarSystem.Equals("SBOX", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new NtstWsvcSboxQuery.Query().SubmitQuery("SBOX", queryUser, queryPass, querySyntax);
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return "[WSVC7582]";
            }
        }
        internal static string FormatXmlQuery(string xmlResult)
        {
            return XDocument.Parse(xmlResult).ToString();
        }
        internal static string UserDescription(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var querySyntax = $"SELECT user_description FROM RADplus_users WHERE USERID = '{tngnWsvcSession.Runtime.AvatarUserId.ToUpper()}'";
            var queryUser   = tngnWsvcSession.Runtime.NtstWsvcUserName;
            var queryPass   = tngnWsvcSession.Runtime.NtstWsvcUserPass;
            var testr = new NtstWsvcLiveQuery.Query().SubmitQuery("LIVE", queryUser, queryPass, querySyntax);
            LogEvent.Debug($"OpenIncidentQuery.UserRoles{Environment.NewLine}" +
                           $"queryUser: {queryUser}" +
                           $"queryPass: {queryPass}" +
                           $"querySyntax: {querySyntax}{Environment.NewLine}" +
                           $"Result: {testr}");
            if (tngnWsvcSession.Runtime.AvatarSystem.Equals("LIVE", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new NtstWsvcLiveQuery.Query().SubmitQuery("LIVE", queryUser, queryPass, querySyntax);
            }
            else if (tngnWsvcSession.Runtime.AvatarSystem.Equals("UAT", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new NtstWsvcUatQuery.Query().SubmitQuery("UAT", queryUser, queryPass, querySyntax);
            }
            else if (tngnWsvcSession.Runtime.AvatarSystem.Equals("SBOX", StringComparison.OrdinalIgnoreCase))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return new NtstWsvcSboxQuery.Query().SubmitQuery("SBOX", queryUser, queryPass, querySyntax);
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return "[WSVC4274]";
            }
        }
    }
}
