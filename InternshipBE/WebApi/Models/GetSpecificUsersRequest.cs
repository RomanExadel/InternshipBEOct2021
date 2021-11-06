using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class GetSpecificUsersRequest
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        public RoleType? RoleType { get; set; }
    }
}
