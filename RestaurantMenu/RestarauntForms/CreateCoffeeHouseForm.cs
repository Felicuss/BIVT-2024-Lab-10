using Model.Core.MenuClasses;
using Model.Core.RestaurantClasses;
using Model.Data;
using System;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class CreateCoffeeHouseForm : Form
    {
        public CreateCoffeeHouseForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    var coffeeHouse = new CoffeeHouse(
                        nameTextBox.Text,
                        new Menu(),
                        addressTextBox.Text,
                        phoneTextBox.Text,
                        workingHoursTextBox.Text,
                        (int)ratingNumeric.Value,
                        hasWiFiCheckBox.Checked,
                        hasTablesCheckBox.Checked,
                        (int)maxCapacityNumeric.Value
                    );
                    if (Form1.Restaurants.Any(r => r == coffeeHouse))
                    {
                        MessageBox.Show("Заведение с таким названием уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.None;
                        return;
                    }
                    SerializationHelper.SaveRestaurant(coffeeHouse);
                    MessageBox.Show("Кофейня успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании кофейни: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Введите название кофейни", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Введите адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(workingHoursTextBox.Text))
            {
                MessageBox.Show("Введите время работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (maxCapacityNumeric.Value < 1)
            {
                MessageBox.Show("Максимальная вместимость должна быть больше 0", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CreateCoffeeHouseForm_Load(object sender, EventArgs e)
        {

        }
    }
} 