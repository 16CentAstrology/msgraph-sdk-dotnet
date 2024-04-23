// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    #pragma warning disable CS1591
    public class DnsEvidence : AlertEvidence, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The dnsServerIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? DnsServerIp {
            get { return BackingStore?.Get<IpEvidence?>("dnsServerIp"); }
            set { BackingStore?.Set("dnsServerIp", value); }
        }
#nullable restore
#else
        public IpEvidence DnsServerIp {
            get { return BackingStore?.Get<IpEvidence>("dnsServerIp"); }
            set { BackingStore?.Set("dnsServerIp", value); }
        }
#endif
        /// <summary>The domainName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainName {
            get { return BackingStore?.Get<string?>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#nullable restore
#else
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#endif
        /// <summary>The hostIpAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? HostIpAddress {
            get { return BackingStore?.Get<IpEvidence?>("hostIpAddress"); }
            set { BackingStore?.Set("hostIpAddress", value); }
        }
#nullable restore
#else
        public IpEvidence HostIpAddress {
            get { return BackingStore?.Get<IpEvidence>("hostIpAddress"); }
            set { BackingStore?.Set("hostIpAddress", value); }
        }
#endif
        /// <summary>The ipAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpEvidence>? IpAddresses {
            get { return BackingStore?.Get<List<IpEvidence>?>("ipAddresses"); }
            set { BackingStore?.Set("ipAddresses", value); }
        }
#nullable restore
#else
        public List<IpEvidence> IpAddresses {
            get { return BackingStore?.Get<List<IpEvidence>>("ipAddresses"); }
            set { BackingStore?.Set("ipAddresses", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DnsEvidence"/> and sets the default values.
        /// </summary>
        public DnsEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.dnsEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DnsEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DnsEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DnsEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"dnsServerIp", n => { DnsServerIp = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"hostIpAddress", n => { HostIpAddress = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"ipAddresses", n => { IpAddresses = n.GetCollectionOfObjectValues<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<IpEvidence>("dnsServerIp", DnsServerIp);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteObjectValue<IpEvidence>("hostIpAddress", HostIpAddress);
            writer.WriteCollectionOfObjectValues<IpEvidence>("ipAddresses", IpAddresses);
        }
    }
}
