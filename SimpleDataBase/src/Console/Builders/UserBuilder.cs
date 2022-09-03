using Console.DataBaseApp.Instances;
namespace Console.Builders;

public class UserBuilder
{
    private string _userId;
    private string _userFirstName;
    private string _userLastName;

    public UserBuilder SetFirstName(string firstName)
    {

        if(string.IsNullOrEmpty(firstName))
        {
            throw new Exception("User Name should`t be not null or empty");
        }

        _userFirstName = firstName;
        _userId = GenerateId();
        return this;
    }
    public UserBuilder SetLastName(string lastName)
    {

        if( string.IsNullOrEmpty(lastName))
        {
            throw new Exception("User Name should`t be not null or empty");
        }

        _userLastName = lastName;
        return this;
    }
    private string GenerateId() => Guid.NewGuid().ToString();

    public User Build()
    {
        if(string.IsNullOrEmpty(_userId) || string.IsNullOrEmpty(_userFirstName) || string.IsNullOrEmpty(_userLastName))
        {
            throw new Exception("Invalid data for User Builder");
        }

        return new User
        {
            UserId = _userId,
            UserFirstName = _userFirstName,
            UserLastName = _userLastName
        };
    }
}