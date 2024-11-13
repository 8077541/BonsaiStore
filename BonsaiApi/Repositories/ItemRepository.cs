using System;
using System.Collections.Generic;
using BonsaiStore.Data;
using BonsaiStore.Helpers;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BonsaiStore.Repositories
{
    public class ItemRepository(ApplicationDbContext context) : IItemRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<ItemModel> CreateItem(ItemModel item)
        {
            ArgumentNullException.ThrowIfNull(item);

            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ArgumentException(
                    "Item name cannot be null or empty.",
                    nameof(item.Name)
                );
            }

            if (item.Price <= 0)
            {
                throw new ArgumentException(
                    "Item price must be greater than zero.",
                    nameof(item.Price)
                );
            }

            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<ItemModel> DeleteItem(ItemModel item)
        {
            _context.Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<List<ItemModel>> GetAllItems(QueryItemObject query)
        {
            var items = await _context.Items.ToListAsync();

            // Apply filters based on query parameters
            if (!string.IsNullOrEmpty(query.Name))
            {
                items = items.Where(item => item.Name.Contains(query.Name)).ToList();
            }

            if (query.MinPrice != 0)
            {
                items = items.Where(item => item.Price >= query.MinPrice).ToList();
            }

            if (query.MaxPrice != 0)
            {
                items = items.Where(item => item.Price <= query.MaxPrice).ToList();
            }
            // Apply sorting based on query parameters
            if (query.SortBy == "name")
            {
                items = items.OrderBy(item => item.Name).ToList();
            }
            else if (query.SortBy == "price")
            {
                items = items.OrderBy(item => item.Price).ToList();
            }

            return items;
        }

        public async Task<ItemModel> GetItemById(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync();
            return item;
        }

        public async Task<ItemModel> UpdateItem(ItemModel item)
        {
            var itemDb = await _context.Items.FirstOrDefaultAsync();
            return itemDb;
        }
    }
}
