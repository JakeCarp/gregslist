namespace gregslist.Models
{
    public class Car
    {
        public Car(string? id, int myProperty)
        {
            //NOTE This line establishes a new globally unique ID
            Id = Guid.NewGuid().ToString();
        }
        public string Model { get; set; }
        public string? Id { get; set; }
        // NOTE This is the method of requiring a property, only  applys to the one that immediatly follows
        // [Required]
        // public int MyProperty { get; private set; }
        //Can also use range for integers
        //[Range]
    }
}