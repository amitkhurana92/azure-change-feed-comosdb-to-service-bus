#r "Microsoft.Azure.DocumentDB.Core"
using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;

public static void run(IReadOnlyList<Document> input, ILogger log,out Model outputSbMsg)
{
    outputSbMsg=null;
    if (input != null && input.Count > 0)
    {
	Model model;
        log.LogInformation("Documents modified " + input.Count);
        foreach (Document doc in input) 
        {
            log.LogInformation("Document Id " + doc.Id);
            log.LogInformation("Base Model Id " + doc.GetPropertyValue<string>("baseModelId"));
            
	    // Initializing the custom class that we need to need on queue.
	    model=new Model();
            model.id=doc.Id;
            model.baseModelId=doc.GetPropertyValue<string>("baseModelId");
	    // Assiging the class object to the queue object	
            outputSbMsg = model; 
        }
    }
}

// Custom class
public class Model{
    public string id { get; set; }
    public string baseModelId { get; set; }
}

