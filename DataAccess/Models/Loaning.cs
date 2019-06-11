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
    [Table("TB_T_Loaning")]
    public class Loaning : BaseModel
    {
        public DateTimeOffset DateLoaning { get; set; }
        public DateTimeOffset DateReturn { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        public Loaning() { }
        public Loaning(LoaningVM loaningVM)
        {
            this.DateLoaning = loaningVM.DateLoaning;
            this.DateReturn = loaningVM.DateReturn;
            this.Quantity = loaningVM.Quantity;
            this.Status = loaningVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, LoaningVM loaningVM)
        {
            this.Id = id;
            this.DateLoaning = loaningVM.DateLoaning;
            this.DateReturn = loaningVM.DateReturn;
            this.Quantity = loaningVM.Quantity;
            this.Status = loaningVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}