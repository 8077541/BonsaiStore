using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiApi.DTOs.ItemDto;
using BonsaiStore.Models;

namespace BonsaiStore.Mappers
{
    public static class ItemMapper
    {
        public static ItemModel ToItemFromCreateDto(this CreateItemDto item)
        {
            return new ItemModel
            {
                Name = item.Name,
                Price = item.Price,
                Description = item.Description,
            };
        }
    }
}
