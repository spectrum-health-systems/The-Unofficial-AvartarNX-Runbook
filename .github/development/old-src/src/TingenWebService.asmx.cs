// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

/* This is the entry point for the Tingen Web Service. The heavy lifting is done
 * in Outpost31, so this class won't change very often.
 *
 * Please see the ProjectInfo.cs file for more information.
 */

using System.Collections.Generic;
using System.Reflection;
using System.Web.Services;
using ScriptLinkStandard.Objects;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Catalog;
using TingenWebService.Core.Configuration;
using TingenWebService.Core.Logger;
using TingenWebService.Core.TingenWsvcSession;
using TingenWebService.Properties;

namespace TingenWebService
{
    /// <summary>The entry class for the Tingen Web Service.</summary>
    /// <remarks>For more information about the Tingen Web Service, please see the <see cref="ProjectInfo"/> file.</remarks>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class TingenWebService : WebService
    {
        /// <summary>The current version of the Tingen Web Service.</summary>
        /// <remarks>To update the version number, modify the AssemblyInfo.cs file.</remarks>
        public static string TngnWsvcVersion { get; set; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>Get the current version of the Tingen Web Service.</summary>
        /// <remarks>This method is required by Avatar.</remarks>
        /// <returns>The current <see cref="TngnWsvcVersion"/> of the Tingen Web Service.</returns>
        [WebMethod]
        public string GetVersion() => $"VERSION {TngnWsvcVersion}";

        /// <summary>Determines what the Tingen Web Service will do, if anything.</summary>
        /// <remarks>This method is required by Avatar.</remarks>
        /// <param name="origOptObj">The original <see cref="AvatarOptionObject"/> sent from Avatar.</param>
        /// <param name="origScriptParam">The original <see cref="AvatarScriptParameter"/> sent from Avatar.</param>
        /// <returns>A completed <see cref="OptionObject2015"/>.</returns>
        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 origOptObj, string origScriptParam)
        {
            /* Used for development/debugging, since you can't put a trace log here.
             */
            LogEvent.Debug();

            Dictionary<string, string> runtimeConfig = RuntimeConfig.Load(Settings.Default, TngnWsvcVersion);

            if (CriticalFailureOccurred(origOptObj, origScriptParam, runtimeConfig["Mode"]))
            {
                LogEvent.Debug();
                // TODO Generate a specific error log for this scenario, and probably send an email.
                return origOptObj.ToReturnOptionObject(0, "");
            }
            else if (runtimeConfig["Mode"] == "enabled" || runtimeConfig["Mode"] == "passthrough")
            {
                LogEvent.Debug();
                TngnWsvcSession wsvcSession = TngnWsvcSession.Start(origOptObj, origScriptParam, runtimeConfig);
                LogEvent.Debug();
                LogEvent.Session(wsvcSession);
                LogEvent.Debug();
                return wsvcSession.OptObj.Completed;
            }
            else
            {
                LogEvent.Debug();
                /* Technically we should never get here because of the CriticalFailureOccurred() check above. */
                //TODO Generate a specific error log for this scenario, and probably send an email.
                return origOptObj.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>Check for critical errors.</summary>
        /// <remarks>
        ///     The following are considered critical errors:
        ///     <list type="bullet">
        ///         <item>The <see cref="OptionObject2015"/> is not passed from Avatar.</item>
        ///         <item>The <see cref="AvatarScriptParameter"/> is not passed from Avatar.</item>
        ///         <item>The Tingen Web Service <c>Mode</c> is set to <i>disabled</i>.</item>
        ///         <item>The Tingen Web Service <c>Mode</c> is set to an <i>unknown state</i>.</item>
        ///     </list>
        /// </remarks>
        /// <param name="origOptObj">The original <see cref="AvatarOptionObject"/> sent from Avatar.</param>
        /// <param name="origScriptParam">The original <see cref="AvatarScriptParameter"/> sent from Avatar.</param>
        /// <param name="tngnWsvcMode">The Tingen Web Service <c>Mode</c>.</param>
        /// <returns><c>true</c> if a critical error occurred; otherwise, <c>false</c>.</returns>
        internal static bool CriticalFailureOccurred(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcMode)
        {
            if (origOptObj == null || string.IsNullOrWhiteSpace(origScriptParam))
            {
                LogEvent.Debug(msg_TngnWscv.MissingComponent(origOptObj, origScriptParam));
                //TODO Generate a specific error log for this scenario, and probably send an email.
                return true;
            }
            else
            {
                switch (tngnWsvcMode)
                {
                    case "enabled":
                    case "passthrough": // Not implemented yet. Even then, what?

                        LogEvent.Debug();
                        return false;

                    case "disabled":
                        LogEvent.Debug(msg_TngnWscv.DisabledMode());
                        //TODO Generate a specific error log for this scenario, and probably send an email.
                        return true;

                    default:
                        LogEvent.Debug(msg_TngnWscv.UnknownMode());
                        //TODO Generate a specific error log for this scenario, and probably send an email.
                        return true;
                }
            }
        }
    }
}