// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

namespace TingenWebService.Core.Framework
{
    public class TngnWsvcWwwFolders
    {
        public string WwwRoot { get; set; }
        public string AppDataRoot { get; set; }
        public string Blueprint { get; set; }
        public string OptObjErrorMessage { get; set; }
        public string TranslationTable { get; set; }
        internal static TngnWsvcWwwFolders Load(string avatarSystem, string serverWwwPath)
        {
            return new TngnWsvcWwwFolders
            {
                WwwRoot            = $@"{serverWwwPath}\{avatarSystem}",
                AppDataRoot        = $@"{serverWwwPath}\{avatarSystem}\bin\AppData",
                Blueprint          = $@"{serverWwwPath}\{avatarSystem}\bin\AppData\Blueprint",
                OptObjErrorMessage = $@"{serverWwwPath}\{avatarSystem}\bin\AppData\OptObjErrorMessage",
                TranslationTable   = $@"{serverWwwPath}\{avatarSystem}\bin\AppData\TranslationTable",
            };
        }
    }
}
