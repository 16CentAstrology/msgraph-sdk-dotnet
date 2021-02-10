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
    /// The interface IWindowsInformationProtectionNetworkLearningSummaryRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionNetworkLearningSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsInformationProtectionNetworkLearningSummary using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummaryToCreate">The WindowsInformationProtectionNetworkLearningSummary to create.</param>
        /// <returns>The created WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> CreateAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummaryToCreate);        /// <summary>
        /// Creates the specified WindowsInformationProtectionNetworkLearningSummary using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummaryToCreate">The WindowsInformationProtectionNetworkLearningSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> CreateAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionNetworkLearningSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionNetworkLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsInformationProtectionNetworkLearningSummary.
        /// </summary>
        /// <returns>The WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> GetAsync();

        /// <summary>
        /// Gets the specified WindowsInformationProtectionNetworkLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionNetworkLearningSummary using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummaryToUpdate">The WindowsInformationProtectionNetworkLearningSummary to update.</param>
        /// <returns>The updated WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> UpdateAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummaryToUpdate);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionNetworkLearningSummary using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummaryToUpdate">The WindowsInformationProtectionNetworkLearningSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> UpdateAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionNetworkLearningSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionNetworkLearningSummaryRequest Expand(Expression<Func<WindowsInformationProtectionNetworkLearningSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionNetworkLearningSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionNetworkLearningSummaryRequest Select(Expression<Func<WindowsInformationProtectionNetworkLearningSummary, object>> selectExpression);

    }
}