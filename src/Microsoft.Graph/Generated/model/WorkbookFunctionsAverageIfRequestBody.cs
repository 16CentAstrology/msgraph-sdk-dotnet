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
    /// The type WorkbookFunctionsAverageIfRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsAverageIfRequestBody
    {
    
        /// <summary>
        /// Gets or sets Range.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "range", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Range { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Criteria { get; set; }
    
        /// <summary>
        /// Gets or sets AverageRange.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageRange", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken AverageRange { get; set; }
    
    }
}