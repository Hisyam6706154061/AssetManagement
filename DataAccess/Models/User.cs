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
    [Table("TB_M_User")]
    public class User : BaseModel
    {
        public string Name { get; set; }
        public int Role { get; set; }
        public int HeadDivision_Id { get; set; }
        public User() { }
        public User(UserVM userVM)
        {
            this.Name = userVM.Name;
            this.Role = userVM.Role;
            this.HeadDivision_Id = userVM.HeadDivision_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, UserVM userVM)
        {
            this.Id = id;
            this.Name = userVM.Name;
            this.Role = userVM.Role;
            this.HeadDivision_Id = userVM.HeadDivision_Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
