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
    /// The type ImportedWindowsAutopilotDeviceIdentityRequest.
    /// </summary>
    public partial class ImportedWindowsAutopilotDeviceIdentityRequest : BaseRequest, IImportedWindowsAutopilotDeviceIdentityRequest
    {
        /// <summary>
        /// Constructs a new ImportedWindowsAutopilotDeviceIdentityRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ImportedWindowsAutopilotDeviceIdentityRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ImportedWindowsAutopilotDeviceIdentity using POST.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToCreate">The ImportedWindowsAutopilotDeviceIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedWindowsAutopilotDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> CreateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ImportedWindowsAutopilotDeviceIdentity using POST and returns a <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToCreate">The ImportedWindowsAutopilotDeviceIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedWindowsAutopilotDeviceIdentity>> CreateResponseAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ImportedWindowsAutopilotDeviceIdentity>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ImportedWindowsAutopilotDeviceIdentity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedWindowsAutopilotDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ImportedWindowsAutopilotDeviceIdentity>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ImportedWindowsAutopilotDeviceIdentity and returns a <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedWindowsAutopilotDeviceIdentity>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ImportedWindowsAutopilotDeviceIdentity>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PATCH.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedWindowsAutopilotDeviceIdentity.</returns>
        public async System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> UpdateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PATCH and returns a <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedWindowsAutopilotDeviceIdentity>> UpdateResponseAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PUT.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> PutAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PUT and returns a <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/> object.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ImportedWindowsAutopilotDeviceIdentity}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ImportedWindowsAutopilotDeviceIdentity>> PutResponseAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ImportedWindowsAutopilotDeviceIdentity>(importedWindowsAutopilotDeviceIdentityToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedWindowsAutopilotDeviceIdentityRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedWindowsAutopilotDeviceIdentityRequest Expand(Expression<Func<ImportedWindowsAutopilotDeviceIdentity, object>> expandExpression)
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
        public IImportedWindowsAutopilotDeviceIdentityRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IImportedWindowsAutopilotDeviceIdentityRequest Select(Expression<Func<ImportedWindowsAutopilotDeviceIdentity, object>> selectExpression)
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
        /// <param name="importedWindowsAutopilotDeviceIdentityToInitialize">The <see cref="ImportedWindowsAutopilotDeviceIdentity"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToInitialize)
        {

        }
    }
}
