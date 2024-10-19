using Microsoft.AspNetCore.Mvc;
using BonsaiStore.Models;
using BonsaiStore.Interfaces;
using BonsaiStore.Helpers;

namespace BonsaiStore.Controllers 
{
	[ApiController]
	[Route("api/[controller]")]
	public class ItemController : ControllerBase
	{
		private IItemRepository _itemRepository;

		public ItemController(IItemRepository itemRepository)
		{
			_itemRepository = itemRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllItems(QueryItemObject query)
		{
			return Ok(await _itemRepository.GetAllItems(query));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetItemById(int id)
		{
			return Ok(await _itemRepository.GetItemById(id));
		}

		[HttpPost]
		public async Task<IActionResult> CreateItem(ItemModel item)
		{
			return Ok(await _itemRepository.CreateItem(item));
		}

		[HttpPut]
		public async Task<IActionResult> UpdateItem(ItemModel item)
		{
			return Ok(await _itemRepository.UpdateItem(item));
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteItem(ItemModel item)
		{
			return Ok(await _itemRepository.DeleteItem(item));
		}
	}
}

