// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    internal partial class CreateEmailSignInUrlResponseProperties
    {
        internal static CreateEmailSignInUrlResponseProperties DeserializeCreateEmailSignInUrlResponseProperties(JsonElement element)
        {
            Optional<Uri> url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new CreateEmailSignInUrlResponseProperties(url.Value);
        }
    }
}
