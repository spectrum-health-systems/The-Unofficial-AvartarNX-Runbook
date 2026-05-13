// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System;

namespace TingenWebService.Core.Logger
{
    public class LogSettings
    {
        public int TraceLogLimit { get; set; }
        public int SessionLogLimit { get; set; }
        public int LogMsec { get; set; }
        public static LogSettings Load(string traceLogLimit, string sessionLogLimit)
        {
            return new LogSettings
            {
                TraceLogLimit   = Convert.ToInt32(traceLogLimit),
                SessionLogLimit = Convert.ToInt32(sessionLogLimit),
            };
        }
    }
}
