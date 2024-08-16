// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// A class containing the properties used for Group Assignment of an iOS LOB App Provisioning and Configuration.
    /// </summary>
    public class IosLobAppProvisioningConfigurationAssignment : Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The target group assignment defined by the admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget? Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.IosLobAppProvisioningConfigurationAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.IosLobAppProvisioningConfigurationAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.IosLobAppProvisioningConfigurationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "target", n => { Target = n.GetObjectValue<Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>(Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
