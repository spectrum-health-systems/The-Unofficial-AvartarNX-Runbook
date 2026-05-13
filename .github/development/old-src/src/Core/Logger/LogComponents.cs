// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Xml.Linq;

namespace TingenWebService.Core.Logger
{
    internal class LogComponents
    {
        internal static string GetCallerInfo([System.Runtime.CompilerServices.CallerFilePath] string className = "", [System.Runtime.CompilerServices.CallerMemberName] string methodName = "", [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            var classOnly = System.IO.Path.GetFileNameWithoutExtension(className);
            return $"{classOnly}-{methodName}-{lineNumber}";
        }
        internal static string FormatXml(string rawXml)
        {
            return $"```xml{Environment.NewLine}" +
                   $"    {XDocument.Parse(rawXml)}{Environment.NewLine}" +
                   $"```{Environment.NewLine}";
        }
    }
}
