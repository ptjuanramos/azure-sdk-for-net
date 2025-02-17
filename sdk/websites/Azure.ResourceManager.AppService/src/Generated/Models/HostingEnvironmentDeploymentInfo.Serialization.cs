// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HostingEnvironmentDeploymentInfo
    {
        internal static HostingEnvironmentDeploymentInfo DeserializeHostingEnvironmentDeploymentInfo(JsonElement element)
        {
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new HostingEnvironmentDeploymentInfo(name.Value, Optional.ToNullable(location));
        }
    }
}
