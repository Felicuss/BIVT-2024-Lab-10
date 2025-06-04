using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Model.Core.DishClasses;
using Model.Core.RestaurantClasses;
using Model.Core.MenuClasses;
using Model.Data;
using Newtonsoft.Json;
using System.Runtime;

namespace RestaurantMenu.Model.Data
{
    public class SerializeXML : SerializeAbstract
    {
        private readonly Type[] _extraTypes = new Type[]
        {
            typeof(FullRestaurantDTO),
            typeof(CafeDTO),
            typeof(HotMealDTO),
            typeof(DrinksDTO),
            typeof(DesertDTO),
            typeof(SaladDTO),
            typeof(SoupDTO),
            typeof(CoffeeHouseDTO)
        };

        protected override void SaveFile(string folderPath, RestaurantDTO dto)
        {
            var path = Path.Combine(folderPath, $"{dto.Name}_restaurant.xml");
            var serializer = new XmlSerializer(typeof(RestaurantDTO), _extraTypes);
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, dto);
            }
        }

        protected override void SaveMenuFile(string folder, MenuDTO menu)
        {
            var fullpath = Path.Combine(folder, $"{menu.Name}.xml");
            var serializer = new XmlSerializer(typeof(MenuDTO), _extraTypes);
            using (var writer = new StreamWriter(fullpath))
            {
                serializer.Serialize(writer, menu);
            }
        }

        protected override IMenu LoadMenuFile(string menuPath)
        {
            string fullpath = menuPath + ".xml";
            if (!File.Exists(fullpath))
            {
                // Создаем новое пустое меню
                var emptyMenu = new MenuDTO 
                { 
                    Name = Path.GetFileNameWithoutExtension(menuPath),
                    Dishes = new List<DishDTO>() 
                };
                
                // Сохраняем его в файл
                var emptyMenuSerializer = new XmlSerializer(typeof(MenuDTO), _extraTypes);
                using (var writer = new StreamWriter(fullpath))
                {
                    emptyMenuSerializer.Serialize(writer, emptyMenu);
                }
                return new Menu();
            }
            var serializer = new XmlSerializer(typeof(MenuDTO), _extraTypes);
            MenuDTO dto;
            using (var reader = new StreamReader(fullpath))
            {
                dto = (MenuDTO)serializer.Deserialize(reader);
            }
            // Заполняем основное меню блюдами
            var dishes = dto.Dishes.Select(d => DeserializeDish(d)).ToList();
            var menu = new Menu(dishes);
            return menu;
        }

        protected override RestaurantDTO DeserializeRestaurantFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(RestaurantDTO), _extraTypes);
            using (var reader = new StreamReader(fileName))
            {
                return (RestaurantDTO)serializer.Deserialize(reader);
            }
        }
    }
}
