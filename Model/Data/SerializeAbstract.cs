using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using Model.Core.RestaurantClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Model.Data.ISerialize;

namespace Model.Data
{
    public abstract class SerializeAbstract : ISerialize
    {
        protected abstract void SaveFile(string folderPath, RestaurantDTO dto);
        protected abstract void SaveMenuFile(string folder, MenuDTO menu);
        protected abstract IMenu LoadMenuFile(string menuPath);
        protected abstract RestaurantDTO DeserializeRestaurantFile(string fileName);

        public DishDTO DishSerializer<T>(T d) where T : class
        {
            DishDTO dishDTO;
            if (!(d is Dish)) throw new Exception("Блюдо не соответствует заданным!");
            var dish = d as Dish;
            if (d is HotMeal hotMeal)
            {
                dishDTO = new HotMealDTO
                {
                    CookingTime = hotMeal.CookingTime,
                    Temperature = hotMeal.Temperature,
                    IsSpicy = hotMeal.IsSpicy,
                    PortionWeight = hotMeal.PortionWeight,
                    IsVegetarian = hotMeal.IsVegetarian
                };
            }
            else if (d is Drinks drinks)
            {
                dishDTO = new DrinksDTO
                {
                    IsHot = drinks.IsHot,
                    WithSugar = drinks.WithSugar
                };
            }
            else if (d is Desert desert)
            {
                dishDTO = new DesertDTO
                {
                    HasLactose = desert.HasLactose,
                    Calories = desert.Calories,
                    IsVegan = desert.IsVegan,
                    Ingridients = desert.Ingridients.ToArray()
                };
            }
            else if (d is Salad salad)
            {
                dishDTO = new SaladDTO
                {
                    Ingredients = salad.Ingredients.ToArray(),
                    ContainsNuts = salad.ContainsNuts,
                    Weight = salad.Weight
                };
            }
            else if (d is Soup soup)
            {
                dishDTO = new SoupDTO
                {
                    Ingredients = soup.Ingredients.ToArray(),
                    IsVegan = soup.IsVegan,
                    Weight = soup.Weight
                };
            }
            else throw new Exception($"Invalid dish type asdasd {d.GetType()}");
            dishDTO.Name = dish.Name;
            dishDTO.Price = dish.Price;
            return dishDTO;
        }

        public void Serialize<T>(T restaurant, string folderPath) where T : Restaurant
        {
            if (restaurant == null) return;

            var folder = Path.Combine(folderPath, restaurant.Name);
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

            // Создаем DTO для основного меню
            var menuDto = new MenuDTO
            {
                Dishes = restaurant.Menu.Dishes.Select(d => DishSerializer(d)).ToList(),
                Name = $"{restaurant.Name}_main_menu"
            }; 

            // Сохраняем основное меню
            SaveMenuFile(folder, menuDto);

            RestaurantDTO dto;
            if (restaurant is FullRestaurant fullRestaurant)
            {
                dto = new FullRestaurantDTO
                {
                    HasBar = fullRestaurant.HasBar,
                    HasTerrace = fullRestaurant.HasTerrace,
                    TableCount = fullRestaurant.TableCount
                };
            }
            else if (restaurant is Cafe cafe)
            {
                dto = new CafeDTO
                {
                    HasWiFi = cafe.HasWiFi,
                    HasTableGames = cafe.HasTableGames,
                    MaxCapacity = cafe.MaxCapacity
                };
            }
            else if (restaurant is CoffeeHouse coffeeHouse)
            {
                dto = new CoffeeHouseDTO
                {
                    HasWiFi = coffeeHouse.HasWiFi,
                    HasTables = coffeeHouse.HasTables,
                    MaxCapacity = coffeeHouse.MaxCapacity
                };
            }
            else throw new Exception("Invalid restaurant type");

            dto.Name = restaurant.Name;
            dto.Address = restaurant.Address;
            dto.PhoneNumber = restaurant.PhoneNumber;
            dto.WorkingHours = restaurant.WorkingHours;
            dto.Rating = restaurant.Rating;
            dto.HasSeasonalMenu = restaurant.HasSeasonalMenu;
            dto.MenuName = menuDto.Name;

            var seasonalMenuDto = new MenuDTO
            {
                Dishes = restaurant.SeasonalMenu.Dishes.Select(d => DishSerializer(d)).ToList(),
                Name = $"{restaurant.Name}_season_menu"
            };
            // Сохраняем менюшку в папку
            SaveMenuFile(folder, seasonalMenuDto);
            // Добавляем к ресторану
            dto.SeasonalMenuName = seasonalMenuDto.Name;
            SaveFile(folder, dto);
        }

        public Dish DeserializeDish<T>(T dto) where T : class
        {
            if (dto is HotMealDTO hotMealDto)
                return new HotMeal("Горячее", hotMealDto.Name, hotMealDto.Price, hotMealDto.CookingTime,
                    hotMealDto.Temperature, hotMealDto.IsSpicy, hotMealDto.PortionWeight, hotMealDto.IsVegetarian);
            else if (dto is DrinksDTO drinksDto)
                return new Drinks("Напиток", drinksDto.Name, drinksDto.Price, drinksDto.IsHot, drinksDto.WithSugar);
            else if (dto is SaladDTO saladDto)
                return new Salad("Салат", saladDto.Name, saladDto.Price, saladDto.Ingredients,
                    saladDto.ContainsNuts, saladDto.Weight);
            else if (dto is SoupDTO soupDTO)
                return new Soup("Суп", soupDTO.Name, soupDTO.Price, soupDTO.Ingredients,
                    soupDTO.Weight, soupDTO.IsVegan);
            else if (dto is DesertDTO desertDto)
                return new Desert("Десерт", desertDto.Name, desertDto.Price, desertDto.HasLactose,
                    desertDto.Calories, desertDto.IsVegan, desertDto.Ingridients);
            throw new Exception($"Invalid dish type {dto.GetType()}");
        }

        public T DeserializeRestaurant<T>(string fileName) where T : Restaurant
        {

            var dto = DeserializeRestaurantFile(fileName);
            if (dto == null) throw new Exception("Не удалось десериализировать файл!");

            // Получим папку ресторана
            var folderRest = Path.GetDirectoryName(fileName);

            // Ищем файл меню
            var menuPath = Path.Combine(folderRest, dto.MenuName);


            var menu = LoadMenuFile(menuPath);

            Restaurant restaurant;
            if (dto is FullRestaurantDTO fullDto)
                restaurant = new FullRestaurant(dto.Name, menu, dto.Address, dto.PhoneNumber,
                    dto.WorkingHours, dto.Rating, fullDto.HasBar, fullDto.HasTerrace, fullDto.TableCount);
            else if (dto is CafeDTO cafeDto)
                restaurant = new Cafe(dto.Name, menu, dto.Address, dto.PhoneNumber,
                    dto.WorkingHours, dto.Rating, cafeDto.HasWiFi, cafeDto.HasTableGames, cafeDto.MaxCapacity);
            else if (dto is CoffeeHouseDTO coffeeHouse)
                restaurant = new CoffeeHouse(dto.Name, menu, dto.Address, dto.PhoneNumber,
                    dto.WorkingHours, dto.Rating, coffeeHouse.HasWiFi, coffeeHouse.HasTables, coffeeHouse.MaxCapacity);
            else
                throw new Exception($"Invalid restaurant type");

            if (dto.HasSeasonalMenu && !string.IsNullOrEmpty(dto.SeasonalMenuName))
            {
                // Получим название файла сезонного меню
                var seasonmenuPath = Path.Combine(folderRest, dto.SeasonalMenuName);
                var seasonMenu = LoadMenuFile(seasonmenuPath);
                restaurant.AddSeasonalMenu(seasonMenu);
            }
            return restaurant as T;
        }

        public List<T> DeserializeAllFiles<T>(string folder, string expansion) where T : Restaurant
        {
            // Если папки нет, то создаем эту папку и заведения пустые
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                return new List<T>();
            }
            var restaurants = new List<T>();
            string[] folderPaths = Directory.GetDirectories(folder);
            foreach (var folderRestaraunt in folderPaths)
            {
                if (!Directory.Exists(folderRestaraunt)) continue;
                string[] files = Directory.GetFiles(folderRestaraunt, $"*_restaurant.{expansion}");
                if (files.Length != 1) continue;
                var restaraunt = DeserializeRestaurant<T>(files[0]);
                restaurants.Add(restaraunt);
            }
            return restaurants;
        }
    }
}
