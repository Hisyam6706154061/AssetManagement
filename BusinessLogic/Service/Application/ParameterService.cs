using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class ParameterService : IParameterService
    {
        IParameterRepository iParameterRepository = new ParameterRepository();
        bool status = false;
        public bool Delete(int id)
        {
            return iParameterRepository.Delete(id);
        }

        public List<Parameter> Get()
        {
            return iParameterRepository.Get();
        }

        public Parameter Get(int id)
        {
            return iParameterRepository.Get(id);
        }

        public List<Parameter> GetSearch(string values)
        {
            return iParameterRepository.GetSearch(values);
        }

        public bool Insert(ParameterVM parameterVM)
        {
            if (string.IsNullOrWhiteSpace(parameterVM.Name))
            {
                return status;
            }
            else
            {
                return iParameterRepository.Insert(parameterVM);
            }
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            return iParameterRepository.Update(id, parameterVM);
        }
    }
}
