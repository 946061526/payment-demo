﻿using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }
    }
}
