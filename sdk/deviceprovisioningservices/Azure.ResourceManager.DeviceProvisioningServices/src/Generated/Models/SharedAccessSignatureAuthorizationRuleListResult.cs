// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> List of shared access keys. </summary>
    internal partial class SharedAccessSignatureAuthorizationRuleListResult
    {
        /// <summary> Initializes a new instance of SharedAccessSignatureAuthorizationRuleListResult. </summary>
        internal SharedAccessSignatureAuthorizationRuleListResult()
        {
            Value = new ChangeTrackingList<DeviceProvisioningServicesSharedAccessKey>();
        }

        /// <summary> Initializes a new instance of SharedAccessSignatureAuthorizationRuleListResult. </summary>
        /// <param name="value"> The list of shared access policies. </param>
        /// <param name="nextLink"> The next link. </param>
        internal SharedAccessSignatureAuthorizationRuleListResult(IReadOnlyList<DeviceProvisioningServicesSharedAccessKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of shared access policies. </summary>
        public IReadOnlyList<DeviceProvisioningServicesSharedAccessKey> Value { get; }
        /// <summary> The next link. </summary>
        public string NextLink { get; }
    }
}
