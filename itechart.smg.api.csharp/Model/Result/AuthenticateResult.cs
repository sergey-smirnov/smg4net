﻿using System.Runtime.Serialization;
using itechart.smg.api.csharp.SmgMobileService;

namespace itechart.smg.api.csharp.Model.Result
{
    [DataContract]
    public class AuthenticateResult : BaseApiResult<AuthenticateOutput>
    {
        [DataMember(Name = "SesionId", EmitDefaultValue = false)]
        public string SesionId { get; set; }
        
        public override void InitializeFromOutput(AuthenticateOutput output)
        {
            base.InitializeFromOutput(output);

            SesionId = output.SessionId.ToString();
        }
    }
}