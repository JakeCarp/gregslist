using gregslist.DB;
using gregslist.Models;

namespace gregslist.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
            return FakeDB.Cars;
        }

        internal Car GetOne(string id)
        {
            Car found = FakeDB.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid ID");
            }
            else
            {
                return found;

            }
        }

        internal string Remove(string id)
        {
            Car car = GetOne(id);
            FakeDB.Cars.Remove(car);
            return "Deleted";
        }
    }
}