using Model.Core.DishClasses;
using System.Collections.Generic;

namespace Model.Core.MenuClasses
{
    public interface IMenu
    {
        List<Dish> Dishes { get; }
        void AddDish(Dish dish);
        void RemoveDish(Dish dish);
        void RemoveDish(string dishName);
    }
}