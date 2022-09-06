using Console.Printer.Interfaces;
using Console.Repositories.Interfaces;
using Console.Builders;
using Factory = Console.Repositories.Factory;
class MainMenuPrinter : IPrinter
{
    public IPrinter Action()
    {
        var key = ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D1:
                return new ShowAllPrinter(Factory.UserRepository);
            case ConsoleKey.D2:
                return new CreateUserFirstNamePrinter(new UserBuilder());
            case ConsoleKey.D0:
                return null;
            default:
                return this;
        }
    }

    public void Show()
    {
        System.Console.Clear();
        
        WriteLine("My Simple Data Base");
        WriteLine();
        WriteLine("1 - Show Data Base");
        WriteLine("2 - Add record to Data Base");
        WriteLine("0 - Exit");

    }
}