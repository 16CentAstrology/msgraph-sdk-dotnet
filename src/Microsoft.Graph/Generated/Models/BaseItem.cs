// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class BaseItem : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user, device, or application that created the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Identity of the user who created the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.User? CreatedByUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User?>("createdByUser"); }
            set { BackingStore?.Set("createdByUser", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.User CreatedByUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User>("createdByUser"); }
            set { BackingStore?.Set("createdByUser", value); }
        }
#endif
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Provides a user-visible description of the item. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>ETag for the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ETag
        {
            get { return BackingStore?.Get<string?>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#nullable restore
#else
        public string ETag
        {
            get { return BackingStore?.Get<string>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#endif
        /// <summary>Identity of the user, device, and application that last modified the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Identity of the user who last modified the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.User? LastModifiedByUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User?>("lastModifiedByUser"); }
            set { BackingStore?.Set("lastModifiedByUser", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.User LastModifiedByUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User>("lastModifiedByUser"); }
            set { BackingStore?.Set("lastModifiedByUser", value); }
        }
#endif
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The name of the item. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Parent information, if the item has a parent. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ItemReference? ParentReference
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ItemReference?>("parentReference"); }
            set { BackingStore?.Set("parentReference", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ItemReference ParentReference
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ItemReference>("parentReference"); }
            set { BackingStore?.Set("parentReference", value); }
        }
#endif
        /// <summary>URL that either displays the resource in the browser (for Office file formats), or is a direct link to the file (for other formats). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.BaseItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.BaseItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.baseSitePage" => new Microsoft.Graph.Models.BaseSitePage(),
                "#microsoft.graph.drive" => new Microsoft.Graph.Models.Drive(),
                "#microsoft.graph.driveItem" => new Microsoft.Graph.Models.DriveItem(),
                "#microsoft.graph.list" => new Microsoft.Graph.Models.List(),
                "#microsoft.graph.listItem" => new Microsoft.Graph.Models.ListItem(),
                "#microsoft.graph.sharedDriveItem" => new Microsoft.Graph.Models.SharedDriveItem(),
                "#microsoft.graph.site" => new Microsoft.Graph.Models.Site(),
                "#microsoft.graph.sitePage" => new Microsoft.Graph.Models.SitePage(),
                _ => new Microsoft.Graph.Models.BaseItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdByUser", n => { CreatedByUser = n.GetObjectValue<Microsoft.Graph.Models.User>(Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "eTag", n => { ETag = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedByUser", n => { LastModifiedByUser = n.GetObjectValue<Microsoft.Graph.Models.User>(Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parentReference", n => { ParentReference = n.GetObjectValue<Microsoft.Graph.Models.ItemReference>(Microsoft.Graph.Models.ItemReference.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteObjectValue<Microsoft.Graph.Models.User>("createdByUser", CreatedByUser);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<Microsoft.Graph.Models.User>("lastModifiedByUser", LastModifiedByUser);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Microsoft.Graph.Models.ItemReference>("parentReference", ParentReference);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
