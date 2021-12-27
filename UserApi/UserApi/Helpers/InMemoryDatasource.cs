using UserApi.Dtos;

namespace UserApi.Helpers
{
    public class InMemoryDatasource : IDatasource
    {
        public IDictionary<int, UserDto> Users { get; private set; }

        public InMemoryDatasource()
        {
            Users = new Dictionary<int, UserDto>();
        }
    }
}