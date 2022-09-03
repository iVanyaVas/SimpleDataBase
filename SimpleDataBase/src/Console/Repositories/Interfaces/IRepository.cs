using System.Collections.Generic;
using Console.DataBaseApp.Instances;

namespace Console.Repositories.Interfaces;

public interface IRepository
{
    IEnumerable<User> GetAllUsers();
    void AddUser(User user);
    void DeleteUser(User user);
    void UpdateUserByName(string userName);
}