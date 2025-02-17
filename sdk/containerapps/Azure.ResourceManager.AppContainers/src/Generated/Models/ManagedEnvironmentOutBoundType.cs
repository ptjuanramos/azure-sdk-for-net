// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Outbound type for the cluster. </summary>
    public readonly partial struct ManagedEnvironmentOutBoundType : IEquatable<ManagedEnvironmentOutBoundType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedEnvironmentOutBoundType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedEnvironmentOutBoundType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LoadBalancerValue = "LoadBalancer";
        private const string UserDefinedRoutingValue = "UserDefinedRouting";

        /// <summary> LoadBalancer. </summary>
        public static ManagedEnvironmentOutBoundType LoadBalancer { get; } = new ManagedEnvironmentOutBoundType(LoadBalancerValue);
        /// <summary> UserDefinedRouting. </summary>
        public static ManagedEnvironmentOutBoundType UserDefinedRouting { get; } = new ManagedEnvironmentOutBoundType(UserDefinedRoutingValue);
        /// <summary> Determines if two <see cref="ManagedEnvironmentOutBoundType"/> values are the same. </summary>
        public static bool operator ==(ManagedEnvironmentOutBoundType left, ManagedEnvironmentOutBoundType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedEnvironmentOutBoundType"/> values are not the same. </summary>
        public static bool operator !=(ManagedEnvironmentOutBoundType left, ManagedEnvironmentOutBoundType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedEnvironmentOutBoundType"/>. </summary>
        public static implicit operator ManagedEnvironmentOutBoundType(string value) => new ManagedEnvironmentOutBoundType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedEnvironmentOutBoundType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedEnvironmentOutBoundType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
