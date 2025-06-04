using Model.Core.MenuClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class Form3 : Form
    {
        private readonly IMenu _menu;

        public Form3(IMenu menu)
        {
            InitializeComponent();
            _menu = menu;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            selectButton.Enabled = false;
            FillComboBox();
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            
            // тут получаем типы блюд
            foreach (var dishType in DishFormFactory.GetDishTypes)
            {
                comboBox1.Items.Add(dishType);
            }
            
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectButton.Enabled = comboBox1.SelectedIndex != -1;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedDishType = comboBox1.SelectedItem.ToString();
            // Определяем какую форму юзать и создаем ее
            Form dishForm = DishFormFactory.CreateDishForm(selectedDishType, _menu);
            if (dishForm != null)
            {
                var result = dishForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                // Если получили ОК, то зыкрываем форму
            }
        }
    }
}
