// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type RiskyServicePrincipalRequest.
    /// </summary>
    public partial class RiskyServicePrincipalRequest : BaseRequest, IRiskyServicePrincipalRequest
    {
        /// <summary>
        /// Constructs a new RiskyServicePrincipalRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RiskyServicePrincipalRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RiskyServicePrincipal using POST.
        /// </summary>
        /// <param name="riskyServicePrincipalToCreate">The RiskyServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<RiskyServicePrincipal> CreateAsync(RiskyServicePrincipal riskyServicePrincipalToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<RiskyServicePrincipal>(riskyServicePrincipalToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RiskyServicePrincipal using POST and returns a <see cref="GraphResponse{RiskyServicePrincipal}"/> object.
        /// </summary>
        /// <param name="riskyServicePrincipalToCreate">The RiskyServicePrincipal to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyServicePrincipal>> CreateResponseAsync(RiskyServicePrincipal riskyServicePrincipalToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<RiskyServicePrincipal>(riskyServicePrincipalToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified RiskyServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<RiskyServicePrincipal>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RiskyServicePrincipal and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified RiskyServicePrincipal.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<RiskyServicePrincipal> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<RiskyServicePrincipal>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified RiskyServicePrincipal and returns a <see cref="GraphResponse{RiskyServicePrincipal}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyServicePrincipal>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<RiskyServicePrincipal>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RiskyServicePrincipal using PATCH.
        /// </summary>
        /// <param name="riskyServicePrincipalToUpdate">The RiskyServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskyServicePrincipal.</returns>
        public async System.Threading.Tasks.Task<RiskyServicePrincipal> UpdateAsync(RiskyServicePrincipal riskyServicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<RiskyServicePrincipal>(riskyServicePrincipalToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RiskyServicePrincipal using PATCH and returns a <see cref="GraphResponse{RiskyServicePrincipal}"/> object.
        /// </summary>
        /// <param name="riskyServicePrincipalToUpdate">The RiskyServicePrincipal to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RiskyServicePrincipal}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyServicePrincipal>> UpdateResponseAsync(RiskyServicePrincipal riskyServicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<RiskyServicePrincipal>(riskyServicePrincipalToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RiskyServicePrincipal using PUT.
        /// </summary>
        /// <param name="riskyServicePrincipalToUpdate">The RiskyServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<RiskyServicePrincipal> PutAsync(RiskyServicePrincipal riskyServicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<RiskyServicePrincipal>(riskyServicePrincipalToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RiskyServicePrincipal using PUT and returns a <see cref="GraphResponse{RiskyServicePrincipal}"/> object.
        /// </summary>
        /// <param name="riskyServicePrincipalToUpdate">The RiskyServicePrincipal object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{RiskyServicePrincipal}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RiskyServicePrincipal>> PutResponseAsync(RiskyServicePrincipal riskyServicePrincipalToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<RiskyServicePrincipal>(riskyServicePrincipalToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyServicePrincipalRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyServicePrincipalRequest Expand(Expression<Func<RiskyServicePrincipal, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyServicePrincipalRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyServicePrincipalRequest Select(Expression<Func<RiskyServicePrincipal, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="riskyServicePrincipalToInitialize">The <see cref="RiskyServicePrincipal"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RiskyServicePrincipal riskyServicePrincipalToInitialize)
        {

            if (riskyServicePrincipalToInitialize != null)
            {
                if (riskyServicePrincipalToInitialize.History != null && riskyServicePrincipalToInitialize.History.CurrentPage != null)
                {
                    riskyServicePrincipalToInitialize.History.InitializeNextPageRequest(this.Client, riskyServicePrincipalToInitialize.HistoryNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    riskyServicePrincipalToInitialize.History.AdditionalData = riskyServicePrincipalToInitialize.AdditionalData;
                }

            }


        }
    }
}
