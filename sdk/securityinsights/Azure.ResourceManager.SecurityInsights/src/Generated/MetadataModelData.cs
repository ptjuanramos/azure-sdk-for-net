// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the MetadataModel data model. </summary>
    public partial class MetadataModelData : ResourceData
    {
        /// <summary> Initializes a new instance of MetadataModelData. </summary>
        public MetadataModelData()
        {
            Providers = new ChangeTrackingList<string>();
            ThreatAnalysisTactics = new ChangeTrackingList<string>();
            ThreatAnalysisTechniques = new ChangeTrackingList<string>();
            PreviewImages = new ChangeTrackingList<string>();
            PreviewImagesDark = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MetadataModelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contentId"> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </param>
        /// <param name="parentId"> Full parent resource ID of the content item the metadata is for.  This is the full resource ID including the scope (subscription and resource group). </param>
        /// <param name="version"> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template best practices.  Can also be any string, but then we cannot guarantee any version checks. </param>
        /// <param name="kind"> The kind of content the metadata is for. </param>
        /// <param name="source"> Source of the content.  This is where/how it was created. </param>
        /// <param name="author"> The creator of the content item. </param>
        /// <param name="support"> Support information for the metadata - type, name, contact information. </param>
        /// <param name="dependencies"> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </param>
        /// <param name="categories"> Categories for the solution content item. </param>
        /// <param name="providers"> Providers for the solution content item. </param>
        /// <param name="firstPublishOn"> first publish date solution content item. </param>
        /// <param name="lastPublishOn"> last publish date for the solution content item. </param>
        /// <param name="customVersion"> The custom version of the content. A optional free text. </param>
        /// <param name="contentSchemaVersion"> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </param>
        /// <param name="icon"> the icon identifier. this id can later be fetched from the solution template. </param>
        /// <param name="threatAnalysisTactics"> the tactics the resource covers. </param>
        /// <param name="threatAnalysisTechniques"> the techniques the resource covers, these have to be aligned with the tactics being used. </param>
        /// <param name="previewImages"> preview image file names. These will be taken from the solution artifacts. </param>
        /// <param name="previewImagesDark"> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal MetadataModelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string contentId, string parentId, string version, SecurityInsightsKind? kind, MetadataSource source, MetadataAuthor author, MetadataSupport support, MetadataDependencies dependencies, MetadataCategories categories, IList<string> providers, DateTimeOffset? firstPublishOn, DateTimeOffset? lastPublishOn, string customVersion, string contentSchemaVersion, string icon, IList<string> threatAnalysisTactics, IList<string> threatAnalysisTechniques, IList<string> previewImages, IList<string> previewImagesDark, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ContentId = contentId;
            ParentId = parentId;
            Version = version;
            Kind = kind;
            Source = source;
            Author = author;
            Support = support;
            Dependencies = dependencies;
            Categories = categories;
            Providers = providers;
            FirstPublishOn = firstPublishOn;
            LastPublishOn = lastPublishOn;
            CustomVersion = customVersion;
            ContentSchemaVersion = contentSchemaVersion;
            Icon = icon;
            ThreatAnalysisTactics = threatAnalysisTactics;
            ThreatAnalysisTechniques = threatAnalysisTechniques;
            PreviewImages = previewImages;
            PreviewImagesDark = previewImagesDark;
            ETag = etag;
        }

        /// <summary> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </summary>
        public string ContentId { get; set; }
        /// <summary> Full parent resource ID of the content item the metadata is for.  This is the full resource ID including the scope (subscription and resource group). </summary>
        public string ParentId { get; set; }
        /// <summary> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template best practices.  Can also be any string, but then we cannot guarantee any version checks. </summary>
        public string Version { get; set; }
        /// <summary> The kind of content the metadata is for. </summary>
        public SecurityInsightsKind? Kind { get; set; }
        /// <summary> Source of the content.  This is where/how it was created. </summary>
        public MetadataSource Source { get; set; }
        /// <summary> The creator of the content item. </summary>
        public MetadataAuthor Author { get; set; }
        /// <summary> Support information for the metadata - type, name, contact information. </summary>
        public MetadataSupport Support { get; set; }
        /// <summary> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </summary>
        public MetadataDependencies Dependencies { get; set; }
        /// <summary> Categories for the solution content item. </summary>
        public MetadataCategories Categories { get; set; }
        /// <summary> Providers for the solution content item. </summary>
        public IList<string> Providers { get; }
        /// <summary> first publish date solution content item. </summary>
        public DateTimeOffset? FirstPublishOn { get; set; }
        /// <summary> last publish date for the solution content item. </summary>
        public DateTimeOffset? LastPublishOn { get; set; }
        /// <summary> The custom version of the content. A optional free text. </summary>
        public string CustomVersion { get; set; }
        /// <summary> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </summary>
        public string ContentSchemaVersion { get; set; }
        /// <summary> the icon identifier. this id can later be fetched from the solution template. </summary>
        public string Icon { get; set; }
        /// <summary> the tactics the resource covers. </summary>
        public IList<string> ThreatAnalysisTactics { get; }
        /// <summary> the techniques the resource covers, these have to be aligned with the tactics being used. </summary>
        public IList<string> ThreatAnalysisTechniques { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. </summary>
        public IList<string> PreviewImages { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </summary>
        public IList<string> PreviewImagesDark { get; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
