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
    /// The interface IRichLongRunningOperationRequest.
    /// </summary>
    public partial interface IRichLongRunningOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RichLongRunningOperation using POST.
        /// </summary>
        /// <param name="richLongRunningOperationToCreate">The RichLongRunningOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RichLongRunningOperation.</returns>
        System.Threading.Tasks.Task<RichLongRunningOperation> CreateAsync(RichLongRunningOperation richLongRunningOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified RichLongRunningOperation using POST and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToCreate">The RichLongRunningOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> CreateResponseAsync(RichLongRunningOperation richLongRunningOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RichLongRunningOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified RichLongRunningOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RichLongRunningOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RichLongRunningOperation.</returns>
        System.Threading.Tasks.Task<RichLongRunningOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified RichLongRunningOperation and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PATCH.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RichLongRunningOperation.</returns>
        System.Threading.Tasks.Task<RichLongRunningOperation> UpdateAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PATCH and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RichLongRunningOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> UpdateResponseAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PUT.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RichLongRunningOperation> PutAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified RichLongRunningOperation using PUT and returns a <see cref="GraphResponse{RichLongRunningOperation}"/> object.
        /// </summary>
        /// <param name="richLongRunningOperationToUpdate">The RichLongRunningOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RichLongRunningOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RichLongRunningOperation>> PutResponseAsync(RichLongRunningOperation richLongRunningOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRichLongRunningOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRichLongRunningOperationRequest Expand(Expression<Func<RichLongRunningOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRichLongRunningOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRichLongRunningOperationRequest Select(Expression<Func<RichLongRunningOperation, object>> selectExpression);

    }
}
