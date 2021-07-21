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
    /// The type TeamCloneRequestBody.
    /// </summary>
    public partial class TeamCloneRequestBody
    {
    
        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets MailNickname.
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets Classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public string Classification { get; set; }
    
        /// <summary>
        /// Gets or sets Visibility.
        /// </summary>
        [JsonPropertyName("visibility")]
        public TeamVisibilityType Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets PartsToClone.
        /// </summary>
        [JsonPropertyName("partsToClone")]
        public ClonableTeamParts PartsToClone { get; set; }
    
    }
}
