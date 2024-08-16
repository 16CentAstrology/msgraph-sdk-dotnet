// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Represents an un-typed status report about organizations app protection and configuration.
    /// </summary>
    public class ManagedAppStatusRaw : Microsoft.Graph.Models.ManagedAppStatus, IParsable
    {
        /// <summary>Status report content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Content
        {
            get { return BackingStore?.Get<UntypedNode?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public UntypedNode Content
        {
            get { return BackingStore?.Get<UntypedNode>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ManagedAppStatusRaw"/> and sets the default values.
        /// </summary>
        public ManagedAppStatusRaw() : base()
        {
            OdataType = "#microsoft.graph.managedAppStatusRaw";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ManagedAppStatusRaw"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.ManagedAppStatusRaw CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ManagedAppStatusRaw();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "content", n => { Content = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<UntypedNode>("content", Content);
        }
    }
}
