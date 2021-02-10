// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ChatMessageRequestBuilder.
    /// </summary>
    public partial class ChatMessageRequestBuilder : EntityRequestBuilder, IChatMessageRequestBuilder
    {

        /// <summary>
        /// Constructs a new ChatMessageRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChatMessageRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IChatMessageRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IChatMessageRequest Request(IEnumerable<Option> options)
        {
            return new ChatMessageRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for HostedContents.
        /// </summary>
        /// <returns>The <see cref="IChatMessageHostedContentsCollectionRequestBuilder"/>.</returns>
        public IChatMessageHostedContentsCollectionRequestBuilder HostedContents
        {
            get
            {
                return new ChatMessageHostedContentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("hostedContents"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Replies.
        /// </summary>
        /// <returns>The <see cref="IChatMessageRepliesCollectionRequestBuilder"/>.</returns>
        public IChatMessageRepliesCollectionRequestBuilder Replies
        {
            get
            {
                return new ChatMessageRepliesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("replies"), this.Client);
            }
        }
    
    }
}