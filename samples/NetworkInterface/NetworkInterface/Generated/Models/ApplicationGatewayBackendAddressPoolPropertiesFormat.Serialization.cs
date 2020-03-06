// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayBackendAddressPoolPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (BackendIPConfigurations != null)
            {
                writer.WritePropertyName("backendIPConfigurations");
                writer.WriteStartArray();
                foreach (var item in BackendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (BackendAddresses != null)
            {
                writer.WritePropertyName("backendAddresses");
                writer.WriteStartArray();
                foreach (var item in BackendAddresses)
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
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayBackendAddressPoolPropertiesFormat DeserializeApplicationGatewayBackendAddressPoolPropertiesFormat(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayBackendAddressPoolPropertiesFormat result = new NetworkInterface.Models.ApplicationGatewayBackendAddressPoolPropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendIPConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendIPConfigurations = new List<NetworkInterface.Models.NetworkInterfaceIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BackendIPConfigurations.Add(NetworkInterface.Models.NetworkInterfaceIPConfiguration.DeserializeNetworkInterfaceIPConfiguration(item));
                    }
                    continue;
                }
                if (property.NameEquals("backendAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendAddresses = new List<NetworkInterface.Models.ApplicationGatewayBackendAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BackendAddresses.Add(NetworkInterface.Models.ApplicationGatewayBackendAddress.DeserializeApplicationGatewayBackendAddress(item));
                    }
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new NetworkInterface.Models.ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
