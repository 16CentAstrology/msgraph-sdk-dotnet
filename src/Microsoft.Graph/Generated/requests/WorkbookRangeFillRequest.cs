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
    /// The type WorkbookRangeFillRequest.
    /// </summary>
    public partial class WorkbookRangeFillRequest : BaseRequest, IWorkbookRangeFillRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRangeFillRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRangeFillRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> CreateAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WorkbookRangeFill>(workbookRangeFillToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> CreateResponseAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WorkbookRangeFill>(workbookRangeFillToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WorkbookRangeFill>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WorkbookRangeFill>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFill and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WorkbookRangeFill>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> UpdateAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> UpdateResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PUT.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFill> PutAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PUT and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WorkbookRangeFill}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> PutResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WorkbookRangeFill>(workbookRangeFillToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Expand(Expression<Func<WorkbookRangeFill, object>> expandExpression)
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
        public IWorkbookRangeFillRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFillRequest Select(Expression<Func<WorkbookRangeFill, object>> selectExpression)
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
        /// <param name="workbookRangeFillToInitialize">The <see cref="WorkbookRangeFill"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookRangeFill workbookRangeFillToInitialize)
        {

        }
    }
}
