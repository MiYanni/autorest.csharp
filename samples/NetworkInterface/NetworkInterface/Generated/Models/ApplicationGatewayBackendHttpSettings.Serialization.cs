// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace NetworkInterface.Models
{
    public partial class ApplicationGatewayBackendHttpSettings : IUtf8JsonSerializable
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
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (CookieBasedAffinity != null)
            {
                writer.WritePropertyName("cookieBasedAffinity");
                writer.WriteStringValue(CookieBasedAffinity.Value.ToString());
            }
            if (RequestTimeout != null)
            {
                writer.WritePropertyName("requestTimeout");
                writer.WriteNumberValue(RequestTimeout.Value);
            }
            if (Probe != null)
            {
                writer.WritePropertyName("probe");
                writer.WriteObjectValue(Probe);
            }
            if (AuthenticationCertificates != null)
            {
                writer.WritePropertyName("authenticationCertificates");
                writer.WriteStartArray();
                foreach (var item in AuthenticationCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TrustedRootCertificates != null)
            {
                writer.WritePropertyName("trustedRootCertificates");
                writer.WriteStartArray();
                foreach (var item in TrustedRootCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ConnectionDraining != null)
            {
                writer.WritePropertyName("connectionDraining");
                writer.WriteObjectValue(ConnectionDraining);
            }
            if (HostName != null)
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (PickHostNameFromBackendAddress != null)
            {
                writer.WritePropertyName("pickHostNameFromBackendAddress");
                writer.WriteBooleanValue(PickHostNameFromBackendAddress.Value);
            }
            if (AffinityCookieName != null)
            {
                writer.WritePropertyName("affinityCookieName");
                writer.WriteStringValue(AffinityCookieName);
            }
            if (ProbeEnabled != null)
            {
                writer.WritePropertyName("probeEnabled");
                writer.WriteBooleanValue(ProbeEnabled.Value);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
        internal static NetworkInterface.Models.ApplicationGatewayBackendHttpSettings DeserializeApplicationGatewayBackendHttpSettings(JsonElement element)
        {
            NetworkInterface.Models.ApplicationGatewayBackendHttpSettings result = new NetworkInterface.Models.ApplicationGatewayBackendHttpSettings();
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
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Protocol = new NetworkInterface.Models.ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cookieBasedAffinity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.CookieBasedAffinity = new NetworkInterface.Models.ApplicationGatewayCookieBasedAffinity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestTimeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.RequestTimeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Probe = NetworkInterface.Models.SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authenticationCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AuthenticationCertificates = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.AuthenticationCertificates.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("trustedRootCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.TrustedRootCertificates = new List<NetworkInterface.Models.SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                result.TrustedRootCertificates.Add(NetworkInterface.Models.SubResource.DeserializeSubResource(item));
                            }
                            continue;
                        }
                        if (property0.NameEquals("connectionDraining"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ConnectionDraining = NetworkInterface.Models.ApplicationGatewayConnectionDraining.DeserializeApplicationGatewayConnectionDraining(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.HostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.PickHostNameFromBackendAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("affinityCookieName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.AffinityCookieName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("probeEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.ProbeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("path"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            result.Path = property0.Value.GetString();
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
                    }
                    continue;
                }
            }
            return result;
        }
    }
}
