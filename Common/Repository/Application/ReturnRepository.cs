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
            throw new NotImplementedException();
        }

        public Return Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Return> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ReturnVM loaningVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ReturnVM returnVM)
        {
            throw new NotImplementedException();
        }
    }
}
