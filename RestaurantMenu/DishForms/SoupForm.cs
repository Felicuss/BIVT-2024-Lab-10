using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class SoupForm : Form
    {
        private readonly char[] synt = new char[] {'.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' '};
        private readonly IMenu _menu;

        public SoupForm(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void SoupForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление супа";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название супа!", "Ошибка", 
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

                var soup = new Soup("Суп", nameTextBox.Text, price, ingredients, weight, isVeganCheckBox.Checked);

                if (DishFormFactory.GetAllDishes(_menu).Any(d => d == soup))
                {
                    MessageBox.Show("Такой суп уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                _menu.AddDish(soup);
                MessageBox.Show("Суп успешно добавлен!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении супа: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
