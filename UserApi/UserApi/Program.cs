using UserApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.UseStartup()
                 .Build()
                 .AddEndpoints();

app.Logger.LogInformation("User API Service Started.......");

app.Run();