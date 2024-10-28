using Microsoft.AspNetCore.Identity;

namespace SocialApi.Data.Models.Response.Roles
{
    public class Role : IdentityRole
    {
        public int? SecurityLvl { get; set; } = null;
    }
}
