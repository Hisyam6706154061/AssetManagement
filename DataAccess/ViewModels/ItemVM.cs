using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ItemVM
    {
        public ItemVM(string name, string brand, string description, string condition, string image, int stock, int price, int type_id)
        {
            this.Name = name;
            this.Brand = brand;
            this.Description = description;
            this.Condition = condition;
            this.Image = image;
            this.Stock = stock;
            this.Price = price;
            this.Type_Id = type_id;
        }
        public ItemVM() { }
        public void Update(int id, string name, string brand, string description, string condition, string image, int stock, int price, int type_id)
        {
            this.Id = id;
            this.Name = name;
            this.Brand = brand;
            this.Description = description;
            this.Condition = condition;
            this.Image = image;
            this.Stock = stock;
            this.Price = price;
            this.Type_Id = type_id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public int Type_Id { get; set; }
    }
}
