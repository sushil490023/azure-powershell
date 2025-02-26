// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class AgentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AgentStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? _agentStatus;

        /// <summary>The Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get => this._agentStatus; }

        /// <summary>Backing field for <see cref="AgentVersion" /> property.</summary>
        private string _agentVersion;

        /// <summary>The Agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string AgentVersion { get => this._agentVersion; }

        /// <summary>Backing field for <see cref="ArcResourceId" /> property.</summary>
        private string _arcResourceId;

        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string ArcResourceId { get => this._arcResourceId; set => this._arcResourceId = value; }

        /// <summary>Backing field for <see cref="ArcVMUuid" /> property.</summary>
        private string _arcVMUuid;

        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string ArcVMUuid { get => this._arcVMUuid; set => this._arcVMUuid = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails _errorDetail;

        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AgentPropertiesErrorDetails()); }

        /// <summary>Error code reported by Agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetailsInternal)ErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetailsInternal)ErrorDetail).Code = value ?? null; }

        /// <summary>Expanded description of reported error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetailsInternal)ErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetailsInternal)ErrorDetail).Message = value ?? null; }

        /// <summary>Backing field for <see cref="LastStatusUpdate" /> property.</summary>
        private global::System.DateTime? _lastStatusUpdate;

        /// <summary>The last updated time of the Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public global::System.DateTime? LastStatusUpdate { get => this._lastStatusUpdate; }

        /// <summary>Backing field for <see cref="LocalIPAddress" /> property.</summary>
        private string _localIPAddress;

        /// <summary>Local IP address reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string LocalIPAddress { get => this._localIPAddress; }

        /// <summary>Backing field for <see cref="MemoryInMb" /> property.</summary>
        private long? _memoryInMb;

        /// <summary>Available memory reported by the Agent, in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public long? MemoryInMb { get => this._memoryInMb; }

        /// <summary>Internal Acessors for AgentStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.AgentStatus { get => this._agentStatus; set { {_agentStatus = value;} } }

        /// <summary>Internal Acessors for AgentVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.AgentVersion { get => this._agentVersion; set { {_agentVersion = value;} } }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.AgentPropertiesErrorDetails()); set { {_errorDetail = value;} } }

        /// <summary>Internal Acessors for LastStatusUpdate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.LastStatusUpdate { get => this._lastStatusUpdate; set { {_lastStatusUpdate = value;} } }

        /// <summary>Internal Acessors for LocalIPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.LocalIPAddress { get => this._localIPAddress; set { {_localIPAddress = value;} } }

        /// <summary>Internal Acessors for MemoryInMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.MemoryInMb { get => this._memoryInMb; set { {_memoryInMb = value;} } }

        /// <summary>Internal Acessors for NumberOfCore</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.NumberOfCore { get => this._numberOfCore; set { {_numberOfCore = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for UptimeInSecond</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesInternal.UptimeInSecond { get => this._uptimeInSecond; set { {_uptimeInSecond = value;} } }

        /// <summary>Backing field for <see cref="NumberOfCore" /> property.</summary>
        private long? _numberOfCore;

        /// <summary>Available compute cores reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public long? NumberOfCore { get => this._numberOfCore; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="UptimeInSecond" /> property.</summary>
        private long? _uptimeInSecond;

        /// <summary>Uptime of the Agent in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public long? UptimeInSecond { get => this._uptimeInSecond; }

        /// <summary>Creates an new <see cref="AgentProperties" /> instance.</summary>
        public AgentProperties()
        {

        }
    }
    public partial interface IAgentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>The Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Agent status.",
        SerializedName = @"agentStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get;  }
        /// <summary>The Agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Agent version.",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentVersion { get;  }
        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fully qualified resource ID of the Hybrid Compute resource for the Agent.",
        SerializedName = @"arcResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ArcResourceId { get; set; }
        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The VM UUID of the Hybrid Compute resource for the Agent.",
        SerializedName = @"arcVmUuid",
        PossibleTypes = new [] { typeof(string) })]
        string ArcVMUuid { get; set; }
        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for the Agent.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Error code reported by Agent</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error code reported by Agent",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get; set; }
        /// <summary>Expanded description of reported error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expanded description of reported error code",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get; set; }
        /// <summary>The last updated time of the Agent status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last updated time of the Agent status.",
        SerializedName = @"lastStatusUpdate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastStatusUpdate { get;  }
        /// <summary>Local IP address reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Local IP address reported by the Agent.",
        SerializedName = @"localIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string LocalIPAddress { get;  }
        /// <summary>Available memory reported by the Agent, in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available memory reported by the Agent, in MB.",
        SerializedName = @"memoryInMB",
        PossibleTypes = new [] { typeof(long) })]
        long? MemoryInMb { get;  }
        /// <summary>Available compute cores reported by the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Available compute cores reported by the Agent.",
        SerializedName = @"numberOfCores",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfCore { get;  }
        /// <summary>The provisioning state of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of this resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Uptime of the Agent in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Uptime of the Agent in seconds.",
        SerializedName = @"uptimeInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? UptimeInSecond { get;  }

    }
    internal partial interface IAgentPropertiesInternal

    {
        /// <summary>The Agent status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.AgentStatus? AgentStatus { get; set; }
        /// <summary>The Agent version.</summary>
        string AgentVersion { get; set; }
        /// <summary>The fully qualified resource ID of the Hybrid Compute resource for the Agent.</summary>
        string ArcResourceId { get; set; }
        /// <summary>The VM UUID of the Hybrid Compute resource for the Agent.</summary>
        string ArcVMUuid { get; set; }
        /// <summary>A description for the Agent.</summary>
        string Description { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IAgentPropertiesErrorDetails ErrorDetail { get; set; }
        /// <summary>Error code reported by Agent</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Expanded description of reported error code</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>The last updated time of the Agent status.</summary>
        global::System.DateTime? LastStatusUpdate { get; set; }
        /// <summary>Local IP address reported by the Agent.</summary>
        string LocalIPAddress { get; set; }
        /// <summary>Available memory reported by the Agent, in MB.</summary>
        long? MemoryInMb { get; set; }
        /// <summary>Available compute cores reported by the Agent.</summary>
        long? NumberOfCore { get; set; }
        /// <summary>The provisioning state of this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Uptime of the Agent in seconds.</summary>
        long? UptimeInSecond { get; set; }

    }
}