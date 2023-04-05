namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public Pizza(string name, string description, float price, string img) 
        { 
            Name = name;
            Description = description;
            Price = price;
            Img = img;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Img { get; set; }

    }
}
