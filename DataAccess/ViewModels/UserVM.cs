using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserVM
    {
        public UserVM(string name, int role, int headDivision_id)
        {
            this.Name = name;
            this.Role = role;
            this.HeadDivision_Id = headDivision_id;
        }
        public UserVM() { }
        public void Update(int id, string name, int role, int headDivision_id)
        {
            this.Id = id;
            this.Name = name;
            this.Role = role;
            this.HeadDivision_Id = headDivision_id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public int HeadDivision_Id { get; set; }
    }
}
