// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251113_code
// u251113_documentation
// =============================================================================

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TingenWebService.Core.Du;
using TingenWebService.Core.Logger;
using TingenWebService.Core.Avatar;

namespace TingenWebService.Module.DoseChangeEvaluationOtp
{
    internal class DoseChangeEvaluationOtpConfig
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public string Mode { get; set; }
        public List<string> Whitelist { get; set; }
        public List<string> Greylist { get; set; }
        public List<string> Blacklist { get; set; }
        public string ProviderIsAuthorizingOrderFieldId { get; set; }
        public string PhysicianApproverFieldId { get; set; }
        public string NotAllowedToAuthorizeOptObjMsg { get; set; }
        public int NotAllowedToAuthorizeOptObjErrCode { get; set; }
        internal static DoseChangeEvaluationOtpConfig Load(string configPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            if (!File.Exists(configPath))
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);
                New(configPath, traceLogLimit, sessionFolder);
            }
            return DuJson.ImportFromLocalFile<DoseChangeEvaluationOtpConfig>(configPath);
        }
        internal static void New(string configPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            DoseChangeEvaluationOtpConfig doseChangeEvaluationOtpConfig = new DoseChangeEvaluationOtpConfig()
            {
                Mode                               = "enabled",
                Whitelist                          = new List<string>(),
                Blacklist                          = new List<string>(),
                Greylist                           = new List<string>(),
                ProviderIsAuthorizingOrderFieldId  = "350.55",
                PhysicianApproverFieldId           = "339.75",
                NotAllowedToAuthorizeOptObjMsg     = "You are not logged in as the authorizing provider.",
                NotAllowedToAuthorizeOptObjErrCode = 1
            };
            DuJson.ExportToLocalFile(doseChangeEvaluationOtpConfig, configPath, true);
        }
    }
}
