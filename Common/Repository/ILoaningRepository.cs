using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace Common.Repository
{
    public interface ILoaningRepository
    {
        List<Loaning> Get();
        List<Loaning> GetSearch(string values);
        Loaning Get(int id);
        bool Insert(LoaningVM loaningVM);
        bool Update(int id, LoaningVM loaningVM);
        bool Delete(int id);
    }
}
