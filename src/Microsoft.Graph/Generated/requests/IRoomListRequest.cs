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
    /// The interface IRoomListRequest.
    /// </summary>
    public partial interface IRoomListRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RoomList using POST.
        /// </summary>
        /// <param name="roomListToCreate">The RoomList to create.</param>
        /// <returns>The created RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> CreateAsync(RoomList roomListToCreate);        /// <summary>
        /// Creates the specified RoomList using POST.
        /// </summary>
        /// <param name="roomListToCreate">The RoomList to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> CreateAsync(RoomList roomListToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RoomList.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RoomList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RoomList.
        /// </summary>
        /// <returns>The RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> GetAsync();

        /// <summary>
        /// Gets the specified RoomList.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RoomList using PATCH.
        /// </summary>
        /// <param name="roomListToUpdate">The RoomList to update.</param>
        /// <returns>The updated RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> UpdateAsync(RoomList roomListToUpdate);

        /// <summary>
        /// Updates the specified RoomList using PATCH.
        /// </summary>
        /// <param name="roomListToUpdate">The RoomList to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RoomList.</returns>
        System.Threading.Tasks.Task<RoomList> UpdateAsync(RoomList roomListToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoomListRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoomListRequest Expand(Expression<Func<RoomList, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoomListRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoomListRequest Select(Expression<Func<RoomList, object>> selectExpression);

    }
}