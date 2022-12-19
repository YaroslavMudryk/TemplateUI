﻿using System.ComponentModel.DataAnnotations;

namespace TemplateUI.Models
{
    public class LoginModel
    {
        [Required, EmailAddress]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}