// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type RedundancyDetectionSettings.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<RedundancyDetectionSettings>))]
    public partial class RedundancyDetectionSettings
    {

        /// <summary>
        /// Gets or sets isEnabled.
        /// Indicates whether email threading and near duplicate detection are enabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets maxWords.
        /// Specifies the maximum number of words used for email threading and near duplicate detection. To learn more, see Minimum/maximum number of words.
        /// </summary>
        [JsonPropertyName("maxWords")]
        public Int32? MaxWords { get; set; }
    
        /// <summary>
        /// Gets or sets minWords.
        /// Specifies the minimum number of words used for email threading and near duplicate detection. To learn more, see Minimum/maximum number of words.
        /// </summary>
        [JsonPropertyName("minWords")]
        public Int32? MinWords { get; set; }
    
        /// <summary>
        /// Gets or sets similarityThreshold.
        /// Specifies the similarity level for documents to be put in the same near duplicate set. To learn more, see Document and email similarity threshold.
        /// </summary>
        [JsonPropertyName("similarityThreshold")]
        public Int32? SimilarityThreshold { get; set; }
    
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
