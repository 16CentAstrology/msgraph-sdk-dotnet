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
    /// The enum FirewallCertificateRevocationListCheckMethodType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FirewallCertificateRevocationListCheckMethodType
    {
    
        /// <summary>
        /// Device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// None
        /// </summary>
        None = 1,
	
        /// <summary>
        /// Attempt
        /// </summary>
        Attempt = 2,
	
        /// <summary>
        /// Require
        /// </summary>
        Require = 3,
	
    }
}