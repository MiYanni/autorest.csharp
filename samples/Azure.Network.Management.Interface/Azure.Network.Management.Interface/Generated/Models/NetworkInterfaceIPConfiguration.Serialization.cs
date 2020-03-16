// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class NetworkInterfaceIPConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (VirtualNetworkTaps != null)
            {
                writer.WritePropertyName("virtualNetworkTaps");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkTaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ApplicationGatewayBackendAddressPools != null)
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPools");
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LoadBalancerBackendAddressPools != null)
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LoadBalancerInboundNatRules != null)
            {
                writer.WritePropertyName("loadBalancerInboundNatRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerInboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PrivateIPAddress != null)
            {
                writer.WritePropertyName("privateIPAddress");
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (PrivateIPAllocationMethod != null)
            {
                writer.WritePropertyName("privateIPAllocationMethod");
                writer.WriteStringValue(PrivateIPAllocationMethod.Value.ToString());
            }
            if (PrivateIPAddressVersion != null)
            {
                writer.WritePropertyName("privateIPAddressVersion");
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Primary != null)
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (PublicIPAddress != null)
            {
                writer.WritePropertyName("publicIPAddress");
                writer.WriteObjectValue(PublicIPAddress);
            }
            if (ApplicationSecurityGroups != null)
            {
                writer.WritePropertyName("applicationSecurityGroups");
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (PrivateLinkConnectionProperties != null)
            {
                writer.WritePropertyName("privateLinkConnectionProperties");
                writer.WriteObjectValue(PrivateLinkConnectionProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceIPConfiguration DeserializeNetworkInterfaceIPConfiguration(JsonElement element)
        {
            NetworkInterfaceIPConfiguration result = new NetworkInterfaceIPConfiguration();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualNetworkTaps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.VirtualNetworkTaps = new List<VirtualNetworkTap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.VirtualNetworkTaps.Add(VirtualNetworkTap.DeserializeVirtualNetworkTap(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayBackendAddressPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ApplicationGatewayBackendAddressPools = new List<ApplicationGatewayBackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.ApplicationGatewayBackendAddressPools.Add(ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddressPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.LoadBalancerBackendAddressPools = new List<BackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.LoadBalancerBackendAddressPools.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerInboundNatRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.LoadBalancerInboundNatRules = new List<InboundNatRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.LoadBalancerInboundNatRules.Add(InboundNatRule.DeserializeInboundNatRule(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PrivateIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateIPAllocationMethod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PrivateIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PrivateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Subnet = Subnet.DeserializeSubnet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PublicIPAddress = PublicIPAddress.DeserializePublicIPAddress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ApplicationSecurityGroups = new List<ApplicationSecurityGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.ApplicationSecurityGroups.Add(ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ProvisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkConnectionProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PrivateLinkConnectionProperties = NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties.DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
