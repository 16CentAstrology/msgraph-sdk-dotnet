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
    /// The interface IOpenShiftRequest.
    /// </summary>
    public partial interface IOpenShiftRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OpenShift using POST.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OpenShift.</returns>
        System.Threading.Tasks.Task<OpenShift> CreateAsync(OpenShift openShiftToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified OpenShift using POST and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenShift>> CreateResponseAsync(OpenShift openShiftToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OpenShift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OpenShift and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OpenShift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OpenShift.</returns>
        System.Threading.Tasks.Task<OpenShift> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OpenShift and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenShift>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenShift using PATCH.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OpenShift.</returns>
        System.Threading.Tasks.Task<OpenShift> UpdateAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenShift using PATCH and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenShift>> UpdateResponseAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenShift using PUT.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OpenShift> PutAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenShift using PUT and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OpenShift}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenShift>> PutResponseAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOpenShiftRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOpenShiftRequest Expand(Expression<Func<OpenShift, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOpenShiftRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOpenShiftRequest Select(Expression<Func<OpenShift, object>> selectExpression);

    }
}
