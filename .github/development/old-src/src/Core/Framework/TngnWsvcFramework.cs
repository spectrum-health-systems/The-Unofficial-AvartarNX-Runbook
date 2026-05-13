// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;

namespace TingenWebService.Core.Framework
{
    public class TngnWsvcFramework
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public TngnWsvcDataFolders TngnWsvcDataFolder { get; set; }
        public TngnWsvcWwwFolders TngnWsvcWwwFolder { get; set; }
        public static TngnWsvcFramework Load(string avatarSystem, string avatarUserId, string serverDataPath, string serverWwwPath, string sessionDate, string sessionStartTime) =>
            new TngnWsvcFramework
            {
                TngnWsvcDataFolder = TngnWsvcDataFolders.Load(avatarSystem, avatarUserId, serverDataPath, sessionDate, sessionStartTime),
                TngnWsvcWwwFolder  = TngnWsvcWwwFolders.Load(avatarSystem, serverWwwPath),
            };
        internal static void Verify(TngnWsvcFramework tngnWsvcFramework, int traceLogLimit, string avatarSystem, string sessionDate)
        {
            // Logging and folder creation logic omitted for brevity
            foreach (var property in tngnWsvcFramework.TngnWsvcDataFolder.GetType().GetProperties())
            {
                var folderName = property.GetValue(tngnWsvcFramework.TngnWsvcDataFolder).ToString();
                if (folderName.Contains(avatarSystem))
                {
                    if (!Directory.Exists(folderName))
                    {
                        Directory.CreateDirectory(folderName);
                    }
                }
            }
        }
    }
}
