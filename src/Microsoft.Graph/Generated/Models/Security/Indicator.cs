// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security
{
    #pragma warning disable CS1591
    public class Indicator : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The artifact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.Artifact? Artifact
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.Artifact?>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.Artifact Artifact
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.Artifact>("artifact"); }
            set { BackingStore?.Set("artifact", value); }
        }
#endif
        /// <summary>The source property</summary>
        public Microsoft.Graph.Models.Security.IndicatorSource? Source
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.IndicatorSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Security.Indicator"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Security.Indicator CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.articleIndicator" => new Microsoft.Graph.Models.Security.ArticleIndicator(),
                "#microsoft.graph.security.intelligenceProfileIndicator" => new Microsoft.Graph.Models.Security.IntelligenceProfileIndicator(),
                _ => new Microsoft.Graph.Models.Security.Indicator(),
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
                { "artifact", n => { Artifact = n.GetObjectValue<Microsoft.Graph.Models.Security.Artifact>(Microsoft.Graph.Models.Security.Artifact.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetEnumValue<Microsoft.Graph.Models.Security.IndicatorSource>(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.Artifact>("artifact", Artifact);
            writer.WriteEnumValue<Microsoft.Graph.Models.Security.IndicatorSource>("source", Source);
        }
    }
}
