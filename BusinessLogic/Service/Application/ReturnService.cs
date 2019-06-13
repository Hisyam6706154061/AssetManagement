using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class ReturnService : IReturnService
    {
        IReturnRepository iReturnRepository = new ReturnRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iReturnRepository.Delete(id);
        }

        public List<Return> Get()
        {
            return iReturnRepository.Get();
        }

        public Return Get(int id)
        {
            return iReturnRepository.Get(id);
        }

        public List<Return> GetSearch(string values)
        {
            return iReturnRepository.GetSearch(values);
        }

        public bool Insert(ReturnVM returnVM)
        {
            if (returnVM.DateReturn == null)
            {
                return status;
            }else
            {
                return iReturnRepository.Insert(returnVM);
            }
        }

        public bool Update(int id, ReturnVM returnVM)
        {
            return iReturnRepository.Update(id, returnVM);
        }
    }
}
