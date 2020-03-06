// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Management.Models
{
    internal static class KeyPermissionExtensions
    {
        public static string ToSerialString(this KeyPermission value) => value switch
        {
            KeyPermission.Read => "Read",
            KeyPermission.Full => "Full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.")
        };

        public static KeyPermission ToKeyPermission(this string value) => value switch
        {
            "Read" => KeyPermission.Read,
            "Full" => KeyPermission.Full,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.")
        };
    }
}