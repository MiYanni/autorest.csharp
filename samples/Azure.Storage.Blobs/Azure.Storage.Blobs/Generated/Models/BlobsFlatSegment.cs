// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An enumeration of blobs. </summary>
    public partial class BlobsFlatSegment
    {
        /// <summary> Initializes a new instance of BlobsFlatSegment. </summary>
        /// <param name="serviceEndpoint"> . </param>
        /// <param name="containerName"> . </param>
        /// <param name="nextMarker"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpoint"/>, <paramref name="containerName"/>, or <paramref name="nextMarker"/> is null. </exception>
        internal BlobsFlatSegment(string serviceEndpoint, string containerName, string nextMarker)
        {
            if (serviceEndpoint == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpoint));
            }
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (nextMarker == null)
            {
                throw new ArgumentNullException(nameof(nextMarker));
            }

            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            NextMarker = nextMarker;
            BlobItems = new ChangeTrackingList<BlobItemInternal>();
        }

        /// <summary> Initializes a new instance of BlobsFlatSegment. </summary>
        /// <param name="serviceEndpoint"> . </param>
        /// <param name="containerName"> . </param>
        /// <param name="prefix"> . </param>
        /// <param name="marker"> . </param>
        /// <param name="maxResults"> . </param>
        /// <param name="nextMarker"> . </param>
        /// <param name="blobItems"> . </param>
        internal BlobsFlatSegment(string serviceEndpoint, string containerName, string prefix, string marker, int? maxResults, string nextMarker, IReadOnlyList<BlobItemInternal> blobItems)
        {
            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            NextMarker = nextMarker;
            BlobItems = blobItems;
        }

        public string ServiceEndpoint { get; }
        public string ContainerName { get; }
        public string Prefix { get; }
        public string Marker { get; }
        public int? MaxResults { get; }
        public string NextMarker { get; }
        public IReadOnlyList<BlobItemInternal> BlobItems { get; }
    }
}
