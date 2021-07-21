// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserGetMailTipsRequestBody.
    /// </summary>
    public partial class UserGetMailTipsRequestBody
    {
    
        /// <summary>
        /// Gets or sets EmailAddresses.
        /// </summary>
        [JsonPropertyName("EmailAddresses")]
        public IEnumerable<string> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets MailTipsOptions.
        /// </summary>
        [JsonPropertyName("MailTipsOptions")]
        public MailTipsType? MailTipsOptions { get; set; }
    
    }
}
