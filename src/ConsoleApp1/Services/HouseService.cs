using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class HouseService
    {
        private List<House> houses;

        public HouseService()
        {
            houses = new List<House>();
        }

        //Add
        public House AddHouse(House house)
        {
            house.Id = Guid.NewGuid();
            houses.Add(house);

            return house;
        }

        // GetById
        public House GetByIdHouse(Guid id)
        {
            foreach (var house in houses)
            {
                if (house.Id == id)
                {
                    return house;
                }
            }

            return null;
        }

        // Delelte
        public bool DeleteHouse(Guid id)
        {
            var requestFromDb = GetByIdHouse(id);
            if (requestFromDb is null)
            {
                return false;
            }
            houses.Remove(requestFromDb);

            return true;
        }

        // Update
        public bool UpdateHouse(House house)
        {
            var requestFromDb = GetByIdHouse(house.Id);
            if (requestFromDb is null)
            {
                return false;
            }
            var index = houses.IndexOf(requestFromDb);
            houses[index] = requestFromDb;
            
            return true;
        }

        // GetAll
        public List<House> GetAllHouses()
        {
            return houses;
        }

    }
}
