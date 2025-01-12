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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type RequestSchedule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RequestSchedule>))]
    public partial class RequestSchedule
    {

        /// <summary>
        /// Gets or sets expiration.
        /// When the eligible or active assignment expires.
        /// </summary>
        [JsonPropertyName("expiration")]
        public ExpirationPattern Expiration { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// The frequency of the  eligible or active assignment. This property is currently unsupported in PIM.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// When the  eligible or active assignment becomes active.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
