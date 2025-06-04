namespace RestaurantMenu
{
    partial class SoupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoupForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            ingredientsLabel = new Label();
            ingredientsTextBox = new TextBox();
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
            // isVeganCheckBox
            // 
            isVeganCheckBox.AutoSize = true;
            isVeganCheckBox.Font = new Font("Segoe UI", 11F);
            isVeganCheckBox.Location = new Point(120, 175);
            isVeganCheckBox.Name = "isVeganCheckBox";
            isVeganCheckBox.Size = new Size(127, 24);
            isVeganCheckBox.TabIndex = 8;
            isVeganCheckBox.Text = "Веганский суп";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(40, 167, 69);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(78, 217);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 35);
            addButton.TabIndex = 9;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // SoupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 290);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(weightLabel);
            Controls.Add(weightTextBox);
            Controls.Add(ingredientsLabel);
            Controls.Add(ingredientsTextBox);
            Controls.Add(isVeganCheckBox);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SoupForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += SoupForm_Load;
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
        private Label ingredientsLabel;
        private TextBox ingredientsTextBox;
        private CheckBox isVeganCheckBox;
        private Button addButton;
    }
}