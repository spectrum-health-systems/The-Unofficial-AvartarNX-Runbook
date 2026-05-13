// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Reflection;
using TingenWebService.Core.Logger;
using ScriptLinkStandard.Objects;

namespace TingenWebServiceCore.Operation
{
    internal static class AvatarField
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static bool AreEqual(string field01, string field02, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            return string.Equals(field01, field02, StringComparison.OrdinalIgnoreCase);
        }
        internal static bool AreEqual(int field01, int field02, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            return field01 == field02;
        }
        internal static string GetValue(OptionObject optObj, string fieldId, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            return optObj.GetFieldValue(fieldId);
        }
        internal static string IsEmpty(string fieldValue, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            return string.IsNullOrWhiteSpace(fieldValue)
                ? "true"
                : "false";
        }
    }
}
