// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PositiveReinforcementNotification : BaseEndUserNotification, IParsable {
        /// <summary>The deliveryPreference property</summary>
        public NotificationDeliveryPreference? DeliveryPreference {
            get { return BackingStore?.Get<NotificationDeliveryPreference?>("deliveryPreference"); }
            set { BackingStore?.Set("deliveryPreference", value); }
        }
        /// <summary>
        /// Instantiates a new positiveReinforcementNotification and sets the default values.
        /// </summary>
        public PositiveReinforcementNotification() : base() {
            OdataType = "#microsoft.graph.positiveReinforcementNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PositiveReinforcementNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PositiveReinforcementNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deliveryPreference", n => { DeliveryPreference = n.GetEnumValue<NotificationDeliveryPreference>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<NotificationDeliveryPreference>("deliveryPreference", DeliveryPreference);
        }
    }
}
