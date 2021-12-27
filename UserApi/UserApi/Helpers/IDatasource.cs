using UserApi.Dtos;

namespace UserApi.Helpers
{
    public interface IDatasource
    {
        IDictionary<int, UserDto> Users { get; }
    }
}