// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TingenWebService.Core.Du;
using TingenWebService.Core.Logger;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.OpenIncident
{
    /// <summary>OpenIncident Module configuration logic.</summary>
    internal class OpenIncidentConfig
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public string Mode { get; set; }
        public List<string> Whitelist { get; set; }
        public List<string> Greylist { get; set; }
        public List<string> Blacklist { get; set; }
        public List<string> AuthorizedUserRoles { get; set; }
        public string BriefIncidentDescriptionFieldId { get; set; }
        public string ProgramOfIncidentFieldId { get; set; }
        public string PersonCompletingIncidentFormFieldId { get; set; }
        public string NotMemberOfAuthorizedUserRoleMsg { get; set; }
        public int NotMemberOfAuthorizedUserRoleErrCode { get; set; }
        public string NotOriginalAuthorOpenMsg { get; set; }
        public int NotOriginalAuthorOpenErrCode { get; set; }
        public string NotOriginalAuthorSubmitMsg { get; set; }
        public int NotOriginalAuthorSubmitErrCode { get; set; }
        public string InvalidProgramOfIncidentMsg { get; set; }
        public int InvalidProgramOfIncidentErrCode { get; set; }
        public string UnknownUserDescriptionMsg { get; set; }
        public int UnknownUserDescriptionErrCode { get; set; }
        internal static OpenIncidentConfig Load(string configPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            if (!File.Exists(configPath))
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);
                New(configPath, traceLogLimit, sessionFolder);
            }
            return DuJson.ImportFromLocalFile<OpenIncidentConfig>(configPath);
        }
        internal static void New(string configPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            OpenIncidentConfig openIncident = new OpenIncidentConfig()
            {
                Mode                                = "enabled",
                Whitelist                           = new List<string>(),
                Blacklist                           = new List<string>(),
                Greylist                            = new List<string>(),
                AuthorizedUserRoles                 = new List<string>()
                {
                    "NXCOMPLIANCE",
                    "NXDOCCLINSUP",
                    "NXDOCMANAGEMENT",
                    "NXDOCNURSESUP",
                    "SuperUser"
                },
                BriefIncidentDescriptionFieldId     = "2",
                ProgramOfIncidentFieldId            = "20",
                PersonCompletingIncidentFormFieldId = "32",
                NotMemberOfAuthorizedUserRoleMsg    = "You are not authorized to view this incident.",
                NotMemberOfAuthorizedUserRoleErrCode= 1,
                NotOriginalAuthorOpenMsg            = "Since you are not the original author of this incident, you will only be able to view it and will not be able to submit modifications.",
                NotOriginalAuthorOpenErrCode        = 3,
                NotOriginalAuthorSubmitMsg          = "Since you are not the original author of this incident, you cannot submit modifications to this incident.",
                NotOriginalAuthorSubmitErrCode      = 1,
                UnknownUserDescriptionMsg           = "Your username was not found in the translation table. Please contact the IT Service Desk and give them this code: WSVC4274",
                UnknownUserDescriptionErrCode       = 1,
                InvalidProgramOfIncidentMsg         = "The Program of Incident specified is not valid. Please correct it before submitting the incident.",
                InvalidProgramOfIncidentErrCode     = 1
            };
            DuJson.ExportToLocalFile(openIncident, configPath, true);
        }
    }
}
