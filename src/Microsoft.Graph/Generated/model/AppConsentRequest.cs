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
    /// The type App Consent Request.
    /// </summary>
    public partial class AppConsentRequestObject : Entity
    {
    
		///<summary>
		/// The AppConsentRequest constructor
		///</summary>
        public AppConsentRequestObject()
        {
            this.ODataType = "microsoft.graph.appConsentRequest";
        }
	
        /// <summary>
        /// Gets or sets app display name.
        /// The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The identifier of the application. Required. Supports $filter (eq only) and $orderby.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets pending scopes.
        /// A list of pending scopes waiting for approval. Required.
        /// </summary>
        [JsonPropertyName("pendingScopes")]
        public IEnumerable<AppConsentRequestScope> PendingScopes { get; set; }
    
        /// <summary>
        /// Gets or sets user consent requests.
        /// A list of pending user consent requests.
        /// </summary>
        [JsonPropertyName("userConsentRequests")]
        public IAppConsentRequestUserConsentRequestsCollectionPage UserConsentRequests { get; set; }

        /// <summary>
        /// Gets or sets userConsentRequestsNextLink.
        /// </summary>
        [JsonPropertyName("userConsentRequests@odata.nextLink")]
        public string UserConsentRequestsNextLink { get; set; }
    
    }
}

