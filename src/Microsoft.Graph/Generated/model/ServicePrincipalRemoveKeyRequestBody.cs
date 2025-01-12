// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ServicePrincipalRemoveKeyRequestBody.
    /// </summary>
    public partial class ServicePrincipalRemoveKeyRequestBody
    {
    
        /// <summary>
        /// Gets or sets KeyId.
        /// </summary>
        [JsonPropertyName("keyId")]
        public Guid KeyId { get; set; }
    
        /// <summary>
        /// Gets or sets Proof.
        /// </summary>
        [JsonPropertyName("proof")]
        public string Proof { get; set; }
    
    }
}
