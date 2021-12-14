@{
  GUID = 'bc3b9317-963c-4722-8b51-903ce141e230'
  RootModule = 'Azs.Azurebridge.Admin.psm1'
  ModuleVersion = '1.0.2'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: AzureBridge Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.8'}, @{ModuleName = 'Az.Resources'; ModuleVersion = '0.12.0'})
  RequiredAssemblies = './bin/Azs.Azurebridge.Admin.private.dll'
  FormatsToProcess = './Azs.Azurebridge.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsAzureBridgeActivation', 'Get-AzsAzureBridgeDownloadedProduct', 'Get-AzsAzureBridgeProduct', 'Invoke-AzsAzureBridgeProductDownload', 'Remove-AzsAzureBridgeDownloadedProduct', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azurestack-powershell'
      ReleaseNotes = 'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell'
    }
  }
}
