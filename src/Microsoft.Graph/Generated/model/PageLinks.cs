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
    /// The type PageLinks.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PageLinks>))]
    public partial class PageLinks
    {

        /// <summary>
        /// Gets or sets oneNoteClientUrl.
        /// Opens the page in the OneNote native client if it's installed.
        /// </summary>
        [JsonPropertyName("oneNoteClientUrl")]
        public ExternalLink OneNoteClientUrl { get; set; }
    
        /// <summary>
        /// Gets or sets oneNoteWebUrl.
        /// Opens the page in OneNote on the web.
        /// </summary>
        [JsonPropertyName("oneNoteWebUrl")]
        public ExternalLink OneNoteWebUrl { get; set; }
    
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
