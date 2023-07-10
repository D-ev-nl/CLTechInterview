namespace Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public int TypeId { get; set; }
        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}