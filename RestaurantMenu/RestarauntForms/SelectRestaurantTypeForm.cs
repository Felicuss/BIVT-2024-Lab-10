using Model.Core.RestaurantClasses;
using System;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class SelectRestaurantTypeForm : Form
    {
        public SelectRestaurantTypeForm()
        {
            InitializeComponent();
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelect.Enabled = comboBoxType.SelectedIndex != -1;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            Form createForm = null;
            string selectedType = comboBoxType.SelectedItem.ToString();

            switch (selectedType)
            {
                case "Ресторан":
                    createForm = new CreateRestaurantForm();
                    break;
                case "Кафе":
                    createForm = new CreateCafeForm();
                    break;
                case "Кофейня":
                    createForm = new CreateCoffeeHouseForm();
                    break;
            }

            if (createForm != null)
            {
                Hide();
                DialogResult result = createForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else Show();
            }
        }

        private void SelectRestaurantTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }
    }
} 