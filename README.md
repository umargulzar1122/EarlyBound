# EarlyBound
Early Bound Classes in C# for Dynamics 365 are strongly typed representations of entities in Dataverse (formerly CDS). These classes are generated using the build command  / CrmSvcUtil tool and provide compile-time checking, IntelliSense support, and better performance when interacting with Dynamics 365 data.


This repository guides generating early-bound classes for use with the Microsoft Dataverse SDK for .NET. Early-bound classes enhance development by offering:

Improved Code Readability and Maintainability: Strongly typed classes represent Dataverse entities, making code more intuitive.

# Compile-Time Type Checking: 
  Reduces runtime errors by ensuring type safety during development.
  Enhanced Developer Productivity: Utilize IntelliSense to discover tables, columns, and choice options.
  
# LINQ Query Support: 
  Leverage the OrganizationServiceContext class to write LINQ queries against Dataverse data.


# Prerequisites
  Before generating early-bound classes, ensure you have the following:

### Power Platform CLI: 
 [Install the latest version.](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction?tabs=windows#install-microsoft-power-platform-cli)  
  
### Dataverse Plug-ins: 
 [Microsoft.CrmSdk.CoreAssemblies](https://www.nuget.org/packages/microsoft.crmsdk.coreassemblies/)

### Client Applications
[Microsoft.PowerPlatform.Dataverse.Client](https://www.nuget.org/packages/Microsoft.PowerPlatform.Dataverse.Client/)
# Setup Instructions
  1). Install Power Platform CLI: Follow the official installation guide.
  
  2). Authenticate: Connect to your Dataverse environment using:
  ```bash
  pac auth create --url https://yourorg.crm.dynamics.com
```

