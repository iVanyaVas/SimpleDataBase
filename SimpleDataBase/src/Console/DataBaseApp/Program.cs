using Console.Printer.Interfaces;
namespace Console.DataBaseApp;

class Program
{
    static void Main()
    {
        IPrinter printer = new MainMenuPrinter();

        while(printer != null)
        {
            printer.Show();
            printer = printer.Action();
        }
    }
}