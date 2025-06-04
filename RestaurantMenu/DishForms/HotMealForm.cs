using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class HotMealForm : Form
    {
        private readonly IMenu _menu;

        public HotMealForm(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void HotMealForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление горячего блюда";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название блюда!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(priceTextBox.Text, out int price))
                {
                    MessageBox.Show("Цена должна быть числом!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Цена должна быть больше нуля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(weightTextBox.Text, out int weight))
                {
                    MessageBox.Show("Вес должен быть числом!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (weight <= 0)
                {
                    MessageBox.Show("Вес должен быть больше нуля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cookingTimeTextBox.Text, out int cookingTime))
                {
                    MessageBox.Show("Время приготовления должно быть числом!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cookingTime <= 0)
                {
                    MessageBox.Show("Время приготовления должно быть больше нуля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(temperatureTextBox.Text, out int temperature))
                {
                    MessageBox.Show("Температура подачи должна быть числом!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var hotMeal = new HotMeal(
                    "Горячее блюдо",
                    nameTextBox.Text,
                    price,
                    cookingTime,
                    temperature,
                    isSpicyCheckBox.Checked,
                    weight,
                    isVegetarianCheckBox.Checked
                );
                if (DishFormFactory.GetAllDishes(_menu).Any(d => d == hotMeal))
                {
                    MessageBox.Show("Такое блюдо уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                _menu.AddDish(hotMeal);
                MessageBox.Show("Блюдо успешно добавлено!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении блюда: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temperatureLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
