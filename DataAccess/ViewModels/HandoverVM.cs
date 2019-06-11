using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class HandoverVM
    {
        public HandoverVM(DateTimeOffset dateHandover, int quantity, int status, int user_id, int loaning_id, int headDivision_id)
        {
            this.DateHandover = dateHandover;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Loaning_Id = loaning_id;
            this.HeadDivision_Id = headDivision_id;
        }
        public HandoverVM() { }
        public void Update(int id, DateTimeOffset dateHandover, int quantity, int status, int user_id, int loaning_id, int headDivision_id)
        {
            this.Id = id;
            this.DateHandover = dateHandover;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Loaning_Id = loaning_id;
            this.HeadDivision_Id = headDivision_id;
        }
        public int Id { get; set; }
        public DateTimeOffset DateHandover { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int User_Id { get; set; }
        public int Loaning_Id { get; set; }
        public int HeadDivision_Id { get; set; }
    }
}
