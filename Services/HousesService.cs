using gregslist.DB;
using gregslist.Models;

namespace gregslist.Services
{
    public class HousesService
    {
        internal List<House> getAll()
        {
            return FakeDB.Houses;
        }

        internal House GetOne(string id)
        {
            House found = FakeDB.Houses.Find(h => h.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            else
            {
                return found;
            }
        }

        internal House Create(House newHouse)
        {
            FakeDB.Houses.Add(newHouse);
            return newHouse;
        }

        internal House Update(House updatedHouse)
        {
            House oldHouse = GetOne(updatedHouse.Id);
            oldHouse.Year = updatedHouse.Year;
            oldHouse.Price = updatedHouse.Price;
            oldHouse.Floors = updatedHouse.Floors;
            oldHouse.Beds = updatedHouse.Beds;
            oldHouse.Baths = updatedHouse.Baths;
            oldHouse.Description = updatedHouse.Description != null ? updatedHouse.Description : oldHouse.Description;
            return oldHouse;
        }

        internal string Remove(string id)
        {
            House house = GetOne(id);
            FakeDB.Houses.Remove(house);
            return "Deleted";
        }
    }
}