using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class ProcurementRepository : IProcurementRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Procurement> Get()
        {
            var get = myContext.Procurement.Include("Item").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Procurement Get(int id)
        {
            var get = myContext.Procurement.Find(id);
            return get;
        }

        public List<Procurement> GetSearch(string values)
        {
            var get = myContext.Procurement.Include("Item").Where(x => (x.Item.Name.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ProcurementVM procurementVM)
        {
            var push = new Procurement(procurementVM);
            var get = myContext.Item.Find(procurementVM.Item_Id);
            if (get != null)
            {
                push.Item = get;
                myContext.Procurement.Add(push);
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            else
            {
                return status;
            }
        }

        public bool Update(int id, ProcurementVM procurementVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, procurementVM);
                myContext.Entry(get).State = EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
