namespace gregslist.Models
{
    public class Car
    {
        public Car(string? id, int myProperty)
        {
            //This line establishes a new globally unique ID
            Id = Guid.NewGuid().ToString();
            MyProperty = myProperty;
        }

        public string? Id { get; private set; }
        public int MyProperty { get; private set; }
    }
}