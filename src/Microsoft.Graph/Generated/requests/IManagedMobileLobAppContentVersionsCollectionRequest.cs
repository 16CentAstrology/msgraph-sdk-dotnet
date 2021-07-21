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
    /// The interface IManagedMobileLobAppContentVersionsCollectionRequest.
    /// </summary>
    public partial interface IManagedMobileLobAppContentVersionsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified MobileAppContent to the collection via POST.
        /// </summary>
        /// <param name="mobileAppContent">The MobileAppContent to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> AddAsync(MobileAppContent mobileAppContent, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified MobileAppContent to the collection via POST and returns a <see cref="GraphResponse{MobileAppContent}"/> object of the request.
        /// </summary>
        /// <param name="mobileAppContent">The MobileAppContent to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppContent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppContent>> AddResponseAsync(MobileAppContent mobileAppContent, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IManagedMobileLobAppContentVersionsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ManagedMobileLobAppContentVersionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedMobileLobAppContentVersionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedMobileLobAppContentVersionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Expand(Expression<Func<MobileAppContent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Select(Expression<Func<MobileAppContent, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppContentVersionsCollectionRequest OrderBy(string value);
    }
}
