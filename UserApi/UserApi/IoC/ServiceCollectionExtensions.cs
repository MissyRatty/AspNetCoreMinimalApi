using UserApi.Helpers;
using UserApi.Repositories;
using UserApi.Services;

namespace UserApi.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IUserRepository, UserRepository>();
        }

        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IUserService, UserService>();
        }

        public static void AddDataSources(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDatasource, InMemoryDatasource>();
        }
    }
}
