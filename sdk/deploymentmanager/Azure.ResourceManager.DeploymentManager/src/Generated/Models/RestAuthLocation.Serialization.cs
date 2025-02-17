// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    internal static partial class RestAuthLocationExtensions
    {
        public static string ToSerialString(this RestAuthLocation value) => value switch
        {
            RestAuthLocation.Query => "Query",
            RestAuthLocation.Header => "Header",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestAuthLocation value.")
        };

        public static RestAuthLocation ToRestAuthLocation(this string value)
        {
            if (string.Equals(value, "Query", StringComparison.InvariantCultureIgnoreCase)) return RestAuthLocation.Query;
            if (string.Equals(value, "Header", StringComparison.InvariantCultureIgnoreCase)) return RestAuthLocation.Header;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestAuthLocation value.");
        }
    }
}
