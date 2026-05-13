// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;

namespace TingenWebService.Core.Logger
{
    internal static class HistoryLog
    {
        internal static void Create(string logFolder, string sessionDate, string logMsg)
        {
            var historyLogPath = $@"{logFolder}\{sessionDate}.history";
            LogUtility.AppendLocal(historyLogPath, logMsg);
        }
        internal static string Timestamp()
        {
            return $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff")}";
        }
    }
}
