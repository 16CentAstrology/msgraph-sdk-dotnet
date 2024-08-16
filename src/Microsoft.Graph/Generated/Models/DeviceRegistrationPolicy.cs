// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class DeviceRegistrationPolicy : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The azureADJoin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AzureADJoinPolicy? AzureADJoin
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AzureADJoinPolicy?>("azureADJoin"); }
            set { BackingStore?.Set("azureADJoin", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AzureADJoinPolicy AzureADJoin
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AzureADJoinPolicy>("azureADJoin"); }
            set { BackingStore?.Set("azureADJoin", value); }
        }
#endif
        /// <summary>The azureADRegistration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AzureADRegistrationPolicy? AzureADRegistration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AzureADRegistrationPolicy?>("azureADRegistration"); }
            set { BackingStore?.Set("azureADRegistration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AzureADRegistrationPolicy AzureADRegistration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AzureADRegistrationPolicy>("azureADRegistration"); }
            set { BackingStore?.Set("azureADRegistration", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The localAdminPassword property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.LocalAdminPasswordSettings? LocalAdminPassword
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LocalAdminPasswordSettings?>("localAdminPassword"); }
            set { BackingStore?.Set("localAdminPassword", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.LocalAdminPasswordSettings LocalAdminPassword
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LocalAdminPasswordSettings>("localAdminPassword"); }
            set { BackingStore?.Set("localAdminPassword", value); }
        }
#endif
        /// <summary>The multiFactorAuthConfiguration property</summary>
        public Microsoft.Graph.Models.MultiFactorAuthConfiguration? MultiFactorAuthConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MultiFactorAuthConfiguration?>("multiFactorAuthConfiguration"); }
            set { BackingStore?.Set("multiFactorAuthConfiguration", value); }
        }
        /// <summary>The userDeviceQuota property</summary>
        public int? UserDeviceQuota
        {
            get { return BackingStore?.Get<int?>("userDeviceQuota"); }
            set { BackingStore?.Set("userDeviceQuota", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.DeviceRegistrationPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.DeviceRegistrationPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.DeviceRegistrationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "azureADJoin", n => { AzureADJoin = n.GetObjectValue<Microsoft.Graph.Models.AzureADJoinPolicy>(Microsoft.Graph.Models.AzureADJoinPolicy.CreateFromDiscriminatorValue); } },
                { "azureADRegistration", n => { AzureADRegistration = n.GetObjectValue<Microsoft.Graph.Models.AzureADRegistrationPolicy>(Microsoft.Graph.Models.AzureADRegistrationPolicy.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "localAdminPassword", n => { LocalAdminPassword = n.GetObjectValue<Microsoft.Graph.Models.LocalAdminPasswordSettings>(Microsoft.Graph.Models.LocalAdminPasswordSettings.CreateFromDiscriminatorValue); } },
                { "multiFactorAuthConfiguration", n => { MultiFactorAuthConfiguration = n.GetEnumValue<Microsoft.Graph.Models.MultiFactorAuthConfiguration>(); } },
                { "userDeviceQuota", n => { UserDeviceQuota = n.GetIntValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.AzureADJoinPolicy>("azureADJoin", AzureADJoin);
            writer.WriteObjectValue<Microsoft.Graph.Models.AzureADRegistrationPolicy>("azureADRegistration", AzureADRegistration);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Models.LocalAdminPasswordSettings>("localAdminPassword", LocalAdminPassword);
            writer.WriteEnumValue<Microsoft.Graph.Models.MultiFactorAuthConfiguration>("multiFactorAuthConfiguration", MultiFactorAuthConfiguration);
            writer.WriteIntValue("userDeviceQuota", UserDeviceQuota);
        }
    }
}
