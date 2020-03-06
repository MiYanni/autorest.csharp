// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace NetworkInterface.Models
{
    /// <summary> The transport protocol for the endpoint. </summary>
    public readonly partial struct TransportProtocol : IEquatable<NetworkInterface.Models.TransportProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TransportProtocol"/> values are the same. </summary>
        public TransportProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UdpValue = "Udp";
        private const string TcpValue = "Tcp";
        private const string AllValue = "All";

        /// <summary> Udp. </summary>
        public static NetworkInterface.Models.TransportProtocol Udp { get; } = new NetworkInterface.Models.TransportProtocol(UdpValue);
        /// <summary> Tcp. </summary>
        public static NetworkInterface.Models.TransportProtocol Tcp { get; } = new NetworkInterface.Models.TransportProtocol(TcpValue);
        /// <summary> All. </summary>
        public static NetworkInterface.Models.TransportProtocol All { get; } = new NetworkInterface.Models.TransportProtocol(AllValue);
        /// <summary> Determines if two <see cref="TransportProtocol"/> values are the same. </summary>
        public static bool operator ==(NetworkInterface.Models.TransportProtocol left, NetworkInterface.Models.TransportProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransportProtocol"/> values are not the same. </summary>
        public static bool operator !=(NetworkInterface.Models.TransportProtocol left, NetworkInterface.Models.TransportProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransportProtocol"/>. </summary>
        public static implicit operator NetworkInterface.Models.TransportProtocol(string value) => new NetworkInterface.Models.TransportProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkInterface.Models.TransportProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkInterface.Models.TransportProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
