// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SecureScoreControlStateUpdate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SecureScoreControlStateUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecureScoreControlStateUpdate"/> class.
        /// </summary>
        public SecureScoreControlStateUpdate()
        {
            this.ODataType = "microsoft.graph.secureScoreControlStateUpdate";
        }

        /// <summary>
        /// Gets or sets assignedTo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedTo", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comment", Required = Newtonsoft.Json.Required.Default)]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets updatedBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updatedBy", Required = Newtonsoft.Json.Required.Default)]
        public string UpdatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets updatedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? UpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}