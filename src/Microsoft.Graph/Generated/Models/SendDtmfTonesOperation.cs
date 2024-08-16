// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class SendDtmfTonesOperation : Microsoft.Graph.Models.CommsOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The results of the action. Possible values are: unknown, completedSuccessfully, mediaOperationCanceled, unknownfutureValue.</summary>
        public Microsoft.Graph.Models.SendDtmfCompletionReason? CompletionReason
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SendDtmfCompletionReason?>("completionReason"); }
            set { BackingStore?.Set("completionReason", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.SendDtmfTonesOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.SendDtmfTonesOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.SendDtmfTonesOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completionReason", n => { CompletionReason = n.GetEnumValue<Microsoft.Graph.Models.SendDtmfCompletionReason>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Models.SendDtmfCompletionReason>("completionReason", CompletionReason);
        }
    }
}
