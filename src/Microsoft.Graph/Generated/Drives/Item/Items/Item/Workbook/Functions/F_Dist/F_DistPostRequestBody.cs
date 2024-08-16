// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist
{
    #pragma warning disable CS1591
    public class F_DistPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Cumulative
        {
            get { return BackingStore?.Get<UntypedNode?>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#nullable restore
#else
        public UntypedNode Cumulative
        {
            get { return BackingStore?.Get<UntypedNode>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#endif
        /// <summary>The degFreedom1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DegFreedom1
        {
            get { return BackingStore?.Get<UntypedNode?>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#nullable restore
#else
        public UntypedNode DegFreedom1
        {
            get { return BackingStore?.Get<UntypedNode>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#endif
        /// <summary>The degFreedom2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DegFreedom2
        {
            get { return BackingStore?.Get<UntypedNode?>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
        }
#nullable restore
#else
        public UntypedNode DegFreedom2
        {
            get { return BackingStore?.Get<UntypedNode>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? X
        {
            get { return BackingStore?.Get<UntypedNode?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public UntypedNode X
        {
            get { return BackingStore?.Get<UntypedNode>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist.F_DistPostRequestBody"/> and sets the default values.
        /// </summary>
        public F_DistPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist.F_DistPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist.F_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.F_Dist.F_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cumulative", n => { Cumulative = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "degFreedom1", n => { DegFreedom1 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "degFreedom2", n => { DegFreedom2 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "x", n => { X = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("cumulative", Cumulative);
            writer.WriteObjectValue<UntypedNode>("degFreedom1", DegFreedom1);
            writer.WriteObjectValue<UntypedNode>("degFreedom2", DegFreedom2);
            writer.WriteObjectValue<UntypedNode>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
