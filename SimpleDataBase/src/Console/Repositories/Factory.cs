using Console.Repositories.Interfaces;

using Repository = Console.Repositories.UserRepository;

namespace Console.Repositories;

public static class Factory
{
    public static readonly IRepository UserRepository = Repository.Create();
}