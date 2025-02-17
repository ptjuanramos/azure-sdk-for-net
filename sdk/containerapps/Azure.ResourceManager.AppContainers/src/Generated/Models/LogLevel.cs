// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Sets the log level for the Dapr sidecar. Allowed values are debug, info, warn, error. Default is info. </summary>
    public readonly partial struct LogLevel : IEquatable<LogLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfoValue = "info";
        private const string DebugValue = "debug";
        private const string WarnValue = "warn";
        private const string ErrorValue = "error";

        /// <summary> info. </summary>
        public static LogLevel Info { get; } = new LogLevel(InfoValue);
        /// <summary> debug. </summary>
        public static LogLevel Debug { get; } = new LogLevel(DebugValue);
        /// <summary> warn. </summary>
        public static LogLevel Warn { get; } = new LogLevel(WarnValue);
        /// <summary> error. </summary>
        public static LogLevel Error { get; } = new LogLevel(ErrorValue);
        /// <summary> Determines if two <see cref="LogLevel"/> values are the same. </summary>
        public static bool operator ==(LogLevel left, LogLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogLevel"/> values are not the same. </summary>
        public static bool operator !=(LogLevel left, LogLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogLevel"/>. </summary>
        public static implicit operator LogLevel(string value) => new LogLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
