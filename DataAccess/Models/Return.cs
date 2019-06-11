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
    [Table("TB_T_Return")]
    public class Return : BaseModel
    {
        public DateTimeOffset DateReturn { get; set; }
        public string LastCondition { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        [ForeignKey("Loaning")]
        public int Loaning_Id { get; set; }
        public Loaning Loaning { get; set; }
        public Return() { }
        public Return(ReturnVM returnVM)
        {
            this.DateReturn = returnVM.DateReturn;
            this.LastCondition = returnVM.LastCondition;
            this.Quantity = returnVM.Quantity;
            this.Status = returnVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, ReturnVM returnVM)
        {
            this.Id = id;
            this.DateReturn = returnVM.DateReturn;
            this.LastCondition = returnVM.LastCondition;
            this.Quantity = returnVM.Quantity;
            this.Status = returnVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
