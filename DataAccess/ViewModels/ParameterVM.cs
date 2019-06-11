using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ParameterVM
    {
        public ParameterVM(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
        public ParameterVM() { }
        public void Update(int id, string name, string value)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
