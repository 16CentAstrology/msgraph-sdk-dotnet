// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IDeviceCompliancePolicyScheduledActionsForRuleCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<DeviceCompliancePolicyScheduledActionsForRuleCollectionPage>))]
    public interface IDeviceCompliancePolicyScheduledActionsForRuleCollectionPage : ICollectionPage<DeviceComplianceScheduledActionForRule>
    {
        /// <summary>
        /// Gets the next page <see cref="IDeviceCompliancePolicyScheduledActionsForRuleCollectionRequest"/> instance.
        /// </summary>
        IDeviceCompliancePolicyScheduledActionsForRuleCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
