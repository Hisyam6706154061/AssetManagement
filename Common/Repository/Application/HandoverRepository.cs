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
    public class HandoverRepository : IHandoverRepository
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

        public List<Handover> Get()
        {
            var get = myContext.Handover.Include("Loaning").Include("Loaning.Item").Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public Handover Get(int id)
        {
            var get = myContext.Handover.Find(id);
            return get;
        }

        public List<Handover> GetSearch(string values)
        {
            var get = myContext.Handover.Include("Loaning").Include("Loaning.Item").Where(x =>( x.Id.ToString().Contains(values) || x.Loaning.Item.Name.Contains(values) ) && x.IsDelete==false ).ToList();
            return get;
        }

        public bool Insert(HandoverVM handoverVM)
        {
            var push = new Handover(handoverVM);
            var get = myContext.Loaning.Find(handoverVM.Loaning_Id);
            if (get != null)
            {
                push.Loaning = get;
                myContext.Handover.Add(push);
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

        public bool Update(int id, HandoverVM handoverVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, handoverVM);
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
