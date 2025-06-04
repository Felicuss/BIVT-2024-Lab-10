using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Core.DishClasses
{
    public class Salad : Dish
    {
        private string[] _ingredients;
        private bool _containsNuts;
        private double _weight;
        public string[] Ingredients { get => _ingredients; }
        public bool ContainsNuts { get => _containsNuts; }
        public double Weight { get => _weight; }

        public override Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>
            {
                { "IngredientsColumn", "Ингредиенты" },
                { "ContainsNutsColumn", "Содержит орехи" },
                { "WeightColumn", "Вес" }
            };
        }
        
        public override Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>
            {
                { "IngredientsColumn", string.Join(", ", Ingredients) },
                { "ContainsNutsColumn", ContainsNuts ? "Да" : "Нет" },
                { "WeightColumn", Weight }
            };
        }
        
        public Salad(string dishType, string name, int price, string[] ingredients, bool containsNuts, double weight) : base(dishType, name, price)
        {
            if (ingredients == null)
                throw new ArgumentNullException(nameof(ingredients), "Передан пустой массив ингредиентов");
            _ingredients = ingredients.ToArray();
            _containsNuts = containsNuts;
            _weight = weight;
        }
    }
}
