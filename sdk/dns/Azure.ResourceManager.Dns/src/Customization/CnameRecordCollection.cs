// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Dns.Models;

[assembly: CodeGenSuppressType("CnameRecordCollection")]

namespace Azure.ResourceManager.Dns
{
    /// <summary>
    /// A class representing a collection of <see cref="CnameRecordResource" /> and their operations.
    /// Each <see cref="CnameRecordResource" /> in the collection will belong to the same instance of <see cref="DnsZoneResource" />.
    /// To get a <see cref="CnameRecordCollection" /> instance call the GetCnameRecords method from an instance of <see cref="DnsZoneResource" />.
    /// </summary>
    public partial class CnameRecordCollection : ArmCollection, IEnumerable<CnameRecordResource>, IAsyncEnumerable<CnameRecordResource>
    {
        private readonly ClientDiagnostics _cnameRecordInfoRecordSetsClientDiagnostics;
        private readonly CnameRecordRestOperations _cnameRecordInfoRecordSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CnameRecordCollection"/> class for mocking. </summary>
        protected CnameRecordCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CnameRecordCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CnameRecordCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cnameRecordInfoRecordSetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dns", CnameRecordResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CnameRecordResource.ResourceType, out string cnameRecordInfoRecordSetsApiVersion);
            _cnameRecordInfoRecordSetsRestClient = new CnameRecordRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cnameRecordInfoRecordSetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsZoneResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsZoneResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a record set within a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CnameRecordResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cnameRecordName, CnameRecordData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cnameRecordInfoRecordSetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsArmOperation<CnameRecordResource>(Response.FromValue(new CnameRecordResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a record set within a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CnameRecordResource> CreateOrUpdate(WaitUntil waitUntil, string cnameRecordName, CnameRecordData data, ETag? ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cnameRecordInfoRecordSetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsArmOperation<CnameRecordResource>(Response.FromValue(new CnameRecordResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a record set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> is null. </exception>
        public virtual async Task<Response<CnameRecordResource>> GetAsync(string cnameRecordName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.Get");
            scope.Start();
            try
            {
                var response = await _cnameRecordInfoRecordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CnameRecordResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a record set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> is null. </exception>
        public virtual Response<CnameRecordResource> Get(string cnameRecordName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.Get");
            scope.Start();
            try
            {
                var response = _cnameRecordInfoRecordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CnameRecordResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the record sets of a specified type in a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}
        /// Operation Id: RecordSets_ListByType
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CnameRecordResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CnameRecordResource> GetAllAsync(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<CnameRecordResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cnameRecordInfoRecordSetsRestClient.ListByTypeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CnameRecordResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CnameRecordResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cnameRecordInfoRecordSetsRestClient.ListByTypeNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CnameRecordResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the record sets of a specified type in a DNS zone.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}
        /// Operation Id: RecordSets_ListByType
        /// </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CnameRecordResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CnameRecordResource> GetAll(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            Page<CnameRecordResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cnameRecordInfoRecordSetsRestClient.ListByType(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CnameRecordResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CnameRecordResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cnameRecordInfoRecordSetsRestClient.ListByTypeNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CnameRecordResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cnameRecordName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cnameRecordInfoRecordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{cnameRecordName}
        /// Operation Id: RecordSets_Get
        /// </summary>
        /// <param name="cnameRecordName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cnameRecordName"/> is null. </exception>
        public virtual Response<bool> Exists(string cnameRecordName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(cnameRecordName, nameof(cnameRecordName));

            using var scope = _cnameRecordInfoRecordSetsClientDiagnostics.CreateScope("CnameRecordCollection.Exists");
            scope.Start();
            try
            {
                var response = _cnameRecordInfoRecordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "CNAME".ToDnsRecordType(), cnameRecordName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CnameRecordResource> IEnumerable<CnameRecordResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CnameRecordResource> IAsyncEnumerable<CnameRecordResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
