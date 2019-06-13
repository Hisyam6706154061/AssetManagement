using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();

        }

        public List<Item> Get()
        {
            throw new NotImplementedException();
        }

        public Item Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ItemVM itemVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ItemVM itemVM)
        {
            throw new NotImplementedException();
        }
    }
}
