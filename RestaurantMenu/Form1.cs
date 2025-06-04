using Model.Core.RestaurantClasses;
using Model.Core.MenuClasses;
using Model.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace RestaurantMenu
{
    public partial class Form1 : Form
    {
        private static List<Restaurant> restaurants = new List<Restaurant>();
        public static List<Restaurant> Restaurants => restaurants;
        private List<Restaurant> filteredRestaurants = new List<Restaurant>();
        private readonly string ALL_TYPES = "Все";
        private string GetRestaurantTypeDisplay(Restaurant restaurant)
        {
            return restaurant.RestaurantType;
        }

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRestaurants();
            FillRestaurantTypesComboBox();
            filteredRestaurants = new List<Restaurant>(restaurants);
            FillComboBox();
            FillComboBoxForExtension();
            EnterButton.Enabled = false;
            var exst = SerializationHelper.GetExtension();
            label3.Text = $"Текущий формат: {exst}";
            Selectmenu.SelectedIndex = -1;
            Selectmenu.SelectedIndexChanged += Selectmenu_SelectedIndexChanged;
            Selectmenu.Items.Clear();
            Selectmenu.Items.Add("Основное меню");
            Selectmenu.Items.Add("Сезонное меню");
        }

        private void LoadRestaurants()
        {
            try
            {
                restaurants = SerializationHelper.LoadAllRestaurants();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ресторанов: {ex.Message}. Если ошибка повторяется, обратитесь в поддержку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboBoxForExtension()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("XML");
            comboBox2.Items.Add("JSON");
            comboBox2.SelectedIndex = -1;
        }
        private void FillRestaurantTypesComboBox()
        {
            comboBoxType.Items.Clear();
            comboBoxType.Items.Add(ALL_TYPES);
            var restaurantTypes = restaurants.Select(GetRestaurantTypeDisplay).Distinct().ToList();
            foreach (var type in restaurantTypes)
            {
                comboBoxType.Items.Add(type);
            }
            comboBoxType.SelectedIndex = 0;
        }
        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var restaurant in filteredRestaurants) comboBox1.Items.Add($"{restaurant.Name}");
            comboBox1.SelectedIndex = -1;
            lblRestaurantInfo.Text = "";
            Selectmenu.Enabled = false;
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                button2.Enabled = true;
                var selectedRestaurant = filteredRestaurants[comboBox1.SelectedIndex];
                DisplayRestaurantInfo(selectedRestaurant);
                Selectmenu.Enabled = true;
                Selectmenu.SelectedIndex = -1;
                button1.Enabled = false;
            }
            else
            {
                button2.Enabled = false;
                Selectmenu.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Selectmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = Selectmenu.SelectedIndex >= 0;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxType.SelectedItem.ToString();

            if (selectedType == ALL_TYPES)
            {
                filteredRestaurants = new List<Restaurant>(restaurants);
            }
            else
            {
                filteredRestaurants = restaurants.Where(r => GetRestaurantTypeDisplay(r) == selectedType).ToList();
            }
            FillComboBox();
        }

        private void DisplayRestaurantInfo(Restaurant restaurant)
        {
            var infoBuilder = new StringBuilder();
            infoBuilder.AppendLine($"Тип заведения: {GetRestaurantTypeDisplay(restaurant)}");
            infoBuilder.AppendLine($"Название: {restaurant.Name}");
            infoBuilder.AppendLine($"Адрес: {restaurant.Address}");
            infoBuilder.AppendLine($"Телефон: {restaurant.PhoneNumber}");
            infoBuilder.AppendLine($"Время работы: {restaurant.WorkingHours}");
            infoBuilder.AppendLine($"Рейтинг: {restaurant.Rating}/5");
            infoBuilder.AppendLine();
            if (restaurant is FullRestaurant fullRestaurant)
            {
                AddFullRestaurantInfo(infoBuilder, fullRestaurant);
            }
            else if (restaurant is Cafe cafe)
            {
                AddCafeInfo(infoBuilder, cafe);
            }
            else if (restaurant is CoffeeHouse coffeeHouse)
            {
                AddCoffeeHouseInfo(infoBuilder, coffeeHouse);
            }
            lblRestaurantInfo.Text = infoBuilder.ToString();
        }
        private void AddFullRestaurantInfo(StringBuilder infoBuilder, FullRestaurant restaurant)
        {
            infoBuilder.AppendLine($"Бар: {(restaurant.HasBar ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Терраса: {(restaurant.HasTerrace ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Количество столиков: {restaurant.TableCount}");
        }

        private void AddCafeInfo(StringBuilder infoBuilder, Cafe cafe)
        {
            infoBuilder.AppendLine($"WiFi: {(cafe.HasWiFi ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Настольные игры: {(cafe.HasTableGames ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Максимальная вместимость: {cafe.MaxCapacity} человек");
        }

        private void AddCoffeeHouseInfo(StringBuilder infoBuilder, CoffeeHouse coffeeHouse)
        {
            infoBuilder.AppendLine($"WiFi: {(coffeeHouse.HasWiFi ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Столики: {(coffeeHouse.HasTables ? "Есть" : "Нет")}");
            infoBuilder.AppendLine($"Максимальная вместимость: {coffeeHouse.MaxCapacity} человек");
        }

        // Клик на посмотреть меню
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                var selectedRestaurant = filteredRestaurants[comboBox1.SelectedIndex];
                var selectedMenuType = Selectmenu.SelectedItem?.ToString();
                bool isSeasonalMenu = selectedMenuType == "Сезонное меню";
                IMenu menuToShow = isSeasonalMenu ?
                    selectedRestaurant.SeasonalMenu :
                    selectedRestaurant.Menu;
                Form2 menuForm = new Form2(selectedRestaurant, menuToShow, isSeasonalMenu);
                menuForm.Show();
            }
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            if (new SelectRestaurantTypeForm().ShowDialog() == DialogResult.OK)
            {
                LoadRestaurants();
                FillRestaurantTypesComboBox();
                comboBoxType_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }
        // Клик на изменить формат
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                var choice = comboBox2.SelectedItem.ToString();
                if (choice == null) return;
                SerializationHelper.ChangeExtension(choice, restaurants);
                MessageBox.Show(
                    $"Формат сохранения успешно изменен на {choice}!",
                    "Успешно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Form1_Load(this, EventArgs.Empty);
            }
        }
        // Ивент, который смотрит, когда мы че то выбрали в ComboBox для формата
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0) EnterButton.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Кнопка удаления ресторана
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRestaurant = filteredRestaurants[comboBox1.SelectedIndex];
            DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить ресторан \"{selectedRestaurant.Name}\"?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SerializationHelper.DeleteRestaurant(selectedRestaurant);
                MessageBox.Show($"Ресторан \"{selectedRestaurant.Name}\" успешно удален.", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRestaurants(); 
                FillRestaurantTypesComboBox(); 
                comboBoxType_SelectedIndexChanged(this, EventArgs.Empty); 
            }
        }
    }
}
