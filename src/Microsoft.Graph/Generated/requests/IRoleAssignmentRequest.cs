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
    /// The interface IRoleAssignmentRequest.
    /// </summary>
    public partial interface IRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RoleAssignment using POST.
        /// </summary>
        /// <param name="roleAssignmentToCreate">The RoleAssignment to create.</param>
        /// <returns>The created RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> CreateAsync(RoleAssignment roleAssignmentToCreate);        /// <summary>
        /// Creates the specified RoleAssignment using POST.
        /// </summary>
        /// <param name="roleAssignmentToCreate">The RoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> CreateAsync(RoleAssignment roleAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RoleAssignment.
        /// </summary>
        /// <returns>The RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified RoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RoleAssignment using PATCH.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment to update.</param>
        /// <returns>The updated RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> UpdateAsync(RoleAssignment roleAssignmentToUpdate);

        /// <summary>
        /// Updates the specified RoleAssignment using PATCH.
        /// </summary>
        /// <param name="roleAssignmentToUpdate">The RoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RoleAssignment.</returns>
        System.Threading.Tasks.Task<RoleAssignment> UpdateAsync(RoleAssignment roleAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Expand(Expression<Func<RoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleAssignmentRequest Select(Expression<Func<RoleAssignment, object>> selectExpression);

    }
}