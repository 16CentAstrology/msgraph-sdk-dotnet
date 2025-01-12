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
    /// The type IdentitySet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IdentitySet>))]
    public partial class IdentitySet
    {

        /// <summary>
        /// Gets or sets application.
        /// Optional. The application associated with this action.
        /// </summary>
        [JsonPropertyName("application")]
        public Identity Application { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// Optional. The device associated with this action.
        /// </summary>
        [JsonPropertyName("device")]
        public Identity Device { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// Optional. The user associated with this action.
        /// </summary>
        [JsonPropertyName("user")]
        public Identity User { get; set; }
    
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
