using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ViewModels;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class TypeRepository : ITypeRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Type> Get()
        {
            throw new NotImplementedException();
        }

        public Type Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Type> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TypeVM typeVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TypeVM typeVM)
        {
            throw new NotImplementedException();
        }
    }
}
