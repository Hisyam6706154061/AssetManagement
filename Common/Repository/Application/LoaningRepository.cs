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
    public class LoaningRepository : ILoaningRepository
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
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<Loaning> Get()
        {
            var get = myContext.Loaning.Include("Item").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Loaning Get(int id)
        {
            var get = myContext.Loaning.Find(id);
            return get;
        }

        public List<Loaning> GetSearch(string values)
        {
            var get = myContext.Loaning.Include("Item").Where(x => (x.Item.Name.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(LoaningVM loaningVM)
        {
            var push = new Loaning(loaningVM);
            var get = myContext.Item.Find(loaningVM.Item_Id);
            if (get != null)
            {
                push.Item = get;
                myContext.Loaning.Add(push);
                var result = myContext.SaveChanges();
                if(result > 0)
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

        public bool Update(int id, LoaningVM loaningVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, loaningVM);
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
