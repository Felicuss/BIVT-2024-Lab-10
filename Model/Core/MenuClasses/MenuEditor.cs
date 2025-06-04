using Model.Core.DishClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Core.MenuClasses
{
    public partial class Menu : IMenu
    {
        public void AddDish(Dish dish)
        {
            if (_dishes.Contains(dish))
            {
                throw new Exception("Такое блюдо уже существует в этом меню!");
            }
            _dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            _dishes.Remove(dish);
        }

        public void RemoveDish(string dishName)
        {
            var dishes = _dishes.Where(d => d.Name == dishName);
            var dish = dishes.FirstOrDefault();

            if (dish != null)
            {
                _dishes.Remove(dish);
            }
            else
            {
                throw new Exception("Такого блюда нет в меню!");
            }
        }
    }
}
