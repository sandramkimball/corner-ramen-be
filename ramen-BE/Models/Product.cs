namespace ramen_BE.Models
{
    public class Product 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string ProductType {get; set;}
        public string ProductImage {get; set;}
        public int Price {get; set;}
    }
}