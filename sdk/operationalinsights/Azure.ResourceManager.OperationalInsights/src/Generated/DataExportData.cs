// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary> A class representing the DataExport data model. </summary>
    public partial class DataExportData : ResourceData
    {
        /// <summary> Initializes a new instance of DataExportData. </summary>
        public DataExportData()
        {
            TableNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataExportData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dataExportId"> The data export rule ID. </param>
        /// <param name="tableNames"> An array of tables to export, for example: [“Heartbeat, SecurityEvent”]. </param>
        /// <param name="enable"> Active when enabled. </param>
        /// <param name="createdDate"> The latest data export rule modification time. </param>
        /// <param name="lastModifiedDate"> Date and time when the export was last modified. </param>
        /// <param name="resourceId"> The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure. </param>
        /// <param name="typePropertiesDestinationType"> The type of the destination resource. </param>
        /// <param name="eventHubName"> Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account. </param>
        internal DataExportData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string dataExportId, IList<string> tableNames, bool? enable, string createdDate, string lastModifiedDate, string resourceId, Type? typePropertiesDestinationType, string eventHubName) : base(id, name, resourceType, systemData)
        {
            DataExportId = dataExportId;
            TableNames = tableNames;
            Enable = enable;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            ResourceId = resourceId;
            TypePropertiesDestinationType = typePropertiesDestinationType;
            EventHubName = eventHubName;
        }

        /// <summary> The data export rule ID. </summary>
        public string DataExportId { get; set; }
        /// <summary> An array of tables to export, for example: [“Heartbeat, SecurityEvent”]. </summary>
        public IList<string> TableNames { get; }
        /// <summary> Active when enabled. </summary>
        public bool? Enable { get; set; }
        /// <summary> The latest data export rule modification time. </summary>
        public string CreatedDate { get; set; }
        /// <summary> Date and time when the export was last modified. </summary>
        public string LastModifiedDate { get; set; }
        /// <summary> The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure. </summary>
        public string ResourceId { get; set; }
        /// <summary> The type of the destination resource. </summary>
        public Type? TypePropertiesDestinationType { get; }
        /// <summary> Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account. </summary>
        public string EventHubName { get; set; }
    }
}
