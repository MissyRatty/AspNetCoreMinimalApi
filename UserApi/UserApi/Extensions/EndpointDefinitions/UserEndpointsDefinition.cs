using UserApi.Models;
using UserApi.Services;

namespace UserApi.EndpointDefinitions
{
    public static class UserEndpointsDefinition
    {
        public static void AddUserEndpoints(this WebApplication app)
        {
            app.MapGet("/api/User", GetAllUsers);

            app.MapGet("/api/User/{id}", GetUserById);

            app.MapPost("/api/User/Create", CreateUser);

            app.MapPut("/api/User/Update", UpdateUser);

            app.MapDelete("/api/User/Delete/{id}", DeleteUser);
        }

        private static IResult GetAllUsers(IUserService userService)
        {
            var users = userService.GetAllUsers();

            if (!users.Any())
            {
                return Results.NoContent();
            }

            return Results.Ok(users);
        }

        private static IResult GetUserById(IUserService userService, int id)
        {
            var user = userService.GetUser(id);

            if (user.UserId == 0)
            {
                return Results.NoContent();
            }

            return Results.Ok(user);
        }

        private static IResult UpdateUser(IUserService userService, UserModel userModel)
        {
            var userUpdated = userService.TryUpdateUser(userModel);

            if (userUpdated)
            {
                return Results.Ok();
            }

            return Results.BadRequest();
        }

        private static IResult CreateUser(IUserService userService, UserModel userModel)
        {
            var userCreated = userService.TryCreateUser(userModel);

            if (userCreated)
            {
                return Results.Ok();
            }

            return Results.BadRequest();
        }

        private static IResult DeleteUser(IUserService userService, int id)
        {
            var userDeleted = userService.TryDeleteUser(id);

            if (userDeleted)
            {
                return Results.Ok();
            }

            return Results.BadRequest();
        }
    }
}
