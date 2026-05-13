// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.Collections.Generic;
using TingenWebService.Core.Avatar;
using TingenWebService.Core.Framework;
using TingenWebService.Core.Logger;
using ScriptLinkStandard.Objects;
using TingenWebService.Core.Maintenance;

namespace TingenWebService.Core.TingenWsvcSession
{
    public class TngnWsvcSession
    {
        public TngnWsvcRuntime Runtime { get; set; }
        public TngnWsvcFramework Framework { get; set; }
        public LogSettings LogSetting { get; set; }
        public AvatarOptionObject OptObj { get; set; }
        public AvatarScriptParameter ScriptParameter { get; set; }
        public static TngnWsvcSession Start(OptionObject2015 origOptObj, string origScriptParam, Dictionary<string, string> runtimeConfig)
        {
            TngnWsvcSession tngnWsvcSession = Load(origOptObj, origScriptParam, runtimeConfig);
            SessionMaintenance.QuickCheck(tngnWsvcSession.LogSetting.TraceLogLimit, tngnWsvcSession.Framework.TngnWsvcDataFolder.Session);
            DailyMaintenance.QuickCheck(tngnWsvcSession);
            AvatarScriptParameter.Parse(tngnWsvcSession);
            return tngnWsvcSession;
        }
        internal static TngnWsvcSession Load(OptionObject2015 origOptObj, string origScriptParam, Dictionary<string, string> runtimeConfig)
        {
            TngnWsvcRuntime tngnWsvcRuntime = TngnWsvcRuntime.Load(runtimeConfig["Version"],
                                                                   runtimeConfig["Mode"],
                                                                   runtimeConfig["AvatarSystem"],
                                                                   origOptObj.OptionUserId,
                                                                   runtimeConfig["NtstWsvcUserName"],
                                                                   runtimeConfig["NtstWsvcUserPass"]);
            return new TngnWsvcSession()
            {
                Runtime    = tngnWsvcRuntime,
                Framework  = TngnWsvcFramework.Load(runtimeConfig["AvatarSystem"], tngnWsvcRuntime.AvatarUserId, runtimeConfig["ServerDataPath"], runtimeConfig["ServerWwwPath"], tngnWsvcRuntime.SessionDate, tngnWsvcRuntime.SessionTime),
                LogSetting = LogSettings.Load(runtimeConfig["TraceLogLimit"], runtimeConfig["SessionLogLimit"]),
                OptObj     = new AvatarOptionObject()
                {
                    Original  = origOptObj,
                    Worker    = origOptObj.Clone(),
                    Completed = null
                },
                ScriptParameter = new AvatarScriptParameter()
                {
                    OriginalScriptParameter = origScriptParam
                },
            };
        }
    }
}
