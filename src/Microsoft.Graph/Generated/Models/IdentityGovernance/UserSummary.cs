// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance {
    public class UserSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of failed tasks for users in a user summary.</summary>
        public int? FailedTasks {
            get { return BackingStore?.Get<int?>("failedTasks"); }
            set { BackingStore?.Set("failedTasks", value); }
        }
        /// <summary>The number of failed users in a user summary.</summary>
        public int? FailedUsers {
            get { return BackingStore?.Get<int?>("failedUsers"); }
            set { BackingStore?.Set("failedUsers", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The number of successful users in a user summary.</summary>
        public int? SuccessfulUsers {
            get { return BackingStore?.Get<int?>("successfulUsers"); }
            set { BackingStore?.Set("successfulUsers", value); }
        }
        /// <summary>The total tasks of users in a user summary.</summary>
        public int? TotalTasks {
            get { return BackingStore?.Get<int?>("totalTasks"); }
            set { BackingStore?.Set("totalTasks", value); }
        }
        /// <summary>The total number of users in a user summary</summary>
        public int? TotalUsers {
            get { return BackingStore?.Get<int?>("totalUsers"); }
            set { BackingStore?.Set("totalUsers", value); }
        }
        /// <summary>
        /// Instantiates a new userSummary and sets the default values.
        /// </summary>
        public UserSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                {"failedUsers", n => { FailedUsers = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulUsers", n => { SuccessfulUsers = n.GetIntValue(); } },
                {"totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                {"totalUsers", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteIntValue("failedUsers", FailedUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulUsers", SuccessfulUsers);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
