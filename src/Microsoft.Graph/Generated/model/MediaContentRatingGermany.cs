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
    /// The type MediaContentRatingGermany.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MediaContentRatingGermany>))]
    public partial class MediaContentRatingGermany
    {

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for Germany. Possible values are: allAllowed, allBlocked, general, agesAbove6, agesAbove12, agesAbove16, adults.
        /// </summary>
        [JsonPropertyName("movieRating")]
        public RatingGermanyMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for Germany. Possible values are: allAllowed, allBlocked, general, agesAbove6, agesAbove12, agesAbove16, adults.
        /// </summary>
        [JsonPropertyName("tvRating")]
        public RatingGermanyTelevisionType? TvRating { get; set; }
    
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
