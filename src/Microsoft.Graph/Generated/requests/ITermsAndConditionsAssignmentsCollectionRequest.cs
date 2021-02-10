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
    /// The interface ITermsAndConditionsAssignmentsCollectionRequest.
    /// </summary>
    public partial interface ITermsAndConditionsAssignmentsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified TermsAndConditionsAssignment to the collection via POST.
        /// </summary>
        /// <param name="termsAndConditionsAssignment">The TermsAndConditionsAssignment to add.</param>
        /// <returns>The created TermsAndConditionsAssignment.</returns>
        System.Threading.Tasks.Task<TermsAndConditionsAssignment> AddAsync(TermsAndConditionsAssignment termsAndConditionsAssignment);

        /// <summary>
        /// Adds the specified TermsAndConditionsAssignment to the collection via POST.
        /// </summary>
        /// <param name="termsAndConditionsAssignment">The TermsAndConditionsAssignment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsAndConditionsAssignment.</returns>
        System.Threading.Tasks.Task<TermsAndConditionsAssignment> AddAsync(TermsAndConditionsAssignment termsAndConditionsAssignment, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITermsAndConditionsAssignmentsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITermsAndConditionsAssignmentsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Expand(Expression<Func<TermsAndConditionsAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Select(Expression<Func<TermsAndConditionsAssignment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsAssignmentsCollectionRequest OrderBy(string value);
    }
}