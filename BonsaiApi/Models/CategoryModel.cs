using System;

namespace BonsaiStore.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
		public List<ItemModel> Items { get; set; } = new List<ItemModel>();
	}
}
