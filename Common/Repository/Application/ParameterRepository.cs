using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using System.Data.Entity;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class ParameterRepository : IParameterRepository
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

        public List<Parameter> Get()
        {
            var get = myContext.Parameter.Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public Parameter Get(int id)
        {
            var get = myContext.Parameter.Find(id);
            return get;
        }

        public List<Parameter> GetSearch(string values)
        {
            var get = myContext.Parameter.Where(x => (x.Name.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ParameterVM parameterVM)
        {
            var push = new Parameter(parameterVM);
            myContext.Parameter.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                return status;
            }
            return status;
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, parameterVM);
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
