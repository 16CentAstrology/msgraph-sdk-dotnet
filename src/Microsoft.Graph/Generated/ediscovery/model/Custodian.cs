// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Custodian.
    /// </summary>
    public partial class Custodian : DataSourceContainer
    {
    
        ///<summary>
        /// The Custodian constructor
        ///</summary>
        public Custodian()
        {
            this.ODataType = "microsoft.graph.ediscovery.custodian";
        }

        /// <summary>
        /// Gets or sets acknowledged date time.
        /// Date and time the custodian acknowledged a hold notification.
        /// </summary>
        [JsonPropertyName("acknowledgedDateTime")]
        public DateTimeOffset? AcknowledgedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets apply hold to sources.
        /// Identifies whether a custodian's sources were placed on hold during creation.
        /// </summary>
        [JsonPropertyName("applyHoldToSources")]
        public bool? ApplyHoldToSources { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// Email address of the custodian.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets site sources.
        /// Data source entity for SharePoint sites associated with the custodian.
        /// </summary>
        [JsonPropertyName("siteSources")]
        public ICustodianSiteSourcesCollectionPage SiteSources { get; set; }

        /// <summary>
        /// Gets or sets siteSourcesNextLink.
        /// </summary>
        [JsonPropertyName("siteSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SiteSourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets unified group sources.
        /// Data source entity for groups associated with the custodian.
        /// </summary>
        [JsonPropertyName("unifiedGroupSources")]
        public ICustodianUnifiedGroupSourcesCollectionPage UnifiedGroupSources { get; set; }

        /// <summary>
        /// Gets or sets unifiedGroupSourcesNextLink.
        /// </summary>
        [JsonPropertyName("unifiedGroupSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UnifiedGroupSourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user sources.
        /// Data source entity for a the custodian. This is the container for a custodian's mailbox and OneDrive for Business site.
        /// </summary>
        [JsonPropertyName("userSources")]
        public ICustodianUserSourcesCollectionPage UserSources { get; set; }

        /// <summary>
        /// Gets or sets userSourcesNextLink.
        /// </summary>
        [JsonPropertyName("userSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserSourcesNextLink { get; set; }
    
    }
}

