using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface IHandoverService
    {
        List<Handover> Get();
        List<Handover> GetSearch(string values);
        Handover Get(int id);
        bool Insert(HandoverVM handoverVM);
        bool Update(int id, HandoverVM handoverVM);
        bool Delete(int id);
    }
}
