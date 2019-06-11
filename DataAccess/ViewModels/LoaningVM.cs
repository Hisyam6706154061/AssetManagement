using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class LoaningVM
    {
        public LoaningVM(DateTimeOffset dateLoaning, DateTimeOffset dateReturn, int quantity, int status, int user_id, int item_id)
        {
            this.DateLoaning = dateLoaning;
            this.DateReturn = dateReturn;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Item_Id = item_id;
        }
        public LoaningVM() { }
        public void Update(int id, DateTimeOffset dateLoaning, DateTimeOffset dateReturn, int quantity, int status, int user_id, int item_id)
        {
            this.Id = id;
            this.DateLoaning = dateLoaning;
            this.DateReturn = dateReturn;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Item_Id = item_id;
        }
        public int Id { get; set; }
        public DateTimeOffset DateLoaning { get; set; }
        public DateTimeOffset DateReturn { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int User_Id { get; set; }
        public int Item_Id { get; set; }
    }
}
