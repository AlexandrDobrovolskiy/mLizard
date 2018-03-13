using System.Collections.Generic;
using mLizard.Roles.Dto;
using mLizard.Users.Dto;

namespace mLizard.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}