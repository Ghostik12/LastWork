using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Social.DAL.Models.Response.Comments;
using Social.DAL.Models.Response.Posts;
using Social.DAL.Models.Response.Roles;
using Social.DAL.Models.Response.Tags;
using Social.DAL.Models.Response.Users;

namespace Social.DAL
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
