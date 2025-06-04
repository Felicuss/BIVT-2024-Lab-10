using Model.Core.MenuClasses;
using System;

namespace Model.Core.RestaurantClasses
{
    public class FullRestaurant : Restaurant
    {
        private bool _hasBar;
        private bool _hasTerrace;
        private int _tableCount;

        public bool HasBar { get => _hasBar; }
        public bool HasTerrace { get => _hasTerrace; }
        public int TableCount { get => _tableCount; }

        public FullRestaurant(string name, IMenu menu, string address, string phoneNumber, string workingHours, int rating,
            bool hasBar, bool hasTerrace, int tableCount)
            : base(name, menu, address, phoneNumber, workingHours, rating, "Ресторан")
        {
            if (tableCount <= 0)
                throw new ArgumentException("Количество столов должно быть больше 0", nameof(tableCount));
            _hasBar = hasBar;
            _hasTerrace = hasTerrace;
            _tableCount = tableCount;
        }
    }

    public class Cafe : Restaurant
    {
        private bool _hasWiFi;
        private bool _hasTableGames;
        private int _maxCapacity;

        public bool HasWiFi { get => _hasWiFi; }
        public bool HasTableGames { get => _hasTableGames; }
        public int MaxCapacity { get => _maxCapacity; }

        public Cafe(string name, IMenu menu, string address, string phoneNumber, string workingHours, int rating,
            bool hasWiFi, bool hasPlayground, int maxCapacity)
            : base(name, menu, address, phoneNumber, workingHours, rating, "Кафе")
        {
            if (maxCapacity <= 0)
                throw new ArgumentException("Максимальная вместимость должна быть больше 0", nameof(maxCapacity));

            _hasWiFi = hasWiFi;
            _hasTableGames = hasPlayground;
            _maxCapacity = maxCapacity;
        }
    }
    public class CoffeeHouse : Restaurant
    {
        private bool _hasWiFi;
        private bool _hasTables;
        private int _maxCapacity;

        public bool HasWiFi { get => _hasWiFi; }
        public bool HasTables { get => _hasTables; }
        public int MaxCapacity { get => _maxCapacity; }

        public CoffeeHouse(string name, IMenu menu, string address, string phoneNumber, string workingHours, int rating,
            bool hasWiFi, bool hasTables, int maxCapacity)
            : base(name, menu, address, phoneNumber, workingHours, rating, "Кофейня")
        {
            if (maxCapacity <= 0)
                throw new ArgumentException("Максимальная вместимость должна быть больше 0", nameof(maxCapacity));

            _hasWiFi = hasWiFi;
            _hasTables = hasTables;
            _maxCapacity = maxCapacity;
        }
    }
}