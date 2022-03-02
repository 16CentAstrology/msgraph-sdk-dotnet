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
    /// The type SubjectRightsRequestRequestBuilder.
    /// </summary>
    public partial class SubjectRightsRequestRequestBuilder : EntityRequestBuilder, ISubjectRightsRequestRequestBuilder
    {

        /// <summary>
        /// Constructs a new SubjectRightsRequestRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SubjectRightsRequestRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISubjectRightsRequestRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISubjectRightsRequestRequest Request(IEnumerable<Option> options)
        {
            return new SubjectRightsRequestRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Notes.
        /// </summary>
        /// <returns>The <see cref="ISubjectRightsRequestNotesCollectionRequestBuilder"/>.</returns>
        public ISubjectRightsRequestNotesCollectionRequestBuilder Notes
        {
            get
            {
                return new SubjectRightsRequestNotesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("notes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Team.
        /// </summary>
        /// <returns>The <see cref="ITeamWithReferenceRequestBuilder"/>.</returns>
        public ITeamWithReferenceRequestBuilder Team
        {
            get
            {
                return new TeamWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("team"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for SubjectRightsRequestGetFinalAttachment.
        /// </summary>
        /// <returns>The <see cref="ISubjectRightsRequestGetFinalAttachmentRequestBuilder"/>.</returns>
        public ISubjectRightsRequestGetFinalAttachmentRequestBuilder GetFinalAttachment()
        {
            return new SubjectRightsRequestGetFinalAttachmentRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getFinalAttachment"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for SubjectRightsRequestGetFinalReport.
        /// </summary>
        /// <returns>The <see cref="ISubjectRightsRequestGetFinalReportRequestBuilder"/>.</returns>
        public ISubjectRightsRequestGetFinalReportRequestBuilder GetFinalReport()
        {
            return new SubjectRightsRequestGetFinalReportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getFinalReport"),
                this.Client);
        }
    
    }
}