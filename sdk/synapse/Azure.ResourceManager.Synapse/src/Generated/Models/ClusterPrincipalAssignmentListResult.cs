// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto cluster principal assignments operation response. </summary>
    internal partial class ClusterPrincipalAssignmentListResult
    {
        /// <summary> Initializes a new instance of ClusterPrincipalAssignmentListResult. </summary>
        internal ClusterPrincipalAssignmentListResult()
        {
            Value = new ChangeTrackingList<ClusterPrincipalAssignmentData>();
        }

        /// <summary> Initializes a new instance of ClusterPrincipalAssignmentListResult. </summary>
        /// <param name="value"> The list of Kusto cluster principal assignments. </param>
        internal ClusterPrincipalAssignmentListResult(IReadOnlyList<ClusterPrincipalAssignmentData> value)
        {
            Value = value;
        }

        /// <summary> The list of Kusto cluster principal assignments. </summary>
        public IReadOnlyList<ClusterPrincipalAssignmentData> Value { get; }
    }
}
