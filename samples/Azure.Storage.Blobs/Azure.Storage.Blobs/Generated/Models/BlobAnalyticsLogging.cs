// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Azure Analytics Logging settings. </summary>
    public partial class BlobAnalyticsLogging
    {
        /// <summary> Initializes a new instance of BlobAnalyticsLogging. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="delete"> Indicates whether all delete requests should be logged. </param>
        /// <param name="read"> Indicates whether all read requests should be logged. </param>
        /// <param name="write"> Indicates whether all write requests should be logged. </param>
        /// <param name="retentionPolicy"> the retention policy which determines how long the associated data should persist. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="retentionPolicy"/> is null. </exception>
        public BlobAnalyticsLogging(string version, bool delete, bool read, bool write, BlobRetentionPolicy retentionPolicy)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (retentionPolicy == null)
            {
                throw new ArgumentNullException(nameof(retentionPolicy));
            }

            Version = version;
            Delete = delete;
            Read = read;
            Write = write;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether all delete requests should be logged. </summary>
        public bool Delete { get; set; }
        /// <summary> Indicates whether all read requests should be logged. </summary>
        public bool Read { get; set; }
        /// <summary> Indicates whether all write requests should be logged. </summary>
        public bool Write { get; set; }
        /// <summary> the retention policy which determines how long the associated data should persist. </summary>
        public BlobRetentionPolicy RetentionPolicy { get; set; }
    }
}
