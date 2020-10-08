// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobContainerProperties
    {
        internal static BlobContainerProperties DeserializeBlobContainerProperties(XElement element)
        {
            DateTimeOffset lastModified = default;
            LeaseStatus? leaseStatus = default;
            LeaseState? leaseState = default;
            LeaseDurationType? leaseDuration = default;
            PublicAccessType? publicAccess = default;
            bool? hasImmutabilityPolicy = default;
            bool? hasLegalHold = default;
            string defaultEncryptionScope = default;
            bool? preventEncryptionScopeOverride = default;
            DateTimeOffset? deletedOn = default;
            int? remainingRetentionDays = default;
            string eTag = default;
            IReadOnlyDictionary<string, string> metadata = default;
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("LeaseStatus") is XElement leaseStatusElement)
            {
                leaseStatus = leaseStatusElement.Value.ToLeaseStatus();
            }
            if (element.Element("LeaseState") is XElement leaseStateElement)
            {
                leaseState = leaseStateElement.Value.ToLeaseState();
            }
            if (element.Element("LeaseDuration") is XElement leaseDurationElement)
            {
                leaseDuration = leaseDurationElement.Value.ToLeaseDurationType();
            }
            if (element.Element("PublicAccess") is XElement publicAccessElement)
            {
                publicAccess = publicAccessElement.Value.ToPublicAccessType();
            }
            if (element.Element("HasImmutabilityPolicy") is XElement hasImmutabilityPolicyElement)
            {
                hasImmutabilityPolicy = (bool?)hasImmutabilityPolicyElement;
            }
            if (element.Element("HasLegalHold") is XElement hasLegalHoldElement)
            {
                hasLegalHold = (bool?)hasLegalHoldElement;
            }
            if (element.Element("DefaultEncryptionScope") is XElement defaultEncryptionScopeElement)
            {
                defaultEncryptionScope = (string)defaultEncryptionScopeElement;
            }
            if (element.Element("DenyEncryptionScopeOverride") is XElement denyEncryptionScopeOverrideElement)
            {
                preventEncryptionScopeOverride = (bool?)denyEncryptionScopeOverrideElement;
            }
            if (element.Element("DeletedTime") is XElement deletedTimeElement)
            {
                deletedOn = deletedTimeElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("RemainingRetentionDays") is XElement remainingRetentionDaysElement)
            {
                remainingRetentionDays = (int?)remainingRetentionDaysElement;
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                eTag = (string)etagElement;
            }
            if (element.Element("Metadata") is XElement metadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in metadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                metadata = dictionary;
            }
            return new BlobContainerProperties(lastModified, leaseStatus, leaseState, leaseDuration, publicAccess, hasImmutabilityPolicy, hasLegalHold, defaultEncryptionScope, preventEncryptionScopeOverride, deletedOn, remainingRetentionDays, eTag, metadata);
        }
    }
}
