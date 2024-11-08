using System;

namespace BonsaiStore.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public double Price { get; set; }

        public List<String> Tags { get; set; } = new List<String>();

        // Navigation properties

        public CategoryModel Category { get; set; } = new CategoryModel();
        public int CategoryId { get; set; }
    }
}
