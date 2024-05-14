// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class RelyingPartyDetailedSummary : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of failed sign ins on AD FS in the period specified. Supports $orderby, $filter (eq).</summary>
        public long? FailedSignInCount
        {
            get { return BackingStore?.Get<long?>("failedSignInCount"); }
            set { BackingStore?.Set("failedSignInCount", value); }
        }
        /// <summary>The migrationStatus property</summary>
        public Microsoft.Graph.Models.MigrationStatus? MigrationStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MigrationStatus?>("migrationStatus"); }
            set { BackingStore?.Set("migrationStatus", value); }
        }
        /// <summary>Specifies all the validations checks done on applications config details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? MigrationValidationDetails
        {
            get { return BackingStore?.Get<List<KeyValuePair>?>("migrationValidationDetails"); }
            set { BackingStore?.Set("migrationValidationDetails", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> MigrationValidationDetails
        {
            get { return BackingStore?.Get<List<KeyValuePair>>("migrationValidationDetails"); }
            set { BackingStore?.Set("migrationValidationDetails", value); }
        }
#endif
        /// <summary>Identifies the relying party to this federation service. It&apos;s used when issuing claims to the relying party. Supports $orderby, $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyId
        {
            get { return BackingStore?.Get<string?>("relyingPartyId"); }
            set { BackingStore?.Set("relyingPartyId", value); }
        }
#nullable restore
#else
        public string RelyingPartyId
        {
            get { return BackingStore?.Get<string>("relyingPartyId"); }
            set { BackingStore?.Set("relyingPartyId", value); }
        }
#endif
        /// <summary>Name of the relying party&apos;s website or other entity on the Internet that uses an identity provider to authenticate a user who wants to log in. Supports $orderby, $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelyingPartyName
        {
            get { return BackingStore?.Get<string?>("relyingPartyName"); }
            set { BackingStore?.Set("relyingPartyName", value); }
        }
#nullable restore
#else
        public string RelyingPartyName
        {
            get { return BackingStore?.Get<string>("relyingPartyName"); }
            set { BackingStore?.Set("relyingPartyName", value); }
        }
#endif
        /// <summary>Specifies where the relying party expects to receive the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ReplyUrls
        {
            get { return BackingStore?.Get<List<string>?>("replyUrls"); }
            set { BackingStore?.Set("replyUrls", value); }
        }
#nullable restore
#else
        public List<string> ReplyUrls
        {
            get { return BackingStore?.Get<List<string>>("replyUrls"); }
            set { BackingStore?.Set("replyUrls", value); }
        }
#endif
        /// <summary>Uniquely identifies the Active Directory forest. Supports $orderby, $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId
        {
            get { return BackingStore?.Get<string?>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#nullable restore
#else
        public string ServiceId
        {
            get { return BackingStore?.Get<string>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#endif
        /// <summary>Calculated as Number of successful / (Number of successful + Number of failed sign ins) or successfulSignInCount / totalSignInCount on AD FS in the period specified. Supports $orderby, $filter (eq).</summary>
        public double? SignInSuccessRate
        {
            get { return BackingStore?.Get<double?>("signInSuccessRate"); }
            set { BackingStore?.Set("signInSuccessRate", value); }
        }
        /// <summary>Number of successful sign ins on AD FS. Supports $orderby, $filter (eq).</summary>
        public long? SuccessfulSignInCount
        {
            get { return BackingStore?.Get<long?>("successfulSignInCount"); }
            set { BackingStore?.Set("successfulSignInCount", value); }
        }
        /// <summary>Number of successful + failed sign ins on AD FS in the period specified. Supports $orderby, $filter (eq).</summary>
        public long? TotalSignInCount
        {
            get { return BackingStore?.Get<long?>("totalSignInCount"); }
            set { BackingStore?.Set("totalSignInCount", value); }
        }
        /// <summary>Number of unique users that signed into the application. Supports $orderby, $filter (eq).</summary>
        public long? UniqueUserCount
        {
            get { return BackingStore?.Get<long?>("uniqueUserCount"); }
            set { BackingStore?.Set("uniqueUserCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RelyingPartyDetailedSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RelyingPartyDetailedSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelyingPartyDetailedSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "failedSignInCount", n => { FailedSignInCount = n.GetLongValue(); } },
                { "migrationStatus", n => { MigrationStatus = n.GetEnumValue<MigrationStatus>(); } },
                { "migrationValidationDetails", n => { MigrationValidationDetails = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "relyingPartyId", n => { RelyingPartyId = n.GetStringValue(); } },
                { "relyingPartyName", n => { RelyingPartyName = n.GetStringValue(); } },
                { "replyUrls", n => { ReplyUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "serviceId", n => { ServiceId = n.GetStringValue(); } },
                { "signInSuccessRate", n => { SignInSuccessRate = n.GetDoubleValue(); } },
                { "successfulSignInCount", n => { SuccessfulSignInCount = n.GetLongValue(); } },
                { "totalSignInCount", n => { TotalSignInCount = n.GetLongValue(); } },
                { "uniqueUserCount", n => { UniqueUserCount = n.GetLongValue(); } },
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
            writer.WriteLongValue("failedSignInCount", FailedSignInCount);
            writer.WriteEnumValue<MigrationStatus>("migrationStatus", MigrationStatus);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("migrationValidationDetails", MigrationValidationDetails);
            writer.WriteStringValue("relyingPartyId", RelyingPartyId);
            writer.WriteStringValue("relyingPartyName", RelyingPartyName);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteDoubleValue("signInSuccessRate", SignInSuccessRate);
            writer.WriteLongValue("successfulSignInCount", SuccessfulSignInCount);
            writer.WriteLongValue("totalSignInCount", TotalSignInCount);
            writer.WriteLongValue("uniqueUserCount", UniqueUserCount);
        }
    }
}
