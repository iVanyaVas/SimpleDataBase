using Console.Printer.Interfaces;
using Console.Builders;
using Console.Repositories.Interfaces;

class CreateUserFirstNamePrinter : IPrinter
{

    private readonly UserBuilder _userBuilder;

    public CreateUserFirstNamePrinter(UserBuilder userBuilder)
    {
        _userBuilder = userBuilder;
    }
    public IPrinter Action()
    {
        while (true)
        {

                try
                {
                    var firstName = ReadLine();
                    _userBuilder.SetFirstName(firstName);
                    return new CreateUserLastNamePrinter(_userBuilder);
                }
            
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }

        }
    }

    public void Show()
    {
        Clear();
        WriteLine("New id will be genereted");
        WriteLine("Please Input First Name");
    }

}