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
    /// The enum TokenIssuerType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TokenIssuerType
    {
    
        /// <summary>
        /// Azure AD
        /// </summary>
        AzureAD = 0,
	
        /// <summary>
        /// ADFederation Services
        /// </summary>
        ADFederationServices = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
        /// <summary>
        /// Azure ADBackup Auth
        /// </summary>
        AzureADBackupAuth = 3,
	
        /// <summary>
        /// ADFederation Services MFAAdapter
        /// </summary>
        ADFederationServicesMFAAdapter = 4,
	
        /// <summary>
        /// NPSExtension
        /// </summary>
        NPSExtension = 5,
	
    }
}
