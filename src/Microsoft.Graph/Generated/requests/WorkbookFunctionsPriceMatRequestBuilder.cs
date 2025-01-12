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
    /// The type WorkbookFunctionsPriceMatRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsPriceMatRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsPriceMatRequest>, IWorkbookFunctionsPriceMatRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsPriceMatRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="settlement">A settlement parameter for the OData method call.</param>
        /// <param name="maturity">A maturity parameter for the OData method call.</param>
        /// <param name="issue">A issue parameter for the OData method call.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="yld">A yld parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        public WorkbookFunctionsPriceMatRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument settlement,
            System.Text.Json.JsonDocument maturity,
            System.Text.Json.JsonDocument issue,
            System.Text.Json.JsonDocument rate,
            System.Text.Json.JsonDocument yld,
            System.Text.Json.JsonDocument basis)
            : base(requestUrl, client)
        {
            this.SetParameter("settlement", settlement, true);
            this.SetParameter("maturity", maturity, true);
            this.SetParameter("issue", issue, true);
            this.SetParameter("rate", rate, true);
            this.SetParameter("yld", yld, true);
            this.SetParameter("basis", basis, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsPriceMatRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsPriceMatRequest(functionUrl, this.Client, options);

            if (this.HasParameter("settlement"))
            {
                request.RequestBody.Settlement = this.GetParameter<System.Text.Json.JsonDocument>("settlement");
            }

            if (this.HasParameter("maturity"))
            {
                request.RequestBody.Maturity = this.GetParameter<System.Text.Json.JsonDocument>("maturity");
            }

            if (this.HasParameter("issue"))
            {
                request.RequestBody.Issue = this.GetParameter<System.Text.Json.JsonDocument>("issue");
            }

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<System.Text.Json.JsonDocument>("rate");
            }

            if (this.HasParameter("yld"))
            {
                request.RequestBody.Yld = this.GetParameter<System.Text.Json.JsonDocument>("yld");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<System.Text.Json.JsonDocument>("basis");
            }

            return request;
        }
    }
}
