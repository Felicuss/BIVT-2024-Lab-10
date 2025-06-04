using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class MenuDTO
    {
        public List<DishDTO> Dishes { get; set; }
        public string Name { get; set; }
    }

    public class DishDTO
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class DesertDTO : DishDTO
    {
        public bool HasLactose { get; set; }
        public int Calories { get; set; }
        public bool IsVegan { get; set; }
        public string[] Ingridients { get; set; }
    }

    public class HotMealDTO : DishDTO
    {
        public int CookingTime { get; set; }
        public int Temperature { get; set; }
        public bool IsSpicy { get; set; }
        public int PortionWeight { get; set; }
        public bool IsVegetarian { get; set; }
    }
    public class SaladDTO : DishDTO
    {
        public string[] Ingredients { get; set; }
        public bool ContainsNuts { get; set; }
        public double Weight { get; set; }
    }
    public class SoupDTO : DishDTO
    {
        public string[] Ingredients { get; set; }
        public double Weight { get; set; }
        public bool IsVegan { get; set; }
    }
    public class DrinksDTO : DishDTO
    {
        public bool IsHot { get; set; }
        public bool WithSugar { get; set; }
    }

    public class RestaurantDTO
    {
        public string Name { get; set; }
        public string MenuName { get; set; }
        public string SeasonalMenuName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkingHours { get; set; }
        public int Rating { get; set; }
        public bool HasSeasonalMenu { get; set; }
    }

    public class FullRestaurantDTO : RestaurantDTO
    {
        public bool HasBar { get; set; }
        public bool HasTerrace { get; set; }
        public int TableCount { get; set; }
    }

    public class CafeDTO : RestaurantDTO
    {
        public bool HasWiFi { get; set; }
        public bool HasTableGames { get; set; }
        public int MaxCapacity { get; set; }
    }
    public class CoffeeHouseDTO : RestaurantDTO
    {
        public bool HasWiFi { get; set; }
        public bool HasTables { get; set; }
        public int MaxCapacity { get; set; }
    }
}
