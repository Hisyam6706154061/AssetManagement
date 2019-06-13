using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repository.Application
{
    public class ProcurementRepository : IProcurementRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Procurement> Get()
        {
            throw new NotImplementedException();
        }

        public Procurement Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Procurement> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProcurementVM procurementVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ProcurementVM procurementVM)
        {
            throw new NotImplementedException();
        }
    }
}
