// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type IncidentAlertsCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class IncidentAlertsCollectionReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IIncidentAlertsCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new IncidentAlertsCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public IncidentAlertsCollectionReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IIncidentAlertsCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IIncidentAlertsCollectionReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new IncidentAlertsCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
