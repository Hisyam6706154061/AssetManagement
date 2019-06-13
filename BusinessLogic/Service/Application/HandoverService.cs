using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class HandoverService : IHandoverService
    {
        IHandoverRepository iHandoverRepository = new HandoverRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iHandoverRepository.Delete(id);
        }

        public List<Handover> Get()
        {
            return iHandoverRepository.Get();
        }

        public Handover Get(int id)
        {
            return iHandoverRepository.Get(id);
        }

        public List<Handover> GetSearch(string values)
        {
            return iHandoverRepository.GetSearch(values);
        }

        public bool Insert(HandoverVM handoverVM)
        {
            if (handoverVM.DateHandover == null)
            {
                return status;
            }
            else
            {
                return iHandoverRepository.Insert(handoverVM);
            }
        }

        public bool Update(int id, HandoverVM handoverVM)
        {
            return iHandoverRepository.Update(id, handoverVM);
        }
    }
}