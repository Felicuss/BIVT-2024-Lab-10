namespace RestaurantMenu
{
    partial class HotMealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotMealForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            cookingTimeLabel = new Label();
            cookingTimeTextBox = new TextBox();
            temperatureLabel = new Label();
            temperatureTextBox = new TextBox();
            isSpicyCheckBox = new CheckBox();
            isVegetarianCheckBox = new CheckBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 11F);
            nameLabel.Location = new Point(12, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(80, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 11F);
            nameTextBox.Location = new Point(120, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 27);
            nameTextBox.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 11F);
            priceLabel.Location = new Point(12, 65);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(48, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Цена:";
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 11F);
            priceTextBox.Location = new Point(120, 62);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(250, 27);
            priceTextBox.TabIndex = 3;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Segoe UI", 11F);
            weightLabel.Location = new Point(12, 105);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(56, 20);
            weightLabel.TabIndex = 4;
            weightLabel.Text = "Вес (г):";
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Segoe UI", 11F);
            weightTextBox.Location = new Point(120, 102);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(250, 27);
            weightTextBox.TabIndex = 5;
            // 
            // cookingTimeLabel
            // 
            cookingTimeLabel.AutoSize = true;
            cookingTimeLabel.Font = new Font("Segoe UI", 11F);
            cookingTimeLabel.Location = new Point(12, 145);
            cookingTimeLabel.Name = "cookingTimeLabel";
            cookingTimeLabel.Size = new Size(100, 20);
            cookingTimeLabel.TabIndex = 6;
            cookingTimeLabel.Text = "Время (мин):";
            // 
            // cookingTimeTextBox
            // 
            cookingTimeTextBox.Font = new Font("Segoe UI", 11F);
            cookingTimeTextBox.Location = new Point(120, 142);
            cookingTimeTextBox.Name = "cookingTimeTextBox";
            cookingTimeTextBox.Size = new Size(250, 27);
            cookingTimeTextBox.TabIndex = 7;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new Font("Segoe UI", 11F);
            temperatureLabel.Location = new Point(12, 185);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(103, 20);
            temperatureLabel.TabIndex = 8;
            temperatureLabel.Text = "Температура:";
            temperatureLabel.Click += temperatureLabel_Click;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Font = new Font("Segoe UI", 11F);
            temperatureTextBox.Location = new Point(120, 182);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(250, 27);
            temperatureTextBox.TabIndex = 9;
            // 
            // isSpicyCheckBox
            // 
            isSpicyCheckBox.AutoSize = true;
            isSpicyCheckBox.Font = new Font("Segoe UI", 11F);
            isSpicyCheckBox.Location = new Point(120, 215);
            isSpicyCheckBox.Name = "isSpicyCheckBox";
            isSpicyCheckBox.Size = new Size(128, 24);
            isSpicyCheckBox.TabIndex = 10;
            isSpicyCheckBox.Text = "Острое блюдо";
            // 
            // isVegetarianCheckBox
            // 
            isVegetarianCheckBox.AutoSize = true;
            isVegetarianCheckBox.Font = new Font("Segoe UI", 11F);
            isVegetarianCheckBox.Location = new Point(120, 245);
            isVegetarianCheckBox.Name = "isVegetarianCheckBox";
            isVegetarianCheckBox.Size = new Size(189, 24);
            isVegetarianCheckBox.TabIndex = 11;
            isVegetarianCheckBox.Text = "Вегетарианское блюдо";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(40, 167, 69);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(69, 286);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 35);
            addButton.TabIndex = 12;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // HotMealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 341);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(weightLabel);
            Controls.Add(weightTextBox);
            Controls.Add(cookingTimeLabel);
            Controls.Add(cookingTimeTextBox);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureTextBox);
            Controls.Add(isSpicyCheckBox);
            Controls.Add(isVegetarianCheckBox);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotMealForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += HotMealForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private Label weightLabel;
        private TextBox weightTextBox;
        private Label cookingTimeLabel;
        private TextBox cookingTimeTextBox;
        private Label temperatureLabel;
        private TextBox temperatureTextBox;
        private CheckBox isSpicyCheckBox;
        private CheckBox isVegetarianCheckBox;
        private Button addButton;
    }
}