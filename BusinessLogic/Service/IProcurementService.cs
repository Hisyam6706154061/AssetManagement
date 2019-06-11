using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface IProcurementService
    {
        List<Procurement> Get();
        List<Procurement> GetSearch(string values);
        Procurement Get(int id);
        bool Insert(ProcurementVM procurementVM);
        bool Update(int id, ProcurementVM procurementVM);
        bool Delete(int id);
    }
}
