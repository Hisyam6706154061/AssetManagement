using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ReturnVM
    {
        public ReturnVM(DateTimeOffset dateReturn, string lastCondition, int quantity, int status, int user_id, int loaning_id)
        {
            this.DateReturn = dateReturn;
            this.LastCondition = lastCondition;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Loaning_Id = loaning_id;
        }
        public ReturnVM() { }
        public void Update(int id, DateTimeOffset dateReturn, string lastCondition, int quantity, int status, int user_id, int loaning_id)
        {
            this.Id = id;
            this.DateReturn = dateReturn;
            this.LastCondition = lastCondition;
            this.Quantity = quantity;
            this.Status = status;
            this.User_Id = user_id;
            this.Loaning_Id = loaning_id;
        }
        public int Id { get; set; }
        public DateTimeOffset DateReturn { get; set; }
        public string LastCondition { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int User_Id { get; set; }
        public int Loaning_Id { get; set; }
    }
}
