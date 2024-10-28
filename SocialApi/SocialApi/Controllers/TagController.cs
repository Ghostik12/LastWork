﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialApi.Contracts.Services.IServices;
using SocialApi.Data.Models.Request.Tags;
using SocialApi.Data.Models.Response.Tags;

namespace SocialApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : Controller
    {
        private readonly ITagService _tagSerive;
        private readonly IMapper _mapper;

        public TagController(ITagService tagService, IMapper mapper)
        {
            _tagSerive = tagService;
            _mapper = mapper;
        }

        /// <summary>
        /// Получение всех тегов
        /// </summary>
        [Authorize(Roles = "Администратор")]
        [HttpGet]
        [Route("GetTags")]
        public async Task<IEnumerable<Tag>> GetTags()
        {
            var tags = await _tagSerive.GetTags();
            return tags;
        }

        /// <summary>
        /// Добавление тега
        /// </summary>
        [Authorize(Roles = "Администратор")]
        [HttpPost]
        [Route("AddTag")]
        public async Task<IActionResult> AddTag(TagCreateRequest request)
        {
            var result = await _tagSerive.CreateTag(request);
            return StatusCode(201);
        }

        /// <summary>
        /// Редактирование тега
        /// </summary>
        [Authorize(Roles = "Администратор")]
        [HttpPatch]
        [Route("EditTag")]
        public async Task<IActionResult> EditTag(TagEditRequest request)
        {
            await _tagSerive.EditTag(request);

            return StatusCode(201);
        }

        /// <summary>
        /// Удаление тега
        /// </summary>
        [Authorize(Roles = "Администратор")]
        [HttpDelete]
        [Route("RemoveTag")]
        public async Task<IActionResult> RemoveTag(Guid id)
        {
            await _tagSerive.RemoveTag(id);

            return StatusCode(201);
        }
    }
}
