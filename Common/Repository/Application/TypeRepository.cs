using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.Context;
using DataAccess.ViewModels;
using System.Linq;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class TypeRepository : ITypeRepository
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

        public List<TypeItem> Get()
        {
            var get = myContext.Type.Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public TypeItem Get(int id)
        {
            var get = myContext.Type.Find(id);
            return get;
        }

        public List<TypeItem> GetSearch(string values)
        {
            var get = myContext.Type.Where(x => (x.Name.Contains(values) || x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(TypeVM typeVM)
        {
            var push = new TypeItem(typeVM);
            myContext.Type.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }else
            {
                return status;
            }
            return status;
        }

        public bool Update(int id, TypeVM typeVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, typeVM);
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
