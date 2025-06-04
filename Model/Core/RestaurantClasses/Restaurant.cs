using Model.Core.MenuClasses;
using System;

namespace Model.Core.RestaurantClasses
{
    public abstract partial class Restaurant : ISeasonalMenu
    {
        private string _name;
        private IMenu _menu;
        private string _address;
        private string _phoneNumber;
        private string _workingHours;
        private int _rating;
        private string _typeRestaurant;

        public string Name { get => _name; }
        public IMenu Menu { get => _menu; }
        public string Address { get => _address; }
        public string PhoneNumber { get => _phoneNumber; }
        public string WorkingHours { get => _workingHours; }
        public int Rating { get => _rating; }
        public string RestaurantType { get => _typeRestaurant; }

        public Restaurant(string name, IMenu menu, string address, string phoneNumber, string workingHours, int rating, string typeRestaurant)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "Название ресторана не может быть пустым");

            if (menu == null)
                throw new ArgumentNullException(nameof(menu), "Меню не может быть null");

            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException(nameof(address), "Адрес не может быть пустым");

            if (string.IsNullOrEmpty(phoneNumber))
                throw new ArgumentNullException(nameof(phoneNumber), "Номер телефона не может быть пустым");

            if (string.IsNullOrEmpty(workingHours))
                throw new ArgumentNullException(nameof(workingHours), "Время работы не может быть пустым");

            if (rating < 0 || rating > 5)
                throw new ArgumentException("Рейтинг должен быть от 0 до 5", nameof(rating));

            _name = name;
            _menu = menu;
            _address = address;
            _phoneNumber = phoneNumber;
            _workingHours = workingHours;
            _rating = rating;
            _seasonMenu = new Menu();
            _typeRestaurant = typeRestaurant;
        }

        public static List<string> GetAllTypes(List<Restaurant> restaurants)
        {
            return restaurants
                .Select(r => r.RestaurantType)
                .Distinct()
                .ToList();
        }

        public static bool operator ==(Restaurant restaurant1, Restaurant restaurant2){
            if (ReferenceEquals(restaurant1, null) && ReferenceEquals(restaurant2, null))
                return true;
            if (ReferenceEquals(restaurant1, null) || ReferenceEquals(restaurant2, null))
                return false;
            return restaurant1.Name == restaurant2.Name;
        }

        public static bool operator !=(Restaurant restaurant1, Restaurant restaurant2){
            return !(restaurant1 == restaurant2);
        }
    }
}