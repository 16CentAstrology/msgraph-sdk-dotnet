// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsSumIfRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsSumIfRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsSumIfRequest>, IWorkbookFunctionsSumIfRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsSumIfRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="range">A range parameter for the OData method call.</param>
        /// <param name="criteria">A criteria parameter for the OData method call.</param>
        /// <param name="sumRange">A sumRange parameter for the OData method call.</param>
        public WorkbookFunctionsSumIfRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument range,
            System.Text.Json.JsonDocument criteria,
            System.Text.Json.JsonDocument sumRange)
            : base(requestUrl, client)
        {
            this.SetParameter("range", range, true);
            this.SetParameter("criteria", criteria, true);
            this.SetParameter("sumRange", sumRange, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsSumIfRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsSumIfRequest(functionUrl, this.Client, options);

            if (this.HasParameter("range"))
            {
                request.RequestBody.Range = this.GetParameter<System.Text.Json.JsonDocument>("range");
            }

            if (this.HasParameter("criteria"))
            {
                request.RequestBody.Criteria = this.GetParameter<System.Text.Json.JsonDocument>("criteria");
            }

            if (this.HasParameter("sumRange"))
            {
                request.RequestBody.SumRange = this.GetParameter<System.Text.Json.JsonDocument>("sumRange");
            }

            return request;
        }
    }
}
