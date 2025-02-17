// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> SKU size. </summary>
    public readonly partial struct SkuSize : IEquatable<SkuSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExtraSmallValue = "Extra small";
        private const string SmallValue = "Small";
        private const string MediumValue = "Medium";
        private const string LargeValue = "Large";

        /// <summary> Extra small. </summary>
        public static SkuSize ExtraSmall { get; } = new SkuSize(ExtraSmallValue);
        /// <summary> Small. </summary>
        public static SkuSize Small { get; } = new SkuSize(SmallValue);
        /// <summary> Medium. </summary>
        public static SkuSize Medium { get; } = new SkuSize(MediumValue);
        /// <summary> Large. </summary>
        public static SkuSize Large { get; } = new SkuSize(LargeValue);
        /// <summary> Determines if two <see cref="SkuSize"/> values are the same. </summary>
        public static bool operator ==(SkuSize left, SkuSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuSize"/> values are not the same. </summary>
        public static bool operator !=(SkuSize left, SkuSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuSize"/>. </summary>
        public static implicit operator SkuSize(string value) => new SkuSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
