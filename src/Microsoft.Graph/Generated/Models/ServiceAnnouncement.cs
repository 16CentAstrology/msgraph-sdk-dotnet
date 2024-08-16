// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ServiceAnnouncement : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of service health information for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.ServiceHealth>? HealthOverviews
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceHealth>?>("healthOverviews"); }
            set { BackingStore?.Set("healthOverviews", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.ServiceHealth> HealthOverviews
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceHealth>>("healthOverviews"); }
            set { BackingStore?.Set("healthOverviews", value); }
        }
#endif
        /// <summary>A collection of service issues for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.ServiceHealthIssue>? Issues
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceHealthIssue>?>("issues"); }
            set { BackingStore?.Set("issues", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.ServiceHealthIssue> Issues
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceHealthIssue>>("issues"); }
            set { BackingStore?.Set("issues", value); }
        }
#endif
        /// <summary>A collection of service messages for tenant. This property is a contained navigation property, it is nullable and readonly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.ServiceUpdateMessage>? Messages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceUpdateMessage>?>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.ServiceUpdateMessage> Messages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.ServiceUpdateMessage>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ServiceAnnouncement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.ServiceAnnouncement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ServiceAnnouncement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "healthOverviews", n => { HealthOverviews = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.ServiceHealth>(Microsoft.Graph.Models.ServiceHealth.CreateFromDiscriminatorValue)?.ToList(); } },
                { "issues", n => { Issues = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.ServiceHealthIssue>(Microsoft.Graph.Models.ServiceHealthIssue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.ServiceUpdateMessage>(Microsoft.Graph.Models.ServiceUpdateMessage.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.ServiceHealth>("healthOverviews", HealthOverviews);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.ServiceHealthIssue>("issues", Issues);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.ServiceUpdateMessage>("messages", Messages);
        }
    }
}
