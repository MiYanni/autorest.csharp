// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SuggestRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (UseFuzzyMatching != null)
            {
                writer.WritePropertyName("fuzzy");
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (OrderBy != null)
            {
                writer.WritePropertyName("orderby");
                writer.WriteStringValue(OrderBy);
            }
            if (SearchText != null)
            {
                writer.WritePropertyName("search");
                writer.WriteStringValue(SearchText);
            }
            if (SearchFields != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFields);
            }
            if (Select != null)
            {
                writer.WritePropertyName("select");
                writer.WriteStringValue(Select);
            }
            if (SuggesterName != null)
            {
                writer.WritePropertyName("suggesterName");
                writer.WriteStringValue(SuggesterName);
            }
            if (Top != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Top.Value);
            }
            writer.WriteEndObject();
        }
    }
}
