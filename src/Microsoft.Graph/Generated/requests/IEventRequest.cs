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
    /// The interface IEventRequest.
    /// </summary>
    public partial interface IEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Event using POST.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Event.</returns>
        System.Threading.Tasks.Task<Event> CreateAsync(Event eventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Event using POST and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="eventToCreate">The Event to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> CreateResponseAsync(Event eventToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Event and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Event.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Event.</returns>
        System.Threading.Tasks.Task<Event> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Event and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Event using PATCH.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Event.</returns>
        System.Threading.Tasks.Task<Event> UpdateAsync(Event eventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Event using PATCH and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="eventToUpdate">The Event to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> UpdateResponseAsync(Event eventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Event using PUT.
        /// </summary>
        /// <param name="eventToUpdate">The Event object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Event> PutAsync(Event eventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Event using PUT and returns a <see cref="GraphResponse{Event}"/> object.
        /// </summary>
        /// <param name="eventToUpdate">The Event object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Event}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> PutResponseAsync(Event eventToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Expand(Expression<Func<Event, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEventRequest Select(Expression<Func<Event, object>> selectExpression);

    }
}
