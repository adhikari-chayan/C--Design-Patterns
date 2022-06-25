using System.ComponentModel.DataAnnotations;
using ChainOfResponsibility;

Console.Title = "Chain of Responsibility";

var validDocument = new Document("How to avoid Java Development",
                                       DateTimeOffset.UtcNow,
                                       true, 
                                       true);
var invalidDocument = new Document("How to avoid Java Development", 
                                        DateTimeOffset.UtcNow, 
                                        false, 
                                        true);

var documentHandlerChain = new DocumentTitleHandler();
documentHandlerChain
    .SetSuccessor(new DocumentLastModifiedHandler())
    .SetSuccessor(new DocumentApprovedByLitigationHandler())
    .SetSuccessor(new DocumentApprovedByManagementHandler());

try
{
    documentHandlerChain.Handle(validDocument);
    
    documentHandlerChain.Handle(invalidDocument);
}
catch (ValidationException validationException)
{
    Console.WriteLine(validationException.Message);
}

Console.ReadKey();