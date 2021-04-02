// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChatMembersCollectionRequestBuilder.
    /// </summary>
    public partial class ChatMembersCollectionRequestBuilder : BaseRequestBuilder, IChatMembersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChatMembersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChatMembersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChatMembersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChatMembersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChatMembersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConversationMemberRequestBuilder"/> for the specified ChatConversationMember.
        /// </summary>
        /// <param name="id">The ID for the ChatConversationMember.</param>
        /// <returns>The <see cref="IConversationMemberRequestBuilder"/>.</returns>
        public IConversationMemberRequestBuilder this[string id]
        {
            get
            {
                return new ConversationMemberRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}