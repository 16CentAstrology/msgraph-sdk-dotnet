using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.Security {
    public enum KubernetesServiceType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "clusterIP")]
        ClusterIP,
        [EnumMember(Value = "externalName")]
        ExternalName,
        [EnumMember(Value = "nodePort")]
        NodePort,
        [EnumMember(Value = "loadBalancer")]
        LoadBalancer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
