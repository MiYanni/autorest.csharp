// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayAvailableSslOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (PredefinedPolicies != null)
            {
                writer.WritePropertyName("predefinedPolicies");
                writer.WriteStartArray();
                foreach (var item in PredefinedPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultPolicy != null)
            {
                writer.WritePropertyName("defaultPolicy");
                writer.WriteStringValue(DefaultPolicy.Value.ToString());
            }
            if (AvailableCipherSuites != null)
            {
                writer.WritePropertyName("availableCipherSuites");
                writer.WriteStartArray();
                foreach (var item in AvailableCipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (AvailableProtocols != null)
            {
                writer.WritePropertyName("availableProtocols");
                writer.WriteStartArray();
                foreach (var item in AvailableProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayAvailableSslOptions DeserializeApplicationGatewayAvailableSslOptions(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayAvailableSslOptions result = new NetworkInterface.Models.ApplicationGatewayAvailableSslOptions();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("predefinedPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PredefinedPolicies = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.PredefinedPolicies.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("defaultPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.DefaultPolicy = new NetworkInterface.Models.ApplicationGatewaySslPolicyName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availableCipherSuites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AvailableCipherSuites = new List<NetworkInterface.Models.ApplicationGatewaySslCipherSuite>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.AvailableCipherSuites.Add(new NetworkInterface.Models.ApplicationGatewaySslCipherSuite(item.GetString()));
                            }
                            continue;
                        }
                        if (property0.NameEquals("availableProtocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AvailableProtocols = new List<NetworkInterface.Models.ApplicationGatewaySslProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.AvailableProtocols.Add(new NetworkInterface.Models.ApplicationGatewaySslProtocol(item.GetString()));
                            }
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
