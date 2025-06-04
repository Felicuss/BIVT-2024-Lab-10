using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public static class DishFormFactory
    {
        //
        public static List<string> GetDishTypes => _dishTypesList;
        // Словарь, где ключ тип блюда (по типу Десерт, Горячее, Салат, Суп, Напиток) и значение - функция формы, где передается меню и возвращается форма
        private static readonly Dictionary<string, Func<IMenu, Form>> _formCreators = new Dictionary<string, Func<IMenu, Form>>();
        private static readonly List<string> _dishTypesList = new List<string>();

        // Конструктор, сюда можно че то добавить еще
        static DishFormFactory()
        {
            // Регистрация стандартных типов блюд в нужном порядке
            RegisterDishForm("Горячее", menu => new HotMealForm(menu));
            RegisterDishForm("Десерт", menu => new DesertForm(menu));
            RegisterDishForm("Салат", menu => new SaladForm(menu));
            RegisterDishForm("Суп", menu => new SoupForm(menu));
            RegisterDishForm("Напиток", menu => new DrinksForm(menu));
        }
        public static void RegisterDishForm(string dishType, Func<IMenu, Form> formCreator)
        {
            _formCreators.Add(dishType, formCreator);
            _dishTypesList.Add(dishType);
        }
        public static Form CreateDishForm(string dishType, IMenu menu)
        {
            // Проверяем, есть ли такой тип в словаре
            if (_formCreators.ContainsKey(dishType))
            {
                // Получаем функцию-создатель
                var createFunction = _formCreators[dishType];
                // Вызываем её с параметром menu
                return createFunction(menu);
            }
            return null;
        }
        public static List<Dish> GetAllDishes(IMenu menu){
            var menu1 = menu as Menu;
            var dishes = menu1.Dishes;
            return dishes;
        }
        
    }
} 