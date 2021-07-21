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
    /// The type GroupLifecyclePolicyRequest.
    /// </summary>
    public partial class GroupLifecyclePolicyRequest : BaseRequest, IGroupLifecyclePolicyRequest
    {
        /// <summary>
        /// Constructs a new GroupLifecyclePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupLifecyclePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> CreateAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupLifecyclePolicy>(groupLifecyclePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupLifecyclePolicy using POST and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToCreate">The GroupLifecyclePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> CreateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(groupLifecyclePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupLifecyclePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupLifecyclePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupLifecyclePolicy and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupLifecyclePolicy.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> UpdateAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PATCH and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupLifecyclePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> UpdateResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PUT.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupLifecyclePolicy> PutAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupLifecyclePolicy using PUT and returns a <see cref="GraphResponse{GroupLifecyclePolicy}"/> object.
        /// </summary>
        /// <param name="groupLifecyclePolicyToUpdate">The GroupLifecyclePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupLifecyclePolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupLifecyclePolicy>> PutResponseAsync(GroupLifecyclePolicy groupLifecyclePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupLifecyclePolicy>(groupLifecyclePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Expand(Expression<Func<GroupLifecyclePolicy, object>> expandExpression)
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
        public IGroupLifecyclePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupLifecyclePolicyRequest Select(Expression<Func<GroupLifecyclePolicy, object>> selectExpression)
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
        /// <param name="groupLifecyclePolicyToInitialize">The <see cref="GroupLifecyclePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupLifecyclePolicy groupLifecyclePolicyToInitialize)
        {

        }
    }
}
