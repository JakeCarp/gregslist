using gregslist.Models;
//Don't get used to this it is bad
namespace gregslist.DB
{
    public class FakeDB
    {
        public static List<Car>? Cars { get; private set; } = new List<Car>()
        {
            //TODO Add Cars Here
        };
        public static List<House>? Houses { get; private set; } = new List<House>()
        {
            //TODO Add Houses Here
        };

        public static List<Job> Jobs { get; private set; } = new List<Job>()
        {
            //TODO Add Jobs Here
        };

    }
}