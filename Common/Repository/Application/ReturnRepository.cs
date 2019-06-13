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
    public class ReturnRepository : IReturnRepository
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

        public List<Return> Get()
        {
            var get = myContext.Return.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Return Get(int id)
        {
            var get = myContext.Return.Find(id);
            return get;
        }

        public List<Return> GetSearch(string values)
        {
            var get = myContext.Return.Include("Loaning").Include("Loaning.Item").Where(x => (x.Loaning.Item.Name.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ReturnVM returnVM)
        {
            var push = new Return(returnVM);
            var get = myContext.Loaning.Find(returnVM.Loaning_Id);
            if (get != null)
            {
                push.Loaning = get;
                myContext.Return.Add(push);
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

        public bool Update(int id, ReturnVM returnVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, returnVM);
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
