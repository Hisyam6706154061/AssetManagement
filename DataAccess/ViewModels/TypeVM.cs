namespace DataAccess.ViewModels
{
    public class TypeVM
    {
        public TypeVM(string name)
        {
            this.Name = name;
        }
        public TypeVM() { }
        public void Update(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
