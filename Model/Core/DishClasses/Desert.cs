using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Core.DishClasses
{
    public class Desert : Dish
    {
        private bool _hasLactose;
        private int _calories;
        private string[] _ingridients;
        private bool _isVegan;
        public bool HasLactose { get => _hasLactose; }
        public int Calories { get => _calories; }
        public bool IsVegan { get => _isVegan; }
        public string[] Ingridients { get => _ingridients.ToArray(); }

        public override Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>
            {
                { "HasLactoseColumn", "Содержит лактозу" },
                { "CaloriesColumn", "Калории" },
                { "IsVeganColumn", "Веганский" },
                { "IngredientsColumn", "Ингредиенты" }
            };
        }
        
        public override Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>
            {
                { "HasLactoseColumn", HasLactose ? "Да" : "Нет" },
                { "CaloriesColumn", Calories },
                { "IsVeganColumn", IsVegan ? "Да" : "Нет" },
                { "IngredientsColumn", string.Join(", ", Ingridients) }
            };
        }

        public Desert(string dishType, string name, int price, bool hasLactose, int calories, bool isVegan, string[] ingridients) : base(dishType, name, price)
        {
            if (ingridients == null || ingridients.Length == 0)
                throw new ArgumentNullException(nameof(ingridients), "Передан пустой массив состава десерта");
            _ingridients = ingridients.ToArray();
            _hasLactose = hasLactose;
            _calories = calories;
            _isVegan = isVegan;
        }
    }
}
