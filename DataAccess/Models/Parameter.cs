using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Parameter")]
    public class Parameter : BaseModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Parameter() { }
        public Parameter(ParameterVM parameterVM)
        {
            this.Name = parameterVM.Name;
            this.Value = parameterVM.Value;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, ParameterVM parameterVM)
        {
            this.Id = id;
            this.Name = parameterVM.Name;
            this.Value = parameterVM.Value;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
