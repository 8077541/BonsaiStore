using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BonsaiStore.Models;
using BonsaiStore.Interfaces;


namespace BonsaiStore.Controllers 
{
	[ApiController]
	[Route("api/[controller]")]
	public class ItemController
	{
		private IItemRepository _itemRepository;

		public ItemController(IItemRepository itemRepository)
		{
			_itemRepository = itemRepository;
		}

		[HttpGet]
		public List<ItemModel> GetAllItems()
		{
			return _itemRepository.GetAllItems();
		}

		[HttpGet("{id}")]
		public ItemModel GetItemById(int id)
		{
			return _itemRepository.GetItemById(id);
		}

		[HttpGet("category/{id}")]
		public List<ItemModel> GetItemsByCategory(int id)
		{
			return _itemRepository.GetItemsByCategory(id);
		}

		[HttpGet("tag/{tag}")]
		public List<ItemModel> GetItemsByTag(string tag)
		{
			return _itemRepository.GetItemsByTag(tag);
		}

		[HttpGet("search/{search}")]
		public List<ItemModel> GetItemsBySearch(string search)
		{
			return _itemRepository.GetItemsBySearch(search);
		}

		[HttpPost]
		public ItemModel CreateItem(ItemModel item)
		{
			return _itemRepository.CreateItem(item);
		}

		[HttpPut]
		public ItemModel UpdateItem(ItemModel item)
		{
			return _itemRepository.UpdateItem(item);
		}

		[HttpDelete]
		public ItemModel DeleteItem(ItemModel item)
		{
			return _itemRepository.DeleteItem(item);
		}
	}
}

