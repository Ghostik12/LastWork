﻿using System.ComponentModel.DataAnnotations;

namespace SocialApi.Data.Models.Request.Tags
{
    public class TagCreateRequest
    {
        [Required(ErrorMessage = "Поле Название обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Название", Prompt = "Название")]
        public string? Name { get; set; }

    }
}
