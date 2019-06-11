using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("TB_T_Handover")]
    public class Handover : BaseModel
    {
        public DateTimeOffset DateHandover { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        [ForeignKey("Loaning")]
        public int Loaning_Id { get; set; }
        public Loaning Loaning { get; set; }
        [ForeignKey("HeadDivision")]
        public int HeadDivision_Id { get; set; }
        public User HeadDivision { get; set; }
        public Handover() { }
        public Handover(HandoverVM handoverVM)
        {
            this.DateHandover = handoverVM.DateHandover;
            this.Quantity = handoverVM.Quantity;
            this.Status = handoverVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, HandoverVM handoverVM)
        {
            this.Id = id;
            this.DateHandover = handoverVM.DateHandover;
            this.Quantity = handoverVM.Quantity;
            this.Status = handoverVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
