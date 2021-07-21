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
    /// The type DeviceOperatingSystemSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceOperatingSystemSummary>))]
    public partial class DeviceOperatingSystemSummary
    {

        /// <summary>
        /// Gets or sets androidCount.
        /// Number of android device count.
        /// </summary>
        [JsonPropertyName("androidCount")]
        public Int32? AndroidCount { get; set; }
    
        /// <summary>
        /// Gets or sets iosCount.
        /// Number of iOS device count.
        /// </summary>
        [JsonPropertyName("iosCount")]
        public Int32? IosCount { get; set; }
    
        /// <summary>
        /// Gets or sets macOSCount.
        /// Number of Mac OS X device count.
        /// </summary>
        [JsonPropertyName("macOSCount")]
        public Int32? MacOSCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknownCount.
        /// Number of unknown device count.
        /// </summary>
        [JsonPropertyName("unknownCount")]
        public Int32? UnknownCount { get; set; }
    
        /// <summary>
        /// Gets or sets windowsCount.
        /// Number of Windows device count.
        /// </summary>
        [JsonPropertyName("windowsCount")]
        public Int32? WindowsCount { get; set; }
    
        /// <summary>
        /// Gets or sets windowsMobileCount.
        /// Number of Windows mobile device count.
        /// </summary>
        [JsonPropertyName("windowsMobileCount")]
        public Int32? WindowsMobileCount { get; set; }
    
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
