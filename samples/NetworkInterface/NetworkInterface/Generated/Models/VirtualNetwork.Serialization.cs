// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class VirtualNetwork : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AddressSpace != null)
            {
                writer.WritePropertyName("addressSpace");
                writer.WriteObjectValue(AddressSpace);
            }
            if (DhcpOptions != null)
            {
                writer.WritePropertyName("dhcpOptions");
                writer.WriteObjectValue(DhcpOptions);
            }
            if (Subnets != null)
            {
                writer.WritePropertyName("subnets");
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (VirtualNetworkPeerings != null)
            {
                writer.WritePropertyName("virtualNetworkPeerings");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkPeerings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (EnableDdosProtection != null)
            {
                writer.WritePropertyName("enableDdosProtection");
                writer.WriteBooleanValue(EnableDdosProtection.Value);
            }
            if (EnableVmProtection != null)
            {
                writer.WritePropertyName("enableVmProtection");
                writer.WriteBooleanValue(EnableVmProtection.Value);
            }
            if (DdosProtectionPlan != null)
            {
                writer.WritePropertyName("ddosProtectionPlan");
                writer.WriteObjectValue(DdosProtectionPlan);
            }
            if (BgpCommunities != null)
            {
                writer.WritePropertyName("bgpCommunities");
                writer.WriteObjectValue(BgpCommunities);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.VirtualNetwork DeserializeVirtualNetwork(JsonElement element)
        {
            NetworkInterface.Models.VirtualNetwork result = new NetworkInterface.Models.VirtualNetwork();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Tags = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        result.Tags.Add(property0.Name, property0.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addressSpace"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AddressSpace = NetworkInterface.Models.AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dhcpOptions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DhcpOptions = NetworkInterface.Models.DhcpOptions.DeserializeDhcpOptions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subnets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Subnets = new List<NetworkInterface.Models.Subnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.Subnets.Add(NetworkInterface.Models.Subnet.DeserializeSubnet(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkPeerings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.VirtualNetworkPeerings = new List<NetworkInterface.Models.VirtualNetworkPeering>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.VirtualNetworkPeerings.Add(NetworkInterface.Models.VirtualNetworkPeering.DeserializeVirtualNetworkPeering(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ResourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ProvisioningState = new NetworkInterface.Models.ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableDdosProtection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.EnableDdosProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableVmProtection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.EnableVmProtection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ddosProtectionPlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DdosProtectionPlan = NetworkInterface.Models.SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpCommunities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.BgpCommunities = NetworkInterface.Models.VirtualNetworkBgpCommunities.DeserializeVirtualNetworkBgpCommunities(property0.Value);
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
