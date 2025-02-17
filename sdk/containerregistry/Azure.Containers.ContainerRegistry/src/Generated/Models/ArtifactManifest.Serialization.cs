// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    public partial class ArtifactManifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static ArtifactManifest DeserializeArtifactManifest(JsonElement element)
        {
            throw new NotSupportedException("Deserialization of abstract type 'global::Azure.Containers.ContainerRegistry.Specialized.ArtifactManifest' not supported.");
        }
    }
}
