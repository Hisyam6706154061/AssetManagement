using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace Common.Repository
{
    public interface ITypeRepository
    {
        List<TypeItem> Get();
        List<TypeItem> GetSearch(string values);
        TypeItem Get(int id);
        bool Insert(TypeVM typeVM);
        bool Update(int id, TypeVM typeVM);
        bool Delete(int id);
    }
}
