// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using ScriptLinkStandard.Objects;

namespace TingenWebService.Core.Catalog
{
    public class msg_TngnWscv
    {
        public static string MissingComponent(OptionObject2015 origOptObj, string origScriptParam) =>
            $"The OptionObject (\"{origOptObj}\") and/or Script Parameter (\"{origScriptParam}\") are missing.";
        public static string DisabledMode() =>
            "The Tingen Web Service is disabled";
        public static string UnknownMode() =>
            "The Tingen Web Service is in an unknown state";
    }
}
