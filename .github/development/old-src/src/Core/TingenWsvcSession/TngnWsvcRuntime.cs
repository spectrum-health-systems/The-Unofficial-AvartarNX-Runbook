// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;

namespace TingenWebService.Core.TingenWsvcSession
{
    public class TngnWsvcRuntime
    {
        public string SessionDate { get; set; }
        public string SessionTime { get; set; }
        public string Version { get; set; }
        public string Mode { get; set; }
        public string AvatarSystem { get; set; }
        public string AvatarUserId { get; set; }
        public string NtstWsvcUserName { get; set; }
        public string NtstWsvcUserPass { get; set; }
        public string RunningLog { get; set; }
        internal static TngnWsvcRuntime Load(string version, string mode, string avatarSystem, string avatarUserId, string ntstWsvcUserName, string ntstWsvcUserPass) =>
            new TngnWsvcRuntime()
            {
                SessionDate         = DateTime.Now.ToString("yyMMdd"),
                SessionTime         = DateTime.Now.ToString("HHmmss"),
                Version             = version,
                Mode                = mode.ToLower(),
                AvatarSystem        = avatarSystem,
                AvatarUserId        = avatarUserId.ToLower(),
                RunningLog          = "",
                NtstWsvcUserName    = ntstWsvcUserName,
                NtstWsvcUserPass    = ntstWsvcUserPass
            };
    }
}
