using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiStore.Models;

namespace BonsaiApi.DTOs.ModelDto
{
    public class CreateOrderDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string PaymentMethod { get; set; } = "Cash";
        public string ShippingMethod { get; set; } = "Standard";

        public List<ItemModel> Items { get; set; } = new List<ItemModel>();
    }
}
