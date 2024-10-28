using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialApi.Data.Models.Response.Comments;
using SocialApi.Data.Models.Response.Posts;
using SocialApi.Data.Models.Response.Tags;
using SocialApi.Data.Models.Response.Roles;
using SocialApi.Data.Models.Response.Users;

namespace SocialApi.Data
{
    public class BlogDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
