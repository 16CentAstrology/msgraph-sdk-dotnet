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
    /// The interface IOnenoteRequest.
    /// </summary>
    public partial interface IOnenoteRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Onenote using POST.
        /// </summary>
        /// <param name="onenoteToCreate">The Onenote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Onenote.</returns>
        System.Threading.Tasks.Task<Onenote> CreateAsync(Onenote onenoteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Onenote using POST and returns a <see cref="GraphResponse{Onenote}"/> object.
        /// </summary>
        /// <param name="onenoteToCreate">The Onenote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Onenote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Onenote>> CreateResponseAsync(Onenote onenoteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Onenote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Onenote and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Onenote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Onenote.</returns>
        System.Threading.Tasks.Task<Onenote> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Onenote and returns a <see cref="GraphResponse{Onenote}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Onenote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Onenote>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Onenote using PATCH.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Onenote.</returns>
        System.Threading.Tasks.Task<Onenote> UpdateAsync(Onenote onenoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Onenote using PATCH and returns a <see cref="GraphResponse{Onenote}"/> object.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Onenote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Onenote>> UpdateResponseAsync(Onenote onenoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Onenote using PUT.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Onenote> PutAsync(Onenote onenoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Onenote using PUT and returns a <see cref="GraphResponse{Onenote}"/> object.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Onenote}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Onenote>> PutResponseAsync(Onenote onenoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteRequest Expand(Expression<Func<Onenote, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteRequest Select(Expression<Func<Onenote, object>> selectExpression);

    }
}
