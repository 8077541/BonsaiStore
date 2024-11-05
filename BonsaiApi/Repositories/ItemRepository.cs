using System;
using System.Collections.Generic;
using BonsaiStore.Data;
using BonsaiStore.Helpers;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BonsaiStore.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ItemModel> CreateItem(ItemModel item)
        {
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<ItemModel> DeleteItem(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemModel>> GetAllItems(QueryItemObject query)
        {
            var items = await _context.Items.ToListAsync();
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
