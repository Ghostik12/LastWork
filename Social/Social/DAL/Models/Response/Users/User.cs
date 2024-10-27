using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using Social.DAL.Models.Response.Posts;
using Social.DAL.Models.Response.Roles;
using System.Data;

namespace Social.DAL.Models.Response.Users
{
    public class User : IdentityUser
    {
        //Id, FirstName, LastName, UserName, Email -> распологаются в классе родителя

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedData { get; set; } = DateTime.Now;

        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Role> Roles { get; set; } = new List<Role>();
    }
}
