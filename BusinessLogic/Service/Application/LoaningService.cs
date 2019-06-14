using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class LoaningService : ILoaningService
    {
        ILoaningRepository iLoaningRepository = new LoaningRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iLoaningRepository.Delete(id);
        }

        public List<Loaning> Get()
        {
            return iLoaningRepository.Get();
        }

        public Loaning Get(int id)
        {
            return iLoaningRepository.Get(id);
        }

        public List<Loaning> GetSearch(string values)
        {
            return iLoaningRepository.GetSearch(values);
        }

        public bool Insert(LoaningVM loaningVM)
        {
            if (loaningVM.DateLoaning==null)
            {
                return status;
            }
            else
            {
                return iLoaningRepository.Insert(loaningVM);
            }
        }


        public bool Update(int id, LoaningVM loaningVM)
        {
            return iLoaningRepository.Update(id, loaningVM);
        }
    }
}
