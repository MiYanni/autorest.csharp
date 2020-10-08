// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class QuerySerialization : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "QuerySerialization");
            writer.WriteObjectValue(Format, "Format");
            writer.WriteEndElement();
        }
    }
}
