using Memento;

Console.Title = "Memento";

CommandManager commandManager = new();
IEmployeeManagerRepository employeeManagerRepository = new EmployeeManagerRepository();

commandManager.Invoke(new AddEmployeeToManagerList(employeeManagerRepository, 1, new Employee(111, "Kevin")));

employeeManagerRepository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerList(employeeManagerRepository, 1, new Employee(222, "Clara")));

employeeManagerRepository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerList(employeeManagerRepository, 2, new Employee(333, "Tom")));

employeeManagerRepository.WriteDataStore();