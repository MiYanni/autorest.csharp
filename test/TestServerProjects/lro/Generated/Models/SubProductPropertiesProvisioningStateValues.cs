// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace lro.Models
{
    /// <summary> The SubProductPropertiesProvisioningStateValues. </summary>
    public readonly partial struct SubProductPropertiesProvisioningStateValues : IEquatable<SubProductPropertiesProvisioningStateValues>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SubProductPropertiesProvisioningStateValues"/> values are the same. </summary>
        public SubProductPropertiesProvisioningStateValues(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "canceled";
        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string CreatedValue = "Created";
        private const string UpdatingValue = "Updating";
        private const string UpdatedValue = "Updated";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string OkValue = "OK";

        /// <summary> Succeeded. </summary>
        public static SubProductPropertiesProvisioningStateValues Succeeded { get; } = new SubProductPropertiesProvisioningStateValues(SucceededValue);
        /// <summary> Failed. </summary>
        public static SubProductPropertiesProvisioningStateValues Failed { get; } = new SubProductPropertiesProvisioningStateValues(FailedValue);
        /// <summary> canceled. </summary>
        public static SubProductPropertiesProvisioningStateValues Canceled { get; } = new SubProductPropertiesProvisioningStateValues(CanceledValue);
        /// <summary> Accepted. </summary>
        public static SubProductPropertiesProvisioningStateValues Accepted { get; } = new SubProductPropertiesProvisioningStateValues(AcceptedValue);
        /// <summary> Creating. </summary>
        public static SubProductPropertiesProvisioningStateValues Creating { get; } = new SubProductPropertiesProvisioningStateValues(CreatingValue);
        /// <summary> Created. </summary>
        public static SubProductPropertiesProvisioningStateValues Created { get; } = new SubProductPropertiesProvisioningStateValues(CreatedValue);
        /// <summary> Updating. </summary>
        public static SubProductPropertiesProvisioningStateValues Updating { get; } = new SubProductPropertiesProvisioningStateValues(UpdatingValue);
        /// <summary> Updated. </summary>
        public static SubProductPropertiesProvisioningStateValues Updated { get; } = new SubProductPropertiesProvisioningStateValues(UpdatedValue);
        /// <summary> Deleting. </summary>
        public static SubProductPropertiesProvisioningStateValues Deleting { get; } = new SubProductPropertiesProvisioningStateValues(DeletingValue);
        /// <summary> Deleted. </summary>
        public static SubProductPropertiesProvisioningStateValues Deleted { get; } = new SubProductPropertiesProvisioningStateValues(DeletedValue);
        /// <summary> OK. </summary>
        public static SubProductPropertiesProvisioningStateValues Ok { get; } = new SubProductPropertiesProvisioningStateValues(OkValue);
        /// <summary> Determines if two <see cref="SubProductPropertiesProvisioningStateValues"/> values are the same. </summary>
        public static bool operator ==(SubProductPropertiesProvisioningStateValues left, SubProductPropertiesProvisioningStateValues right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubProductPropertiesProvisioningStateValues"/> values are not the same. </summary>
        public static bool operator !=(SubProductPropertiesProvisioningStateValues left, SubProductPropertiesProvisioningStateValues right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SubProductPropertiesProvisioningStateValues"/>. </summary>
        public static implicit operator SubProductPropertiesProvisioningStateValues(string value) => new SubProductPropertiesProvisioningStateValues(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubProductPropertiesProvisioningStateValues other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubProductPropertiesProvisioningStateValues other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
