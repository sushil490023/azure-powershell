// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class AzureStorageBlobContainerEndpointUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageBlobContainerEndpointUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAzureStorageBlobContainerEndpointUpdatePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdateProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdateProperties __endpointBaseUpdateProperties = new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.EndpointBaseUpdateProperties();

        /// <summary>A description for the Endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)__endpointBaseUpdateProperties).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)__endpointBaseUpdateProperties).Description = value ?? null; }

        /// <summary>The Endpoint resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.EndpointType EndpointType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)__endpointBaseUpdateProperties).EndpointType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal)__endpointBaseUpdateProperties).EndpointType = value ; }

        /// <summary>
        /// Creates an new <see cref="AzureStorageBlobContainerEndpointUpdateProperties" /> instance.
        /// </summary>
        public AzureStorageBlobContainerEndpointUpdateProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__endpointBaseUpdateProperties), __endpointBaseUpdateProperties);
            await eventListener.AssertObjectIsValid(nameof(__endpointBaseUpdateProperties), __endpointBaseUpdateProperties);
        }
    }
    public partial interface IAzureStorageBlobContainerEndpointUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdateProperties
    {

    }
    internal partial interface IAzureStorageBlobContainerEndpointUpdatePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpointBaseUpdatePropertiesInternal
    {

    }
}