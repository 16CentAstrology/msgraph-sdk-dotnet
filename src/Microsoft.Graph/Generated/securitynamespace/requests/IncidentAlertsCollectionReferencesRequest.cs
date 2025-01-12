// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type IncidentAlertsCollectionReferencesRequest.
    /// </summary>
    public partial class IncidentAlertsCollectionReferencesRequest : Microsoft.Graph.BaseRequest, IIncidentAlertsCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new IncidentAlertsCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IncidentAlertsCollectionReferencesRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified Alert to the collection via POST.
        /// </summary>
        /// <param name="alert">The Alert to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(Alert alert, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(alert.Id))
            {
                throw new Microsoft.Graph.ServiceException(new Microsoft.Graph.Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new Microsoft.Graph.ReferenceRequestBody { ODataId = string.Format("{0}/security/alerts/{1}", this.Client.BaseUrl, alert.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified Alert to the collection via POST and returns a <see cref="GraphResponse{Alert}"/> object of the request.
        /// </summary>
        /// <param name="alert">The Alert to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(Alert alert, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;

            if (string.IsNullOrEmpty(alert.Id))
            {
                throw new Microsoft.Graph.ServiceException(new Microsoft.Graph.Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new Microsoft.Graph.ReferenceRequestBody { ODataId = string.Format("{0}/security/alerts/{1}", this.Client.BaseUrl, alert.Id) };
            return this.SendAsyncWithGraphResponse(requestBody, cancellationToken);
        }

    }
}
