using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using mLizard.Roles.Dto;
using mLizard.Users.Dto;

namespace mLizard.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}