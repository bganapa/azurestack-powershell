---
external help file:
Module Name: Azs.ContainerRegistry.Admin
online version: https://docs.microsoft.com/en-us/powershell/module/azs.containerregistry.admin/start-azscontainerregistrysetup
schema: 2.0.0
---

# Start-AzsContainerRegistrySetup

## SYNOPSIS
Invokes container registry certificate uploading and service deployment.

## SYNTAX

### StartExpanded (Default)
```
Start-AzsContainerRegistrySetup [-Location <String>] [-SubscriptionId <String>] [-Password <SecureString>]
 [-SslCertInputFile <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Start
```
Start-AzsContainerRegistrySetup -StartSetupRequest <IContainerRegistrySetupProperty> [-Location <String>]
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StartViaIdentity
```
Start-AzsContainerRegistrySetup -InputObject <IContainerRegistryAdminIdentity>
 -StartSetupRequest <IContainerRegistrySetupProperty> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### StartViaIdentityExpanded
```
Start-AzsContainerRegistrySetup -InputObject <IContainerRegistryAdminIdentity> [-Password <SecureString>]
 [-SslCertInputFile <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invokes container registry certificate uploading and service deployment.

## EXAMPLES

### Example 1: Start Azs ContainerRegistry Setup
```powershell
PS C:\> Start-AzsContainerRegistrySetup -Password $password -SslCertInputFile $pfx_cert_path

```

Invokes container registry certificate uploading and service deployment.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.IContainerRegistryAdminIdentity
Parameter Sets: StartViaIdentity, StartViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Location
The name of Azure region.

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzLocation)[0].Location
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
Ssl certificate password.

```yaml
Type: System.Security.SecureString
Parameter Sets: StartExpanded, StartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SslCertInputFile
Input File for SslCert (Ssl certificate in base64 format.)

```yaml
Type: System.String
Parameter Sets: StartExpanded, StartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartSetupRequest
Container registry setup properties.
To construct, see NOTES section for STARTSETUPREQUEST properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetupProperty
Parameter Sets: Start, StartViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetupProperty

### Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.IContainerRegistryAdminIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Models.Api20191101Preview.IContainerRegistrySetup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IContainerRegistryAdminIdentity>: Identity Parameter
  - `[CapacityName <String>]`: The name of the capacity parameter.
  - `[ConfigurationName <String>]`: The name of the configuration.
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: The name of Azure region.
  - `[QuotaName <String>]`: The name of the container registry quota.
  - `[SubscriptionId <String>]`: The ID of the target subscription.

STARTSETUPREQUEST <IContainerRegistrySetupProperty>: Container registry setup properties.
  - `[Password <SecureString>]`: Ssl certificate password.
  - `[SslCertBase64 <Byte[]>]`: Ssl certificate in base64 format.

## RELATED LINKS

