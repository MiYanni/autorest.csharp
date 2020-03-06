// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace NetworkInterface.Models
{
    /// <summary> Application Gateway protocol. </summary>
    public readonly partial struct ApplicationGatewayProtocol : IEquatable<NetworkInterface.Models.ApplicationGatewayProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewayProtocol"/> values are the same. </summary>
        public ApplicationGatewayProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "Http";
        private const string HttpsValue = "Https";

        /// <summary> Http. </summary>
        public static NetworkInterface.Models.ApplicationGatewayProtocol Http { get; } = new NetworkInterface.Models.ApplicationGatewayProtocol(HttpValue);
        /// <summary> Https. </summary>
        public static NetworkInterface.Models.ApplicationGatewayProtocol Https { get; } = new NetworkInterface.Models.ApplicationGatewayProtocol(HttpsValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayProtocol"/> values are the same. </summary>
        public static bool operator ==(NetworkInterface.Models.ApplicationGatewayProtocol left, NetworkInterface.Models.ApplicationGatewayProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayProtocol"/> values are not the same. </summary>
        public static bool operator !=(NetworkInterface.Models.ApplicationGatewayProtocol left, NetworkInterface.Models.ApplicationGatewayProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayProtocol"/>. </summary>
        public static implicit operator NetworkInterface.Models.ApplicationGatewayProtocol(string value) => new NetworkInterface.Models.ApplicationGatewayProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkInterface.Models.ApplicationGatewayProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkInterface.Models.ApplicationGatewayProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
