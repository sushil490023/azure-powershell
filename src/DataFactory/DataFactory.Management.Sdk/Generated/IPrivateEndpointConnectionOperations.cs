// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PrivateEndpointConnectionOperations operations.
    /// </summary>
    public partial interface IPrivateEndpointConnectionOperations
    {
        /// <summary>
        /// Approves or rejects a private endpoint connection
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The private endpoint connection name.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the private endpoint connection entity.  Should only be
        /// specified for update, for which it should match existing entity or
        /// can be * for unconditional update.
        /// </param>
        /// <param name='properties'>
        /// Core resource properties
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnectionResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string factoryName, string privateEndpointConnectionName, string ifMatch = default(string), PrivateLinkConnectionApprovalRequest properties = default(PrivateLinkConnectionApprovalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a private endpoint connection
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The private endpoint connection name.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// ETag of the private endpoint connection entity. Should only be
        /// specified for get. If the ETag matches the existing entity tag, or
        /// if * was provided, then no content will be returned.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnectionResource>> GetWithHttpMessagesAsync(string resourceGroupName, string factoryName, string privateEndpointConnectionName, string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a private endpoint connection
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The private endpoint connection name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string factoryName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
