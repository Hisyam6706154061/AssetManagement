using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("TB_M_Item")]
    public class Item : BaseModel
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        [ForeignKey("Type")]
        public int Type_Id { get; set; }
        public Type Type { get; set; }
        public Item() { }
        public Item(ItemVM itemVM)
        {
            this.Name = itemVM.Name;
            this.Brand = itemVM.Brand;
            this.Description = itemVM.Description;
            this.Condition = itemVM.Condition;
            this.Image = itemVM.Image;
            this.Stock = itemVM.Stock;
            this.Price = itemVM.Price;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, ItemVM itemVM)
        {
            this.Id = id;
            this.Name = itemVM.Name;
            this.Brand = itemVM.Brand;
            this.Description = itemVM.Description;
            this.Condition = itemVM.Condition;
            this.Image = itemVM.Image;
            this.Stock = itemVM.Stock;
            this.Price = itemVM.Price;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
