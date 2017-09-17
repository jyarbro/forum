﻿using System.ComponentModel.DataAnnotations;

namespace Forum3.Models.InputModels {
	public class RegisterInput {
		[Required]
		[StringLength(64, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
		public string DisplayName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[EmailAddress]
		[Compare(nameof(Email), ErrorMessage = "The email and confirmation email do not match.")]
		public string ConfirmEmail { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}
}