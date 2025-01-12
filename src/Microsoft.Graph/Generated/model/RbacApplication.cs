// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Rbac Application.
    /// </summary>
    public partial class RbacApplication : Entity
    {
    
        /// <summary>
        /// Gets or sets role assignments.
        /// Resource to grant access to users or groups.
        /// </summary>
        [JsonPropertyName("roleAssignments")]
        public IRbacApplicationRoleAssignmentsCollectionPage RoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.
        /// </summary>
        [JsonPropertyName("roleDefinitions")]
        public IRbacApplicationRoleDefinitionsCollectionPage RoleDefinitions { get; set; }

        /// <summary>
        /// Gets or sets roleDefinitionsNextLink.
        /// </summary>
        [JsonPropertyName("roleDefinitions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleDefinitionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role assignment schedule instances.
        /// Instances for active role assignments.
        /// </summary>
        [JsonPropertyName("roleAssignmentScheduleInstances")]
        public IRbacApplicationRoleAssignmentScheduleInstancesCollectionPage RoleAssignmentScheduleInstances { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentScheduleInstancesNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignmentScheduleInstances@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentScheduleInstancesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role assignment schedule requests.
        /// Requests for active role assignments to principals through PIM.
        /// </summary>
        [JsonPropertyName("roleAssignmentScheduleRequests")]
        public IRbacApplicationRoleAssignmentScheduleRequestsCollectionPage RoleAssignmentScheduleRequests { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentScheduleRequestsNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignmentScheduleRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentScheduleRequestsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role assignment schedules.
        /// Schedules for active role assignment operations.
        /// </summary>
        [JsonPropertyName("roleAssignmentSchedules")]
        public IRbacApplicationRoleAssignmentSchedulesCollectionPage RoleAssignmentSchedules { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentSchedulesNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignmentSchedules@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentSchedulesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role eligibility schedule instances.
        /// Instances for role eligibility requests.
        /// </summary>
        [JsonPropertyName("roleEligibilityScheduleInstances")]
        public IRbacApplicationRoleEligibilityScheduleInstancesCollectionPage RoleEligibilityScheduleInstances { get; set; }

        /// <summary>
        /// Gets or sets roleEligibilityScheduleInstancesNextLink.
        /// </summary>
        [JsonPropertyName("roleEligibilityScheduleInstances@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleEligibilityScheduleInstancesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role eligibility schedule requests.
        /// Requests for role eligibilities for principals through PIM.
        /// </summary>
        [JsonPropertyName("roleEligibilityScheduleRequests")]
        public IRbacApplicationRoleEligibilityScheduleRequestsCollectionPage RoleEligibilityScheduleRequests { get; set; }

        /// <summary>
        /// Gets or sets roleEligibilityScheduleRequestsNextLink.
        /// </summary>
        [JsonPropertyName("roleEligibilityScheduleRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleEligibilityScheduleRequestsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role eligibility schedules.
        /// Schedules for role eligibility operations.
        /// </summary>
        [JsonPropertyName("roleEligibilitySchedules")]
        public IRbacApplicationRoleEligibilitySchedulesCollectionPage RoleEligibilitySchedules { get; set; }

        /// <summary>
        /// Gets or sets roleEligibilitySchedulesNextLink.
        /// </summary>
        [JsonPropertyName("roleEligibilitySchedules@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleEligibilitySchedulesNextLink { get; set; }
    
    }
}

