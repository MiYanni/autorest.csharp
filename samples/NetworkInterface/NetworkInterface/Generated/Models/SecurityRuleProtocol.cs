// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace NetworkInterface.Models
{
    /// <summary> Network protocol this rule applies to. </summary>
    public readonly partial struct SecurityRuleProtocol : IEquatable<NetworkInterface.Models.SecurityRuleProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SecurityRuleProtocol"/> values are the same. </summary>
        public SecurityRuleProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "Tcp";
        private const string UdpValue = "Udp";
        private const string IcmpValue = "Icmp";
        private const string EspValue = "Esp";
        private const string AsteriskValue = "*";
        private const string AhValue = "Ah";

        /// <summary> Tcp. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Tcp { get; } = new NetworkInterface.Models.SecurityRuleProtocol(TcpValue);
        /// <summary> Udp. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Udp { get; } = new NetworkInterface.Models.SecurityRuleProtocol(UdpValue);
        /// <summary> Icmp. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Icmp { get; } = new NetworkInterface.Models.SecurityRuleProtocol(IcmpValue);
        /// <summary> Esp. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Esp { get; } = new NetworkInterface.Models.SecurityRuleProtocol(EspValue);
        /// <summary> *. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Asterisk { get; } = new NetworkInterface.Models.SecurityRuleProtocol(AsteriskValue);
        /// <summary> Ah. </summary>
        public static NetworkInterface.Models.SecurityRuleProtocol Ah { get; } = new NetworkInterface.Models.SecurityRuleProtocol(AhValue);
        /// <summary> Determines if two <see cref="SecurityRuleProtocol"/> values are the same. </summary>
        public static bool operator ==(NetworkInterface.Models.SecurityRuleProtocol left, NetworkInterface.Models.SecurityRuleProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityRuleProtocol"/> values are not the same. </summary>
        public static bool operator !=(NetworkInterface.Models.SecurityRuleProtocol left, NetworkInterface.Models.SecurityRuleProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityRuleProtocol"/>. </summary>
        public static implicit operator NetworkInterface.Models.SecurityRuleProtocol(string value) => new NetworkInterface.Models.SecurityRuleProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkInterface.Models.SecurityRuleProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkInterface.Models.SecurityRuleProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
