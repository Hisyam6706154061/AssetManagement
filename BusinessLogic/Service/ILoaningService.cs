using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface ILoaningService
    {
        List<Loaning> Get();
        List<Loaning> GetSearch(string values);
        Loaning Get(int id);
        bool Insert(LoaningVM loaningVM);
        bool Update(int id, LoaningVM loaningVM);
        bool Delete(int id);
    }
}
