// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Threading;

namespace TingenWebService.Core.Logger
{
    internal static class DebugLog
    {
        internal static void Create(string logMsg, string classPath, string methodName, int lineNumber)
        {
            Thread.Sleep(100);
            var logName = $"{DateTime.Now:ssff-fffff}-{LogUtility.GetClassName(classPath)}-{methodName}-{lineNumber}.debug";
            LogUtility.WriteLocal($@"C:\\Tingen_Data\\.development\\debug\\{logName}", logMsg);
        }
    }
}
