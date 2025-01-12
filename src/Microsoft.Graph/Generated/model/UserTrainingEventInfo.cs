// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserTrainingEventInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserTrainingEventInfo>))]
    public partial class UserTrainingEventInfo
    {

        /// <summary>
        /// Gets or sets displayName.
        /// Display name of the training.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets latestTrainingStatus.
        /// Latest status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("latestTrainingStatus")]
        public TrainingStatus? LatestTrainingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets trainingAssignedProperties.
        /// Event details of the training when it was assigned to the user.
        /// </summary>
        [JsonPropertyName("trainingAssignedProperties")]
        public UserTrainingContentEventInfo TrainingAssignedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets trainingCompletedProperties.
        /// Event details of the training when it was completed by the user.
        /// </summary>
        [JsonPropertyName("trainingCompletedProperties")]
        public UserTrainingContentEventInfo TrainingCompletedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets trainingUpdatedProperties.
        /// Event details of the training when it was updated/in-progress by the user.
        /// </summary>
        [JsonPropertyName("trainingUpdatedProperties")]
        public UserTrainingContentEventInfo TrainingUpdatedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
