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
    /// The type Solutions Root.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SolutionsRoot>))]
    public partial class SolutionsRoot
    {
    
        /// <summary>
        /// Gets or sets booking businesses.
        /// </summary>
        [JsonPropertyName("bookingBusinesses")]
        public ISolutionsRootBookingBusinessesCollectionPage BookingBusinesses { get; set; }

        /// <summary>
        /// Gets or sets bookingBusinessesNextLink.
        /// </summary>
        [JsonPropertyName("bookingBusinesses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string BookingBusinessesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets booking currencies.
        /// </summary>
        [JsonPropertyName("bookingCurrencies")]
        public ISolutionsRootBookingCurrenciesCollectionPage BookingCurrencies { get; set; }

        /// <summary>
        /// Gets or sets bookingCurrenciesNextLink.
        /// </summary>
        [JsonPropertyName("bookingCurrencies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string BookingCurrenciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

