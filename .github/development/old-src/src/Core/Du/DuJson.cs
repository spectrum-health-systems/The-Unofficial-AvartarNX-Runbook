// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251111_code
// u251111_documentation
// =============================================================================

using System.IO;
using TingenWebService.Core.Du;
using TingenWebService.Core.Logger;

namespace TingenWebService.Core.Du
{
    /// <summary>Provides JSON functionality.</summary>
    /// <remarks>No logging done here.</remarks>
    internal static class DuJson
    {
        internal static void ExportToLocalFile<JsonObject>(JsonObject jsonObject, string filePath, bool formatJson = true)
        {
            // .NET Framework 4.8 does not support System.Text.Json
            // Use simple serialization for stub
            var fileContent = jsonObject.ToString();
            File.WriteAllText(filePath, fileContent);
        }
        internal static JsonObject ImportFromLocalFile<JsonObject>(string filePath)
        {
            var configurationFileContents = File.ReadAllText(filePath);
            // Stub: return default
            return default(JsonObject);
        }
    }
}
