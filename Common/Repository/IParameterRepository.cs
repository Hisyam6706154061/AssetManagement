using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace Common.Repository
{
    public interface IParameterRepository
    {
        List<Parameter> Get();
        List<Parameter> GetSearch(string values);
        Parameter Get(int id);
        bool Insert(ParameterVM parameterVM);
        bool Update(int id, ParameterVM parameterVM);
        bool Delete(int id);
    }
}
