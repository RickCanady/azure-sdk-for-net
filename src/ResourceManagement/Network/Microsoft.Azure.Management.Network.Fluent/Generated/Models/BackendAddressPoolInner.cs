// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pool of backend IP addresses.
    /// </summary>
    [JsonTransformation]
    public partial class BackendAddressPoolInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the BackendAddressPoolInner class.
        /// </summary>
        public BackendAddressPoolInner() { }

        /// <summary>
        /// Initializes a new instance of the BackendAddressPoolInner class.
        /// </summary>
        /// <param name="backendIPConfigurations">Gets collection of references
        /// to IP addresses defined in network interfaces.</param>
        /// <param name="loadBalancingRules">Gets load balancing rules that use
        /// this backend address pool.</param>
        /// <param name="outboundNatRule">Gets outbound rules that use this
        /// backend address pool.</param>
        /// <param name="provisioningState">Get provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public BackendAddressPoolInner(string id = default(string), IList<NetworkInterfaceIPConfigurationInner> backendIPConfigurations = default(IList<NetworkInterfaceIPConfigurationInner>), IList<Resource.Fluent.SubResource> loadBalancingRules = default(IList<Resource.Fluent.SubResource>), Resource.Fluent.SubResource outboundNatRule = default(Resource.Fluent.SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            BackendIPConfigurations = backendIPConfigurations;
            LoadBalancingRules = loadBalancingRules;
            OutboundNatRule = outboundNatRule;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets collection of references to IP addresses defined in network
        /// interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIPConfigurations")]
        public IList<NetworkInterfaceIPConfigurationInner> BackendIPConfigurations { get; protected set; }

        /// <summary>
        /// Gets load balancing rules that use this backend address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<Resource.Fluent.SubResource> LoadBalancingRules { get; protected set; }

        /// <summary>
        /// Gets outbound rules that use this backend address pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRule")]
        public Resource.Fluent.SubResource OutboundNatRule { get; protected set; }

        /// <summary>
        /// Gets or sets get provisioning state of the public IP resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
