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
    /// The type Ediscovery Estimate Operation.
    /// </summary>
    public partial class EdiscoveryEstimateOperation : CaseOperation
    {
    
        ///<summary>
        /// The EdiscoveryEstimateOperation constructor
        ///</summary>
        public EdiscoveryEstimateOperation()
        {
            this.ODataType = "microsoft.graph.security.ediscoveryEstimateOperation";
        }

        /// <summary>
        /// Gets or sets indexed item count.
        /// The estimated count of items for the search that matched the content query.
        /// </summary>
        [JsonPropertyName("indexedItemCount")]
        public Int64? IndexedItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets indexed items size.
        /// The estimated size of items for the search that matched the content query.
        /// </summary>
        [JsonPropertyName("indexedItemsSize")]
        public Int64? IndexedItemsSize { get; set; }
    
        /// <summary>
        /// Gets or sets mailbox count.
        /// The number of mailboxes that had search hits.
        /// </summary>
        [JsonPropertyName("mailboxCount")]
        public Int32? MailboxCount { get; set; }
    
        /// <summary>
        /// Gets or sets site count.
        /// The number of mailboxes that had search hits.
        /// </summary>
        [JsonPropertyName("siteCount")]
        public Int32? SiteCount { get; set; }
    
        /// <summary>
        /// Gets or sets unindexed item count.
        /// The estimated count of unindexed items for the collection.
        /// </summary>
        [JsonPropertyName("unindexedItemCount")]
        public Int64? UnindexedItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets unindexed items size.
        /// The estimated size of unindexed items for the collection.
        /// </summary>
        [JsonPropertyName("unindexedItemsSize")]
        public Int64? UnindexedItemsSize { get; set; }
    
        /// <summary>
        /// Gets or sets search.
        /// eDiscovery search.
        /// </summary>
        [JsonPropertyName("search")]
        public EdiscoverySearch Search { get; set; }
    
    }
}

