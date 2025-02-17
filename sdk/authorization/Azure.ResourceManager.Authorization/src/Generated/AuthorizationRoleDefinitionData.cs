// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the AuthorizationRoleDefinition data model. </summary>
    public partial class AuthorizationRoleDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of AuthorizationRoleDefinitionData. </summary>
        public AuthorizationRoleDefinitionData()
        {
            Permissions = new ChangeTrackingList<RoleDefinitionPermission>();
            AssignableScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AuthorizationRoleDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="description"> The role definition description. </param>
        /// <param name="roleType"> The role type. </param>
        /// <param name="permissions"> Role definition permissions. </param>
        /// <param name="assignableScopes"> Role definition assignable scopes. </param>
        internal AuthorizationRoleDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string roleName, string description, AuthorizationRoleType? roleType, IList<RoleDefinitionPermission> permissions, IList<string> assignableScopes) : base(id, name, resourceType, systemData)
        {
            RoleName = roleName;
            Description = description;
            RoleType = roleType;
            Permissions = permissions;
            AssignableScopes = assignableScopes;
        }

        /// <summary> The role name. </summary>
        public string RoleName { get; set; }
        /// <summary> The role definition description. </summary>
        public string Description { get; set; }
        /// <summary> The role type. </summary>
        public AuthorizationRoleType? RoleType { get; set; }
        /// <summary> Role definition permissions. </summary>
        public IList<RoleDefinitionPermission> Permissions { get; }
        /// <summary> Role definition assignable scopes. </summary>
        public IList<string> AssignableScopes { get; }
    }
}
