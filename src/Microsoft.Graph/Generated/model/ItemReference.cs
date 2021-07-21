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
    /// The type ItemReference.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ItemReference>))]
    public partial class ItemReference
    {

        /// <summary>
        /// Gets or sets driveId.
        /// Unique identifier of the drive instance that contains the item. Read-only.
        /// </summary>
        [JsonPropertyName("driveId")]
        public string DriveId { get; set; }
    
        /// <summary>
        /// Gets or sets driveType.
        /// Identifies the type of drive. See [drive][] resource for values.
        /// </summary>
        [JsonPropertyName("driveType")]
        public string DriveType { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Unique identifier of the item in the drive. Read-only.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the item being referenced. Read-only.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets path.
        /// Path that can be used to navigate to the item. Read-only.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or sets shareId.
        /// A unique identifier for a shared resource that can be accessed via the [Shares][] API.
        /// </summary>
        [JsonPropertyName("shareId")]
        public string ShareId { get; set; }
    
        /// <summary>
        /// Gets or sets sharepointIds.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonPropertyName("sharepointIds")]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets siteId.
        /// For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
        /// </summary>
        [JsonPropertyName("siteId")]
        public string SiteId { get; set; }
    
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
