// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ClientUserAgent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ClientUserAgent : UserAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUserAgent"/> class.
        /// </summary>
        public ClientUserAgent()
        {
            this.ODataType = "microsoft.graph.callRecords.clientUserAgent";
        }

        /// <summary>
        /// Gets or sets platform.
        /// Identifies the platform used by this endpoint. Possible values are: unknown, windows, macOS, iOS, android, web, ipPhone, roomSystem, surfaceHub, holoLens, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public ClientPlatform? Platform { get; set; }
    
        /// <summary>
        /// Gets or sets productFamily.
        /// Identifies the family of application software used by this endpoint. Possible values are: unknown, teams, skypeForBusiness, lync, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productFamily", Required = Newtonsoft.Json.Required.Default)]
        public ProductFamily? ProductFamily { get; set; }
    
    }
}