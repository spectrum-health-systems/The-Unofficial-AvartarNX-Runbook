// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using TingenWebServiceCore.TingenWsvcSession;
using TingenWebServiceCore.Catalog;
using TingenWebService.Core.Logger;

namespace TingenWebService.Core.Catalog
{
    internal class msg_Maintenance
    {
        internal static string RefreshTranslations(string tableName = "")
        {
            return string.IsNullOrWhiteSpace(tableName)
                ? $"complete. [{HistoryLog.Timestamp()}]{Environment.NewLine}"
                : $"[{HistoryLog.Timestamp()}] Refreshing the {tableName} translation table...";
        }
        internal static string RefreshBlueprints(string tableName = "")
        {
            return string.IsNullOrWhiteSpace(tableName)
                ? $"complete. [{HistoryLog.Timestamp()}]{Environment.NewLine}"
                : $"[{HistoryLog.Timestamp()}] Refreshing the {tableName} translation table...";
        }
    }
}
