// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayFirewallExclusion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable");
            writer.WriteStringValue(MatchVariable);
            writer.WritePropertyName("selectorMatchOperator");
            writer.WriteStringValue(SelectorMatchOperator);
            writer.WritePropertyName("selector");
            writer.WriteStringValue(Selector);
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayFirewallExclusion DeserializeApplicationGatewayFirewallExclusion(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayFirewallExclusion result = new NetworkInterface.Models.ApplicationGatewayFirewallExclusion();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"))
                {
                    result.MatchVariable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"))
                {
                    result.SelectorMatchOperator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selector"))
                {
                    result.Selector = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
