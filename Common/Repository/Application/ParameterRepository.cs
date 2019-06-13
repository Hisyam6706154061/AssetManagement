using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace Common.Repository.Application
{
    public class ParameterRepository : IParameterRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parameter> Get()
        {
            throw new NotImplementedException();
        }

        public Parameter Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parameter> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ParameterVM parameterVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            throw new NotImplementedException();
        }
    }
}
