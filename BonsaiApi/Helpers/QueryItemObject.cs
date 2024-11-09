namespace BonsaiStore.Helpers
{
    public class QueryItemObject
    {
        public string OrderBy { get; set; } = "Id";
        public string Order { get; set; } = "asc";
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Tag { get; set; }
    }
}
