using Model.Core.DishClasses;
using System.Collections.Generic;

namespace Model.Core.MenuClasses
{
    public partial class Menu : IMenu
    {
        private List<Dish> _dishes;
        public List<Dish> Dishes { get => _dishes; }

        public Menu()
        {
            _dishes = new List<Dish>();
        }

        public Menu(List<Dish> dishes)
        {
            _dishes = dishes;
        }

        public static Menu operator +(Menu menu, Dish dish)
        {
            menu.AddDish(dish);
            return menu;
        }
    }
}