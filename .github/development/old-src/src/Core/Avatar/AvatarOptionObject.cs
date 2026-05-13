// =============================================================================
// https://github.com/spectrum-health-systems/tingen-web-service
// u251112_code
// u251112_documentation
// =============================================================================

using System.IO;
using System.Reflection;
using ScriptLinkStandard.Objects;

namespace TingenWebService.Core.Avatar
{
    /// <summary>Avatar OptionObject logic.</summary>
    public class AvatarOptionObject
    {
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
        public OptionObject2015 Original { get; set; }
        public OptionObject2015 Worker { get; set; }
        public OptionObject2015 Completed { get; set; }
        public static string VerifyExistence(OptionObject2015 origOptObj) =>
            (origOptObj == null)
                ? "An OptionObject was not sent."
                : "An OptionObject was sent.";
        public static void ToReturn(dynamic tngnWsvcSession, int errCode, string errMsg = "")
        {
            tngnWsvcSession.OptObj.Completed = tngnWsvcSession.OptObj.Worker.Clone();
            tngnWsvcSession.OptObj.Completed.ToReturnOptionObject(errCode, errMsg);
        }
        public static void ExportOptObj(OptionObject2015 origOptObj, string exportPath)
        {
            var dateTime = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var htmlVersion = origOptObj.ToHtmlString(true);
            File.WriteAllText($@"{exportPath}\\exported-optionobject-{dateTime}.html", htmlVersion);
            var jsonVersion = origOptObj.ToJson();
            File.WriteAllText($@"{exportPath}\\exported-optionobject-{dateTime}.json", jsonVersion);
        }
    }
}
