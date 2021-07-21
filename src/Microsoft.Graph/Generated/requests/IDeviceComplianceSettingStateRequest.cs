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
    /// The interface IDeviceComplianceSettingStateRequest.
    /// </summary>
    public partial interface IDeviceComplianceSettingStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceSettingState using POST.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToCreate">The DeviceComplianceSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> CreateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceComplianceSettingState using POST and returns a <see cref="GraphResponse{DeviceComplianceSettingState}"/> object.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToCreate">The DeviceComplianceSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceSettingState>> CreateResponseAsync(DeviceComplianceSettingState deviceComplianceSettingStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceComplianceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceComplianceSettingState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceComplianceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceComplianceSettingState and returns a <see cref="GraphResponse{DeviceComplianceSettingState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceSettingState>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PATCH.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> UpdateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PATCH and returns a <see cref="GraphResponse{DeviceComplianceSettingState}"/> object.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceSettingState>> UpdateResponseAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PUT.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> PutAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PUT and returns a <see cref="GraphResponse{DeviceComplianceSettingState}"/> object.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceComplianceSettingState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceSettingState>> PutResponseAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Expand(Expression<Func<DeviceComplianceSettingState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Select(Expression<Func<DeviceComplianceSettingState, object>> selectExpression);

    }
}
