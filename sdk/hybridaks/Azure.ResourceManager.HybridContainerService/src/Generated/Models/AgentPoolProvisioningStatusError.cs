// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The AgentPoolProvisioningStatusError. </summary>
    public partial class AgentPoolProvisioningStatusError
    {
        /// <summary> Initializes a new instance of AgentPoolProvisioningStatusError. </summary>
        public AgentPoolProvisioningStatusError()
        {
        }

        /// <summary> Initializes a new instance of AgentPoolProvisioningStatusError. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        internal AgentPoolProvisioningStatusError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Gets or sets the code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the message. </summary>
        public string Message { get; set; }
    }
}
