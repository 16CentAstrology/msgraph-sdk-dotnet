// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IContentTypeColumnPositionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IContentTypeColumnPositionsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IContentTypeColumnPositionsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IContentTypeColumnPositionsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IColumnDefinitionWithReferenceRequestBuilder"/> for the specified ColumnDefinition.
        /// </summary>
        /// <param name="id">The ID for the ColumnDefinition.</param>
        /// <returns>The <see cref="IColumnDefinitionWithReferenceRequestBuilder"/>.</returns>
        IColumnDefinitionWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IContentTypeColumnPositionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnPositionsCollectionReferencesRequestBuilder"/>.</returns>
        IContentTypeColumnPositionsCollectionReferencesRequestBuilder References { get; }

    }
}
