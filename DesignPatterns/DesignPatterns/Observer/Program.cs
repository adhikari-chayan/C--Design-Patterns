using Observer;

Console.Title = "Observer";

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

orderService.CompleteTicketSale(1,2);

orderService.RemoveObserver(ticketResellerService);

orderService.CompleteTicketSale(2,4);

Console.ReadKey();