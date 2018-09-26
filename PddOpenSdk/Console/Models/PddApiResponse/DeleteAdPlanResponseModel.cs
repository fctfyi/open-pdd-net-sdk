// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PddOpenSdk.Models.PddApiResponse
{

    public class AdPlanDeleteResponse
    {

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_success")]
        public bool IsSuccess { get; set; }
    }

    public class DeleteAdPlanResponseModel
    {

        /// <summary>
        /// Examples: {"is_success":true}
        /// </summary>
        [JsonProperty("ad_plan_delete_response")]
        public AdPlanDeleteResponse AdPlanDeleteResponse { get; set; }
    }

}