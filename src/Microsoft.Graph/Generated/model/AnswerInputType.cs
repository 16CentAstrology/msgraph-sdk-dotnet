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
    /// The enum AnswerInputType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AnswerInputType
    {
    
        /// <summary>
        /// Text
        /// </summary>
        Text = 0,
	
        /// <summary>
        /// Radio Button
        /// </summary>
        RadioButton = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
