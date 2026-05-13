// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;
using System.Linq;

namespace TingenWebService.Core.Logger
{
    internal class LogUtility
    {
        internal static string GetClassName(string classPath)
        {
            string[] fullClassPath = classPath.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
            return fullClassPath.Last().Replace(".cs", "");
        }
        internal static void WriteLocal(string filePath, string fileContent) => File.WriteAllText(filePath, fileContent);
        internal static void AppendLocal(string filePath, string fileContent) => File.AppendAllText(filePath, fileContent);
    }
}
