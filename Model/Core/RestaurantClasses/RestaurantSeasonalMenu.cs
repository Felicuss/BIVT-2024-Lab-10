using Model.Core.MenuClasses;
using System;

namespace Model.Core.RestaurantClasses
{
    public abstract partial class Restaurant : ISeasonalMenu
    {
        private IMenu _seasonMenu;
        public IMenu SeasonalMenu { get => _seasonMenu; }
        public bool HasSeasonalMenu { get => _seasonMenu != null; }
        public void AddSeasonalMenu(IMenu menu)
        {
            if (menu == null)
                throw new ArgumentNullException(nameof(menu), "Меню не может быть null");
            _seasonMenu = menu;
        }

        public void RemoveSeasonalMenu()
        {
            _seasonMenu = new Menu();
        }

    }
}
