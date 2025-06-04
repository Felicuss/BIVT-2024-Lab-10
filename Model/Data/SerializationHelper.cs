using System;
using System.IO;
using System.Collections.Generic;
using Model.Data;
using Model.Core.RestaurantClasses;
using RestaurantMenu.Model.Data;

namespace Model.Data
{
    public static class SerializationHelper
    {
        private static readonly string DefaultFolderPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "RestarauntFiles");
        private static readonly string formatFilePath = Path.Combine(DefaultFolderPath, "Format.txt");
        public static ISerialize GetSerializer()
        {
            string extension = GetExtension();
            return extension == "json" ? new SerializeJSON() : new SerializeXML();
        }

        public static string GetExtension()
        {
            if (!Directory.Exists(DefaultFolderPath)) Directory.CreateDirectory(DefaultFolderPath);
            if (!File.Exists(formatFilePath))
            {
                File.WriteAllText(formatFilePath, "json");
                return "json";
            }
            string content = File.ReadAllText(formatFilePath).Trim();
            if (string.IsNullOrEmpty(content) || (content != "json" && content != "xml"))
            {
                File.WriteAllText(formatFilePath, "json");
                return "json";
            }
            return content;
        }

        public static void SaveRestaurant(Restaurant restaurant)
        {
            var serializer = GetSerializer();
            if (!Directory.Exists(DefaultFolderPath))
                Directory.CreateDirectory(DefaultFolderPath);
            serializer.Serialize(restaurant, DefaultFolderPath);
        }

        public static void SaveRestaurant(List<Restaurant> restaurants)
        {
            foreach (var r in restaurants) SaveRestaurant(r);
        }

        public static List<Restaurant> LoadAllRestaurants()
        {
            var serializer = GetSerializer();
            if (!Directory.Exists(DefaultFolderPath))
            {
                Directory.CreateDirectory(DefaultFolderPath);
                return new List<Restaurant>();
            }
            return serializer.DeserializeAllFiles<Restaurant>(DefaultFolderPath, GetExtension());
        }

        public static void ChangeExtension(string type, List<Restaurant> restaurants)
        {
            if (type == "JSON") File.WriteAllText(formatFilePath, "json");
            else File.WriteAllText(formatFilePath, "xml");
            SaveRestaurant(restaurants);
        }

        public static void DeleteRestaurant(Restaurant restaurant)
        {
            var folder = Path.Combine(DefaultFolderPath, restaurant.Name);
            if (!Directory.Exists(folder)) return;
            var files = Directory.GetFiles(folder);
            foreach (var file in files)
            {
                File.Delete(file);
            }
            Directory.Delete(folder);
        }
    }
} 