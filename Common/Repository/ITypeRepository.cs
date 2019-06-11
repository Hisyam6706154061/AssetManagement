using DataAccess.ViewModels;
using System;
using System.Collections.Generic;

namespace Common.Repository
{
    public interface ITypeRepository
    {
        List<Type> Get();
        List<Type> GetSearch(string values);
        Type Get(int id);
        bool Insert(TypeVM typeVM);
        bool Update(int id, TypeVM typeVM);
        bool Delete(int id);
    }
}
