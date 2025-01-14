// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Communication.Models;

namespace Azure.ResourceManager.Communication
{
    /// <summary> The CommunicationService service client. </summary>
    public partial class CommunicationServiceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal CommunicationServiceRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of CommunicationServiceOperations for mocking. </summary>
        protected CommunicationServiceOperations()
        {
        }

        /// <summary> Initializes a new instance of CommunicationServiceOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Gets subscription ID which uniquely identifies the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal CommunicationServiceOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-08-20-preview")
        {
            RestClient = new CommunicationServiceRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Links an Azure Notification Hub to this communication service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="linkNotificationHubParameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkedNotificationHub>> LinkNotificationHubAsync(string resourceGroupName, string communicationServiceName, LinkNotificationHubParameters linkNotificationHubParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.LinkNotificationHub");
            scope.Start();
            try
            {
                return await RestClient.LinkNotificationHubAsync(resourceGroupName, communicationServiceName, linkNotificationHubParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Links an Azure Notification Hub to this communication service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="linkNotificationHubParameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkedNotificationHub> LinkNotificationHub(string resourceGroupName, string communicationServiceName, LinkNotificationHubParameters linkNotificationHubParameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.LinkNotificationHub");
            scope.Start();
            try
            {
                return RestClient.LinkNotificationHub(resourceGroupName, communicationServiceName, linkNotificationHubParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to update an existing CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CommunicationServiceResource>> UpdateAsync(string resourceGroupName, string communicationServiceName, TaggedResource parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, communicationServiceName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to update an existing CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CommunicationServiceResource> Update(string resourceGroupName, string communicationServiceName, TaggedResource parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, communicationServiceName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the CommunicationService and its properties. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CommunicationServiceResource>> GetAsync(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, communicationServiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the CommunicationService and its properties. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CommunicationServiceResource> Get(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, communicationServiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the access keys of the CommunicationService resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CommunicationServiceKeys>> ListKeysAsync(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListKeys");
            scope.Start();
            try
            {
                return await RestClient.ListKeysAsync(resourceGroupName, communicationServiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the access keys of the CommunicationService resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CommunicationServiceKeys> ListKeys(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListKeys");
            scope.Start();
            try
            {
                return RestClient.ListKeys(resourceGroupName, communicationServiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate CommunicationService access key. PrimaryKey and SecondaryKey cannot be regenerated at the same time. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameter that describes the Regenerate Key Operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CommunicationServiceKeys>> RegenerateKeyAsync(string resourceGroupName, string communicationServiceName, RegenerateKeyParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.RegenerateKey");
            scope.Start();
            try
            {
                return await RestClient.RegenerateKeyAsync(resourceGroupName, communicationServiceName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate CommunicationService access key. PrimaryKey and SecondaryKey cannot be regenerated at the same time. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameter that describes the Regenerate Key Operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CommunicationServiceKeys> RegenerateKey(string resourceGroupName, string communicationServiceName, RegenerateKeyParameters parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.RegenerateKey");
            scope.Start();
            try
            {
                return RestClient.RegenerateKey(resourceGroupName, communicationServiceName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Handles requests to list all resources in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<CommunicationServiceResource> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CommunicationServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunicationServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Handles requests to list all resources in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<CommunicationServiceResource> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<CommunicationServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunicationServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<CommunicationServiceResource> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<CommunicationServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CommunicationServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Handles requests to list all resources in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<CommunicationServiceResource> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<CommunicationServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CommunicationServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create a new CommunicationService or update an existing CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="communicationServiceName"/> is null. </exception>
        public virtual async Task<CommunicationServiceCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string communicationServiceName, CommunicationServiceResource parameters = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, communicationServiceName, parameters, cancellationToken).ConfigureAwait(false);
                return new CommunicationServiceCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, communicationServiceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new CommunicationService or update an existing CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="communicationServiceName"/> is null. </exception>
        public virtual CommunicationServiceCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string communicationServiceName, CommunicationServiceResource parameters = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, communicationServiceName, parameters, cancellationToken);
                return new CommunicationServiceCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, communicationServiceName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to delete a CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="communicationServiceName"/> is null. </exception>
        public virtual async Task<CommunicationServiceDeleteOperation> StartDeleteAsync(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, communicationServiceName, cancellationToken).ConfigureAwait(false);
                return new CommunicationServiceDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, communicationServiceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to delete a CommunicationService. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="communicationServiceName"> The name of the CommunicationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="communicationServiceName"/> is null. </exception>
        public virtual CommunicationServiceDeleteOperation StartDelete(string resourceGroupName, string communicationServiceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (communicationServiceName == null)
            {
                throw new ArgumentNullException(nameof(communicationServiceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CommunicationServiceOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, communicationServiceName, cancellationToken);
                return new CommunicationServiceDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, communicationServiceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
