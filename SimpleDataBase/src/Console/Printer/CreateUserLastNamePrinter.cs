using Console.Printer.Interfaces;
using Console.Builders;
using Console.Repositories.Interfaces;
using Factory = Console.Repositories.Factory;

class CreateUserLastNamePrinter : IPrinter
{
    private readonly UserBuilder _userBuilder;

    public CreateUserLastNamePrinter(UserBuilder userBuilder)
    {
        _userBuilder = userBuilder;
    }
    public IPrinter Action()
    {
        while (true)
        {

                try
                {
                    var lastName = ReadLine();
                    _userBuilder.SetLastName(lastName);
                    return new CreateUserPrinter(_userBuilder, Factory.UserRepository);
                }
            
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }

        }
    }

    public void Show()
    {
        WriteLine("Please Input Last Name");
    }

}