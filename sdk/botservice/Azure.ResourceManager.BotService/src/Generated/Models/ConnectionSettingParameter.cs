// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Extra Parameter in a Connection Setting Properties to indicate service provider specific properties. </summary>
    public partial class ConnectionSettingParameter
    {
        /// <summary> Initializes a new instance of ConnectionSettingParameter. </summary>
        public ConnectionSettingParameter()
        {
        }

        /// <summary> Initializes a new instance of ConnectionSettingParameter. </summary>
        /// <param name="key"> Key for the Connection Setting Parameter. </param>
        /// <param name="value"> Value associated with the Connection Setting Parameter. </param>
        internal ConnectionSettingParameter(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary> Key for the Connection Setting Parameter. </summary>
        public string Key { get; set; }
        /// <summary> Value associated with the Connection Setting Parameter. </summary>
        public string Value { get; set; }
    }
}
