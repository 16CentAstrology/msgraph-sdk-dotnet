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
    /// The interface IWindowsMicrosoftEdgeAppRequest.
    /// </summary>
    public partial interface IWindowsMicrosoftEdgeAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsMicrosoftEdgeApp using POST.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToCreate">The WindowsMicrosoftEdgeApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsMicrosoftEdgeApp.</returns>
        System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> CreateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsMicrosoftEdgeApp using POST and returns a <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToCreate">The WindowsMicrosoftEdgeApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsMicrosoftEdgeApp>> CreateResponseAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsMicrosoftEdgeApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsMicrosoftEdgeApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsMicrosoftEdgeApp.</returns>
        System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsMicrosoftEdgeApp and returns a <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsMicrosoftEdgeApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PATCH.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsMicrosoftEdgeApp.</returns>
        System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> UpdateAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PATCH and returns a <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsMicrosoftEdgeApp>> UpdateResponseAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PUT.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsMicrosoftEdgeApp> PutAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsMicrosoftEdgeApp using PUT and returns a <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> object.
        /// </summary>
        /// <param name="windowsMicrosoftEdgeAppToUpdate">The WindowsMicrosoftEdgeApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsMicrosoftEdgeApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsMicrosoftEdgeApp>> PutResponseAsync(WindowsMicrosoftEdgeApp windowsMicrosoftEdgeAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMicrosoftEdgeAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMicrosoftEdgeAppRequest Expand(Expression<Func<WindowsMicrosoftEdgeApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMicrosoftEdgeAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMicrosoftEdgeAppRequest Select(Expression<Func<WindowsMicrosoftEdgeApp, object>> selectExpression);

    }
}
