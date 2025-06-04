namespace RestaurantMenu
{
    partial class DrinksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinksForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            isHotCheckBox = new CheckBox();
            withSugarCheckBox = new CheckBox();
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
            // isHotCheckBox
            // 
            isHotCheckBox.AutoSize = true;
            isHotCheckBox.Font = new Font("Segoe UI", 11F);
            isHotCheckBox.Location = new Point(120, 95);
            isHotCheckBox.Name = "isHotCheckBox";
            isHotCheckBox.Size = new Size(148, 24);
            isHotCheckBox.TabIndex = 4;
            isHotCheckBox.Text = "Горячий напиток";
            // 
            // withSugarCheckBox
            // 
            withSugarCheckBox.AutoSize = true;
            withSugarCheckBox.Font = new Font("Segoe UI", 11F);
            withSugarCheckBox.Location = new Point(120, 125);
            withSugarCheckBox.Name = "withSugarCheckBox";
            withSugarCheckBox.Size = new Size(100, 24);
            withSugarCheckBox.TabIndex = 5;
            withSugarCheckBox.Text = "С сахаром";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(40, 167, 69);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(69, 166);
            addButton.Name = "addButton";
            addButton.Size = new Size(250, 35);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // DrinksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 235);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(isHotCheckBox);
            Controls.Add(withSugarCheckBox);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DrinksForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += DrinksForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private CheckBox isHotCheckBox;
        private CheckBox withSugarCheckBox;
        private Button addButton;
    }
}