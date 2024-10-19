using System;
using System.Collections.Generic;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using BonsaiStore.Data;
using BonsaiStore.Helpers;
namespace BonsaiStore.Repositories
{

	public class ItemRepository : IItemRepository
	{
	private readonly ApplicationDbContext _context;
	
	public ItemRepository(ApplicationDbContext context)	{
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
			throw new NotImplementedException();
		}
		public async Task<ItemModel> GetItemById(int id)
		{
			throw new NotImplementedException();
		}
		public async Task<ItemModel> UpdateItem(ItemModel item)
		{
			throw new NotImplementedException();
		}
}}
