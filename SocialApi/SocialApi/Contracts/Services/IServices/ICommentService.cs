using SocialApi.Data.Models.Request.Comments;
using SocialApi.Data.Models.Response.Comments;

namespace SocialApi.Contracts.Services.IServices
{
    public interface ICommentService
    {
        Task<Guid> CreateComment(CommentCreateRequest model);
        Task<int> EditComment(CommentEditRequest model);
        Task RemoveComment(Guid id);
        Task<List<Comment>> GetComments();
    }
}
