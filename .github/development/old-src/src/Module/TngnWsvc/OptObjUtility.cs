// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Reflection;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Logger;
using TingenWebService.Core.TingenWsvcSession;

namespace TingenWebService.Module.TngnWsvc
{
    /// <summary>Various utilities for OptionObjects.</summary>
    /// <remarks>For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.</remarks>
    internal class OptObjUtility
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        internal static void CatchOptionObject(TngnWsvcSession wsvcSession)
        {
            LogEvent.Trace(1, wsvcSession.LogSetting.TraceLogLimit, wsvcSession.Framework.TngnWsvcDataFolder.Session, ExeAsm);
            AvatarOptionObject.ExportOptObj(wsvcSession.OptObj.Original, wsvcSession.Framework.TngnWsvcDataFolder.Export);
        }
    }
}
