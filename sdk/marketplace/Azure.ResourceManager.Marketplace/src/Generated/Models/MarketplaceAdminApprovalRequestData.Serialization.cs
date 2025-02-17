// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class MarketplaceAdminApprovalRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId");
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId");
                writer.WriteStringValue(PublisherId);
            }
            if (Optional.IsDefined(AdminAction))
            {
                writer.WritePropertyName("adminAction");
                writer.WriteStringValue(AdminAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ApprovedPlans))
            {
                writer.WritePropertyName("approvedPlans");
                writer.WriteStartArray();
                foreach (var item in ApprovedPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Comment))
            {
                writer.WritePropertyName("comment");
                writer.WriteStringValue(Comment);
            }
            if (Optional.IsDefined(Administrator))
            {
                writer.WritePropertyName("administrator");
                writer.WriteStringValue(Administrator);
            }
            if (Optional.IsCollectionDefined(CollectionIds))
            {
                writer.WritePropertyName("collectionIds");
                writer.WriteStartArray();
                foreach (var item in CollectionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MarketplaceAdminApprovalRequestData DeserializeMarketplaceAdminApprovalRequestData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> offerId = default;
            Optional<string> displayName = default;
            Optional<string> publisherId = default;
            Optional<MarketplaceAdminAction> adminAction = default;
            Optional<IList<string>> approvedPlans = default;
            Optional<string> comment = default;
            Optional<string> administrator = default;
            Optional<IReadOnlyList<PlanRequesterDetails>> plans = default;
            Optional<IList<Guid>> collectionIds = default;
            Optional<Uri> icon = default;
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
                        if (property0.NameEquals("offerId"))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("adminAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            adminAction = new MarketplaceAdminAction(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("approvedPlans"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            approvedPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("comment"))
                        {
                            comment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administrator"))
                        {
                            administrator = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plans"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PlanRequesterDetails> array = new List<PlanRequesterDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PlanRequesterDetails.DeserializePlanRequesterDetails(item));
                            }
                            plans = array;
                            continue;
                        }
                        if (property0.NameEquals("collectionIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            collectionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("icon"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                icon = null;
                                continue;
                            }
                            icon = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MarketplaceAdminApprovalRequestData(id, name, type, systemData.Value, offerId.Value, displayName.Value, publisherId.Value, Optional.ToNullable(adminAction), Optional.ToList(approvedPlans), comment.Value, administrator.Value, Optional.ToList(plans), Optional.ToList(collectionIds), icon.Value);
        }
    }
}
