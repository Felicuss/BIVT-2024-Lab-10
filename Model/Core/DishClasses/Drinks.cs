using System;
using System.Collections.Generic;

namespace Model.Core.DishClasses
{
    public class Drinks : Dish
    {
        private bool _isHot;
        private bool _withSugar;
        public bool IsHot { get => _isHot; }
        public bool WithSugar { get => _withSugar; }

        public override Dictionary<string, string> GetColumnInfo()
        {
            return new Dictionary<string, string>
            {
                { "IsHotColumn", "Горячий" },
                { "WithSugarColumn", "С сахаром" }
            };
        }
        
        public override Dictionary<string, object> GetColumnValues()
        {
            return new Dictionary<string, object>
            {
                { "IsHotColumn", IsHot ? "Да" : "Нет" },
                { "WithSugarColumn", WithSugar ? "Да" : "Нет" }
            };
        }

        public Drinks(string dishType, string name, int price, bool isHot, bool withSugar)
            : base(dishType, name, price)
        {
            _isHot = isHot;
            _withSugar = withSugar;
        }
    }
}