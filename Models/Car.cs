

namespace gregslist.Models
{
    public class Car
    {
        public Car(string make, string model, int miles, int price, string description)
        {
            Make = make;
            Model = model;
            Miles = miles;
            Description = description;
            Price = price;
            //NOTE This line establishes a new globally unique ID
            Id = Guid.NewGuid().ToString(); ;
        }

        public string Make { get; set; }

        public string Description { get; set; }

        public int Miles { get; set; }

        public int Price { get; set; }

        public string Model { get; set; }
        public string? Id { get; set; }
        // NOTE This is the method of requiring a property, only  applys to the one that immediatly follows
        // [Required]
        // public int MyProperty { get; private set; }
        //Can also use range for integers
        //[Range]
    }
}