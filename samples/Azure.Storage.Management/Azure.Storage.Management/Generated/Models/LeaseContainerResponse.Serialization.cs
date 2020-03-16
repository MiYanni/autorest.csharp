// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class LeaseContainerResponse
    {
        internal static LeaseContainerResponse DeserializeLeaseContainerResponse(JsonElement element)
        {
            LeaseContainerResponse result = new LeaseContainerResponse();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("leaseId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LeaseId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("leaseTimeSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LeaseTimeSeconds = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
