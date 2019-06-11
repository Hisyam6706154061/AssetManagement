using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface IReturnService
    {
        List<Return> Get();
        List<Return> GetSearch(string values);
        Return Get(int id);
        bool Insert(ReturnVM loaningVM);
        bool Update(int id, ReturnVM returnVM);
        bool Delete(int id);
    }
}
