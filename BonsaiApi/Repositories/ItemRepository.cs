using System;
using System.Collections.Generic;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using BonsaiStore.Data;
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
			throw new NotImplementedException();
		}

		public async Task<ItemModel> DeleteItem(ItemModel item)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ItemModel>> GetAllItems()
		{
			throw new NotImplementedException();
		}

		public async Task<ItemModel> GetItemById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ItemModel>> GetItemsByCategory(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ItemModel>> GetItemsBySearch(string search)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ItemModel>> GetItemsByTag(string tag)
		{
			throw new NotImplementedException();
		}

		public async Task<ItemModel> UpdateItem(ItemModel item)
		{
			throw new NotImplementedException();
		}
}}
