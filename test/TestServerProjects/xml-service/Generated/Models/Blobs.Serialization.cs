// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class Blobs
    {
        internal static Blobs DeserializeBlobs(XElement element)
        {
            Blobs result = default;
            result = new Blobs(); result.BlobPrefix = new List<BlobPrefix>();
            foreach (var e in element.Elements("BlobPrefix"))
            {
                BlobPrefix value = default;
                value = Models.BlobPrefix.DeserializeBlobPrefix(e);
                result.BlobPrefix.Add(value);
            }
            result.Blob = new List<Blob>();
            foreach (var e0 in element.Elements("Blob"))
            {
                Blob value = default;
                value = Models.Blob.DeserializeBlob(e0);
                result.Blob.Add(value);
            }
            return result;
        }
    }
}
