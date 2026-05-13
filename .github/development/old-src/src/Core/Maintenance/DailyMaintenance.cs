// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using TingenWebService.Core.Catalog;
using TingenWebService.Core.Framework;
using TingenWebService.Core.Logger;
using TingenWebService.Core.Query;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Core.Maintenance
{
    /// <summary>Performs daily maintenance tasks.</summary>
    internal class DailyMaintenance
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Daily updates.</summary>
        /// <param name="tngnWsvcSession">The object that contains all the information for this session.</param>
        internal static void QuickCheck(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);

            if (!File.Exists($@"{tngnWsvcSession.Framework.TngnWsvcDataFolder.History}\{tngnWsvcSession.Runtime.SessionDate}.history"))
            {
                LogEvent.Trace(2, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);

                VerifyTingenWebService(tngnWsvcSession);
            }
        }

        // Should also have a "reset"
        internal static void VerifyTingenWebService(TngnWsvcSession tngnWsvcSession)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);

            TngnWsvcFramework.Verify(tngnWsvcSession.Framework, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Runtime.AvatarSystem, tngnWsvcSession.Runtime.SessionDate);

            //Core.Framework.AppDataFolders.CreateFramework(tngnWsvcSession.Folder);

            //CreateHistoryPath(tngnWsvcSession.Folder.History, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.SessionFolder);

            RefreshTranslationTables(tngnWsvcSession.Framework.TngnWsvcDataFolder.AvatarGeneratedData, tngnWsvcSession.Framework.TngnWsvcDataFolder.TranslationTable, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, tngnWsvcSession.Framework.TngnWsvcDataFolder.History, tngnWsvcSession.Runtime.SessionDate);
            RefreshBlueprints(tngnWsvcSession.Framework.TngnWsvcWwwFolder.Blueprint, tngnWsvcSession.Framework.TngnWsvcDataFolder.Blueprint, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, tngnWsvcSession.Framework.TngnWsvcDataFolder.History, tngnWsvcSession.Runtime.SessionDate);
        }

        internal static void CreateHistoryPath(string historyPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);

            if (!Directory.Exists(historyPath))
            {
                Directory.CreateDirectory(historyPath);
            }
        }

        /// <summary>Checks to see if the daily log path exists.</summary>
        /// <param name="dailyLogPath">The path to the daily logs.</param>
        /// <returns>True if the path exists, false if not.</returns>
        internal static bool DailyLogPathExists(string dailyLogPath) => Directory.Exists(dailyLogPath);

        /// <summary>Creates the daily log path.</summary>
        /// <param name="dailyLogPath">The path to the daily logs.</param>
        /// <param name="traceLogLimit">The global trace log limit.</param>
        /// <param name="sessionFolder">The current session folder.</param>
        internal static void CreateDailyLogPath(string dailyLogPath, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);

            if (!Directory.Exists(dailyLogPath))
            {
                Directory.CreateDirectory(dailyLogPath);
            }
        }

        /// <summary>Create the daily log.</summary>
        /// <param name="dailyLogPath">The path to the daily logs.</param>
        /// <param name="currentDate">The current date.</param>
        /// <param name="traceLogLimit">The global trace log limit.</param>
        /// <param name="sessionFolder">The current session folder.</param>
        internal static void CreateDailyLog(string dailyLogPath, string currentDate, int traceLogLimit, string sessionFolder)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);

            if (!File.Exists($@"{dailyLogPath}\daily.{currentDate}"))
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);

                File.Create($@"{dailyLogPath}\daily.{currentDate}").Dispose();
            }
        }

        /// <summary>Refreshes the translation tables by ensuring the necessary translation files are updated or recreated.</summary>
        /// <remarks>
        ///     This method ensures that the translation tables are up-to-date by verifying the
        ///     existence of specific translation files and recreating them if necessary. It also logs the process for
        ///     traceability.
        ///     </remarks>
        /// <param name="generatedDataPath">The path to the directory containing the generated data files.</param>
        /// <param name="translationPath">The path to the directory where translation files are stored.</param>
        /// <param name="traceLogLimit">The global trace log limit.</param>
        /// <param name="sessionFolder">The current session folder.</param>
        internal static void RefreshTranslationTables(string generatedDataPath, string translationPath, int traceLogLimit, string sessionFolder, string historyFolder, string sessionDate)
        {
            // Move this to the translations tables themselves.

            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);

            if (File.Exists($@"{translationPath}\USERID_UserDescription_Active.translation"))
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);
                LogEvent.History(historyFolder, sessionDate, msg_Maintenance.RefreshTranslations("USERID_UserDescription_Active.translation"));

                File.Delete($@"{translationPath}\USERID_UserDescription_Active.translation");
            }

            var generatedUserIdPath = $@"{generatedDataPath}\USERID_UserDescription_Active.txt";

            QueryUserId.CreateTranslationFile(generatedUserIdPath, translationPath, traceLogLimit, sessionFolder);

            LogEvent.History(historyFolder, sessionDate, msg_Maintenance.RefreshTranslations());
        }

        /// <summary>Refresh blueprints.</summary>
        /// <param name="blueprintSource"></param>
        /// <param name="blueprintTarget"></param>
        /// <param name="traceLogLimit"></param>
        /// <param name="sessionFolder"></param>
        /// <param name="historyFolder"></param>
        /// <param name="sessionDate"></param>
        internal static void RefreshBlueprints(string blueprintSource, string blueprintTarget, int traceLogLimit, string sessionFolder, string historyFolder, string sessionDate)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);
            LogEvent.Debug($"{blueprintSource} - {blueprintTarget}");


            if (!Directory.Exists(blueprintSource) || !Directory.Exists(blueprintTarget))
                return;

            LogEvent.Debug();

            var sourceFiles = Directory.GetFiles(blueprintSource);

            foreach (var sourceFile in sourceFiles)
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);

                var fileName   = Path.GetFileName(sourceFile);
                var targetFile = Path.Combine(blueprintTarget, fileName);

                bool shouldCopy = !File.Exists(targetFile) || File.GetLastWriteTimeUtc(sourceFile) > File.GetLastWriteTimeUtc(targetFile);

                if (shouldCopy)
                {
                    LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);

                    File.Copy(sourceFile, targetFile, true);
                    LogEvent.History(historyFolder, sessionDate, $"[{HistoryLog.Timestamp()}] Blueprint '{fileName}' refreshed.{Environment.NewLine}");
                }
            }


        }
    }
}
