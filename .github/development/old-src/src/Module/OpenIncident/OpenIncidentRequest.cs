// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Reflection;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Catalog;
using TingenWebService.Core.Logger;
using TingenWebService.Core.Query;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.OpenIncident
{
    /// <summary>OpenIncident Module request logic.</summary>
    internal class OpenIncidentRequest
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void PostFileEvent(TngnWsvcSession tngnWsvcSession, OpenIncidentConfig openIncidentConfig)
        {
            LogEvent.Trace(1, tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            //Nothing here.
        }
    }
}
