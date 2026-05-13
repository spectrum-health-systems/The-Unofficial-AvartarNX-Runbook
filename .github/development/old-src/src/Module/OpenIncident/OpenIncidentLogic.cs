// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Linq;
using System.Reflection;
using TingenWebService.Core.Logger;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Query;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.OpenIncident
{
    internal class OpenIncidentLogic
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void VerifyAccess(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Debug();
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            bool isOriginalAuthor = IsOriginalAuthor(tngnWsvcSession, openIncidentConfig);
            bool isMemberOfAuthorizedUserRole = IsMemberOfAuthorizedUserRole(tngnWsvcSession, openIncidentConfig);
            if (isOriginalAuthor || (!isMemberOfAuthorizedUserRole && isOriginalAuthor))
            {
                LogEvent.Trace(4, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 0);
            }
            else if (isMemberOfAuthorizedUserRole && !isOriginalAuthor)
            {
                LogEvent.Trace(4, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, openIncidentConfig.NotOriginalAuthorOpenErrCode, openIncidentConfig.NotOriginalAuthorOpenMsg);
            }
            else if (!isMemberOfAuthorizedUserRole && !isOriginalAuthor)
            {
                LogEvent.Trace(4, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, openIncidentConfig.NotMemberOfAuthorizedUserRoleErrCode, openIncidentConfig.NotMemberOfAuthorizedUserRoleMsg);
            }
        }
        internal static bool IsOriginalAuthor(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Debug();
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var originalAuthorFullName = tngnWsvcSession.OptObj.Original.GetFieldValue(openIncidentConfig.PersonCompletingIncidentFormFieldId);
            if (MatchFoundInTranslationTable(tngnWsvcSession, openIncidentConfig, originalAuthorFullName))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return true;
            }
            else
            {
                if (MatchFoundInAvatarQuery(tngnWsvcSession, openIncidentConfig, originalAuthorFullName))
                {
                    LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                    return true;
                }
                else
                {
                    LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                    return false;
                }
            }
        }
        internal static bool IsMemberOfAuthorizedUserRole(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Debug();
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var currentUserRoles = OpenIncidentQuery.GetCurrentUserRoles(tngnWsvcSession);
            var authorizedUserRoles = GetAuthorizedUserRolesAsString(openIncidentConfig);
            if (openIncidentConfig.AuthorizedUserRoles.Any(userRole => currentUserRoles.Contains(userRole)))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Current user is a member of an authorized user role";
                var runningBody  = BodyUserRoles(authorizedUserRoles, currentUserRoles);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return true;
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Current user is not a member of an authorized user role";
                var runningBody  = BodyUserRoles(authorizedUserRoles, currentUserRoles);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
        }
        internal static string GetAuthorizedUserRolesAsString(OpenIncidentConfig openIncidentConfig)
        {
            return openIncidentConfig?.AuthorizedUserRoles == null || !openIncidentConfig.AuthorizedUserRoles.Any()
                ? string.Empty
                : string.Join(", ", openIncidentConfig.AuthorizedUserRoles);
        }
        internal static bool MatchFoundInTranslationTable(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig, string originalAuthorFullName)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var translatedUserDescription = Core.Translation.UserId.GetUserDescription(tngnWsvcSession.OptObj.Worker.OptionUserId, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, tngnWsvcSession.Framework.TngnWsvcDataFolder.TranslationTable);
            if (translatedUserDescription == null || string.IsNullOrWhiteSpace(translatedUserDescription) || translatedUserDescription == "WSVC4274")
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Cannot find current user in the translation table";
                var runningBody  = BodyAuthorTranslation(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, translatedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
            else if (originalAuthorFullName == translatedUserDescription)
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Original author/current user match in the translation table";
                var runningBody  = BodyAuthorTranslation(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, translatedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return true;
            }
            else if (originalAuthorFullName != translatedUserDescription)
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Original author/current user do not match in the translation table";
                var runningBody  = BodyAuthorTranslation(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, translatedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Unknown error when using the translation table to match original author/current user";
                var runningBody  = BodyAuthorTranslation(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, translatedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
        }
        internal static bool MatchFoundInAvatarQuery(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig, string originalAuthorFullName)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var queryiedUserDescription = OpenIncidentQuery.UserDescription(tngnWsvcSession);
            if (queryiedUserDescription.Contains($"val=\"{originalAuthorFullName}\""))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = $"Original author/current user match via query{Environment.NewLine}" +
                                   $"{Environment.NewLine}" +
                                   $"{LogComponents.GetCallerInfo()}";
                var runningBody  = BodyAuthorQuery(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, queryiedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return true;
            }
            else if (!queryiedUserDescription.Contains($"val=\"{originalAuthorFullName}\""))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                LogEvent.Debug($"{queryiedUserDescription} - {originalAuthorFullName}");
                var runningTitle = $"Original author/current user do not match via query{Environment.NewLine}" +
                                   $"{Environment.NewLine}" +
                                   $"{LogComponents.GetCallerInfo()}";
                var runningBody  = BodyAuthorQuery(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, queryiedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Unknown error when attempting to match original author/current user via query";
                var runningBody  = BodyAuthorQuery(tngnWsvcSession.Runtime.AvatarUserId, originalAuthorFullName, queryiedUserDescription);
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
        }
        internal static void IsOriginalAuthorSubmitting(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var originalAuthorFullName = tngnWsvcSession.OptObj.Original.GetFieldValue(openIncidentConfig.PersonCompletingIncidentFormFieldId);
            var fileCheck = tngnWsvcSession.Framework.TngnWsvcDataFolder.AvatarGeneratedData + $@"\USERID_User Description_{tngnWsvcSession.Runtime.AvatarSystem}.txt";
            var sessionUserFullName    = Core.Translation.UserId.GetUserDescription(tngnWsvcSession.OptObj.Worker.OptionUserId, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, tngnWsvcSession.Framework.TngnWsvcDataFolder.TranslationTable);
            if (originalAuthorFullName != sessionUserFullName)
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, openIncidentConfig.NotOriginalAuthorSubmitErrCode, openIncidentConfig.NotOriginalAuthorSubmitMsg);
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 0);
            }
        }
        internal static bool IsProgramOfIncidentValid(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            var programOfIncident = tngnWsvcSession.OptObj.Original.GetFieldValue(openIncidentConfig.ProgramOfIncidentFieldId);
            if (string.IsNullOrEmpty(programOfIncident))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                var runningTitle = "Invalid Program of Incident";
                var runningBody  = $"Program of Incident = {programOfIncident}{Environment.NewLine}";
                SessionLog.AddToRunningLog(tngnWsvcSession, LogComponents.GetCallerInfo(), runningTitle, runningBody);
                return false;
            }
            else
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
                return true;
            }
        }
        internal static string BodyUserRoles(string authorizedUserRoles, string currentUserRoles)
        {
            return $"{LogComponents.GetCallerInfo()}{Environment.NewLine}" +
                   $"Authorized user roles: {authorizedUserRoles}{Environment.NewLine}" +
                   $"Query User Role response: {currentUserRoles}{Environment.NewLine}";
        }
        internal static string BodyAuthorTranslation(string avatarUserId, string originalAuthor, string translatedUserDescription)
        {
            return $"{LogComponents.GetCallerInfo()}{Environment.NewLine}" +
                   $"User ID: {avatarUserId}{Environment.NewLine}" +
                   $"Original author: {originalAuthor}{Environment.NewLine}" +
                   $"Translation table User Description value: {translatedUserDescription}";
        }
        internal static string BodyAuthorQuery(string avatarUserId, string originalAuthor, string queryiedUserDescription)
        {
            return $"{LogComponents.GetCallerInfo()}{Environment.NewLine}" +
                   $"User ID: {avatarUserId}{Environment.NewLine}" +
                   $"Original author: {originalAuthor}{Environment.NewLine}" +
                   $"Query User Role response: {queryiedUserDescription}{Environment.NewLine}";
        }
    }
}
