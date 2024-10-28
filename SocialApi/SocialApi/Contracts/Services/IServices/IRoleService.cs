using SocialApi.Data.Models.Request.Roles;
using SocialApi.Data.Models.Response.Roles;

namespace SocialApi.Contracts.Services.IServices
{
    public interface IRoleService
    {
        Task<Guid> CreateRole(RoleCreateRequest model);
        Task EditRole(RoleEditRequest model);
        Task RemoveRole(Guid id);
        Task<List<Role>> GetRoles();
    }
}
