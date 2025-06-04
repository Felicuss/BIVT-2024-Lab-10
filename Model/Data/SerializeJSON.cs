using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Model.Core.DishClasses;
using Model.Core.RestaurantClasses;
using Model.Core.MenuClasses;
using Model.Data;

namespace RestaurantMenu.Model.Data
{
    public class SerializeJSON : SerializeAbstract
    {
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.All
        };

        protected override void SaveFile(string folderPath, RestaurantDTO dto)
        {
            var path = Path.Combine(folderPath, $"{dto.Name}_restaurant.json");
            string result = JsonConvert.SerializeObject(dto, _settings);
            File.WriteAllText(path, result);
        }

        protected override void SaveMenuFile(string folder, MenuDTO menu)
        {
            var fullpath = Path.Combine(folder, $"{menu.Name}.json");
            string result = JsonConvert.SerializeObject(menu, _settings);
            File.WriteAllText(fullpath, result);
        }

        protected override IMenu LoadMenuFile(string menuPath)
        {
            string fullpath = menuPath + ".json";
            if (!File.Exists(fullpath))
            {
                var emptyMenu = new MenuDTO 
                { 
                    Name = Path.GetFileNameWithoutExtension(menuPath),
                    Dishes = new List<DishDTO>() 
                };
                string result = JsonConvert.SerializeObject(emptyMenu, _settings);
                File.WriteAllText(fullpath, result);
                return new Menu();
            }
            string json = File.ReadAllText(fullpath);
            var dto = JsonConvert.DeserializeObject<MenuDTO>(json, _settings);
            var dishes = dto.Dishes.Select(d => DeserializeDish(d)).ToList();
            var menu = new Menu(dishes);
            return menu;
        }

        protected override RestaurantDTO DeserializeRestaurantFile(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<RestaurantDTO>(json, _settings);
        }
    }
}