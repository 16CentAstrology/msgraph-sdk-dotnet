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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type TeleconferenceDeviceQuality.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TeleconferenceDeviceQuality
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleconferenceDeviceQuality"/> class.
        /// </summary>
        public TeleconferenceDeviceQuality()
        {
            this.ODataType = "microsoft.graph.teleconferenceDeviceQuality";
        }

        /// <summary>
        /// Gets or sets callChainId.
        /// A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callChainId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? CallChainId { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceDeploymentEnvironment.
        /// A geo-region where the service is deployed, such as ProdNoam.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudServiceDeploymentEnvironment", Required = Newtonsoft.Json.Required.Default)]
        public string CloudServiceDeploymentEnvironment { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceDeploymentId.
        /// A unique deployment identifier assigned by Azure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudServiceDeploymentId", Required = Newtonsoft.Json.Required.Default)]
        public string CloudServiceDeploymentId { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceInstanceName.
        /// The Azure deployed cloud service instance name, such as FrontEnd_IN_3.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudServiceInstanceName", Required = Newtonsoft.Json.Required.Default)]
        public string CloudServiceInstanceName { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceName.
        /// The Azure deployed cloud service name, such as contoso.cloudapp.net.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudServiceName", Required = Newtonsoft.Json.Required.Default)]
        public string CloudServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets deviceDescription.
        /// Any additional description, such as VTC Bldg 30/21.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDescription", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceDescription { get; set; }
    
        /// <summary>
        /// Gets or sets deviceName.
        /// The user media agent name, such as Cisco SX80.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets mediaLegId.
        /// A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaLegId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? MediaLegId { get; set; }
    
        /// <summary>
        /// Gets or sets mediaQualityList.
        /// The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaQualityList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<TeleconferenceDeviceMediaQuality> MediaQualityList { get; set; }
    
        /// <summary>
        /// Gets or sets participantId.
        /// A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participantId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? ParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}