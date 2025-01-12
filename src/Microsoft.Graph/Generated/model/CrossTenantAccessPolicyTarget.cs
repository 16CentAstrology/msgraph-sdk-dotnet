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
    /// The type CrossTenantAccessPolicyTarget.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CrossTenantAccessPolicyTarget>))]
    public partial class CrossTenantAccessPolicyTarget
    {

        /// <summary>
        /// Gets or sets target.
        /// The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
    
        /// <summary>
        /// Gets or sets targetType.
        /// The type of resource that you want to target. The possible values are: user, group, application, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("targetType")]
        public CrossTenantAccessPolicyTargetType? TargetType { get; set; }
    
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
