// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// This type represents when and to whom to send an e-mail reminder.
    /// </summary>
    public class BookingReminder : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The message in the reminder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message
        {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message
        {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The amount of time before the start of an appointment that the reminder should be sent. It&apos;s denoted in ISO 8601 format.</summary>
        public TimeSpan? Offset
        {
            get { return BackingStore?.Get<TimeSpan?>("offset"); }
            set { BackingStore?.Set("offset", value); }
        }
        /// <summary>The recipients property</summary>
        public Microsoft.Graph.Models.BookingReminderRecipients? Recipients
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BookingReminderRecipients?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.BookingReminder"/> and sets the default values.
        /// </summary>
        public BookingReminder()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.BookingReminder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.BookingReminder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.BookingReminder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "message", n => { Message = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "offset", n => { Offset = n.GetTimeSpanValue(); } },
                { "recipients", n => { Recipients = n.GetEnumValue<Microsoft.Graph.Models.BookingReminderRecipients>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeSpanValue("offset", Offset);
            writer.WriteEnumValue<Microsoft.Graph.Models.BookingReminderRecipients>("recipients", Recipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
