// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The UnknownFrontDoorSecretProperties. </summary>
    internal partial class UnknownFrontDoorSecretProperties : FrontDoorSecretProperties
    {
        /// <summary> Initializes a new instance of UnknownFrontDoorSecretProperties. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        internal UnknownFrontDoorSecretProperties(SecretType secretType) : base(secretType)
        {
            SecretType = secretType;
        }
    }
}
