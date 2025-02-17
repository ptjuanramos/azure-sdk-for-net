// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The ControllerConnectionDetailsList. </summary>
    public partial class ControllerConnectionDetailsList
    {
        /// <summary> Initializes a new instance of ControllerConnectionDetailsList. </summary>
        internal ControllerConnectionDetailsList()
        {
            ConnectionDetailsList = new ChangeTrackingList<ControllerConnectionDetails>();
        }

        /// <summary> Initializes a new instance of ControllerConnectionDetailsList. </summary>
        /// <param name="connectionDetailsList"> List of Azure Dev Spaces Controller connection details. </param>
        internal ControllerConnectionDetailsList(IReadOnlyList<ControllerConnectionDetails> connectionDetailsList)
        {
            ConnectionDetailsList = connectionDetailsList;
        }

        /// <summary> List of Azure Dev Spaces Controller connection details. </summary>
        public IReadOnlyList<ControllerConnectionDetails> ConnectionDetailsList { get; }
    }
}
