// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace xms_error_responses.Models
{
    /// <summary> The PetActionError. </summary>
    internal partial class PetActionError
    {
        /// <summary> Initializes a new instance of PetActionError. </summary>
        internal PetActionError()
        {
        }

        /// <summary> Initializes a new instance of PetActionError. </summary>
        /// <param name="errorType"> . </param>
        /// <param name="errorMessage"> the error message. </param>
        internal PetActionError(string errorType, string errorMessage)
        {
            ErrorType = errorType;
            ErrorMessage = errorMessage;
        }

        internal string ErrorType { get; set; }
        /// <summary> the error message. </summary>
        public string ErrorMessage { get; }
    }
}