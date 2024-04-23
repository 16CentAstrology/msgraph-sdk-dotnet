// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    #pragma warning disable CS1591
    public class Security : Microsoft.Graph.Models.Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The alerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Alert>? Alerts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Alert>?>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Alert> Alerts {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Alert>>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#endif
        /// <summary>A collection of alerts in Microsoft 365 Defender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Alert>? AlertsV2 {
            get { return BackingStore?.Get<List<Alert>?>("alerts_v2"); }
            set { BackingStore?.Set("alerts_v2", value); }
        }
#nullable restore
#else
        public List<Alert> AlertsV2 {
            get { return BackingStore?.Get<List<Alert>>("alerts_v2"); }
            set { BackingStore?.Set("alerts_v2", value); }
        }
#endif
        /// <summary>The attackSimulation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AttackSimulationRoot? AttackSimulation {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationRoot?>("attackSimulation"); }
            set { BackingStore?.Set("attackSimulation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AttackSimulationRoot AttackSimulation {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AttackSimulationRoot>("attackSimulation"); }
            set { BackingStore?.Set("attackSimulation", value); }
        }
#endif
        /// <summary>The cases property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CasesRoot? Cases {
            get { return BackingStore?.Get<CasesRoot?>("cases"); }
            set { BackingStore?.Set("cases", value); }
        }
#nullable restore
#else
        public CasesRoot Cases {
            get { return BackingStore?.Get<CasesRoot>("cases"); }
            set { BackingStore?.Set("cases", value); }
        }
#endif
        /// <summary>A collection of incidents in Microsoft 365 Defender, each of which is a set of correlated alerts and associated metadata that reflects the story of an attack.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Incident>? Incidents {
            get { return BackingStore?.Get<List<Incident>?>("incidents"); }
            set { BackingStore?.Set("incidents", value); }
        }
#nullable restore
#else
        public List<Incident> Incidents {
            get { return BackingStore?.Get<List<Incident>>("incidents"); }
            set { BackingStore?.Set("incidents", value); }
        }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LabelsRoot? Labels {
            get { return BackingStore?.Get<LabelsRoot?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public LabelsRoot Labels {
            get { return BackingStore?.Get<LabelsRoot>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The secureScoreControlProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.SecureScoreControlProfile>? SecureScoreControlProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScoreControlProfile>?>("secureScoreControlProfiles"); }
            set { BackingStore?.Set("secureScoreControlProfiles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.SecureScoreControlProfile> SecureScoreControlProfiles {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScoreControlProfile>>("secureScoreControlProfiles"); }
            set { BackingStore?.Set("secureScoreControlProfiles", value); }
        }
#endif
        /// <summary>The secureScores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.SecureScore>? SecureScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScore>?>("secureScores"); }
            set { BackingStore?.Set("secureScores", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.SecureScore> SecureScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SecureScore>>("secureScores"); }
            set { BackingStore?.Set("secureScores", value); }
        }
#endif
        /// <summary>The subjectRightsRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.SubjectRightsRequest>? SubjectRightsRequests {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SubjectRightsRequest>?>("subjectRightsRequests"); }
            set { BackingStore?.Set("subjectRightsRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.SubjectRightsRequest> SubjectRightsRequests {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.SubjectRightsRequest>>("subjectRightsRequests"); }
            set { BackingStore?.Set("subjectRightsRequests", value); }
        }
#endif
        /// <summary>The threatIntelligence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.ThreatIntelligence? ThreatIntelligence {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.ThreatIntelligence?>("threatIntelligence"); }
            set { BackingStore?.Set("threatIntelligence", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.ThreatIntelligence ThreatIntelligence {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.ThreatIntelligence>("threatIntelligence"); }
            set { BackingStore?.Set("threatIntelligence", value); }
        }
#endif
        /// <summary>The triggers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TriggersRoot? Triggers {
            get { return BackingStore?.Get<TriggersRoot?>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#nullable restore
#else
        public TriggersRoot Triggers {
            get { return BackingStore?.Get<TriggersRoot>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#endif
        /// <summary>The triggerTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TriggerTypesRoot? TriggerTypes {
            get { return BackingStore?.Get<TriggerTypesRoot?>("triggerTypes"); }
            set { BackingStore?.Set("triggerTypes", value); }
        }
#nullable restore
#else
        public TriggerTypesRoot TriggerTypes {
            get { return BackingStore?.Get<TriggerTypesRoot>("triggerTypes"); }
            set { BackingStore?.Set("triggerTypes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Security"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Alert>(Microsoft.Graph.Models.Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alerts_v2", n => { AlertsV2 = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attackSimulation", n => { AttackSimulation = n.GetObjectValue<Microsoft.Graph.Models.AttackSimulationRoot>(Microsoft.Graph.Models.AttackSimulationRoot.CreateFromDiscriminatorValue); } },
                {"cases", n => { Cases = n.GetObjectValue<CasesRoot>(CasesRoot.CreateFromDiscriminatorValue); } },
                {"incidents", n => { Incidents = n.GetCollectionOfObjectValues<Incident>(Incident.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetObjectValue<LabelsRoot>(LabelsRoot.CreateFromDiscriminatorValue); } },
                {"secureScoreControlProfiles", n => { SecureScoreControlProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SecureScoreControlProfile>(Microsoft.Graph.Models.SecureScoreControlProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScores", n => { SecureScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SecureScore>(Microsoft.Graph.Models.SecureScore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subjectRightsRequests", n => { SubjectRightsRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.SubjectRightsRequest>(Microsoft.Graph.Models.SubjectRightsRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"threatIntelligence", n => { ThreatIntelligence = n.GetObjectValue<Microsoft.Graph.Models.Security.ThreatIntelligence>(Microsoft.Graph.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue); } },
                {"triggerTypes", n => { TriggerTypes = n.GetObjectValue<TriggerTypesRoot>(TriggerTypesRoot.CreateFromDiscriminatorValue); } },
                {"triggers", n => { Triggers = n.GetObjectValue<TriggersRoot>(TriggersRoot.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Alert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<Alert>("alerts_v2", AlertsV2);
            writer.WriteObjectValue<Microsoft.Graph.Models.AttackSimulationRoot>("attackSimulation", AttackSimulation);
            writer.WriteObjectValue<CasesRoot>("cases", Cases);
            writer.WriteCollectionOfObjectValues<Incident>("incidents", Incidents);
            writer.WriteObjectValue<LabelsRoot>("labels", Labels);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SecureScore>("secureScores", SecureScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.SubjectRightsRequest>("subjectRightsRequests", SubjectRightsRequests);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.ThreatIntelligence>("threatIntelligence", ThreatIntelligence);
            writer.WriteObjectValue<TriggersRoot>("triggers", Triggers);
            writer.WriteObjectValue<TriggerTypesRoot>("triggerTypes", TriggerTypes);
        }
    }
}
