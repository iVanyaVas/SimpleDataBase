using Console.Printer.Interfaces;
using Console.Repositories.Interfaces;
 class ShowAllPrinter: IPrinter
{
    private readonly IRepository _repository;

    public ShowAllPrinter(IRepository repository)
    {
        _repository = repository;
    }
    public IPrinter Action()
    {
        ReadKey();
        return new MainMenuPrinter();
    }

    public void Show()
    {
        Clear();

        WriteLine("{0,-50} {1,-25} {2,-25}", "ID", "First Name", "Last Name");
        WriteLine("--------------------------------------------------------------------------------------------");
        foreach(var user in _repository.GetAllUsers())
        {
            WriteLine("{0,-50} {1,-25} {2,-25}", user.UserId, user.UserFirstName, user.UserLastName);
        }
        WriteLine("--------------------------------------------------------------------------------------------");
        WriteLine("Press ane key to continue...");
    }

}