// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class SmsAuthenticationMethodTarget : Microsoft.Graph.Models.AuthenticationMethodTarget, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines if users can use this authentication method to sign in to Microsoft Entra ID. true if users can use this method for primary authentication, otherwise false.</summary>
        public bool? IsUsableForSignIn
        {
            get { return BackingStore?.Get<bool?>("isUsableForSignIn"); }
            set { BackingStore?.Set("isUsableForSignIn", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.SmsAuthenticationMethodTarget"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.SmsAuthenticationMethodTarget CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.SmsAuthenticationMethodTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isUsableForSignIn", n => { IsUsableForSignIn = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("isUsableForSignIn", IsUsableForSignIn);
        }
    }
}
