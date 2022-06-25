using Proxy;

Console.Title = "Proxy";
//Without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

Console.WriteLine();

//with proxy
Console.WriteLine("Constructing document proxy.");
var myDocumentProxy = new DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed");
myDocumentProxy.DisplayDocument();

//with chained proxy
Console.WriteLine("Constructing protected document proxy.");
var myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed");
myProtectedDocumentProxy.DisplayDocument();

//with chained proxy, no access
Console.WriteLine("Constructing protected document proxy.");
myProtectedDocumentProxy = new ProtectedDocumentProxy("MyDocument.pdf", "AnotherRole");
Console.WriteLine("Protected document proxy constructed");
myProtectedDocumentProxy.DisplayDocument();

Console.ReadLine();