using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("TB_M_Type")]
    public class Type : BaseModel
    {
        public string Name { get; set; }
        public Type() { }
        public Type(TypeVM typeVM)
        {
            this.Name = typeVM.Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update (int id, TypeVM typeVM)
        {
            this.Id = id;
            this.Name = typeVM.Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
