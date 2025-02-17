// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SupportedOSProperty
    {
        internal static SupportedOSProperty DeserializeSupportedOSProperty(JsonElement element)
        {
            Optional<string> instanceType = default;
            Optional<IReadOnlyList<SupportedOSDetails>> supportedOS = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedOs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportedOSDetails> array = new List<SupportedOSDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedOSDetails.DeserializeSupportedOSDetails(item));
                    }
                    supportedOS = array;
                    continue;
                }
            }
            return new SupportedOSProperty(instanceType.Value, Optional.ToList(supportedOS));
        }
    }
}
