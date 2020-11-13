// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobsFlatSegment
    {
        internal static BlobsFlatSegment DeserializeBlobsFlatSegment(XElement element)
        {
            string serviceEndpoint = default;
            string containerName = default;
            string prefix = default;
            string marker = default;
            int? maxResults = default;
            string nextMarker = default;
            IReadOnlyList<BlobItemInternal> blobItems = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
            }
            if (element.Attribute("ContainerName") is XAttribute containerNameAttribute)
            {
                containerName = (string)containerNameAttribute;
            }
            if (element.Element("Prefix") is XElement prefixElement)
            {
                prefix = (string)prefixElement;
            }
            if (element.Element("Marker") is XElement markerElement)
            {
                marker = (string)markerElement;
            }
            if (element.Element("MaxResults") is XElement maxResultsElement)
            {
                maxResults = (int?)maxResultsElement;
            }
            if (element.Element("NextMarker") is XElement nextMarkerElement)
            {
                nextMarker = (string)nextMarkerElement;
            }
            if (element.Element("Blobs") is XElement blobsElement)
            {
                var array = new List<BlobItemInternal>();
                foreach (var e in blobsElement.Elements("Blob"))
                {
                    array.Add(BlobItemInternal.DeserializeBlobItemInternal(e));
                }
                blobItems = array;
            }
            return new BlobsFlatSegment(serviceEndpoint, containerName, prefix, marker, maxResults, nextMarker, blobItems);
        }
    }
}