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
    /// The interface ISecureScoreControlProfileRequest.
    /// </summary>
    public partial interface ISecureScoreControlProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecureScoreControlProfile.</returns>
        System.Threading.Tasks.Task<SecureScoreControlProfile> CreateAsync(SecureScoreControlProfile secureScoreControlProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SecureScoreControlProfile using POST and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToCreate">The SecureScoreControlProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> CreateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SecureScoreControlProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SecureScoreControlProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecureScoreControlProfile.</returns>
        System.Threading.Tasks.Task<SecureScoreControlProfile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SecureScoreControlProfile and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecureScoreControlProfile.</returns>
        System.Threading.Tasks.Task<SecureScoreControlProfile> UpdateAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PATCH and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecureScoreControlProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> UpdateResponseAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PUT.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SecureScoreControlProfile> PutAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecureScoreControlProfile using PUT and returns a <see cref="GraphResponse{SecureScoreControlProfile}"/> object.
        /// </summary>
        /// <param name="secureScoreControlProfileToUpdate">The SecureScoreControlProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SecureScoreControlProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecureScoreControlProfile>> PutResponseAsync(SecureScoreControlProfile secureScoreControlProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreControlProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreControlProfileRequest Expand(Expression<Func<SecureScoreControlProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreControlProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecureScoreControlProfileRequest Select(Expression<Func<SecureScoreControlProfile, object>> selectExpression);

    }
}
