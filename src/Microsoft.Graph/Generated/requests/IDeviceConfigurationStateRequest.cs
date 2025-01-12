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
    /// The interface IDeviceConfigurationStateRequest.
    /// </summary>
    public partial interface IDeviceConfigurationStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationState using POST.
        /// </summary>
        /// <param name="deviceConfigurationStateToCreate">The DeviceConfigurationState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationState.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationState> CreateAsync(DeviceConfigurationState deviceConfigurationStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceConfigurationState using POST and returns a <see cref="GraphResponse{DeviceConfigurationState}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationStateToCreate">The DeviceConfigurationState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationState>> CreateResponseAsync(DeviceConfigurationState deviceConfigurationStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationState.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationState> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationState and returns a <see cref="GraphResponse{DeviceConfigurationState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationState>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationState using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationStateToUpdate">The DeviceConfigurationState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationState.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationState> UpdateAsync(DeviceConfigurationState deviceConfigurationStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationState using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationState}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationStateToUpdate">The DeviceConfigurationState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationState>> UpdateResponseAsync(DeviceConfigurationState deviceConfigurationStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationState using PUT.
        /// </summary>
        /// <param name="deviceConfigurationStateToUpdate">The DeviceConfigurationState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationState> PutAsync(DeviceConfigurationState deviceConfigurationStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationState using PUT and returns a <see cref="GraphResponse{DeviceConfigurationState}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationStateToUpdate">The DeviceConfigurationState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceConfigurationState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationState>> PutResponseAsync(DeviceConfigurationState deviceConfigurationStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationStateRequest Expand(Expression<Func<DeviceConfigurationState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationStateRequest Select(Expression<Func<DeviceConfigurationState, object>> selectExpression);

    }
}
