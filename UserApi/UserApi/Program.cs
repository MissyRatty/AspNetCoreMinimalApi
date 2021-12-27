using UserApi.IoC;
using UserApi.Models;
using UserApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddDataSources();



var app = builder.Build();

//logging
app.Logger.LogInformation("User API Service Started.......");


app.MapGet("/api/User", (IUserService userService) =>
{
    var users = userService.GetAllUsers();

    if(!users.Any())
    {
        return Results.NoContent();
    }

    return Results.Ok(users);
    
});


app.MapGet("/api/User/{id}", (IUserService userService, int id) =>
{
    var user = userService.GetUser(id);

    if (user.UserId == 0)
    {
        return Results.NoContent();
    }

    return Results.Ok(user);

});


app.MapPost("/api/User/Create", (IUserService userService, UserModel userModel) =>
{
    var userCreated = userService.TryCreateUser(userModel);

    if (userCreated)
    {
        return Results.Ok();
    }

    return Results.BadRequest();
});


app.MapPut("/api/User/Update", (IUserService userService, UserModel userModel) =>
{
    var userUpdated = userService.TryUpdateUser(userModel);

    if (userUpdated)
    {
        return Results.Ok();
    }

    return Results.BadRequest();
});

app.MapDelete("/api/User/Delete/{id}", (IUserService userService, int id) =>
{
    var userDeleted = userService.TryDeleteUser(id);

    if (userDeleted)
    {
        return Results.Ok();
    }

    return Results.BadRequest();
});


app.Run();