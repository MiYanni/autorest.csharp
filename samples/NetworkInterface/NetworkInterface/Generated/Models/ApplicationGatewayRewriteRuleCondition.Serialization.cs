// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayRewriteRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Variable != null)
            {
                writer.WritePropertyName("variable");
                writer.WriteStringValue(Variable);
            }
            if (Pattern != null)
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (IgnoreCase != null)
            {
                writer.WritePropertyName("ignoreCase");
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Negate != null)
            {
                writer.WritePropertyName("negate");
                writer.WriteBooleanValue(Negate.Value);
            }
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayRewriteRuleCondition DeserializeApplicationGatewayRewriteRuleCondition(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayRewriteRuleCondition result = new NetworkInterface.Models.ApplicationGatewayRewriteRuleCondition();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("variable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreCase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IgnoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("negate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Negate = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
