// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobContainersSegment
    {
        internal static BlobContainersSegment DeserializeBlobContainersSegment(XElement element)
        {
            string serviceEndpoint = default;
            string prefix = default;
            string marker = default;
            int? maxResults = default;
            string nextMarker = default;
            IReadOnlyList<BlobContainerItem> blobContainerItems = default;
            if (element.Attribute("ServiceEndpoint") is XAttribute serviceEndpointAttribute)
            {
                serviceEndpoint = (string)serviceEndpointAttribute;
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
            if (element.Element("Containers") is XElement containersElement)
            {
                var array = new List<BlobContainerItem>();
                foreach (var e in containersElement.Elements("Container"))
                {
                    array.Add(BlobContainerItem.DeserializeBlobContainerItem(e));
                }
                blobContainerItems = array;
            }
            return new BlobContainersSegment(serviceEndpoint, prefix, marker, maxResults, nextMarker, blobContainerItems);
        }
    }
}
