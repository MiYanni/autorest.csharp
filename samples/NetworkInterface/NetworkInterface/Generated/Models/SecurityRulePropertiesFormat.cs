// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace NetworkInterface.Models
{
    /// <summary> Security rule resource. </summary>
    public partial class SecurityRulePropertiesFormat
    {
        /// <summary> A description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> Network protocol this rule applies to. </summary>
        public NetworkInterface.Models.SecurityRuleProtocol Protocol { get; set; }
        /// <summary> The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string SourcePortRange { get; set; }
        /// <summary> The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string DestinationPortRange { get; set; }
        /// <summary> The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies where network traffic originates from. </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary> The CIDR or source IP ranges. </summary>
        public ICollection<string> SourceAddressPrefixes { get; set; }
        /// <summary> The application security group specified as source. </summary>
        public ICollection<NetworkInterface.Models.ApplicationSecurityGroup> SourceApplicationSecurityGroups { get; set; }
        /// <summary> The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. </summary>
        public string DestinationAddressPrefix { get; set; }
        /// <summary> The destination address prefixes. CIDR or destination IP ranges. </summary>
        public ICollection<string> DestinationAddressPrefixes { get; set; }
        /// <summary> The application security group specified as destination. </summary>
        public ICollection<NetworkInterface.Models.ApplicationSecurityGroup> DestinationApplicationSecurityGroups { get; set; }
        /// <summary> The source port ranges. </summary>
        public ICollection<string> SourcePortRanges { get; set; }
        /// <summary> The destination port ranges. </summary>
        public ICollection<string> DestinationPortRanges { get; set; }
        /// <summary> The network traffic is allowed or denied. </summary>
        public NetworkInterface.Models.SecurityRuleAccess Access { get; set; }
        /// <summary> The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </summary>
        public int? Priority { get; set; }
        /// <summary> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </summary>
        public NetworkInterface.Models.SecurityRuleDirection Direction { get; set; }
        /// <summary> The provisioning state of the security rule resource. </summary>
        public NetworkInterface.Models.ProvisioningState? ProvisioningState { get; internal set; }
    }
}
