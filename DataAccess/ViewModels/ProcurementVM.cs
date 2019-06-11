namespace DataAccess.ViewModels
{
    public class ProcurementVM
    {
        public ProcurementVM(int quantity, int status, int admin_id, int item_id, int headDivision_id)
        {
            this.Quantity = quantity;
            this.Status = status;
            this.Admin_Id = admin_id;
            this.Item_Id = item_id;
            this.HeadDivision_Id = headDivision_id;
        }
        public ProcurementVM() { }
        public void Update(int id, int quantity, int status, int admin_id, int item_id, int headDivision_id)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Status = status;
            this.Admin_Id = admin_id;
            this.Item_Id = item_id;
            this.HeadDivision_Id = headDivision_id;
        }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Status { get; set; }
        public int Admin_Id { get; set; }
        public int Item_Id { get; set; }
        public int HeadDivision_Id { get; set; }
    }
}
