using Sampekey.Model.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sampekey.Interface
{
    public interface IUserRole
    {
        Task<IEnumerable<UserRole>> GetAllUserRoles();
        Task<IEnumerable<UserRole>> FindUserRolesByUserId(string value);
        Task<IEnumerable<UserRole>> FindUserRolesByRoleId(string value);
        Task<UserRole> AddUserRole(UserRole value);
        Task<bool> DeleteUserRole(UserRole value);

    }
}
