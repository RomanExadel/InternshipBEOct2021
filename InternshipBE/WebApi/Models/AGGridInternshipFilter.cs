using DAL.Entities.Filtering;
using Shared.Models;

namespace WebApi.Models
{
    public class AGGridInternshipsFilter : AGGridBaseRequest
    {
        public IntershipFilterModel IntershipsFilterBy { get; set; }
    }
}
