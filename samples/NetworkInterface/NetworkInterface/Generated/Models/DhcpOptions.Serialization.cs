// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class DhcpOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DnsServers != null)
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.DhcpOptions DeserializeDhcpOptions(JsonElement element)
        {
            NetworkInterface.Models.DhcpOptions result = new NetworkInterface.Models.DhcpOptions();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.DnsServers = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.DnsServers.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
