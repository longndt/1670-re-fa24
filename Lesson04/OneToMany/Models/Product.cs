namespace OneToMany.Models
{
    //relationship: 1 Category - Many Product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
        public int Quantity { get; set; }

        //set foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}