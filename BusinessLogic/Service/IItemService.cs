using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface IItemService
    {
        List<Item> Get();
        List<Item> GetSearch(string values);
        Item Get(int id);
        bool Insert(ItemVM itemVM);
        bool Update(int id, ItemVM itemVM);
        bool Delete(int id);
    }
}
