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
    /// The type RichLongRunningOperationRequest.
    /// </summary>
    public partial class RichLongRunningOperationRequest : BaseRequest, IRichLongRunningOperationRequest
    {
        /// <summary>
        /// Constructs a new RichLongRunningOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RichLongRunningOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RichLongRunningOperation using POST.
        /// </summary>
        /// <param name="richLongRunningOperationToCreate">The RichLongRunningOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RichLongRunningOperation.</returns>
        public async System.Threading.Tasks.Task<RichLongRunningOperation> CreateAsync(RichLongRunningOperation richLongRunningOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<RichLongRunningOperation>(richLongRunningOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RichLongRunningOperation using POST and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToCreate">The RichLongRunningOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> CreateResponseAsync(RichLongRunningOperation richLongRunningOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<RichLongRunningOperation>(richLongRunningOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified RichLongRunningOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<RichLongRunningOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RichLongRunningOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified RichLongRunningOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RichLongRunningOperation.</returns>
        public async System.Threading.Tasks.Task<RichLongRunningOperation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<RichLongRunningOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified RichLongRunningOperation and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<RichLongRunningOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PATCH.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RichLongRunningOperation.</returns>
        public async System.Threading.Tasks.Task<RichLongRunningOperation> UpdateAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<RichLongRunningOperation>(richLongRunningOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PATCH and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> UpdateResponseAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<RichLongRunningOperation>(richLongRunningOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PUT.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<RichLongRunningOperation> PutAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<RichLongRunningOperation>(richLongRunningOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PUT and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{RichLongRunningOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> PutResponseAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<RichLongRunningOperation>(richLongRunningOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRichLongRunningOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRichLongRunningOperationRequest Expand(Expression<Func<RichLongRunningOperation, object>> expandExpression)
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
        public IRichLongRunningOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRichLongRunningOperationRequest Select(Expression<Func<RichLongRunningOperation, object>> selectExpression)
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
        /// <param name="richLongRunningOperationToInitialize">The <see cref="RichLongRunningOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RichLongRunningOperation richLongRunningOperationToInitialize)
        {

        }
    }
}
