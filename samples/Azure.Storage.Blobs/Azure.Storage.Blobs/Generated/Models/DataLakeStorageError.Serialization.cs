// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class DataLakeStorageError
    {
        internal static DataLakeStorageError DeserializeDataLakeStorageError(XElement element)
        {
            DataLakeStorageErrorDetails dataLakeStorageErrorDetails = default;
            if (element.Element("error") is XElement errorElement)
            {
                dataLakeStorageErrorDetails = DataLakeStorageErrorDetails.DeserializeDataLakeStorageErrorDetails(errorElement);
            }
            return new DataLakeStorageError(dataLakeStorageErrorDetails);
        }
    }
}