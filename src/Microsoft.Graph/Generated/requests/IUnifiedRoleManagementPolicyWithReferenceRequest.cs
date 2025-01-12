// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUnifiedRoleManagementPolicyWithReferenceRequest.
    /// </summary>
    public partial interface IUnifiedRoleManagementPolicyWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleManagementPolicy.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicy and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified UnifiedRoleManagementPolicy using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyToCreate">The UnifiedRoleManagementPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleManagementPolicy.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicy> CreateAsync(UnifiedRoleManagementPolicy unifiedRoleManagementPolicyToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified UnifiedRoleManagementPolicy using POST and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyToCreate">The UnifiedRoleManagementPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicy>> CreateResponseAsync(UnifiedRoleManagementPolicy unifiedRoleManagementPolicyToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified UnifiedRoleManagementPolicy using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyToUpdate">The UnifiedRoleManagementPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleManagementPolicy.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicy> UpdateAsync(UnifiedRoleManagementPolicy unifiedRoleManagementPolicyToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified UnifiedRoleManagementPolicy using PATCH and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyToUpdate">The UnifiedRoleManagementPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicy>> UpdateResponseAsync(UnifiedRoleManagementPolicy unifiedRoleManagementPolicyToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyWithReferenceRequest Expand(Expression<Func<UnifiedRoleManagementPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyWithReferenceRequest Select(Expression<Func<UnifiedRoleManagementPolicy, object>> selectExpression);

    }
}
