using Console.Printer.Interfaces;
using Console.Builders;
using Console.Repositories.Interfaces;

class CreateUserPrinter : IPrinter
{
    private readonly UserBuilder _userBuilder;
    private readonly IRepository _repository;

    public CreateUserPrinter(UserBuilder userBuilder, IRepository repository)
    {
        _userBuilder = userBuilder;
        _repository = repository;
    }
    public IPrinter Action()
    {
        try
        {
                var user = _userBuilder.Build();
                _repository.AddUser(user);

                WriteLine("User added ");
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }

        WriteLine("Press any key to proceed...");
        ReadKey();

        return new MainMenuPrinter();
    }

    public void Show()
    {
    }

}