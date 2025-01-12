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
    /// The interface IPlannerBucketRequest.
    /// </summary>
    public partial interface IPlannerBucketRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerBucket using POST.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerBucket.</returns>
        System.Threading.Tasks.Task<PlannerBucket> CreateAsync(PlannerBucket plannerBucketToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PlannerBucket using POST and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="plannerBucketToCreate">The PlannerBucket to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerBucket}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> CreateResponseAsync(PlannerBucket plannerBucketToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PlannerBucket.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PlannerBucket and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PlannerBucket.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerBucket.</returns>
        System.Threading.Tasks.Task<PlannerBucket> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PlannerBucket and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerBucket}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlannerBucket using PATCH.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerBucket.</returns>
        System.Threading.Tasks.Task<PlannerBucket> UpdateAsync(PlannerBucket plannerBucketToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlannerBucket using PATCH and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerBucket}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> UpdateResponseAsync(PlannerBucket plannerBucketToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlannerBucket using PUT.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PlannerBucket> PutAsync(PlannerBucket plannerBucketToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PlannerBucket using PUT and returns a <see cref="GraphResponse{PlannerBucket}"/> object.
        /// </summary>
        /// <param name="plannerBucketToUpdate">The PlannerBucket object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PlannerBucket}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucket>> PutResponseAsync(PlannerBucket plannerBucketToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketRequest Expand(Expression<Func<PlannerBucket, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketRequest Select(Expression<Func<PlannerBucket, object>> selectExpression);

    }
}
