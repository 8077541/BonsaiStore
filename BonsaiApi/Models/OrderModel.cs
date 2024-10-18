using System;


namespace BonsaiStore.Models
{
	public class OrderModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public double Total { get; set; }
		public List<ItemModel> Items { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.Now;


		//LATER ADD PAYMENT PROPERTIES AND ACCOUNT PROPERTIES

	}
}
