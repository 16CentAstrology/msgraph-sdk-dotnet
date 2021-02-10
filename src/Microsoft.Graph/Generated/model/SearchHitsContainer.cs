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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SearchHitsContainer.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SearchHitsContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHitsContainer"/> class.
        /// </summary>
        public SearchHitsContainer()
        {
            this.ODataType = "microsoft.graph.searchHitsContainer";
        }

        /// <summary>
        /// Gets or sets hits.
        /// A collection of the search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hits", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SearchHit> Hits { get; set; }
    
        /// <summary>
        /// Gets or sets moreResultsAvailable.
        /// Provides information if more results are available. Based on this information, you can adjust the from and size properties of the searchRequest accordingly.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "moreResultsAvailable", Required = Newtonsoft.Json.Required.Default)]
        public bool? MoreResultsAvailable { get; set; }
    
        /// <summary>
        /// Gets or sets total.
        /// The total number of results. Note this is not the number of results on the page, but the total number of results satisfying the query.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Total { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}