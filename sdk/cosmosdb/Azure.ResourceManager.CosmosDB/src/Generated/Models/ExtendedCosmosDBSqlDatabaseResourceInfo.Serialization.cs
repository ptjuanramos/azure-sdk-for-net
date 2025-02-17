// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlDatabaseResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Colls))
            {
                writer.WritePropertyName("_colls");
                writer.WriteStringValue(Colls);
            }
            if (Optional.IsDefined(Users))
            {
                writer.WritePropertyName("_users");
                writer.WriteStringValue(Users);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(DatabaseName);
            writer.WriteEndObject();
        }

        internal static ExtendedCosmosDBSqlDatabaseResourceInfo DeserializeExtendedCosmosDBSqlDatabaseResourceInfo(JsonElement element)
        {
            Optional<string> colls = default;
            Optional<string> users = default;
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_colls"))
                {
                    colls = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_users"))
                {
                    users = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ExtendedCosmosDBSqlDatabaseResourceInfo(id, colls.Value, users.Value, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }
    }
}
