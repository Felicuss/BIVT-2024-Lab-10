using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Core.RestaurantClasses
{
    public abstract partial class Restaurant : ISeasonalMenu
    {
        public List<Dish> Select(Type type)
        {
            if (_menu == null) return new List<Dish>();
            List<Dish> selectList = new List<Dish>();
            foreach (var dish in _menu.Dishes)
            {
                if (dish.GetType() == type)
                {
                    selectList.Add(dish);
                }
            }
            return selectList;
        }

        public List<Dish> Select(string nameType)
        {
            if (_menu == null) return new List<Dish>();
            List<Dish> selectList = new List<Dish>();
            foreach (var dish in _menu.Dishes)
            {
                if (dish.DishType.Equals(nameType))
                {
                    selectList.Add(dish);
                }
            }
            return selectList;
        }
    }
}
