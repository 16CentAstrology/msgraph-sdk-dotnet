// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAuthenticationRequest.
    /// </summary>
    public partial interface IAuthenticationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Authentication using POST.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Authentication.</returns>
        System.Threading.Tasks.Task<Authentication> CreateAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Authentication using POST and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToCreate">The Authentication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Authentication>> CreateResponseAsync(Authentication authenticationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Authentication and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Authentication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Authentication.</returns>
        System.Threading.Tasks.Task<Authentication> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Authentication and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Authentication>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Authentication using PATCH.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Authentication.</returns>
        System.Threading.Tasks.Task<Authentication> UpdateAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Authentication using PATCH and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Authentication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Authentication>> UpdateResponseAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Authentication using PUT.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Authentication> PutAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Authentication using PUT and returns a <see cref="GraphResponse{Authentication}"/> object.
        /// </summary>
        /// <param name="authenticationToUpdate">The Authentication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Authentication}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Authentication>> PutResponseAsync(Authentication authenticationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationRequest Expand(Expression<Func<Authentication, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationRequest Select(Expression<Func<Authentication, object>> selectExpression);

    }
}
