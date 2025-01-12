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
    /// The interface IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest.
    /// </summary>
    public partial interface IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToCreate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentWindowsHelloForBusinessConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentWindowsHelloForBusinessConfiguration> CreateAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using POST and returns a <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToCreate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentWindowsHelloForBusinessConfiguration>> CreateResponseAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentWindowsHelloForBusinessConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentWindowsHelloForBusinessConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration and returns a <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentWindowsHelloForBusinessConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceEnrollmentWindowsHelloForBusinessConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentWindowsHelloForBusinessConfiguration> UpdateAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentWindowsHelloForBusinessConfiguration>> UpdateResponseAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using PUT.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentWindowsHelloForBusinessConfiguration> PutAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceEnrollmentWindowsHelloForBusinessConfiguration using PUT and returns a <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate">The DeviceEnrollmentWindowsHelloForBusinessConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceEnrollmentWindowsHelloForBusinessConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceEnrollmentWindowsHelloForBusinessConfiguration>> PutResponseAsync(DeviceEnrollmentWindowsHelloForBusinessConfiguration deviceEnrollmentWindowsHelloForBusinessConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest Expand(Expression<Func<DeviceEnrollmentWindowsHelloForBusinessConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentWindowsHelloForBusinessConfigurationRequest Select(Expression<Func<DeviceEnrollmentWindowsHelloForBusinessConfiguration, object>> selectExpression);

    }
}
