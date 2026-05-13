// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.Threading;

namespace TingenWebService.Core.Logger
{
    internal static class TraceLog
    {
        internal static void Create(int traceLevel, int traceLogLimit, string sessionFolder, string exeAsm, string classPath, string methodName, int lineNumber)
        {
            if (traceLogLimit != 0 && (traceLevel <= traceLogLimit))
            {
                Thread.Sleep(traceLogLimit);
                var logName = $"{DateTime.Now:ssff-fffff}-{exeAsm}-{LogUtility.GetClassName(classPath)}-{methodName}-{lineNumber}.trace";
                LogUtility.WriteLocal($@"{sessionFolder}\{logName}", "");
            }
        }
    }
}
