// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class LanguageResult
    {
        internal static LanguageResult DeserializeLanguageResult(JsonElement element)
        {
            LanguageResult result = new LanguageResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Documents.Add(DocumentLanguage.DeserializeDocumentLanguage(item));
                    }
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Errors.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Statistics = RequestStatistics.DeserializeRequestStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("modelVersion"))
                {
                    result.ModelVersion = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
