using System;

namespace Model.Core.MenuClasses
{
    public interface ISeasonalMenu
    {
        IMenu SeasonalMenu { get; }
        bool HasSeasonalMenu { get; }
        void AddSeasonalMenu(IMenu menu);
        void RemoveSeasonalMenu();
    }
}