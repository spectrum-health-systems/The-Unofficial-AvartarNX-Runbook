// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using TingenWebService.Core.Logger;

namespace TingenWebServiceCore.Catalog
{
    internal class msg_Framework
    {
        internal static string CreateFolder(string folderName) =>
            Environment.NewLine +
            $"[{HistoryLog.Timestamp()}] Folder \"{folderName}\" did not exist, and was created..." +
            Environment.NewLine;
    }
}
