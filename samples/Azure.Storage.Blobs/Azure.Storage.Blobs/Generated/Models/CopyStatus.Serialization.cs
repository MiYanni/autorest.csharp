// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    internal static class CopyStatusExtensions
    {
        public static string ToSerialString(this CopyStatus value) => value switch
        {
            CopyStatus.Pending => "pending",
            CopyStatus.Success => "success",
            CopyStatus.Aborted => "aborted",
            CopyStatus.Failed => "failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CopyStatus value.")
        };

        public static CopyStatus ToCopyStatus(this string value)
        {
            if (string.Equals(value, "pending", StringComparison.InvariantCultureIgnoreCase)) return CopyStatus.Pending;
            if (string.Equals(value, "success", StringComparison.InvariantCultureIgnoreCase)) return CopyStatus.Success;
            if (string.Equals(value, "aborted", StringComparison.InvariantCultureIgnoreCase)) return CopyStatus.Aborted;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return CopyStatus.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CopyStatus value.");
        }
    }
}
