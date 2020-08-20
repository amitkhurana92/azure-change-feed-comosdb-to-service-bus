# Azure Comos DB change feed to Azure Service Bus using Azure Function

Change feed support in Azure Cosmos DB works by listening to an Azure Cosmos container for any changes.

Azure Functions provides the simplest way to connect to the change feed. You can create small reactive Azure Functions that will be automatically triggered on each new event in your Azure Cosmos container's change feed.

In this repository we will use the Azure service bus as output binding.

## Steps:
* When a document is modified in a cosmos container an azure function will be triggered.
* Azure function we will do the processing and extract the relevant data.
* Service bus (queue) is used for output binding and will store the relevant data.


The flow is like this

![Flow](/event-sourcing.png)

Azure ComosDB (Trigger) -> Azure Function -> Azure Service Bus (Output Binding)

## Files
* Azure Function folder contain two files
  * function.json : Contains binding. Change the value according to your database and queue configuration.
  * run.csx : Contains the code. In this we have created a custom class model that contains the variable we need to send on the queue.

Detailed explanation can be found on my blog post: https://techopaths.com/programming/binding-service-bus-to-azure-cosmosdb-change-feed/


