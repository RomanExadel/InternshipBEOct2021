using DAL.Entities.Filtering;

namespace WebApi.Models
{
    public class AGGridFilterRequest
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public IntershipFilterModel IntershipsFilterBy { get; set; }
    }
}
