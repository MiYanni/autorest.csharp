// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayRequestRoutingRulePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RuleType != null)
            {
                writer.WritePropertyName("ruleType");
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Priority != null)
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (BackendAddressPool != null)
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (BackendHttpSettings != null)
            {
                writer.WritePropertyName("backendHttpSettings");
                writer.WriteObjectValue(BackendHttpSettings);
            }
            if (HttpListener != null)
            {
                writer.WritePropertyName("httpListener");
                writer.WriteObjectValue(HttpListener);
            }
            if (UrlPathMap != null)
            {
                writer.WritePropertyName("urlPathMap");
                writer.WriteObjectValue(UrlPathMap);
            }
            if (RewriteRuleSet != null)
            {
                writer.WritePropertyName("rewriteRuleSet");
                writer.WriteObjectValue(RewriteRuleSet);
            }
            if (RedirectConfiguration != null)
            {
                writer.WritePropertyName("redirectConfiguration");
                writer.WriteObjectValue(RedirectConfiguration);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayRequestRoutingRulePropertiesFormat DeserializeApplicationGatewayRequestRoutingRulePropertiesFormat(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayRequestRoutingRulePropertiesFormat result = new NetworkInterface.Models.ApplicationGatewayRequestRoutingRulePropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RuleType = new NetworkInterface.Models.ApplicationGatewayRequestRoutingRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendAddressPool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendAddressPool = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHttpSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendHttpSettings = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("httpListener"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HttpListener = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("urlPathMap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UrlPathMap = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("rewriteRuleSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RewriteRuleSet = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("redirectConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RedirectConfiguration = NetworkInterface.Models.SubResource.DeserializeSubResource(property.Value);
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
