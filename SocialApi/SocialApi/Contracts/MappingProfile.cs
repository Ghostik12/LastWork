using AutoMapper;
using SocialApi.Data.Models.Request.Comments;
using SocialApi.Data.Models.Request.Posts;
using SocialApi.Data.Models.Request.Tags;
using SocialApi.Data.Models.Request.Users;
using SocialApi.Data.Models.Response.Comments;
using SocialApi.Data.Models.Response.Posts;
using SocialApi.Data.Models.Response.Tags;
using SocialApi.Data.Models.Response.Users;

namespace SocialApi.Contracts
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
            CreateMap<PostEditRequest, Post>();
            CreateMap<TagCreateRequest, Tag>();
            CreateMap<TagEditRequest, Tag>();
            CreateMap<UserEditRequest, User>();
        }
    }
}
