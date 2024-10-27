using AutoMapper;
using Social.DAL.Models.Request.Comments;
using Social.DAL.Models.Request.Posts;
using Social.DAL.Models.Request.Tags;
using Social.DAL.Models.Request.Users;
using Social.DAL.Models.Response.Comments;
using Social.DAL.Models.Response.Posts;
using Social.DAL.Models.Response.Tags;
using Social.DAL.Models.Response.Users;

namespace Social.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterRequest, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.UserName));

            CreateMap<CommentCreateRequest, Comment>();
            CreateMap<CommentEditRequest, Comment>();
            CreateMap<PostCreateRequest, Post>();
            CreateMap<PostEditViewModel, Post>();
            CreateMap<TagCreateRequest, Tag>();
            CreateMap<TagEditRequest, Tag>();
            CreateMap<UserEditRequest, User>();
        }
    }
}
