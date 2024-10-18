using System;
using System.Collections.Generic;
using BonsaiStore.Models;
namespace BonsaiStore.Interfaces
{
	public interface IItemRepository
	{
		List<ItemModel> GetAllItems();
		ItemModel GetItemById(int id);
		List<ItemModel> GetItemsByCategory(int id);
		List<ItemModel> GetItemsByTag(string tag);
		List<ItemModel> GetItemsBySearch(string search);
		ItemModel CreateItem(ItemModel item);
		ItemModel UpdateItem(ItemModel item);
		ItemModel DeleteItem(ItemModel item);
	}
}
