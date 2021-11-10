﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class UpdateUsersFromInternshipRequest
    {
        [Required(ErrorMessage = "InternshipId is required")]
        public int InternshipId { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public string[] UserIds { get; set; }
    }
}
