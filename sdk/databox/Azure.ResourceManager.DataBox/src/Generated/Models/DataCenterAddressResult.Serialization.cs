// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAddressResult
    {
        internal static DataCenterAddressResult DeserializeDataCenterAddressResult(JsonElement element)
        {
            if (element.TryGetProperty("datacenterAddressType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatacenterAddressInstruction": return DataCenterAddressInstructionResult.DeserializeDataCenterAddressInstructionResult(element);
                    case "DatacenterAddressLocation": return DataCenterAddressLocationResult.DeserializeDataCenterAddressLocationResult(element);
                }
            }
            DataCenterAddressType dataCenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<AzureLocation> dataCenterAzureLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datacenterAddressType"))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownDataCenterAddressResult(dataCenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), Optional.ToNullable(dataCenterAzureLocation));
        }
    }
}
