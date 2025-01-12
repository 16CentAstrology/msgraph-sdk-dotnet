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
    /// The enum ActionState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionState
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 1,
	
        /// <summary>
        /// Canceled
        /// </summary>
        Canceled = 2,
	
        /// <summary>
        /// Active
        /// </summary>
        Active = 3,
	
        /// <summary>
        /// Done
        /// </summary>
        Done = 4,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 5,
	
        /// <summary>
        /// Not Supported
        /// </summary>
        NotSupported = 6,
	
    }
}
