namespace RestaurantMenu
{
    partial class DesertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesertForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            caloriesLabel = new Label();
            caloriesTextBox = new TextBox();
            ingredientsLabel = new Label();
            ingredientsTextBox = new TextBox();
            hasLactoseCheckBox = new CheckBox();
            isVeganCheckBox = new CheckBox();
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
            // caloriesLabel
            // 
            caloriesLabel.AutoSize = true;
            caloriesLabel.Font = new Font("Segoe UI", 11F);
            caloriesLabel.Location = new Point(12, 105);
            caloriesLabel.Name = "caloriesLabel";
            caloriesLabel.Size = new Size(73, 20);
            caloriesLabel.TabIndex = 4;
            caloriesLabel.Text = "Калории:";
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Font = new Font("Segoe UI", 11F);
            caloriesTextBox.Location = new Point(120, 102);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(250, 27);
            caloriesTextBox.TabIndex = 5;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Segoe UI", 11F);
            ingredientsLabel.Location = new Point(12, 145);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(106, 20);
            ingredientsLabel.TabIndex = 6;
            ingredientsLabel.Text = "Ингредиенты:";
            // 
            // ingredientsTextBox
            // 
            ingredientsTextBox.Font = new Font("Segoe UI", 11F);
            ingredientsTextBox.Location = new Point(120, 142);
            ingredientsTextBox.Name = "ingredientsTextBox";
            ingredientsTextBox.Size = new Size(250, 27);
            ingredientsTextBox.TabIndex = 7;
            // 
            // hasLactoseCheckBox
            // 
            hasLactoseCheckBox.AutoSize = true;
            hasLactoseCheckBox.Font = new Font("Segoe UI", 11F);
            hasLactoseCheckBox.Location = new Point(120, 185);
            hasLactoseCheckBox.Name = "hasLactoseCheckBox";
            hasLactoseCheckBox.Size = new Size(153, 24);
            hasLactoseCheckBox.TabIndex = 8;
            hasLactoseCheckBox.Text = "Содержит лактозу";
            // 
            // isVeganCheckBox
            // 
            isVeganCheckBox.AutoSize = true;
            isVeganCheckBox.Font = new Font("Segoe UI", 11F);
            isVeganCheckBox.Location = new Point(120, 215);
            isVeganCheckBox.Name = "isVeganCheckBox";
            isVeganCheckBox.Size = new Size(149, 24);
            isVeganCheckBox.TabIndex = 9;
            isVeganCheckBox.Text = "Веганское блюдо";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(40, 167, 69);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(80, 256);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 35);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // DesertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 315);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(caloriesLabel);
            Controls.Add(caloriesTextBox);
            Controls.Add(ingredientsLabel);
            Controls.Add(ingredientsTextBox);
            Controls.Add(hasLactoseCheckBox);
            Controls.Add(isVeganCheckBox);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DesertForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += DesertForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private Label caloriesLabel;
        private TextBox caloriesTextBox;
        private Label ingredientsLabel;
        private TextBox ingredientsTextBox;
        private CheckBox hasLactoseCheckBox;
        private CheckBox isVeganCheckBox;
        private Button addButton;
    }
}