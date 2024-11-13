using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiStore.Helpers
{
    public class QueryOrderObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 2;
    }
}
