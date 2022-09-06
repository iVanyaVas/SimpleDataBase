using System.Collections.Generic;
using Console.Repositories.Interfaces;
using Console.DataBaseApp.Instances;
using Newtonsoft.Json;
using Console.Builders;
using System.IO;
namespace Console.Repositories;

public class UserRepository : IRepository
{
    private const string FileName = "data.json";
    private IList<User> _users = new List<User>();

    private UserRepository(IList<User> users)
    {
        _users = users;
    }
    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }
    public void AddUser(User user)
    {
        _users.Add(user);
        var serialized = Serialize();
        WriteToFile(serialized);
    }
    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }
    public void UpdateUserByName(string userName)
    {
        throw new NotImplementedException();
    }

    public static UserRepository Create()
    {
        IList<User> users;
        if (!File.Exists(FileName))
		{
			users = new List<User>();
		}
        else
		{
			var serialized = File.ReadAllText(FileName);
			users = JsonConvert.DeserializeObject<IList<User>>(serialized);
		}

        return new UserRepository(users);
    }
    string Serialize()=> JsonConvert.SerializeObject(_users);
    void WriteToFile(string serialized)=>File.WriteAllText(FileName, serialized);

}