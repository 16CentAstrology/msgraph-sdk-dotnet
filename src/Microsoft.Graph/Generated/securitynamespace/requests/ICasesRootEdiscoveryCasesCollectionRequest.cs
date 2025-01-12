// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICasesRootEdiscoveryCasesCollectionRequest.
    /// </summary>
    public partial interface ICasesRootEdiscoveryCasesCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified EdiscoveryCase to the collection via POST.
        /// </summary>
        /// <param name="ediscoveryCase">The EdiscoveryCase to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryCase.</returns>
        System.Threading.Tasks.Task<EdiscoveryCase> AddAsync(EdiscoveryCase ediscoveryCase, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified EdiscoveryCase to the collection via POST and returns a <see cref="GraphResponse{EdiscoveryCase}"/> object of the request.
        /// </summary>
        /// <param name="ediscoveryCase">The EdiscoveryCase to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryCase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EdiscoveryCase>> AddResponseAsync(EdiscoveryCase ediscoveryCase, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICasesRootEdiscoveryCasesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CasesRootEdiscoveryCasesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CasesRootEdiscoveryCasesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CasesRootEdiscoveryCasesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Expand(Expression<Func<EdiscoveryCase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Select(Expression<Func<EdiscoveryCase, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICasesRootEdiscoveryCasesCollectionRequest OrderBy(string value);
    }
}
