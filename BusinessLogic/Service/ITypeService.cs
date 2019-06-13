using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface ITypeService
    {
        List<TypeItem> Get();
        List<TypeItem> GetSearch(string values);
        TypeItem Get(int id);
        bool Insert(TypeVM typeVM);
        bool Update(int id, TypeVM typeVM);
        bool Delete(int id);
    }
}
