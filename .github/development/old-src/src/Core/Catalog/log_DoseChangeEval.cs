using System;

namespace TingenWebServiceCore.Catalog
{
    internal class log_DoseChangeEval
    {
        internal static string[] PrescriberIsAuthorizing(string callerInfo, string staffMemberIdQuery, string physicianApprover) => new string[]
            {
                $"{callerInfo}",
                "Dose Change Evaluation OTP - Prescriber Is Authorizing Order Event Triggered",
                $"Query: {staffMemberIdQuery}{Environment.NewLine}" +
                $"Physician/Approver : {physicianApprover}"
            };
    }
}
