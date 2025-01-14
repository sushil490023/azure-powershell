
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for NetworkInterfaceIPConfiguration
.Description
Create a in-memory object for NetworkInterfaceIPConfiguration
.Example
PS C:\> New-AzConnectedNetworkInterfaceIPConfigurationObject -IPAllocationMethod "Dynamic" -IPVersion "IPv4"

DnsServer Gateway IPAddress IPAllocationMethod IPVersion Subnet
--------- ------- --------- ------------------ --------- ------
                            Dynamic            IPv4

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterfaceIPConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.ConnectedNetwork/new-AzConnectedNetworkInterfaceIPConfigurationObject
#>
function New-AzConnectedNetworkInterfaceIPConfigurationObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkInterfaceIPConfiguration])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [System.String[]]
    # The list of DNS servers IP addresses.
    ${DnsServer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [System.String]
    # The value of the gateway.
    ${Gateway},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [System.String]
    # The value of the IP address.
    ${IPAddress},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.IPAllocationMethod]
    # IP address allocation method.
    ${IPAllocationMethod},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.IPVersion]
    # IP address version.
    ${IPVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Body')]
    [System.String]
    # The value of the subnet.
    ${Subnet}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.ConnectedNetwork.custom\New-AzConnectedNetworkInterfaceIPConfigurationObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
