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
    /// The interface IIosCompliancePolicyRequest.
    /// </summary>
    public partial interface IIosCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosCompliancePolicy using POST.
        /// </summary>
        /// <param name="iosCompliancePolicyToCreate">The IosCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCompliancePolicy.</returns>
        System.Threading.Tasks.Task<IosCompliancePolicy> CreateAsync(IosCompliancePolicy iosCompliancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosCompliancePolicy using POST and returns a <see cref="GraphResponse{IosCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="iosCompliancePolicyToCreate">The IosCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCompliancePolicy>> CreateResponseAsync(IosCompliancePolicy iosCompliancePolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCompliancePolicy.</returns>
        System.Threading.Tasks.Task<IosCompliancePolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosCompliancePolicy and returns a <see cref="GraphResponse{IosCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="iosCompliancePolicyToUpdate">The IosCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosCompliancePolicy.</returns>
        System.Threading.Tasks.Task<IosCompliancePolicy> UpdateAsync(IosCompliancePolicy iosCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosCompliancePolicy using PATCH and returns a <see cref="GraphResponse{IosCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="iosCompliancePolicyToUpdate">The IosCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosCompliancePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCompliancePolicy>> UpdateResponseAsync(IosCompliancePolicy iosCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosCompliancePolicy using PUT.
        /// </summary>
        /// <param name="iosCompliancePolicyToUpdate">The IosCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosCompliancePolicy> PutAsync(IosCompliancePolicy iosCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosCompliancePolicy using PUT and returns a <see cref="GraphResponse{IosCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="iosCompliancePolicyToUpdate">The IosCompliancePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosCompliancePolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosCompliancePolicy>> PutResponseAsync(IosCompliancePolicy iosCompliancePolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCompliancePolicyRequest Expand(Expression<Func<IosCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCompliancePolicyRequest Select(Expression<Func<IosCompliancePolicy, object>> selectExpression);

    }
}
