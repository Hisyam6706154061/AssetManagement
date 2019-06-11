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
    [Table("TB_T_Procurement")]
    public class Procurement : BaseModel
    {
        public int Quantity { get; set; }
        public int Status { get; set; }
        [ForeignKey("Admin")]
        public int Admin_Id { get; set; }
        public User Admin { get; set; }
        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }
        [ForeignKey("HeadDivision")]
        public int HeadDivision_Id { get; set; }
        public User HeadDivision { get; set; }
        public Procurement() { }
        public Procurement(ProcurementVM procurementVM)
        {
            this.Quantity = procurementVM.Quantity;
            this.Status = procurementVM.Status;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, ProcurementVM procurementVM)
        {
            this.Id = id;
            this.Quantity = procurementVM.Quantity;
            this.Status = procurementVM.Status;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
