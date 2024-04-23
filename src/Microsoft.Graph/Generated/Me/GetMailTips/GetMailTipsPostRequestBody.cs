// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Me.GetMailTips {
    #pragma warning disable CS1591
    public class GetMailTipsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? throw new InvalidOperationException("AdditionalData can not be null"); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The EmailAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EmailAddresses {
            get { return BackingStore?.Get<List<string>?>("EmailAddresses"); }
            set { BackingStore?.Set("EmailAddresses", value); }
        }
#nullable restore
#else
        public List<string> EmailAddresses {
            get { return BackingStore?.Get<List<string>>("EmailAddresses"); }
            set { BackingStore?.Set("EmailAddresses", value); }
        }
#endif
        /// <summary>The MailTipsOptions property</summary>
        public MailTipsType? MailTipsOptions {
            get { return BackingStore?.Get<MailTipsType?>("MailTipsOptions"); }
            set { BackingStore?.Set("MailTipsOptions", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="GetMailTipsPostRequestBody"/> and sets the default values.
        /// </summary>
        public GetMailTipsPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetMailTipsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetMailTipsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetMailTipsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"EmailAddresses", n => { EmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"MailTipsOptions", n => { MailTipsOptions = n.GetEnumValue<MailTipsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("EmailAddresses", EmailAddresses);
            writer.WriteEnumValue<MailTipsType>("MailTipsOptions", MailTipsOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
