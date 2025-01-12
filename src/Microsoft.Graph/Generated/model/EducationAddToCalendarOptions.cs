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
    /// The enum EducationAddToCalendarOptions.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EducationAddToCalendarOptions
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Students And Publisher
        /// </summary>
        StudentsAndPublisher = 1,
	
        /// <summary>
        /// Students And Team Owners
        /// </summary>
        StudentsAndTeamOwners = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
        /// <summary>
        /// Students Only
        /// </summary>
        StudentsOnly = 4,
	
    }
}
