using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace Common.Repository
{
    public interface IItemRepository
    {
        List<Item> Get();
        List<Item> GetSearch(string values);
        Item Get(int id);
        bool Insert(ItemVM itemVM);
        bool Update(int id, ItemVM itemVM);
        bool Delete(int id);
    }
}
