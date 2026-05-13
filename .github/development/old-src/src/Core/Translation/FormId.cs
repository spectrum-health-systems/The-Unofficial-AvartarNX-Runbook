// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.IO;
using System.Reflection;
using TingenWebService.Core.Logger;

namespace TingenWebService.Core.Translation
{
    /// <summary>Provides functionality for retrieving form names based on form IDs and managing related metadata.</summary>
    /// <remarks>This class includes methods and properties for working with form identifiers and their
    /// associated names. It is designed for internal use and relies on a translation file to map form IDs to form
    /// names.</remarks>
    internal class FormId
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Retrieves the name of a form based on its identifier from a translation file.</summary>
        /// <remarks>
        ///     The <c>OptionId</c> component of the OptionObject contains the form ID.<br/>
        ///     <br/>
        ///     The <c>OptionId</c> is compared against entries in the <c>form_id-form_name.translation</c> file. If a match is
        ///     found, the corresponding form name is returned.<br/>
        ///     <br/>
        ///     If no match is found, the form name is given the value of <c>WSVC2491</c>.
        /// </remarks>
        /// <param name="optionId">The unique identifier of the form to look up.</param>
        /// <param name="translationPath">The directory path where the translation file is located.</param>
        /// <param name="sessionFolder">The current session folder.</param>
        /// <param name="traceLogLimit">The global <see cref="Core.Logger.LogSettings.TraceLogLimit"/>.</param>
        /// <returns>The name of the form if found in the translation file; otherwise, "WSVC2491".</returns>
        internal static string GetFormName(string optionId, string translationPath, string sessionFolder, int traceLogLimit)
        {
            LogEvent.Trace(1, traceLogLimit, sessionFolder, ExeAsm);

            foreach (string line in File.ReadAllLines($@"{translationPath}\form_id-form_name.trans"))
            {
                LogEvent.Trace(2, traceLogLimit, sessionFolder, ExeAsm);

                if (!string.IsNullOrWhiteSpace(line) && line.Split('=')[0] == optionId)
                {
                    LogEvent.Trace(3 , traceLogLimit, sessionFolder, ExeAsm);

                    return line.Split('=')[1];
                }
            }

            return "WSVC2491";
        }
    }
}
