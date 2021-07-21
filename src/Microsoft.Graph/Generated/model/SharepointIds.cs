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
    /// The type SharepointIds.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SharepointIds>))]
    public partial class SharepointIds
    {

        /// <summary>
        /// Gets or sets listId.
        /// The unique identifier (guid) for the item's list in SharePoint.
        /// </summary>
        [JsonPropertyName("listId")]
        public string ListId { get; set; }
    
        /// <summary>
        /// Gets or sets listItemId.
        /// An integer identifier for the item within the containing list.
        /// </summary>
        [JsonPropertyName("listItemId")]
        public string ListItemId { get; set; }
    
        /// <summary>
        /// Gets or sets listItemUniqueId.
        /// The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
        /// </summary>
        [JsonPropertyName("listItemUniqueId")]
        public string ListItemUniqueId { get; set; }
    
        /// <summary>
        /// Gets or sets siteId.
        /// The unique identifier (guid) for the item's site collection (SPSite).
        /// </summary>
        [JsonPropertyName("siteId")]
        public string SiteId { get; set; }
    
        /// <summary>
        /// Gets or sets siteUrl.
        /// The SharePoint URL for the site that contains the item.
        /// </summary>
        [JsonPropertyName("siteUrl")]
        public string SiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets tenantId.
        /// The unique identifier (guid) for the tenancy.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets webId.
        /// The unique identifier (guid) for the item's site (SPWeb).
        /// </summary>
        [JsonPropertyName("webId")]
        public string WebId { get; set; }
    
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
