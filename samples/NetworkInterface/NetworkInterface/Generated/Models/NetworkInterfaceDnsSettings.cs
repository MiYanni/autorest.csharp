// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace NetworkInterface.Models
{
    /// <summary> DNS settings of a network interface. </summary>
    public partial class NetworkInterfaceDnsSettings
    {
        /// <summary> List of DNS servers IP addresses. Use &apos;AzureProvidedDNS&apos; to switch to azure provided DNS resolution. &apos;AzureProvidedDNS&apos; value cannot be combined with other IPs, it must be the only value in dnsServers collection. </summary>
        public ICollection<string> DnsServers { get; set; }
        /// <summary> If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set. This property is what is configured on each of those VMs. </summary>
        public ICollection<string> AppliedDnsServers { get; internal set; }
        /// <summary> Relative DNS name for this NIC used for internal communications between VMs in the same virtual network. </summary>
        public string InternalDnsNameLabel { get; set; }
        /// <summary> Fully qualified DNS name supporting internal communications between VMs in the same virtual network. </summary>
        public string InternalFqdn { get; internal set; }
        /// <summary> Even if internalDnsNameLabel is not specified, a DNS entry is created for the primary NIC of the VM. This DNS name can be constructed by concatenating the VM name with the value of internalDomainNameSuffix. </summary>
        public string InternalDomainNameSuffix { get; internal set; }
    }
}
