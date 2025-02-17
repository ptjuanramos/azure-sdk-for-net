// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Base class for fabric specific details of container. </summary>
    internal partial class ProtectionContainerFabricSpecificDetails
    {
        /// <summary> Initializes a new instance of ProtectionContainerFabricSpecificDetails. </summary>
        internal ProtectionContainerFabricSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of ProtectionContainerFabricSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal ProtectionContainerFabricSpecificDetails(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        public string InstanceType { get; }
    }
}
