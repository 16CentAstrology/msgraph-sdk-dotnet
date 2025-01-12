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
    /// The type ServiceAnnouncementRequest.
    /// </summary>
    public partial class ServiceAnnouncementRequest : BaseRequest, IServiceAnnouncementRequest
    {
        /// <summary>
        /// Constructs a new ServiceAnnouncementRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ServiceAnnouncementRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ServiceAnnouncement using POST.
        /// </summary>
        /// <param name="serviceAnnouncementToCreate">The ServiceAnnouncement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServiceAnnouncement.</returns>
        public async System.Threading.Tasks.Task<ServiceAnnouncement> CreateAsync(ServiceAnnouncement serviceAnnouncementToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ServiceAnnouncement>(serviceAnnouncementToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ServiceAnnouncement using POST and returns a <see cref="GraphResponse{ServiceAnnouncement}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementToCreate">The ServiceAnnouncement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncement>> CreateResponseAsync(ServiceAnnouncement serviceAnnouncementToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ServiceAnnouncement>(serviceAnnouncementToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ServiceAnnouncement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ServiceAnnouncement>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ServiceAnnouncement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ServiceAnnouncement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServiceAnnouncement.</returns>
        public async System.Threading.Tasks.Task<ServiceAnnouncement> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ServiceAnnouncement>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ServiceAnnouncement and returns a <see cref="GraphResponse{ServiceAnnouncement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncement>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ServiceAnnouncement>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ServiceAnnouncement using PATCH.
        /// </summary>
        /// <param name="serviceAnnouncementToUpdate">The ServiceAnnouncement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServiceAnnouncement.</returns>
        public async System.Threading.Tasks.Task<ServiceAnnouncement> UpdateAsync(ServiceAnnouncement serviceAnnouncementToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ServiceAnnouncement>(serviceAnnouncementToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ServiceAnnouncement using PATCH and returns a <see cref="GraphResponse{ServiceAnnouncement}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementToUpdate">The ServiceAnnouncement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServiceAnnouncement}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncement>> UpdateResponseAsync(ServiceAnnouncement serviceAnnouncementToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ServiceAnnouncement>(serviceAnnouncementToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ServiceAnnouncement using PUT.
        /// </summary>
        /// <param name="serviceAnnouncementToUpdate">The ServiceAnnouncement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ServiceAnnouncement> PutAsync(ServiceAnnouncement serviceAnnouncementToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ServiceAnnouncement>(serviceAnnouncementToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ServiceAnnouncement using PUT and returns a <see cref="GraphResponse{ServiceAnnouncement}"/> object.
        /// </summary>
        /// <param name="serviceAnnouncementToUpdate">The ServiceAnnouncement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ServiceAnnouncement}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ServiceAnnouncement>> PutResponseAsync(ServiceAnnouncement serviceAnnouncementToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ServiceAnnouncement>(serviceAnnouncementToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IServiceAnnouncementRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IServiceAnnouncementRequest Expand(Expression<Func<ServiceAnnouncement, object>> expandExpression)
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
        public IServiceAnnouncementRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IServiceAnnouncementRequest Select(Expression<Func<ServiceAnnouncement, object>> selectExpression)
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
        /// <param name="serviceAnnouncementToInitialize">The <see cref="ServiceAnnouncement"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ServiceAnnouncement serviceAnnouncementToInitialize)
        {

            if (serviceAnnouncementToInitialize != null)
            {
                if (serviceAnnouncementToInitialize.HealthOverviews != null && serviceAnnouncementToInitialize.HealthOverviews.CurrentPage != null)
                {
                    serviceAnnouncementToInitialize.HealthOverviews.InitializeNextPageRequest(this.Client, serviceAnnouncementToInitialize.HealthOverviewsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    serviceAnnouncementToInitialize.HealthOverviews.AdditionalData = serviceAnnouncementToInitialize.AdditionalData;
                }
                if (serviceAnnouncementToInitialize.Issues != null && serviceAnnouncementToInitialize.Issues.CurrentPage != null)
                {
                    serviceAnnouncementToInitialize.Issues.InitializeNextPageRequest(this.Client, serviceAnnouncementToInitialize.IssuesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    serviceAnnouncementToInitialize.Issues.AdditionalData = serviceAnnouncementToInitialize.AdditionalData;
                }
                if (serviceAnnouncementToInitialize.Messages != null && serviceAnnouncementToInitialize.Messages.CurrentPage != null)
                {
                    serviceAnnouncementToInitialize.Messages.InitializeNextPageRequest(this.Client, serviceAnnouncementToInitialize.MessagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    serviceAnnouncementToInitialize.Messages.AdditionalData = serviceAnnouncementToInitialize.AdditionalData;
                }

            }


        }
    }
}
