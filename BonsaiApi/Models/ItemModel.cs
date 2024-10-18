using System;


namespace BonsaiStore.Models

{
	public class ItemModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public double Price { get; set; }

		public List<String> Tags { get; set; }

		// Navigation properties

		public CategoryModel Category { get; set; }
		public int CategoryId { get; set; }


	}
}
