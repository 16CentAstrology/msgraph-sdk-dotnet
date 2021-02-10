// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EventType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EventType
    {
    
        /// <summary>
        /// Single Instance
        /// </summary>
        SingleInstance = 0,
	
        /// <summary>
        /// Occurrence
        /// </summary>
        Occurrence = 1,
	
        /// <summary>
        /// Exception
        /// </summary>
        Exception = 2,
	
        /// <summary>
        /// Series Master
        /// </summary>
        SeriesMaster = 3,
	
    }
}