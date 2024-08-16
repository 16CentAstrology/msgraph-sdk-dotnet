// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ApiApplication : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>When true, allows an application to use claims mapping without specifying a custom signing key.</summary>
        public bool? AcceptMappedClaims
        {
            get { return BackingStore?.Get<bool?>("acceptMappedClaims"); }
            set { BackingStore?.Set("acceptMappedClaims", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Microsoft Entra ID knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? KnownClientApplications
        {
            get { return BackingStore?.Get<List<Guid?>?>("knownClientApplications"); }
            set { BackingStore?.Set("knownClientApplications", value); }
        }
#nullable restore
#else
        public List<Guid?> KnownClientApplications
        {
            get { return BackingStore?.Get<List<Guid?>>("knownClientApplications"); }
            set { BackingStore?.Set("knownClientApplications", value); }
        }
#endif
        /// <summary>The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PermissionScope>? Oauth2PermissionScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PermissionScope>?>("oauth2PermissionScopes"); }
            set { BackingStore?.Set("oauth2PermissionScopes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PermissionScope> Oauth2PermissionScopes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PermissionScope>>("oauth2PermissionScopes"); }
            set { BackingStore?.Set("oauth2PermissionScopes", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Lists the client applications that are preauthorized with the specified delegated permissions to access this application&apos;s APIs. Users aren&apos;t required to consent to any preauthorized application (for the permissions specified). However, any other permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PreAuthorizedApplication>? PreAuthorizedApplications
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PreAuthorizedApplication>?>("preAuthorizedApplications"); }
            set { BackingStore?.Set("preAuthorizedApplications", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PreAuthorizedApplication> PreAuthorizedApplications
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PreAuthorizedApplication>>("preAuthorizedApplications"); }
            set { BackingStore?.Set("preAuthorizedApplications", value); }
        }
#endif
        /// <summary>Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount or PersonalMicrosoftAccount, the value for this property must be 2.</summary>
        public int? RequestedAccessTokenVersion
        {
            get { return BackingStore?.Get<int?>("requestedAccessTokenVersion"); }
            set { BackingStore?.Set("requestedAccessTokenVersion", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ApiApplication"/> and sets the default values.
        /// </summary>
        public ApiApplication()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ApiApplication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.ApiApplication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ApiApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acceptMappedClaims", n => { AcceptMappedClaims = n.GetBoolValue(); } },
                { "knownClientApplications", n => { KnownClientApplications = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                { "oauth2PermissionScopes", n => { Oauth2PermissionScopes = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PermissionScope>(Microsoft.Graph.Models.PermissionScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "preAuthorizedApplications", n => { PreAuthorizedApplications = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PreAuthorizedApplication>(Microsoft.Graph.Models.PreAuthorizedApplication.CreateFromDiscriminatorValue)?.ToList(); } },
                { "requestedAccessTokenVersion", n => { RequestedAccessTokenVersion = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acceptMappedClaims", AcceptMappedClaims);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("knownClientApplications", KnownClientApplications);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PermissionScope>("oauth2PermissionScopes", Oauth2PermissionScopes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PreAuthorizedApplication>("preAuthorizedApplications", PreAuthorizedApplications);
            writer.WriteIntValue("requestedAccessTokenVersion", RequestedAccessTokenVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
