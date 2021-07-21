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
    /// The type FileSystemInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<FileSystemInfo>))]
    public partial class FileSystemInfo
    {

        /// <summary>
        /// Gets or sets createdDateTime.
        /// The UTC date and time the file was created on a client.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastAccessedDateTime.
        /// The UTC date and time the file was last accessed. Available for the recent file list only.
        /// </summary>
        [JsonPropertyName("lastAccessedDateTime")]
        public DateTimeOffset? LastAccessedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// The UTC date and time the file was last modified on a client.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
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
