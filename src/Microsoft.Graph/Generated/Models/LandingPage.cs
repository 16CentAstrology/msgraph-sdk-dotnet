// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    #pragma warning disable CS1591
    public class LandingPage : Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user who created the landing page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy {
            get { return BackingStore?.Get<EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public EmailIdentity CreatedBy {
            get { return BackingStore?.Get<EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when the landing page was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the landing page as defined by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The detail information for a landing page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LandingPageDetail>? Details {
            get { return BackingStore?.Get<List<LandingPageDetail>?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public List<LandingPageDetail> Details {
            get { return BackingStore?.Get<List<LandingPageDetail>>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The display name of the landing page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Email identity of the user who last modified the landing page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public EmailIdentity LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Date and time when the landing page was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Content locale.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#endif
        /// <summary>The source of the content. Possible values are: unknown, global, tenant, unknownFutureValue.</summary>
        public SimulationContentSource? Source {
            get { return BackingStore?.Get<SimulationContentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The status of the simulation. Possible values are: unknown, draft, ready, archive, delete, unknownFutureValue.</summary>
        public SimulationContentStatus? Status {
            get { return BackingStore?.Get<SimulationContentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Supported locales.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedLocales {
            get { return BackingStore?.Get<List<string>?>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#nullable restore
#else
        public List<string> SupportedLocales {
            get { return BackingStore?.Get<List<string>>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LandingPage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LandingPage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LandingPage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfObjectValues<LandingPageDetail>(LandingPageDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                {"status", n => { Status = n.GetEnumValue<SimulationContentStatus>(); } },
                {"supportedLocales", n => { SupportedLocales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<LandingPageDetail>("details", Details);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteEnumValue<SimulationContentStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedLocales", SupportedLocales);
        }
    }
}
