using System;
using System.Collections.Generic;
using BonsaiStore.Models;
namespace BonsaiStore.Interfaces
{
	public interface IItemRepository
	{
		Task<List<ItemModel>> GetAllItems();
		Task<ItemModel> GetItemById(int id);
		Task<List<ItemModel>> GetItemsByCategory(int id);
		Task<List<ItemModel>> GetItemsByTag(string tag);
		Task<List<ItemModel>> GetItemsBySearch(string search);
		Task<ItemModel> CreateItem(ItemModel item);
		Task<ItemModel> UpdateItem(ItemModel item);
		Task<ItemModel> DeleteItem(ItemModel item);
	}
}
