# Azure Comos DB change feed to Azure Service Bus using Azure Function

Azure Functions provides the simplest way to connect to the change feed. You can create small reactive Azure Functions that will be automatically triggered on each new event in your Azure Cosmos container's change feed.

In this repository we will use the Azure service bus as output binding.

The flow is like this

Azure ComosDB (Trigger) -> Azure Function -> Azure Service Bus (Output Binding)


