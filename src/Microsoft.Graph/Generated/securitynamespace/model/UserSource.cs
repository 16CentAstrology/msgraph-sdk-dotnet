// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type User Source.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<UserSource>))]
    public partial class UserSource : DataSource
    {
    
        ///<summary>
        /// The UserSource constructor
        ///</summary>
        public UserSource()
        {
            this.ODataType = "microsoft.graph.security.userSource";
        }

        /// <summary>
        /// Gets or sets email.
        /// Email address of the user's mailbox.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets included sources.
        /// Specifies which sources are included in this group. Possible values are: mailbox, site.
        /// </summary>
        [JsonPropertyName("includedSources")]
        public SourceType? IncludedSources { get; set; }
    
        /// <summary>
        /// Gets or sets site web url.
        /// The URL of the user's OneDrive for Business site. Read-only.
        /// </summary>
        [JsonPropertyName("siteWebUrl")]
        public string SiteWebUrl { get; set; }
    
    }
}

