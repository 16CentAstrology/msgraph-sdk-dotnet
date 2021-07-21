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
    /// The interface ITermsAndConditionsRequest.
    /// </summary>
    public partial interface ITermsAndConditionsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TermsAndConditions using POST.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TermsAndConditions using POST and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> CreateResponseAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TermsAndConditions and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TermsAndConditions and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> UpdateResponseAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TermsAndConditions using PUT.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> PutAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TermsAndConditions using PUT and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TermsAndConditions}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> PutResponseAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsRequest Expand(Expression<Func<TermsAndConditions, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsRequest Select(Expression<Func<TermsAndConditions, object>> selectExpression);

    }
}
