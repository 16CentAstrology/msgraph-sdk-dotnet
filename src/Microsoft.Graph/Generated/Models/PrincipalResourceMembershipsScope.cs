// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class PrincipalResourceMembershipsScope : AccessReviewScope, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines the scopes of the principals whose access to resources are reviewed in the access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScope>? PrincipalScopes
        {
            get { return BackingStore?.Get<List<AccessReviewScope>?>("principalScopes"); }
            set { BackingStore?.Set("principalScopes", value); }
        }
#nullable restore
#else
        public List<AccessReviewScope> PrincipalScopes
        {
            get { return BackingStore?.Get<List<AccessReviewScope>>("principalScopes"); }
            set { BackingStore?.Set("principalScopes", value); }
        }
#endif
        /// <summary>Defines the scopes of the resources for which access is reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScope>? ResourceScopes
        {
            get { return BackingStore?.Get<List<AccessReviewScope>?>("resourceScopes"); }
            set { BackingStore?.Set("resourceScopes", value); }
        }
#nullable restore
#else
        public List<AccessReviewScope> ResourceScopes
        {
            get { return BackingStore?.Get<List<AccessReviewScope>>("resourceScopes"); }
            set { BackingStore?.Set("resourceScopes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrincipalResourceMembershipsScope"/> and sets the default values.
        /// </summary>
        public PrincipalResourceMembershipsScope() : base()
        {
            OdataType = "#microsoft.graph.principalResourceMembershipsScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrincipalResourceMembershipsScope"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrincipalResourceMembershipsScope CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrincipalResourceMembershipsScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "principalScopes", n => { PrincipalScopes = n.GetCollectionOfObjectValues<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "resourceScopes", n => { ResourceScopes = n.GetCollectionOfObjectValues<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<AccessReviewScope>("principalScopes", PrincipalScopes);
            writer.WriteCollectionOfObjectValues<AccessReviewScope>("resourceScopes", ResourceScopes);
        }
    }
}
