using System;


namespace BonsaiStore.Models
{
	public class OrderModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string Zip { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public double Total { get; set; }
		public List<ItemModel> Items { get; set; } = new List<ItemModel>();
		public DateTime OrderDate { get; set; } = DateTime.Now;


		//LATER ADD PAYMENT PROPERTIES AND ACCOUNT PROPERTIES

	}
}
