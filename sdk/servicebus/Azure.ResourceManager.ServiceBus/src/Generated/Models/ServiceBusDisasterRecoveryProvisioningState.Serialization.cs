// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal static partial class ServiceBusDisasterRecoveryProvisioningStateExtensions
    {
        public static string ToSerialString(this ServiceBusDisasterRecoveryProvisioningState value) => value switch
        {
            ServiceBusDisasterRecoveryProvisioningState.Accepted => "Accepted",
            ServiceBusDisasterRecoveryProvisioningState.Succeeded => "Succeeded",
            ServiceBusDisasterRecoveryProvisioningState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusDisasterRecoveryProvisioningState value.")
        };

        public static ServiceBusDisasterRecoveryProvisioningState ToServiceBusDisasterRecoveryProvisioningState(this string value)
        {
            if (string.Equals(value, "Accepted", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusDisasterRecoveryProvisioningState.Accepted;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusDisasterRecoveryProvisioningState.Succeeded;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return ServiceBusDisasterRecoveryProvisioningState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceBusDisasterRecoveryProvisioningState value.");
        }
    }
}
