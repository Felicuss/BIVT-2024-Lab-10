using System;
using System.Collections.Generic;

namespace Model.Core.DishClasses
{
    public abstract class Dish
    {
        private string _name;
        private int _price;
        private string _dishType;
        public string Name { get => _name; }
        public int Price { get => _price; }
        public string DishType { get => _dishType; }
        public virtual Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>();
        }
        public virtual Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>();
        }
        
        public Dish(string dishType, string name, int price)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Имя блюда не может быть пустым");
            _dishType = dishType;
            _name = name;
            _price = price;
        }
        
        public static bool operator ==(Dish dish1, Dish dish2){
            if (ReferenceEquals(dish1, null) && ReferenceEquals(dish2, null))
                return true;
            if (ReferenceEquals(dish1, null) || ReferenceEquals(dish2, null))
                return false;
            return dish1.Name == dish2.Name;
        }

        public static bool operator !=(Dish dish1, Dish dish2){
            return !(dish1 == dish2);
        }
    }
}