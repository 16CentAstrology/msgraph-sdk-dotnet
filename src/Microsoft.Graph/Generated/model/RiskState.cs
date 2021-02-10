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
    /// The enum RiskState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RiskState
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Confirmed Safe
        /// </summary>
        ConfirmedSafe = 1,
	
        /// <summary>
        /// Remediated
        /// </summary>
        Remediated = 2,
	
        /// <summary>
        /// Dismissed
        /// </summary>
        Dismissed = 3,
	
        /// <summary>
        /// At Risk
        /// </summary>
        AtRisk = 4,
	
        /// <summary>
        /// Confirmed Compromised
        /// </summary>
        ConfirmedCompromised = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}