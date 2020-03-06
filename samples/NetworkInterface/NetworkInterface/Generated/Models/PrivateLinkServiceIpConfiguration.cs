// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace NetworkInterface.Models
{
    /// <summary> The private link service ip configuration. </summary>
    public partial class PrivateLinkServiceIpConfiguration : NetworkInterface.Models.SubResource
    {
        /// <summary> The name of private link service ip configuration. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; internal set; }
        /// <summary> The resource type. </summary>
        public string Type { get; internal set; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public NetworkInterface.Models.IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public NetworkInterface.Models.Subnet Subnet { get; set; }
        /// <summary> Whether the ip configuration is primary or not. </summary>
        public bool? Primary { get; set; }
        /// <summary> The provisioning state of the private link service IP configuration resource. </summary>
        public NetworkInterface.Models.ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4. </summary>
        public NetworkInterface.Models.IPVersion? PrivateIPAddressVersion { get; set; }
    }
}
