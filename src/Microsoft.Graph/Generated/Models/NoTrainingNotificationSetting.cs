// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    #pragma warning disable CS1591
    public class NoTrainingNotificationSetting : EndUserNotificationSetting, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The notification for the user who is part of the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SimulationNotification? SimulationNotification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SimulationNotification?>("simulationNotification"); }
            set { BackingStore?.Set("simulationNotification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SimulationNotification SimulationNotification {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SimulationNotification>("simulationNotification"); }
            set { BackingStore?.Set("simulationNotification", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="NoTrainingNotificationSetting"/> and sets the default values.
        /// </summary>
        public NoTrainingNotificationSetting() : base()
        {
            OdataType = "#microsoft.graph.noTrainingNotificationSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NoTrainingNotificationSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NoTrainingNotificationSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NoTrainingNotificationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"simulationNotification", n => { SimulationNotification = n.GetObjectValue<Microsoft.Graph.Models.SimulationNotification>(Microsoft.Graph.Models.SimulationNotification.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.SimulationNotification>("simulationNotification", SimulationNotification);
        }
    }
}
