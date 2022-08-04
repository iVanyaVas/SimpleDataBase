using Console.Printer.Interfaces;

class MainMenuPrinter : IPrinter
{
    public IPrinter Action()
    {
        var key = ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D1:
                return this;
            case ConsoleKey.D2:
                return this;
            case ConsoleKey.D0:
                return null;
            default:
                return this;
        }
    }

    public void Show()
    {
        Clear();
        
        WriteLine("My Simple Data Base");
        WriteLine();
        WriteLine("1 - Show Data Base {Not Implemented}");
        WriteLine("2 - Add record to Data Base {Not Implemented}");
        WriteLine("0 - Exit");

    }
}