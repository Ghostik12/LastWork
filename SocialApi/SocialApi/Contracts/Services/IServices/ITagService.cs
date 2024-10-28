﻿using SocialApi.Data.Models.Request.Tags;
using SocialApi.Data.Models.Response.Tags;

namespace SocialApi.Contracts.Services.IServices
{
    public interface ITagService
    {
        Task<Guid> CreateTag(TagCreateRequest model);
        Task EditTag(TagEditRequest model);
        Task RemoveTag(Guid id);
        Task<List<Tag>> GetTags();
    }
}