// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayRedirectConfiguration : IUtf8JsonSerializable
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
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (RedirectType != null)
            {
                writer.WritePropertyName("redirectType");
                writer.WriteStringValue(RedirectType.Value.ToString());
            }
            if (TargetListener != null)
            {
                writer.WritePropertyName("targetListener");
                writer.WriteObjectValue(TargetListener);
            }
            if (TargetUrl != null)
            {
                writer.WritePropertyName("targetUrl");
                writer.WriteStringValue(TargetUrl);
            }
            if (IncludePath != null)
            {
                writer.WritePropertyName("includePath");
                writer.WriteBooleanValue(IncludePath.Value);
            }
            if (IncludeQueryString != null)
            {
                writer.WritePropertyName("includeQueryString");
                writer.WriteBooleanValue(IncludeQueryString.Value);
            }
            if (RequestRoutingRules != null)
            {
                writer.WritePropertyName("requestRoutingRules");
                writer.WriteStartArray();
                foreach (var item in RequestRoutingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UrlPathMaps != null)
            {
                writer.WritePropertyName("urlPathMaps");
                writer.WriteStartArray();
                foreach (var item in UrlPathMaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PathRules != null)
            {
                writer.WritePropertyName("pathRules");
                writer.WriteStartArray();
                foreach (var item in PathRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayRedirectConfiguration DeserializeApplicationGatewayRedirectConfiguration(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayRedirectConfiguration result = new NetworkInterface.Models.ApplicationGatewayRedirectConfiguration();
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
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Type = property.Value.GetString();
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
                        if (property0.NameEquals("redirectType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RedirectType = new NetworkInterface.Models.ApplicationGatewayRedirectType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetListener"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.TargetListener = NetworkInterface.Models.SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("targetUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.TargetUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("includePath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.IncludePath = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("includeQueryString"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.IncludeQueryString = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requestRoutingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RequestRoutingRules = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.RequestRoutingRules.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("urlPathMaps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.UrlPathMaps = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.UrlPathMaps.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("pathRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PathRules = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.PathRules.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
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
