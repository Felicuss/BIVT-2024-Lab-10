using System;
using System.Collections.Generic;

namespace Model.Core.DishClasses
{
    public class HotMeal : Dish
    {
        private int _cookingTime;
        private int _temperature;
        private bool _isSpicy;
        private int _portionWeight;
        private bool _isVegetarian;
        public int CookingTime { get => _cookingTime; }
        public int Temperature { get => _temperature; }
        public bool IsSpicy { get => _isSpicy; }
        public int PortionWeight { get => _portionWeight; }
        public bool IsVegetarian { get => _isVegetarian; }
        
        public override Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>
            {
                { "CookingTimeColumn", "Время готовки" },
                { "TemperatureColumn", "Температура" },
                { "IsSpicyColumn", "Острое" },
                { "PortionWeightColumn", "Вес порции" },
                { "IsVegetarianColumn", "Вегетарианское" }
            };
        }
        
        public override Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>
            {
                { "CookingTimeColumn", CookingTime },
                { "TemperatureColumn", Temperature },
                { "IsSpicyColumn", IsSpicy ? "Да" : "Нет" },
                { "PortionWeightColumn", PortionWeight },
                { "IsVegetarianColumn", IsVegetarian ? "Да" : "Нет" }
            };
        }
        
        public HotMeal(string dishType, string name, int price, int cookingTime, int temperature, bool isSpicy, int portionWeight, bool isVegetarian)
            : base(dishType, name, price)
        {
            _cookingTime = cookingTime;
            _temperature = temperature;
            _isSpicy = isSpicy;
            _portionWeight = portionWeight;
            _isVegetarian = isVegetarian;
        }
    }
}