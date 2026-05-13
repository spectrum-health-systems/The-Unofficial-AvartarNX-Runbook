// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

namespace TingenWebService.Core.Framework
{
    public class TngnWsvcDataFolders
    {
        public string AvatarGeneratedData { get; set; }
        public string DataRoot { get; set; }
        public string AppDataRoot { get; set; }
        public string Blueprint { get; set; }
        public string Config { get; set; }
        public string Export { get; set; }
        public string History { get; set; }
        public string Import { get; set; }
        public string Log { get; set; }
        public string OptObjErrorMessage { get; set; }
        public string TranslationTable { get; set; }
        public string ArchiveRoot { get; set; }
        public string Session { get; set; }
        internal static TngnWsvcDataFolders Load(string avatarSystem, string avatarUserId, string serverDataPath, string sessionDate, string sessionStartTime)
        {
            return new TngnWsvcDataFolders
            {
                AvatarGeneratedData = $@"{serverDataPath}\AvatarGeneratedData",
                DataRoot            = $@"{serverDataPath}\{avatarSystem}",
                AppDataRoot         = $@"{serverDataPath}\{avatarSystem}\AppData",
                Blueprint           = $@"{serverDataPath}\{avatarSystem}\AppData\Blueprint",
                Config              = $@"{serverDataPath}\{avatarSystem}\AppData\Config",
                Export              = $@"{serverDataPath}\{avatarSystem}\AppData\Export",
                History             = $@"{serverDataPath}\{avatarSystem}\AppData\History",
                Import              = $@"{serverDataPath}\{avatarSystem}\AppData\Import",
                Log                 = $@"{serverDataPath}\{avatarSystem}\AppData\Log",
                OptObjErrorMessage  = $@"{serverDataPath}\{avatarSystem}\AppData\OptObjErrorMessage",
                TranslationTable    = $@"{serverDataPath}\{avatarSystem}\AppData\TranslationTable",
                ArchiveRoot         = $@"{serverDataPath}\{avatarSystem}\Archive",
                Session             = $@"{serverDataPath}\{avatarSystem}\Session\{sessionDate}\{avatarUserId}\{sessionStartTime}"
            };
        }
    }
}
