// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the TenantBillingPeriodResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="TenantBillingPeriodConsumptionResource" /> from a <see cref="ResourceIdentifier" /> with a resource type of Microsoft.Billing/billingAccounts/billingPeriods.
    /// </summary>
    public partial class TenantBillingPeriodConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantBillingPeriodConsumptionResource"/> instance. </summary>
        internal static ResourceIdentifier CreateResourceIdentifier(string billingAccountId, string billingPeriodName)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingPeriods/{billingPeriodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _balancesClientDiagnostics;
        private readonly BalancesRestOperations _balancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantBillingPeriodConsumptionResource"/> class for mocking. </summary>
        protected TenantBillingPeriodConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantBillingPeriodConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantBillingPeriodConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _balancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _balancesRestClient = new BalancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/billingPeriods";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the balances for a scope by billing period and billingAccountId. Balances are available via this API only for May 1, 2014 or later.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/balances
        /// Operation Id: Balances_GetForBillingPeriodByBillingAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConsumptionBalanceResult>> GetBalanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _balancesClientDiagnostics.CreateScope("TenantBillingPeriodConsumptionResource.GetBalance");
            scope.Start();
            try
            {
                var response = await _balancesRestClient.GetForBillingPeriodByBillingAccountAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the balances for a scope by billing period and billingAccountId. Balances are available via this API only for May 1, 2014 or later.
        /// Request Path: /providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/balances
        /// Operation Id: Balances_GetForBillingPeriodByBillingAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConsumptionBalanceResult> GetBalance(CancellationToken cancellationToken = default)
        {
            using var scope = _balancesClientDiagnostics.CreateScope("TenantBillingPeriodConsumptionResource.GetBalance");
            scope.Start();
            try
            {
                var response = _balancesRestClient.GetForBillingPeriodByBillingAccount(Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
