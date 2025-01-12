// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Event Message Response.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EventMessageResponse>))]
    public partial class EventMessageResponse : EventMessage
    {
    
        ///<summary>
        /// The EventMessageResponse constructor
        ///</summary>
        public EventMessageResponse()
        {
            this.ODataType = "microsoft.graph.eventMessageResponse";
        }

        /// <summary>
        /// Gets or sets proposed new time.
        /// </summary>
        [JsonPropertyName("proposedNewTime")]
        public TimeSlot ProposedNewTime { get; set; }
    
        /// <summary>
        /// Gets or sets response type.
        /// </summary>
        [JsonPropertyName("responseType")]
        public ResponseType? ResponseType { get; set; }
    
    }
}

