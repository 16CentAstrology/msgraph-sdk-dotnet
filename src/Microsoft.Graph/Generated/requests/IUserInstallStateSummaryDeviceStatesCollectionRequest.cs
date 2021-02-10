// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserInstallStateSummaryDeviceStatesCollectionRequest.
    /// </summary>
    public partial interface IUserInstallStateSummaryDeviceStatesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DeviceInstallState to the collection via POST.
        /// </summary>
        /// <param name="deviceInstallState">The DeviceInstallState to add.</param>
        /// <returns>The created DeviceInstallState.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> AddAsync(DeviceInstallState deviceInstallState);

        /// <summary>
        /// Adds the specified DeviceInstallState to the collection via POST.
        /// </summary>
        /// <param name="deviceInstallState">The DeviceInstallState to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceInstallState.</returns>
        System.Threading.Tasks.Task<DeviceInstallState> AddAsync(DeviceInstallState deviceInstallState, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserInstallStateSummaryDeviceStatesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserInstallStateSummaryDeviceStatesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Expand(Expression<Func<DeviceInstallState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Select(Expression<Func<DeviceInstallState, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryDeviceStatesCollectionRequest OrderBy(string value);
    }
}