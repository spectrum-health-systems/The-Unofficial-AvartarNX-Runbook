// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Collections.Generic;
using TingenWebService.Properties;

namespace TingenWebService.Core.Configuration
{
    /// <summary>Tingen Web Service runtime configuration logic.</summary>
    /// <remarks>For more information about the Tingen Web Service, please see the <see cref="ProjectInfo"/> file.</remarks>
    internal class RuntimeConfig
    {
        /// <summary>Loads the runtime configuration from the Web.config file.</summary>
        /// <remarks>
        ///     <para>
        ///         Since the Tingen Web Service is not directly referenced by Outpost31, the settings are read into a
        ///         dictionary instead of a strongly-typed object.<br/>
        ///         <br/>
        ///         When a new setting is added to the Web.config file, it must also be added to this class.
        ///     </para>
        /// </remarks>
        /// <param name="webConfig">The contents of the Web.config file.</param>
        /// <param name="tngnWsvcVersion">The current <see cref="TingenWebService.TngnWsvcVersion"/> of the Tingen Web Service.</param>
        /// <returns>A dictionary with the runtime configuration settings.</returns>
        internal static Dictionary<string, string> Load(Settings webConfig, string tngnWsvcVersion) =>
            new Dictionary<string, string>
            {
                { "Version",             tngnWsvcVersion },
                { "BuildNumber",         webConfig.BuildNumber },
                { "AvatarSystem",        webConfig.AvatarSystem },
                { "Mode",                webConfig.Mode.ToLower() },
                { "ServerWwwPath",       webConfig.ServerWwwPath},
                { "ServerDataPath",      webConfig.ServerDataPath},
                { "TraceLogLimit",       webConfig.TraceLogLimit},
                { "SessionLogLimit",     webConfig.SessionLogLimit },
                { "NtstWsvcUserName",    webConfig.NtstWsvcUserName },
                { "NtstWsvcUserPass",    webConfig.NtstWsvcUserPass }
            };
    }
}