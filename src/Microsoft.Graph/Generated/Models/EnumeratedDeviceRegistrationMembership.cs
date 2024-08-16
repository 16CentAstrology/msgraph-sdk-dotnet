// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class EnumeratedDeviceRegistrationMembership : Microsoft.Graph.Models.DeviceRegistrationMembership, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups
        {
            get { return BackingStore?.Get<List<string>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<string> Groups
        {
            get { return BackingStore?.Get<List<string>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Users
        {
            get { return BackingStore?.Get<List<string>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<string> Users
        {
            get { return BackingStore?.Get<List<string>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.EnumeratedDeviceRegistrationMembership"/> and sets the default values.
        /// </summary>
        public EnumeratedDeviceRegistrationMembership() : base()
        {
            OdataType = "#microsoft.graph.enumeratedDeviceRegistrationMembership";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.EnumeratedDeviceRegistrationMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.EnumeratedDeviceRegistrationMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.EnumeratedDeviceRegistrationMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "users", n => { Users = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
        }
    }
}
