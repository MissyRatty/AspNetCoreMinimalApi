using UserApi.IoC;

namespace UserApi
{
    public class Startup
    {
        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRepositories();
            services.AddServices();
            services.AddDataSources();
        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
        }
    }
}
