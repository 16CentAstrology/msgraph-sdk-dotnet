// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum OnlineMeetingProviderType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OnlineMeetingProviderType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Skype For Business
        /// </summary>
        SkypeForBusiness = 1,
	
        /// <summary>
        /// Skype For Consumer
        /// </summary>
        SkypeForConsumer = 2,
	
        /// <summary>
        /// Teams For Business
        /// </summary>
        TeamsForBusiness = 3,
	
    }
}
