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
# Configure Settings:
  1). Within the Project folder, create a builderSettings.json file. 
  
  2). Populate it with the desired configuration. Below is an example configuration:
  ```yaml
 {
    "entityNamesFilter": ["account", "contact"],
    "generateSdkMessages": true,
    "namespace": "YourNamespace",
    "serviceContextName": "ServiceContext",
    "language": "CS",
    "generateGlobalOptionSets": false,
    "emitFieldsClasses": false,
    "emitEntityETC": false,
    "emitVirtualAttributes": false,
    "logLevel": "Off",
    "entityTypesFolder": "Entities",
    "optionSetsTypesFolder": "OptionSets",
    "messagesTypesFolder": "Messages"
}
```
3). Adjust the settings as needed. For a comprehensive list of configuration options, please take a look at the [official documentation](https://learn.microsoft.com/en-us/power-platform/developer/cli/reference/modelbuilder). 

# Generate Early-Bound Classes:
  1). Open a command prompt and navigate to your project directory.

  2). Execute the following command:
  ```bash
  pac modelbuilder build --settingsTemplateFile ./builderSettings.json --outdirectory ./Entities
```
3). This command generates the early-bound classes based on your configuration and outputs them to the Entities folder.



## Run Locally

Clone the project

```bash
  git clone https://github.com/umargulzar1122/EarlyBound.git
```

Go to the project directory

Open the solution file

Restore Dependencies

### Set Startup Project (Visual Studio)

Open EarlyBound.sln

In Solution Explorer:

Right-click the D365.Plugins.ConsoleApp Project

Select "Set as Startup Project"

#### Run using:

Press F5 to start with debugging

Or Ctrl+F5 to start without debugging


