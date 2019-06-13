using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class ProcurementService : IProcurementService
    {
        IProcurementRepository iProcurementRepository = new ProcurementRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iProcurementRepository.Delete(id);
        }

        public List<Procurement> Get()
        {
            return iProcurementRepository.Get();
        }

        public Procurement Get(int id)
        {
            return iProcurementRepository.Get(id);
        }

        public List<Procurement> GetSearch(string values)
        {
            return iProcurementRepository.GetSearch(values);
        }

        public bool Insert(ProcurementVM procurementVM)
        {
            if (procurementVM.Status == null)
            {
                return status;
            }
            else
            {
                return iProcurementRepository.Insert(procurementVM);
            }
        }

        public bool Update(int id, ProcurementVM procurementVM)
        {
            return iProcurementRepository.Update(id, procurementVM);
        }
    }
}
