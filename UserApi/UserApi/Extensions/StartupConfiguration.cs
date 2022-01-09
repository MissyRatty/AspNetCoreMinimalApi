namespace UserApi.Extensions
{
    public static class StartupConfiguration
    {
        public static WebApplicationBuilder UseStartup(this WebApplicationBuilder builder)
        {
            // Create the start up class manually
            var startup = new Startup(builder.Configuration);

            // register implementations in the IoC
            startup.ConfigureServices(builder.Services);

            return builder;
        }
    }
}
