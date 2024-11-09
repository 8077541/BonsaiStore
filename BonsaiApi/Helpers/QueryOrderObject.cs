using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiStore.Helpers
{
    public class QueryOrderObject
    {
        public string OrderBy { get; set; } = "Id";
        public string Order { get; set; } = "asc";
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
