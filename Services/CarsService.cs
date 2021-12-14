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

        internal Car Create(Car newCar)
        {
            FakeDB.Cars.Add(newCar);
            return newCar;
        }
        internal string Remove(string id)
        {
            Car car = GetOne(id);
            FakeDB.Cars.Remove(car);
            return "Deleted";
        }

        internal Car Update(Car updatedCar)
        {
            Car oldCar = GetOne(updatedCar.Id);
            oldCar.Model = updatedCar.Model != null ? updatedCar.Model : oldCar.Model;
            //Fill out these for each of the possibly updated fields
            return oldCar;
        }
    }
}