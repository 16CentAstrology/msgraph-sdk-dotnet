// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEdiscoveryReviewTagWithReferenceRequest.
    /// </summary>
    public partial interface IEdiscoveryReviewTagWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified EdiscoveryReviewTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryReviewTag.</returns>
        System.Threading.Tasks.Task<EdiscoveryReviewTag> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EdiscoveryReviewTag and returns a <see cref="GraphResponse{EdiscoveryReviewTag}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewTag>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified EdiscoveryReviewTag using POST.
        /// </summary>
        /// <param name="ediscoveryReviewTagToCreate">The EdiscoveryReviewTag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryReviewTag.</returns>
        System.Threading.Tasks.Task<EdiscoveryReviewTag> CreateAsync(EdiscoveryReviewTag ediscoveryReviewTagToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified EdiscoveryReviewTag using POST and returns a <see cref="GraphResponse{EdiscoveryReviewTag}"/> object.
        /// </summary>
        /// <param name="ediscoveryReviewTagToCreate">The EdiscoveryReviewTag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewTag>> CreateResponseAsync(EdiscoveryReviewTag ediscoveryReviewTagToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified EdiscoveryReviewTag using PATCH.
        /// </summary>
        /// <param name="ediscoveryReviewTagToUpdate">The EdiscoveryReviewTag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryReviewTag.</returns>
        System.Threading.Tasks.Task<EdiscoveryReviewTag> UpdateAsync(EdiscoveryReviewTag ediscoveryReviewTagToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified EdiscoveryReviewTag using PATCH and returns a <see cref="GraphResponse{EdiscoveryReviewTag}"/> object.
        /// </summary>
        /// <param name="ediscoveryReviewTagToUpdate">The EdiscoveryReviewTag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryReviewTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryReviewTag>> UpdateResponseAsync(EdiscoveryReviewTag ediscoveryReviewTagToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified EdiscoveryReviewTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified EdiscoveryReviewTag and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryReviewTagWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryReviewTagWithReferenceRequest Expand(Expression<Func<EdiscoveryReviewTag, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryReviewTagWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEdiscoveryReviewTagWithReferenceRequest Select(Expression<Func<EdiscoveryReviewTag, object>> selectExpression);

    }
}
