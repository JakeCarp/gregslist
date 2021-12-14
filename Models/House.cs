namespace gregslist.Models
{
    public class House
    {
        public House(int year, int price, int floors, int beds, int baths, string? description)
        {
            Year = year;
            Price = price;
            Floors = floors;
            Beds = beds;
            Baths = baths;
            Description = description;
            Id = Guid.NewGuid().ToString();
        }

        public int Year { get; set; }
        public int Price { get; set; }
        public int Floors { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public string? Description { get; set; }
        public string? Id { get; private set; }
    }
}