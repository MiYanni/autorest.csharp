// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The service error response object. </summary>
    internal partial class DataLakeStorageErrorDetails
    {
        /// <summary> Initializes a new instance of DataLakeStorageErrorDetails. </summary>
        internal DataLakeStorageErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of DataLakeStorageErrorDetails. </summary>
        /// <param name="code"> The service error code. </param>
        /// <param name="message"> The service error message. </param>
        internal DataLakeStorageErrorDetails(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> The service error code. </summary>
        public string Code { get; }
        /// <summary> The service error message. </summary>
        public string Message { get; }
    }
}
