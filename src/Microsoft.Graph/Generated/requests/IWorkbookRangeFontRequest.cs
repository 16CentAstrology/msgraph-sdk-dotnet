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
    /// The interface IWorkbookRangeFontRequest.
    /// </summary>
    public partial interface IWorkbookRangeFontRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeFont using POST.
        /// </summary>
        /// <param name="workbookRangeFontToCreate">The WorkbookRangeFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFont.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFont> CreateAsync(WorkbookRangeFont workbookRangeFontToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookRangeFont using POST and returns a <see cref="GraphResponse{WorkbookRangeFont}"/> object.
        /// </summary>
        /// <param name="workbookRangeFontToCreate">The WorkbookRangeFont to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFont}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFont>> CreateResponseAsync(WorkbookRangeFont workbookRangeFontToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookRangeFont and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeFont.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFont.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFont> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookRangeFont and returns a <see cref="GraphResponse{WorkbookRangeFont}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFont}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFont>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PATCH.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFont.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFont> UpdateAsync(WorkbookRangeFont workbookRangeFontToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFont}"/> object.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFont}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFont>> UpdateResponseAsync(WorkbookRangeFont workbookRangeFontToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PUT.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFont> PutAsync(WorkbookRangeFont workbookRangeFontToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookRangeFont using PUT and returns a <see cref="GraphResponse{WorkbookRangeFont}"/> object.
        /// </summary>
        /// <param name="workbookRangeFontToUpdate">The WorkbookRangeFont object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookRangeFont}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFont>> PutResponseAsync(WorkbookRangeFont workbookRangeFontToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFontRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFontRequest Expand(Expression<Func<WorkbookRangeFont, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFontRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFontRequest Select(Expression<Func<WorkbookRangeFont, object>> selectExpression);

    }
}
