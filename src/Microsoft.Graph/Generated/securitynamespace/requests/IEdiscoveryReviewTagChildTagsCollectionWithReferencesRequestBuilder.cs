// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IEdiscoveryReviewTagWithReferenceRequestBuilder"/> for the specified EdiscoveryReviewTag.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryReviewTag.</param>
        /// <returns>The <see cref="IEdiscoveryReviewTagWithReferenceRequestBuilder"/>.</returns>
        IEdiscoveryReviewTagWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IEdiscoveryReviewTagChildTagsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewTagChildTagsCollectionReferencesRequestBuilder"/>.</returns>
        IEdiscoveryReviewTagChildTagsCollectionReferencesRequestBuilder References { get; }

    }
}
