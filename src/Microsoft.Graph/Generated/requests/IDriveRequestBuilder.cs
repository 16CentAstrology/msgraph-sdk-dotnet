// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDriveRequestBuilder.
    /// </summary>
    public partial interface IDriveRequestBuilder : IBaseItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDriveRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDriveRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Bundles.
        /// </summary>
        /// <returns>The <see cref="IDriveBundlesCollectionRequestBuilder"/>.</returns>
        IDriveBundlesCollectionRequestBuilder Bundles { get; }

        /// <summary>
        /// Gets the request builder for Following.
        /// </summary>
        /// <returns>The <see cref="IDriveFollowingCollectionRequestBuilder"/>.</returns>
        IDriveFollowingCollectionRequestBuilder Following { get; }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IDriveItemsCollectionRequestBuilder"/>.</returns>
        IDriveItemsCollectionRequestBuilder Items { get; }

        /// <summary>
        /// Gets the request builder for List.
        /// </summary>
        /// <returns>The <see cref="IListRequestBuilder"/>.</returns>
        IListRequestBuilder List { get; }

        /// <summary>
        /// Gets the request builder for Root.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        IDriveItemRequestBuilder Root { get; }

        /// <summary>
        /// Gets the request builder for Special.
        /// </summary>
        /// <returns>The <see cref="IDriveSpecialCollectionRequestBuilder"/>.</returns>
        IDriveSpecialCollectionRequestBuilder Special { get; }
    
        /// <summary>
        /// Gets the request builder for DriveSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveSearchRequestBuilder"/>.</returns>
        IDriveSearchRequestBuilder Search(
            string q = null);

        /// <summary>
        /// Gets the request builder for DriveRecent.
        /// </summary>
        /// <returns>The <see cref="IDriveRecentRequestBuilder"/>.</returns>
        IDriveRecentRequestBuilder Recent();

        /// <summary>
        /// Gets the request builder for DriveSharedWithMe.
        /// </summary>
        /// <returns>The <see cref="IDriveSharedWithMeRequestBuilder"/>.</returns>
        IDriveSharedWithMeRequestBuilder SharedWithMe();
    
    }
}
