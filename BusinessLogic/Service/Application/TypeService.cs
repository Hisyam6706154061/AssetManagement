using System;
using System.Collections.Generic;
using DataAccess.ViewModels;
using Common.Repository.Application;
using Common.Repository;
using DataAccess.Models;

namespace BusinessLogic.Service.Application
{
    public class TypeService : ITypeService
    {
        ITypeRepository iTypeRepository = new TypeRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iTypeRepository.Delete(id);
        }

        public List<TypeItem> Get()
        {
            return iTypeRepository.Get();
        }

        public TypeItem Get(int id)
        {
            return iTypeRepository.Get(id);
        }

        public List<TypeItem> GetSearch(string values)
        {
            return iTypeRepository.GetSearch(values);
        }

        public bool Insert(TypeVM typeVM)
        {
            if (string.IsNullOrWhiteSpace(typeVM.Name))
            {
                return status;
            }
            else
            {
                return iTypeRepository.Insert(typeVM);
            }
        }

        public bool Update(int id, TypeVM typeVM)
        {
            return iTypeRepository.Update(id, typeVM);
        }
    }
}
