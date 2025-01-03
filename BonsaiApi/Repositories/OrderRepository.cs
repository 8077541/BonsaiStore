using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiStore.Data;
using BonsaiStore.Helpers;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BonsaiApi.Repositories
{
    public class OrderRepository(ApplicationDbContext context) : IOrderRepository
    {
        private readonly ApplicationDbContext _context = context;

        public Task<OrderModel> CreateOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> DeleteOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> GetAllOrders(QueryOrderObject query)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetOrder(QueryOrderObject query)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> UpdateOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
