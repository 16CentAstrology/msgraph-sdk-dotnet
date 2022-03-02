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
    /// The type WorkbookTableRowOperationResultRequestBuilder.
    /// </summary>
    public partial class WorkbookTableRowOperationResultRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookTableRowOperationResultRequest>, IWorkbookTableRowOperationResultRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableRowOperationResultRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="key">A key parameter for the OData method call.</param>
        public WorkbookTableRowOperationResultRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string key)
            : base(requestUrl, client)
        {
            this.SetParameter("key", key, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableRowOperationResultRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableRowOperationResultRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}