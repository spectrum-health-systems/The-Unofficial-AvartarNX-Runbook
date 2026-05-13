using System;
using System.Reflection;
using TingenWebService.Core.Logger;
using SuperLive;
using NtstWsvcLiveQuery;
using NtstWsvcUatNxQuery;
using NtstWsvcUatQuery;
using NtstWsvcSboxQuery;

namespace TingenWebService.Core.Query
{
    internal class QueryUserId
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static string ToStaffMemberId(dynamic tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var querySyntax = $"SELECT Staff_Member_ID FROM RADplus_users WHERE USERID = '{tngnWsvcSession.Runtime.AvatarUserId.ToUpper()}'";
            var queryUser   = tngnWsvcSession.Runtime.NtstWsvcUserName;
            var queryPass   = tngnWsvcSession.Runtime.NtstWsvcUserPass;
            var testr = new SuperLive.Query().SubmitQuery("LIVE", queryUser, queryPass, querySyntax);
            LogEvent.Debug($"SLIVE!OpenIncidentQuery.UserRoles{Environment.NewLine}" +
                           $"queryUser: {queryUser}" +
                           $"queryPass: {queryPass}" +
                           $"querySyntax: {querySyntax}{Environment.NewLine}" +
                           $"Result: {testr}");
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
                LogEvent.Debug($"{queryUser} - {queryPass} - {querySyntax}");
                return new NtstWsvcSboxQuery.Query().SubmitQuery("SBOX", queryUser, queryPass, querySyntax);
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return "[WSVC4274]";
            }
        }
        internal static void CreateTranslationFile(string generatedUserIdPath, string translationPath, int traceLogLimit, string sessionFolder)
        {
            // Stub implementation for translation file creation
            // In production, this would parse the generatedUserIdPath and write to translationPath
        }
    }
}
