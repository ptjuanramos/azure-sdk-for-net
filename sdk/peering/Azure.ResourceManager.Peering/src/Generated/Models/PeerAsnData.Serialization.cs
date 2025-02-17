// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeerAsnData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerAsn");
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsCollectionDefined(PeerContactDetail))
            {
                writer.WritePropertyName("peerContactDetail");
                writer.WriteStartArray();
                foreach (var item in PeerContactDetail)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PeerName))
            {
                writer.WritePropertyName("peerName");
                writer.WriteStringValue(PeerName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PeerAsnData DeserializePeerAsnData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> peerAsn = default;
            Optional<IList<PeerAsnContactDetail>> peerContactDetail = default;
            Optional<string> peerName = default;
            Optional<PeerAsnValidationState> validationState = default;
            Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("peerAsn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peerAsn = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerContactDetail"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PeerAsnContactDetail> array = new List<PeerAsnContactDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PeerAsnContactDetail.DeserializePeerAsnContactDetail(item));
                            }
                            peerContactDetail = array;
                            continue;
                        }
                        if (property0.NameEquals("peerName"))
                        {
                            peerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validationState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            validationState = new PeerAsnValidationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PeerAsnData(id, name, type, systemData.Value, Optional.ToNullable(peerAsn), Optional.ToList(peerContactDetail), peerName.Value, Optional.ToNullable(validationState), errorMessage.Value);
        }
    }
}
