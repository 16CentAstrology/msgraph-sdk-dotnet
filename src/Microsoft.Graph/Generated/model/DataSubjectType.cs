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
    /// The enum DataSubjectType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DataSubjectType
    {
    
        /// <summary>
        /// Customer
        /// </summary>
        Customer = 0,
	
        /// <summary>
        /// Current Employee
        /// </summary>
        CurrentEmployee = 1,
	
        /// <summary>
        /// Former Employee
        /// </summary>
        FormerEmployee = 2,
	
        /// <summary>
        /// Prospective Employee
        /// </summary>
        ProspectiveEmployee = 3,
	
        /// <summary>
        /// Student
        /// </summary>
        Student = 4,
	
        /// <summary>
        /// Teacher
        /// </summary>
        Teacher = 5,
	
        /// <summary>
        /// Faculty
        /// </summary>
        Faculty = 6,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
    }
}
