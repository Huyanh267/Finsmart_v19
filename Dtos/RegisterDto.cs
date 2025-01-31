﻿using System.ComponentModel.DataAnnotations;

namespace Finsmart_v19.Dtos
{
    public class RegisterDto
    {
        [Required, EmailAddress] public string Email { get; set; } = null!;
        [Required] public string Password { get; set; } = null!;
        [Required] public string ConfirmPassword { get; set; } = null!;
        [Required] public string Username { get; set; } = null!;
        [Required] public string Others { get; set; } = null!;
    }
}
