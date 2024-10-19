

using BonsaiStore.Models;
using BonsaiStore.Helpers;
namespace BonsaiStore.Interfaces
{
	public interface IItemRepository
	{
		Task<List<ItemModel>> GetAllItems(QueryItemObject query);
		Task<ItemModel> GetItemById(int id);
		Task<ItemModel> CreateItem(ItemModel item);
		Task<ItemModel> UpdateItem(ItemModel item);
		Task<ItemModel> DeleteItem(ItemModel item);
	}
}
