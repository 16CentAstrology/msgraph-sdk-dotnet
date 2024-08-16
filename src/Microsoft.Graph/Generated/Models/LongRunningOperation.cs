// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class LongRunningOperation : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The start time of the operation. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The time of the last action in the operation. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastActionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>URI of the resource that the operation is performed on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLocation
        {
            get { return BackingStore?.Get<string?>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#nullable restore
#else
        public string ResourceLocation
        {
            get { return BackingStore?.Get<string>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#endif
        /// <summary>The status of the operation. The possible values are: notStarted, running, succeeded, failed, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.LongRunningOperationStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LongRunningOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Details about the status of the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDetail
        {
            get { return BackingStore?.Get<string?>("statusDetail"); }
            set { BackingStore?.Set("statusDetail", value); }
        }
#nullable restore
#else
        public string StatusDetail
        {
            get { return BackingStore?.Get<string>("statusDetail"); }
            set { BackingStore?.Set("statusDetail", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.LongRunningOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.LongRunningOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.attackSimulationOperation" => new Microsoft.Graph.Models.AttackSimulationOperation(),
                "#microsoft.graph.richLongRunningOperation" => new Microsoft.Graph.Models.RichLongRunningOperation(),
                _ => new Microsoft.Graph.Models.LongRunningOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Models.LongRunningOperationStatus>(); } },
                { "statusDetail", n => { StatusDetail = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<Microsoft.Graph.Models.LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("statusDetail", StatusDetail);
        }
    }
}
