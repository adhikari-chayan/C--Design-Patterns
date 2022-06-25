using TemplateMethod;

Console.Title = "Template Method";

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("3f897f3c-0e0f-446e-a9d9-6ff772e6bb8c"));

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("1fc34956-21be-41b1-9717-d9c2a9eb2899"));

EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("f5810fe3-8efc-436c-9c6b-335fed3dde4a"));


Console.ReadKey();