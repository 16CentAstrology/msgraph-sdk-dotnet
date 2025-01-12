// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CallOptions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CallOptions>))]
    public partial class CallOptions
    {

        ///<summary>
        /// The internal CallOptions constructor
        ///</summary>
        protected internal CallOptions()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets hideBotAfterEscalation.
        /// Indicates whether to hide the app after the call is escalated.
        /// </summary>
        [JsonPropertyName("hideBotAfterEscalation")]
        public bool? HideBotAfterEscalation { get; set; }
    
        /// <summary>
        /// Gets or sets isContentSharingNotificationEnabled.
        /// Indicates whether content sharing notifications should be enabled for the call.
        /// </summary>
        [JsonPropertyName("isContentSharingNotificationEnabled")]
        public bool? IsContentSharingNotificationEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
