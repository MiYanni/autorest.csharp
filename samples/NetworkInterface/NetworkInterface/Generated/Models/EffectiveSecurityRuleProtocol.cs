// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace NetworkInterface.Models
{
    /// <summary> The network protocol this rule applies to. </summary>
    public readonly partial struct EffectiveSecurityRuleProtocol : IEquatable<NetworkInterface.Models.EffectiveSecurityRuleProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EffectiveSecurityRuleProtocol"/> values are the same. </summary>
        public EffectiveSecurityRuleProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "Tcp";
        private const string UdpValue = "Udp";
        private const string AllValue = "All";

        /// <summary> Tcp. </summary>
        public static NetworkInterface.Models.EffectiveSecurityRuleProtocol Tcp { get; } = new NetworkInterface.Models.EffectiveSecurityRuleProtocol(TcpValue);
        /// <summary> Udp. </summary>
        public static NetworkInterface.Models.EffectiveSecurityRuleProtocol Udp { get; } = new NetworkInterface.Models.EffectiveSecurityRuleProtocol(UdpValue);
        /// <summary> All. </summary>
        public static NetworkInterface.Models.EffectiveSecurityRuleProtocol All { get; } = new NetworkInterface.Models.EffectiveSecurityRuleProtocol(AllValue);
        /// <summary> Determines if two <see cref="EffectiveSecurityRuleProtocol"/> values are the same. </summary>
        public static bool operator ==(NetworkInterface.Models.EffectiveSecurityRuleProtocol left, NetworkInterface.Models.EffectiveSecurityRuleProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EffectiveSecurityRuleProtocol"/> values are not the same. </summary>
        public static bool operator !=(NetworkInterface.Models.EffectiveSecurityRuleProtocol left, NetworkInterface.Models.EffectiveSecurityRuleProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EffectiveSecurityRuleProtocol"/>. </summary>
        public static implicit operator NetworkInterface.Models.EffectiveSecurityRuleProtocol(string value) => new NetworkInterface.Models.EffectiveSecurityRuleProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkInterface.Models.EffectiveSecurityRuleProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkInterface.Models.EffectiveSecurityRuleProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
