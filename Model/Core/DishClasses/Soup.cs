using System;
using System.Collections.Generic;

namespace Model.Core.DishClasses
{
    public class Soup : Dish
    {
        private string[] _ingredients;
        private double _weight;
        private bool _isVegan;
        public string[] Ingredients { get => _ingredients; }
        public double Weight { get => _weight; }
        public bool IsVegan { get => _isVegan; }

        public override Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>
            {
                { "IngredientsColumn", "Ингредиенты" },
                { "WeightColumn", "Вес" },
                { "IsVeganColumn", "Веганский" }
            };
        }
        
        public override Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>
            {
                { "IngredientsColumn", string.Join(", ", Ingredients) },
                { "WeightColumn", Weight },
                { "IsVeganColumn", IsVegan ? "Да" : "Нет" }
            };
        }
        
        public Soup(string dishType, string name, int price, string[] ingredients, double weight, bool isVegan) : base(dishType, name, price)
        {
            if (ingredients == null)
                throw new ArgumentNullException(nameof(ingredients), "Передан пустой массив ингредиентов");
            _ingredients = ingredients.ToArray();
            _weight = weight;
            _isVegan = isVegan;
        }
    }
}