// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using TingenWebService.Core.Logger;

namespace TingenWebService.Core.Translation
{
    /// <summary>Logic related to the USERID_User Description.txt file.</summary>
    /// <remarks>
    ///     About this file.
    /// </remarks>
    internal class UserId
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Get the full username of an Avatar Username/</summary>
        /// <remarks>
        ///     e.g., JDOE becomes John Doe
        /// </remarks>
        /// <param name="avatarUserName">The username of the avatar to look up</param>
        /// <returns>The full name of the user associated with the specified avatar username.</returns>
        internal static string GetUserDescription(string avatarUserName, int traceLogLimit, string currentSessionFolder, string translationPath)
        {
            LogEvent.Trace(1, traceLogLimit, currentSessionFolder, ExeAsm);

            foreach (string line in File.ReadLines($@"{translationPath}\USERID_UserDescription_Active.translation"))
            {
                // split into two parts

                var fileUserName = line.Split('^')[0];

                if (fileUserName == avatarUserName.Trim())
                {
                    LogEvent.Trace(4, traceLogLimit, currentSessionFolder, ExeAsm);

                    return line.Split('^')[1];
                }
            }

            return "WSVC4274"; // Your username was not found in the USERID_User Description.txt file.
        }

        /// <summary>
        /// Creates a translation file by reading and processing the contents of the specified original file.
        /// </summary>
        /// <remarks>This method reads all non-empty lines from the original file, trims any leading or
        /// trailing whitespace, and writes the processed content to a new file named "user_id-user_description.trans"
        /// in the specified directory.</remarks>
        /// <param name="originalFilePath">The full path to the original file to be read and processed. Cannot be null or empty.</param>
        /// <param name="translationPath">The directory path where the translation file will be created. Cannot be null or empty.</param>
        internal static void CreateTranslationFile(string originalFilePath, string translationPath, int traceLogLimit, string currentSessionFolder)
        {
            /* This trace log has a limit of 9 to avoid excessive logging in loops.
             */
            LogEvent.Trace(9, traceLogLimit, currentSessionFolder, ExeAsm);
            
            // Put another type of log here

            var line = string.Empty;

            foreach (string fileLine in File.ReadLines(originalFilePath))
            {
                /* This trace log has a limit of 9 to avoid excessive logging in loops.
                 */
                LogEvent.Trace(9, traceLogLimit, currentSessionFolder, ExeAsm);

                if (!string.IsNullOrWhiteSpace(fileLine))
                {
                    /* This trace log has a limit of 9 to avoid excessive logging in loops.
                     */
                    LogEvent.Trace(9, traceLogLimit, currentSessionFolder, ExeAsm);

                    line += fileLine.Trim() + Environment.NewLine;
                }
            }

            File.WriteAllText($@"{translationPath}\USERID_UserDescription_Active.translation", line);
        }
    }
}
