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
    /// The interface INamedLocationRequest.
    /// </summary>
    public partial interface INamedLocationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified NamedLocation using POST.
        /// </summary>
        /// <param name="namedLocationToCreate">The NamedLocation to create.</param>
        /// <returns>The created NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> CreateAsync(NamedLocation namedLocationToCreate);        /// <summary>
        /// Creates the specified NamedLocation using POST.
        /// </summary>
        /// <param name="namedLocationToCreate">The NamedLocation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> CreateAsync(NamedLocation namedLocationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified NamedLocation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified NamedLocation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified NamedLocation.
        /// </summary>
        /// <returns>The NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> GetAsync();

        /// <summary>
        /// Gets the specified NamedLocation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified NamedLocation using PATCH.
        /// </summary>
        /// <param name="namedLocationToUpdate">The NamedLocation to update.</param>
        /// <returns>The updated NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> UpdateAsync(NamedLocation namedLocationToUpdate);

        /// <summary>
        /// Updates the specified NamedLocation using PATCH.
        /// </summary>
        /// <param name="namedLocationToUpdate">The NamedLocation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NamedLocation.</returns>
        System.Threading.Tasks.Task<NamedLocation> UpdateAsync(NamedLocation namedLocationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INamedLocationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INamedLocationRequest Expand(Expression<Func<NamedLocation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INamedLocationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INamedLocationRequest Select(Expression<Func<NamedLocation, object>> selectExpression);

    }
}