// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class IdentityApiConnector : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The object which describes the authentication configuration details for calling the API. Basic and PKCS 12 client certificate are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ApiAuthenticationConfigurationBase? AuthenticationConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ApiAuthenticationConfigurationBase?>("authenticationConfiguration"); }
            set { BackingStore?.Set("authenticationConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ApiAuthenticationConfigurationBase AuthenticationConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ApiAuthenticationConfigurationBase>("authenticationConfiguration"); }
            set { BackingStore?.Set("authenticationConfiguration", value); }
        }
#endif
        /// <summary>The name of the API connector.</summary>
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
        /// <summary>The URL of the API endpoint to call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl
        {
            get { return BackingStore?.Get<string?>("targetUrl"); }
            set { BackingStore?.Set("targetUrl", value); }
        }
#nullable restore
#else
        public string TargetUrl
        {
            get { return BackingStore?.Get<string>("targetUrl"); }
            set { BackingStore?.Set("targetUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.IdentityApiConnector"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.IdentityApiConnector CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.IdentityApiConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationConfiguration", n => { AuthenticationConfiguration = n.GetObjectValue<Microsoft.Graph.Models.ApiAuthenticationConfigurationBase>(Microsoft.Graph.Models.ApiAuthenticationConfigurationBase.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "targetUrl", n => { TargetUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.ApiAuthenticationConfigurationBase>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("targetUrl", TargetUrl);
        }
    }
}
