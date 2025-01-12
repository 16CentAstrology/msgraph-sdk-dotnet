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
    /// The type EducationUserAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class EducationUserAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IEducationUserAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EducationUserAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationUserAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationUserAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationUserAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EducationUserAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationAssignmentRequestBuilder"/> for the specified EducationUserEducationAssignment.
        /// </summary>
        /// <param name="id">The ID for the EducationUserEducationAssignment.</param>
        /// <returns>The <see cref="IEducationAssignmentRequestBuilder"/>.</returns>
        public IEducationAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new EducationAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EducationAssignmentDelta.
        /// </summary>
        /// <returns>The <see cref="IEducationAssignmentDeltaRequestBuilder"/>.</returns>
        public IEducationAssignmentDeltaRequestBuilder Delta()
        {
            return new EducationAssignmentDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
