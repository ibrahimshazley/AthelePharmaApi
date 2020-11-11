using System.Collections.Generic;

namespace AthelePharmaERP_API.Models.Helpers
{
    public class PaginationModel<T>
    {
        public int TotalCount { get; set; }
        public List<T> Data { get; set; }
    }
}
