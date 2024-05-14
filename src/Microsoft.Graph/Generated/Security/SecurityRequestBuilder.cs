// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.Alerts;
using Microsoft.Graph.Security.Alerts_v2;
using Microsoft.Graph.Security.AttackSimulation;
using Microsoft.Graph.Security.Cases;
using Microsoft.Graph.Security.Identities;
using Microsoft.Graph.Security.Incidents;
using Microsoft.Graph.Security.Labels;
using Microsoft.Graph.Security.MicrosoftGraphSecurityRunHuntingQuery;
using Microsoft.Graph.Security.SecureScoreControlProfiles;
using Microsoft.Graph.Security.SecureScores;
using Microsoft.Graph.Security.SubjectRightsRequests;
using Microsoft.Graph.Security.ThreatIntelligence;
using Microsoft.Graph.Security.TriggerTypes;
using Microsoft.Graph.Security.Triggers;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security
{
    /// <summary>
    /// Provides operations to manage the security singleton.
    /// </summary>
    public class SecurityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the alerts property of the microsoft.graph.security entity.</summary>
        public AlertsRequestBuilder Alerts
        {
            get => new AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the alerts_v2 property of the microsoft.graph.security entity.</summary>
        public Alerts_v2RequestBuilder Alerts_v2
        {
            get => new Alerts_v2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
        public AttackSimulationRequestBuilder AttackSimulation
        {
            get => new AttackSimulationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cases property of the microsoft.graph.security entity.</summary>
        public CasesRequestBuilder Cases
        {
            get => new CasesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identities property of the microsoft.graph.security entity.</summary>
        public IdentitiesRequestBuilder Identities
        {
            get => new IdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the incidents property of the microsoft.graph.security entity.</summary>
        public IncidentsRequestBuilder Incidents
        {
            get => new IncidentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the labels property of the microsoft.graph.security entity.</summary>
        public LabelsRequestBuilder Labels
        {
            get => new LabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the runHuntingQuery method.</summary>
        public MicrosoftGraphSecurityRunHuntingQueryRequestBuilder MicrosoftGraphSecurityRunHuntingQuery
        {
            get => new MicrosoftGraphSecurityRunHuntingQueryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the secureScoreControlProfiles property of the microsoft.graph.security entity.</summary>
        public SecureScoreControlProfilesRequestBuilder SecureScoreControlProfiles
        {
            get => new SecureScoreControlProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the secureScores property of the microsoft.graph.security entity.</summary>
        public SecureScoresRequestBuilder SecureScores
        {
            get => new SecureScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subjectRightsRequests property of the microsoft.graph.security entity.</summary>
        public SubjectRightsRequestsRequestBuilder SubjectRightsRequests
        {
            get => new SubjectRightsRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threatIntelligence property of the microsoft.graph.security entity.</summary>
        public ThreatIntelligenceRequestBuilder ThreatIntelligence
        {
            get => new ThreatIntelligenceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the triggers property of the microsoft.graph.security entity.</summary>
        public TriggersRequestBuilder Triggers
        {
            get => new TriggersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the triggerTypes property of the microsoft.graph.security entity.</summary>
        public TriggerTypesRequestBuilder TriggerTypes
        {
            get => new TriggerTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="SecurityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SecurityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get security
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Security.Security"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Security.Security?> GetAsync(Action<RequestConfiguration<SecurityRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Security.Security> GetAsync(Action<RequestConfiguration<SecurityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Security.Security>(requestInfo, Microsoft.Graph.Models.Security.Security.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update security
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Security.Security"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.Security.Security?> PatchAsync(Microsoft.Graph.Models.Security.Security body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.Security.Security> PatchAsync(Microsoft.Graph.Models.Security.Security body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.Security.Security>(requestInfo, Microsoft.Graph.Models.Security.Security.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SecurityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SecurityRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Security.Security body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.Security.Security body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="SecurityRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SecurityRequestBuilder WithUrl(string rawUrl)
        {
            return new SecurityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get security
        /// </summary>
        public class SecurityRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SecurityRequestBuilderGetRequestConfiguration : RequestConfiguration<SecurityRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SecurityRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
