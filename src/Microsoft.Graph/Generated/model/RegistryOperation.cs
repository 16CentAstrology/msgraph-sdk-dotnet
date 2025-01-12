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
    /// The enum RegistryOperation.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RegistryOperation
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Create
        /// </summary>
        Create = 1,
	
        /// <summary>
        /// Modify
        /// </summary>
        Modify = 2,
	
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
