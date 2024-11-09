using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiStore.Helpers;
using BonsaiStore.Models;

namespace BonsaiStore.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<OrderModel>> GetAllOrders(QueryOrderObject query);
        Task<OrderModel> GetOrder(QueryOrderObject query);

        Task<OrderModel> CreateOrder(OrderModel order);

        Task<OrderModel> UpdateOrder(OrderModel order);

        Task<OrderModel> DeleteOrder(OrderModel order);
    }
}
