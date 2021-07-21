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
    /// The type AuthenticationRequest.
    /// </summary>
    public partial class AuthenticationRequest : BaseRequest, IAuthenticationRequest
    {
        /// <summary>
        /// Constructs a new AuthenticationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AuthenticationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Authentication using POST.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> CreateAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Authentication>(authenticationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Authentication using POST and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> CreateResponseAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Authentication>(authenticationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Authentication>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Authentication and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Authentication>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Authentication and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Authentication>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Authentication using PATCH.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Authentication.</returns>
        public async System.Threading.Tasks.Task<Authentication> UpdateAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Authentication>(authenticationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Authentication using PATCH and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> UpdateResponseAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Authentication>(authenticationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Authentication using PUT.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Authentication> PutAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Authentication>(authenticationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Authentication using PUT and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Authentication}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Authentication>> PutResponseAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Authentication>(authenticationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Expand(Expression<Func<Authentication, object>> expandExpression)
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
        public IAuthenticationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationRequest Select(Expression<Func<Authentication, object>> selectExpression)
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
        /// <param name="authenticationToInitialize">The <see cref="Authentication"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Authentication authenticationToInitialize)
        {

            if (authenticationToInitialize != null)
            {
                if (authenticationToInitialize.Fido2Methods != null && authenticationToInitialize.Fido2Methods.CurrentPage != null)
                {
                    authenticationToInitialize.Fido2Methods.InitializeNextPageRequest(this.Client, authenticationToInitialize.Fido2MethodsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authenticationToInitialize.Fido2Methods.AdditionalData = authenticationToInitialize.AdditionalData;
                }
                if (authenticationToInitialize.Methods != null && authenticationToInitialize.Methods.CurrentPage != null)
                {
                    authenticationToInitialize.Methods.InitializeNextPageRequest(this.Client, authenticationToInitialize.MethodsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authenticationToInitialize.Methods.AdditionalData = authenticationToInitialize.AdditionalData;
                }
                if (authenticationToInitialize.MicrosoftAuthenticatorMethods != null && authenticationToInitialize.MicrosoftAuthenticatorMethods.CurrentPage != null)
                {
                    authenticationToInitialize.MicrosoftAuthenticatorMethods.InitializeNextPageRequest(this.Client, authenticationToInitialize.MicrosoftAuthenticatorMethodsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authenticationToInitialize.MicrosoftAuthenticatorMethods.AdditionalData = authenticationToInitialize.AdditionalData;
                }
                if (authenticationToInitialize.WindowsHelloForBusinessMethods != null && authenticationToInitialize.WindowsHelloForBusinessMethods.CurrentPage != null)
                {
                    authenticationToInitialize.WindowsHelloForBusinessMethods.InitializeNextPageRequest(this.Client, authenticationToInitialize.WindowsHelloForBusinessMethodsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authenticationToInitialize.WindowsHelloForBusinessMethods.AdditionalData = authenticationToInitialize.AdditionalData;
                }

            }


        }
    }
}
