// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsNominalRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsNominalRequestBody
    {
    
        /// <summary>
        /// Gets or sets EffectRate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "effectRate", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken EffectRate { get; set; }
    
        /// <summary>
        /// Gets or sets Npery.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "npery", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Npery { get; set; }
    
    }
}