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
    /// The interface IReportRootRequest.
    /// </summary>
    public partial interface IReportRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ReportRoot using POST.
        /// </summary>
        /// <param name="reportRootToCreate">The ReportRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ReportRoot.</returns>
        System.Threading.Tasks.Task<ReportRoot> CreateAsync(ReportRoot reportRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ReportRoot using POST and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToCreate">The ReportRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRoot>> CreateResponseAsync(ReportRoot reportRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ReportRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ReportRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ReportRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ReportRoot.</returns>
        System.Threading.Tasks.Task<ReportRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ReportRoot and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ReportRoot using PATCH.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ReportRoot.</returns>
        System.Threading.Tasks.Task<ReportRoot> UpdateAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ReportRoot using PATCH and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRoot>> UpdateResponseAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ReportRoot using PUT.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ReportRoot> PutAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ReportRoot using PUT and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ReportRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRoot>> PutResponseAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootRequest Expand(Expression<Func<ReportRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootRequest Select(Expression<Func<ReportRoot, object>> selectExpression);

    }
}
