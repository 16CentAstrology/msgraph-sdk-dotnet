// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Print Usage.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrintUsage>))]
    public partial class PrintUsage : Entity
    {
    
        ///<summary>
        /// The internal PrintUsage constructor
        ///</summary>
        protected internal PrintUsage()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets completed black and white job count.
        /// </summary>
        [JsonPropertyName("completedBlackAndWhiteJobCount")]
        public Int64? CompletedBlackAndWhiteJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets completed color job count.
        /// </summary>
        [JsonPropertyName("completedColorJobCount")]
        public Int64? CompletedColorJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets incomplete job count.
        /// </summary>
        [JsonPropertyName("incompleteJobCount")]
        public Int64? IncompleteJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets usage date.
        /// </summary>
        [JsonPropertyName("usageDate")]
        public Date UsageDate { get; set; }
    
    }
}

