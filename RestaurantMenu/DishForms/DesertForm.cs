using Model.Core.DishClasses;
using Model.Core.MenuClasses;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class DesertForm : Form
    {
        private readonly IMenu _menu;
        private readonly char[] synt = new char[] {'.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' '};

        public DesertForm(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void DesertForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление десерта";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название десерта!", "Ошибка", 
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

                if (!int.TryParse(caloriesTextBox.Text, out int calories))
                {
                    MessageBox.Show("Калории должны быть числом!", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (calories <= 0)
                {
                    MessageBox.Show("Калории должны быть больше нуля!", "Ошибка", 
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
                    MessageBox.Show("Введите хотя бы один ингредиент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var desert = new Desert("Десерт", nameTextBox.Text, price, hasLactoseCheckBox.Checked, calories, isVeganCheckBox.Checked, ingredients);
    
                if (DishFormFactory.GetAllDishes(_menu).Any(d => d == desert))
                {
                    MessageBox.Show("Такой десерт уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _menu.AddDish(desert);
                MessageBox.Show("Десерт успешно добавлен!", "Успех", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении десерта: {ex.Message}", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
