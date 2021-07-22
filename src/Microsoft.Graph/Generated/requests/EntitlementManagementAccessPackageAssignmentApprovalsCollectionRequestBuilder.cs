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
    /// The type EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder.
    /// </summary>
    public partial class EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder : BaseRequestBuilder, IEntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEntitlementManagementAccessPackageAssignmentApprovalsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEntitlementManagementAccessPackageAssignmentApprovalsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EntitlementManagementAccessPackageAssignmentApprovalsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IApprovalRequestBuilder"/> for the specified EntitlementManagementApproval.
        /// </summary>
        /// <param name="id">The ID for the EntitlementManagementApproval.</param>
        /// <returns>The <see cref="IApprovalRequestBuilder"/>.</returns>
        public IApprovalRequestBuilder this[string id]
        {
            get
            {
                return new ApprovalRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ApprovalFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IApprovalFilterByCurrentUserRequestBuilder"/>.</returns>
        public IApprovalFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            ApprovalFilterByCurrentUserOptions on)
        {
            return new ApprovalFilterByCurrentUserRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.filterByCurrentUser"),
                this.Client,
                on);
        }
    }
}