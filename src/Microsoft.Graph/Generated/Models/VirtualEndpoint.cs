// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class VirtualEndpoint : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of Cloud PC audit events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcAuditEvent>? AuditEvents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcAuditEvent>?>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcAuditEvent> AuditEvents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcAuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#endif
        /// <summary>A collection of cloud-managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPC>? CloudPCs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPC>?>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPC> CloudPCs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPC>>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#endif
        /// <summary>A collection of device image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcDeviceImage>? DeviceImages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcDeviceImage>?>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcDeviceImage> DeviceImages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcDeviceImage>>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#endif
        /// <summary>A collection of gallery image resources on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcGalleryImage>? GalleryImages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcGalleryImage>?>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcGalleryImage> GalleryImages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcGalleryImage>>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish Azure network connections for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcOnPremisesConnection>? OnPremisesConnections
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcOnPremisesConnection>?>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcOnPremisesConnection> OnPremisesConnections
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcOnPremisesConnection>>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#endif
        /// <summary>A collection of Cloud PC provisioning policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcProvisioningPolicy>? ProvisioningPolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcProvisioningPolicy>?>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcProvisioningPolicy> ProvisioningPolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcProvisioningPolicy>>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#endif
        /// <summary>A collection of Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcUserSetting>? UserSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcUserSetting>?>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcUserSetting> UserSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcUserSetting>>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.VirtualEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcAuditEvent>(Microsoft.Graph.Models.CloudPcAuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPC>(Microsoft.Graph.Models.CloudPC.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcDeviceImage>(Microsoft.Graph.Models.CloudPcDeviceImage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcGalleryImage>(Microsoft.Graph.Models.CloudPcGalleryImage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcOnPremisesConnection>(Microsoft.Graph.Models.CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                { "provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcProvisioningPolicy>(Microsoft.Graph.Models.CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcUserSetting>(Microsoft.Graph.Models.CloudPcUserSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPC>("cloudPCs", CloudPCs);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
