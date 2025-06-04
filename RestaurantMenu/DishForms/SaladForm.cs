using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class SaladForm : Form
    {
        private readonly char[] synt = new char[] {'.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' '};
        private readonly IMenu _menu;

        public SaladForm(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void SaladForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление салата";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название салата!", "Ошибка", 
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

                if (!double.TryParse(weightTextBox.Text, out double weight))
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

                if (string.IsNullOrEmpty(ingredientsTextBox.Text))
                {
                    MessageBox.Show("Введите ингредиенты!", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var ingredients = ingredientsTextBox.Text.Split(synt)
                .Where(word => !string.IsNullOrEmpty(word))
                .Select(word => word.Trim())
                .ToArray();

                if (ingredients.Length == 0)
                {
                    MessageBox.Show("Введите хотя бы один ингредиент!", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var salad = new Salad(
                    "Салат",
                    nameTextBox.Text,
                    price,
                    ingredients,
                    containsNutsCheckBox.Checked,
                    weight
                );

                if (DishFormFactory.GetAllDishes(_menu).Any(d => d == salad))
                {
                    MessageBox.Show("Такой салат уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                _menu.AddDish(salad);
                MessageBox.Show("Салат успешно добавлен!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении салата: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
