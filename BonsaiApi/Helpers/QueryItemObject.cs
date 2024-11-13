using BonsaiStore.Models;

namespace BonsaiStore.Helpers
{
    public class QueryItemObject
    {
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 2;
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = 0;
        public string? CategoryName { get; set; }
        public string? Tag { get; set; }
    }
}
