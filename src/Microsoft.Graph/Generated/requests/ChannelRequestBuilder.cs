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
    /// The type ChannelRequestBuilder.
    /// </summary>
    public partial class ChannelRequestBuilder : EntityRequestBuilder, IChannelRequestBuilder
    {

        /// <summary>
        /// Constructs a new ChannelRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChannelRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IChannelRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IChannelRequest Request(IEnumerable<Option> options)
        {
            return new ChannelRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for FilesFolder.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        public IDriveItemRequestBuilder FilesFolder
        {
            get
            {
                return new DriveItemRequestBuilder(this.AppendSegmentToRequestUrl("filesFolder"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IChannelMembersCollectionRequestBuilder"/>.</returns>
        public IChannelMembersCollectionRequestBuilder Members
        {
            get
            {
                return new ChannelMembersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("members"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IChannelMessagesCollectionRequestBuilder"/>.</returns>
        public IChannelMessagesCollectionRequestBuilder Messages
        {
            get
            {
                return new ChannelMessagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("messages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SharedWithTeams.
        /// </summary>
        /// <returns>The <see cref="IChannelSharedWithTeamsCollectionRequestBuilder"/>.</returns>
        public IChannelSharedWithTeamsCollectionRequestBuilder SharedWithTeams
        {
            get
            {
                return new ChannelSharedWithTeamsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sharedWithTeams"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tabs.
        /// </summary>
        /// <returns>The <see cref="IChannelTabsCollectionRequestBuilder"/>.</returns>
        public IChannelTabsCollectionRequestBuilder Tabs
        {
            get
            {
                return new ChannelTabsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tabs"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ChannelCompleteMigration.
        /// </summary>
        /// <returns>The <see cref="IChannelCompleteMigrationRequestBuilder"/>.</returns>
        public IChannelCompleteMigrationRequestBuilder CompleteMigration()
        {
            return new ChannelCompleteMigrationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.completeMigration"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ChannelProvisionEmail.
        /// </summary>
        /// <returns>The <see cref="IChannelProvisionEmailRequestBuilder"/>.</returns>
        public IChannelProvisionEmailRequestBuilder ProvisionEmail()
        {
            return new ChannelProvisionEmailRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.provisionEmail"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ChannelRemoveEmail.
        /// </summary>
        /// <returns>The <see cref="IChannelRemoveEmailRequestBuilder"/>.</returns>
        public IChannelRemoveEmailRequestBuilder RemoveEmail()
        {
            return new ChannelRemoveEmailRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeEmail"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ChannelDoesUserHaveAccess.
        /// </summary>
        /// <returns>The <see cref="IChannelDoesUserHaveAccessRequestBuilder"/>.</returns>
        public IChannelDoesUserHaveAccessRequestBuilder DoesUserHaveAccess(
            string userId = null,
            string tenantId = null,
            string userPrincipalName = null)
        {
            return new ChannelDoesUserHaveAccessRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.doesUserHaveAccess"),
                this.Client,
                userId,
                tenantId,
                userPrincipalName);
        }
    
    }
}
