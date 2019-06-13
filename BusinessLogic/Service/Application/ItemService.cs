using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class ItemService : IItemService
    {
        IItemRepository iItemRepository = new ItemRepository(); 
        bool status = false;
        public bool Delete(int id)
        {
            return iItemRepository.Delete(id);

        }

        public List<Item> Get()
        {
            return iItemRepository.Get();
        }

        public Item Get(int id)
        {
            return iItemRepository.Get(id);
        }

        public List<Item> GetSearch(string values)
        {
            return iItemRepository.GetSearch(values);
        }

        public bool Insert(ItemVM itemVM)
        {
            if (string.IsNullOrWhiteSpace(itemVM.Name))
            {
                return status;
            }else
            {
                return iItemRepository.Insert(itemVM);
            }
        }

        public bool Update(int id, ItemVM itemVM)
        {
            return iItemRepository.Update(id, itemVM);
        }
    }
}
