using DataAccess.ViewModels;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface ITypeService
    {
        List<Type> Get();
        List<Type> GetSearch(string values);
        Type Get(int id);
        bool Insert(TypeVM typeVM);
        bool Update(int id, TypeVM typeVM);
        bool Delete(int id);
    }
}
