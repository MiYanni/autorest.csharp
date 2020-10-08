// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs
{
    internal class BlobGetPropertiesHeaders
    {
        private readonly Response _response;
        public BlobGetPropertiesHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the blob was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Returns the date and time the blob was created. </summary>
        public DateTimeOffset? CreatedOn => _response.Headers.TryGetValue("x-ms-creation-time", out DateTimeOffset? value) ? value : null;
        public string Metadata => _response.Headers.TryGetValue("x-ms-meta", out string value) ? value : null;
        /// <summary> Optional. Only valid when Object Replication is enabled for the storage container and on the destination blob of the replication. </summary>
        public string ObjectReplicationPolicyId => _response.Headers.TryGetValue("x-ms-or-policy-id", out string value) ? value : null;
        /// <summary> Optional. Only valid when Object Replication is enabled for the storage container and on the source blob of the replication. When retrieving this header, it will return the header with the policy id and rule id (e.g. x-ms-or-policyid_ruleid), and the value will be the status of the replication (e.g. complete, failed). </summary>
        public string ObjectReplicationRules => _response.Headers.TryGetValue("x-ms-or", out string value) ? value : null;
        /// <summary> The blob&apos;s type. </summary>
        public BlobType? BlobType => _response.Headers.TryGetValue("x-ms-blob-type", out BlobType? value) ? value : null;
        /// <summary> Conclusion time of the last attempted Copy Blob operation where this blob was the destination blob. This value can specify the time of a completed, aborted, or failed copy attempt. This header does not appear if a copy is pending, if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public DateTimeOffset? CopyCompletedOn => _response.Headers.TryGetValue("x-ms-copy-completion-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Only appears when x-ms-copy-status is failed or pending. Describes the cause of the last fatal or non-fatal copy operation failure. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public string CopyStatusDescription => _response.Headers.TryGetValue("x-ms-copy-status-description", out string value) ? value : null;
        /// <summary> String identifier for this copy operation. Use with Get Blob Properties to check the status of this copy operation, or pass to Abort Copy Blob to abort a pending copy. </summary>
        public string CopyId => _response.Headers.TryGetValue("x-ms-copy-id", out string value) ? value : null;
        /// <summary> Contains the number of bytes copied and the total bytes in the source in the last attempted Copy Blob operation where this blob was the destination blob. Can show between 0 and Content-Length bytes copied. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public string CopyProgress => _response.Headers.TryGetValue("x-ms-copy-progress", out string value) ? value : null;
        /// <summary> URL up to 2 KB in length that specifies the source blob or file used in the last attempted Copy Blob operation where this blob was the destination blob. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public Uri CopySource => _response.Headers.TryGetValue("x-ms-copy-source", out Uri value) ? value : null;
        /// <summary> State of the copy operation identified by x-ms-copy-id. </summary>
        public CopyStatus? CopyStatus => _response.Headers.TryGetValue("x-ms-copy-status", out CopyStatus? value) ? value : null;
        /// <summary> Included if the blob is incremental copy blob. </summary>
        public bool? IsIncrementalCopy => _response.Headers.TryGetValue("x-ms-incremental-copy", out bool? value) ? value : null;
        /// <summary> Included if the blob is incremental copy blob or incremental copy snapshot, if x-ms-copy-status is success. Snapshot time of the last successful incremental copy snapshot for this blob. </summary>
        public string DestinationSnapshot => _response.Headers.TryGetValue("x-ms-copy-destination-snapshot", out string value) ? value : null;
        /// <summary> When a blob is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public LeaseDurationType? LeaseDuration => _response.Headers.TryGetValue("x-ms-lease-duration", out LeaseDurationType? value) ? value : null;
        /// <summary> Lease state of the blob. </summary>
        public LeaseState? LeaseState => _response.Headers.TryGetValue("x-ms-lease-state", out LeaseState? value) ? value : null;
        /// <summary> The current lease status of the blob. </summary>
        public LeaseStatus? LeaseStatus => _response.Headers.TryGetValue("x-ms-lease-status", out LeaseStatus? value) ? value : null;
        /// <summary> The number of bytes present in the response body. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> The content type specified for the blob. The default content type is &apos;application/octet-stream&apos;. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> If the blob has an MD5 hash and this operation is to read the full blob, this response header is returned so that the client can check for message content integrity. </summary>
        public byte[] ContentHash => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> This header returns the value that was specified for the Content-Encoding request header. </summary>
        public string ContentEncoding => _response.Headers.TryGetValue("Content-Encoding", out string value) ? value : null;
        /// <summary> This header returns the value that was specified for the &apos;x-ms-blob-content-disposition&apos; header. The Content-Disposition response header field conveys additional information about how to process the response payload, and also can be used to attach additional metadata. For example, if set to attachment, it indicates that the user-agent should not display the response, but instead show a Save As dialog with a filename other than the blob name specified. </summary>
        public string ContentDisposition => _response.Headers.TryGetValue("Content-Disposition", out string value) ? value : null;
        /// <summary> This header returns the value that was specified for the Content-Language request header. </summary>
        public string ContentLanguage => _response.Headers.TryGetValue("Content-Language", out string value) ? value : null;
        /// <summary> This header is returned if it was previously specified for the blob. </summary>
        public string CacheControl => _response.Headers.TryGetValue("Cache-Control", out string value) ? value : null;
        /// <summary> The current sequence number for a page blob. This header is not returned for block blobs or append blobs. </summary>
        public long? BlobSequenceNumber => _response.Headers.TryGetValue("x-ms-blob-sequence-number", out long? value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Indicates that the service supports requests for partial blob content. </summary>
        public string AcceptRanges => _response.Headers.TryGetValue("Accept-Ranges", out string value) ? value : null;
        /// <summary> The number of committed blocks present in the blob. This header is returned only for append blobs. </summary>
        public int? BlobCommittedBlockCount => _response.Headers.TryGetValue("x-ms-blob-committed-block-count", out int? value) ? value : null;
        /// <summary> The value of this header is set to true if the blob data and application metadata are completely encrypted using the specified algorithm. Otherwise, the value is set to false (when the blob is unencrypted, or if only parts of the blob/application metadata are encrypted). </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-server-encrypted", out bool? value) ? value : null;
        /// <summary> The SHA-256 hash of the encryption key used to encrypt the metadata. This header is only returned when the metadata was encrypted with a customer-provided key. </summary>
        public string EncryptionKeySha256 => _response.Headers.TryGetValue("x-ms-encryption-key-sha256", out string value) ? value : null;
        /// <summary> Returns the name of the encryption scope used to encrypt the blob contents and application metadata.  Note that the absence of this header implies use of the default account encryption scope. </summary>
        public string EncryptionScope => _response.Headers.TryGetValue("x-ms-encryption-scope", out string value) ? value : null;
        /// <summary> The tier of page blob on a premium storage account or tier of block blob on blob storage LRS accounts. For a list of allowed premium page blob tiers, see https://docs.microsoft.com/en-us/azure/virtual-machines/windows/premium-storage#features. For blob storage LRS accounts, valid values are Hot/Cool/Archive. </summary>
        public string AccessTier => _response.Headers.TryGetValue("x-ms-access-tier", out string value) ? value : null;
        /// <summary> For page blobs on a premium storage account only. If the access tier is not explicitly set on the blob, the tier is inferred based on its content length and this header will be returned with true value. </summary>
        public bool? AccessTierInferred => _response.Headers.TryGetValue("x-ms-access-tier-inferred", out bool? value) ? value : null;
        /// <summary> For blob storage LRS accounts, valid values are rehydrate-pending-to-hot/rehydrate-pending-to-cool. If the blob is being rehydrated and is not complete then this header is returned indicating that rehydrate is pending and also tells the destination tier. </summary>
        public string ArchiveStatus => _response.Headers.TryGetValue("x-ms-archive-status", out string value) ? value : null;
        /// <summary> The time the tier was changed on the object. This is only returned if the tier on the block blob was ever set. </summary>
        public DateTimeOffset? AccessTierChangedOn => _response.Headers.TryGetValue("x-ms-access-tier-change-time", out DateTimeOffset? value) ? value : null;
        /// <summary> A DateTime value returned by the service that uniquely identifies the blob. The value of this header indicates the blob version, and may be used in subsequent requests to access this version of the blob. </summary>
        public string VersionId => _response.Headers.TryGetValue("x-ms-version-id", out string value) ? value : null;
        /// <summary> The value of this header indicates whether version of this blob is a current version, see also x-ms-version-id header. </summary>
        public bool? IsCurrentVersion => _response.Headers.TryGetValue("x-ms-is-current-version", out bool? value) ? value : null;
        /// <summary> The number of tags associated with the blob. </summary>
        public long? TagCount => _response.Headers.TryGetValue("x-ms-tag-count", out long? value) ? value : null;
        /// <summary> The time this blob will expire. </summary>
        public DateTimeOffset? ExpiresOn => _response.Headers.TryGetValue("x-ms-expiry-time", out DateTimeOffset? value) ? value : null;
        /// <summary> If this blob has been sealed. </summary>
        public bool? IsSealed => _response.Headers.TryGetValue("x-ms-blob-sealed", out bool? value) ? value : null;
        /// <summary> If an object is in rehydrate pending state then this header is returned with priority of rehydrate. Valid values are High and Standard. </summary>
        public string RehydratePriority => _response.Headers.TryGetValue("x-ms-rehydrate-priority", out string value) ? value : null;
        /// <summary> UTC date/time value generated by the service that indicates the time at which the blob was last read or written to. </summary>
        public DateTimeOffset? LastAccessed => _response.Headers.TryGetValue("x-ms-last-access-time", out DateTimeOffset? value) ? value : null;
        public string ErrorCode => _response.Headers.TryGetValue("x-ms-error-code", out string value) ? value : null;
    }
}
