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
    /// The interface IUsedInsightRequest.
    /// </summary>
    public partial interface IUsedInsightRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UsedInsight using POST.
        /// </summary>
        /// <param name="usedInsightToCreate">The UsedInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UsedInsight.</returns>
        System.Threading.Tasks.Task<UsedInsight> CreateAsync(UsedInsight usedInsightToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UsedInsight using POST and returns a <see cref="GraphResponse{UsedInsight}"/> object.
        /// </summary>
        /// <param name="usedInsightToCreate">The UsedInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UsedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsedInsight>> CreateResponseAsync(UsedInsight usedInsightToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UsedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UsedInsight and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UsedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UsedInsight.</returns>
        System.Threading.Tasks.Task<UsedInsight> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UsedInsight and returns a <see cref="GraphResponse{UsedInsight}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UsedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsedInsight>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UsedInsight using PATCH.
        /// </summary>
        /// <param name="usedInsightToUpdate">The UsedInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UsedInsight.</returns>
        System.Threading.Tasks.Task<UsedInsight> UpdateAsync(UsedInsight usedInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UsedInsight using PATCH and returns a <see cref="GraphResponse{UsedInsight}"/> object.
        /// </summary>
        /// <param name="usedInsightToUpdate">The UsedInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UsedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsedInsight>> UpdateResponseAsync(UsedInsight usedInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UsedInsight using PUT.
        /// </summary>
        /// <param name="usedInsightToUpdate">The UsedInsight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UsedInsight> PutAsync(UsedInsight usedInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UsedInsight using PUT and returns a <see cref="GraphResponse{UsedInsight}"/> object.
        /// </summary>
        /// <param name="usedInsightToUpdate">The UsedInsight object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UsedInsight}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UsedInsight>> PutResponseAsync(UsedInsight usedInsightToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUsedInsightRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUsedInsightRequest Expand(Expression<Func<UsedInsight, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUsedInsightRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUsedInsightRequest Select(Expression<Func<UsedInsight, object>> selectExpression);

    }
}
