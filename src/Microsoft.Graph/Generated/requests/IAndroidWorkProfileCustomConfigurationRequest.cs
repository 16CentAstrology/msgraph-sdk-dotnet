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
    /// The interface IAndroidWorkProfileCustomConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileCustomConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileCustomConfiguration using POST.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToCreate">The AndroidWorkProfileCustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileCustomConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileCustomConfiguration> CreateAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AndroidWorkProfileCustomConfiguration using POST and returns a <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToCreate">The AndroidWorkProfileCustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileCustomConfiguration>> CreateResponseAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidWorkProfileCustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidWorkProfileCustomConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidWorkProfileCustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileCustomConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileCustomConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidWorkProfileCustomConfiguration and returns a <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileCustomConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWorkProfileCustomConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToUpdate">The AndroidWorkProfileCustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileCustomConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileCustomConfiguration> UpdateAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWorkProfileCustomConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToUpdate">The AndroidWorkProfileCustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileCustomConfiguration>> UpdateResponseAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWorkProfileCustomConfiguration using PUT.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToUpdate">The AndroidWorkProfileCustomConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileCustomConfiguration> PutAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWorkProfileCustomConfiguration using PUT and returns a <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileCustomConfigurationToUpdate">The AndroidWorkProfileCustomConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidWorkProfileCustomConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileCustomConfiguration>> PutResponseAsync(AndroidWorkProfileCustomConfiguration androidWorkProfileCustomConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileCustomConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileCustomConfigurationRequest Expand(Expression<Func<AndroidWorkProfileCustomConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileCustomConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileCustomConfigurationRequest Select(Expression<Func<AndroidWorkProfileCustomConfiguration, object>> selectExpression);

    }
}
