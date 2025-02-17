// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX Virtual Machines. </summary>
    internal partial class WorkloadNetworkVirtualMachinesList
    {
        /// <summary> Initializes a new instance of WorkloadNetworkVirtualMachinesList. </summary>
        internal WorkloadNetworkVirtualMachinesList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkVirtualMachineData>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkVirtualMachinesList. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal WorkloadNetworkVirtualMachinesList(IReadOnlyList<WorkloadNetworkVirtualMachineData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkVirtualMachineData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
