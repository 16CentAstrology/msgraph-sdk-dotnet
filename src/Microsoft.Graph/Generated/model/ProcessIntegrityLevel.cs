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
    /// The enum ProcessIntegrityLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ProcessIntegrityLevel
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Untrusted
        /// </summary>
        Untrusted = 1,
	
        /// <summary>
        /// Low
        /// </summary>
        Low = 2,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 3,
	
        /// <summary>
        /// High
        /// </summary>
        High = 4,
	
        /// <summary>
        /// System
        /// </summary>
        System = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}