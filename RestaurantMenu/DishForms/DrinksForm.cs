using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class DrinksForm : Form
    {
        private readonly IMenu _menu;

        public DrinksForm(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void DrinksForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление напитка";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название напитка!", "Ошибка", 
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
                var drink = new Drinks(
                    "Напиток",
                    nameTextBox.Text,
                    price,
                    isHotCheckBox.Checked,
                    withSugarCheckBox.Checked
                );
                if (DishFormFactory.GetAllDishes(_menu).Any(d => d == drink))
                {
                    MessageBox.Show("Такой напиток уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                _menu.AddDish(drink);
                MessageBox.Show("Напиток успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK; // Возвращает результата ок, Form3 
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении напитка: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
