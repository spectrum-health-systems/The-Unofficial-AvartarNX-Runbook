// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251111_code
// u251111_documentation
// =============================================================================

using System;
using System.Reflection;

namespace TingenWebService.Core.Avatar
{
    /// <summary>Avatar Script Parameter logic.</summary>
    public class AvatarScriptParameter
    {
        public string OriginalScriptParameter { get; set; }
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public static string VerifyExistence(string origScriptParam) =>
            string.IsNullOrWhiteSpace(origScriptParam)
                ? $"The sent script parameter ('{origScriptParam}') does not exist."
                : $"The sent script parameter ('{origScriptParam}') does exist.";
        public static void Parse(dynamic tngnWsvcSession)
        {
            if (tngnWsvcSession.ScriptParameter.OriginalScriptParameter.StartsWith("_", StringComparison.OrdinalIgnoreCase))
            {
                var specificFormName = GetFormName(tngnWsvcSession);
                SpecificFormRequest(specificFormName, tngnWsvcSession);
            }
            else
            {
                StandAloneRequest(tngnWsvcSession);
            }
        }
        internal static void SpecificFormRequest(string specificFormName, dynamic tngnWsvcSession)
        {
            if (specificFormName == "WSVC2491")
            {
                tngnWsvcSession.TngnWsvcSessionError.HardError(tngnWsvcSession, 1, $"[WSVC2491] The form ID '{tngnWsvcSession.OptObj.Original.OptionId}' was not found in the translation table.");
            }
            else
            {
                switch (specificFormName)
                {
                    case "OpenIncident":
                        tngnWsvcSession.Module.OpenIncident.OpenIncidentEvent.Parse(tngnWsvcSession);
                        break;
                    case "DoseChangeEvaluationOtp":
                        tngnWsvcSession.Module.DoseChangeEvaluationOtp.DoseChangeEvaluationOtpEvent.Parse(tngnWsvcSession);
                        break;
                    default:
                        break;
                }
            }
        }
        internal static void StandAloneRequest(dynamic tngnWsvcSession)
        {
            if (tngnWsvcSession.ScriptParameter.OriginalScriptParameter.StartsWith("tngnwsvc"))
            {
                // TODO Add admin static requests here.
            }
            else if (string.Equals(tngnWsvcSession.ScriptParameter.OriginalScriptParameter, "catchoptionobject", StringComparison.CurrentCultureIgnoreCase))
            {
                tngnWsvcSession.Module.TngnWsvc.OptObjUtility.CatchOptionObject(tngnWsvcSession);
            }
            else
            {
                tngnWsvcSession.TngnWsvcSessionError.HardError(tngnWsvcSession, 1, $"[WSVC9321] The Script Parameter request '{tngnWsvcSession.ScriptParameter.OriginalScriptParameter}' was not found in the translation table.");
            }
        }
        internal static string GetFormName(dynamic tngnWsvcSession)
        {
            return tngnWsvcSession.Translation.FormId.GetFormName(tngnWsvcSession.OptObj.Original.OptionId, tngnWsvcSession.Framework.TngnWsvcDataFolder.TranslationTable, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, tngnWsvcSession.LogSetting.TraceLogLimit);
        }
    }
}
