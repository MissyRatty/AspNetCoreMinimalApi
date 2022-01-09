using UserApi.EndpointDefinitions;

namespace UserApi.Extensions
{
    public static class EndpointHandler
    {
        public static WebApplication AddEndpoints(this WebApplication application)
        {
            //add all the individual end point definitions ?
            application.AddUserEndpoints();

            return application; 
        }
    }
}
