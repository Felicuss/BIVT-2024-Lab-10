namespace RestaurantMenu
{
    partial class CreateCoffeeHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCoffeeHouseForm));
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            workingHoursTextBox = new TextBox();
            ratingNumeric = new NumericUpDown();
            hasWiFiCheckBox = new CheckBox();
            hasTablesCheckBox = new CheckBox();
            maxCapacityNumeric = new NumericUpDown();
            createButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ratingNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxCapacityNumeric).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 11F);
            nameTextBox.Location = new Point(151, 23);
            nameTextBox.Margin = new Padding(4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(310, 27);
            nameTextBox.TabIndex = 0;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 11F);
            addressTextBox.Location = new Point(151, 58);
            addressTextBox.Margin = new Padding(4);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(310, 27);
            addressTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 11F);
            phoneTextBox.Location = new Point(151, 92);
            phoneTextBox.Margin = new Padding(4);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(310, 27);
            phoneTextBox.TabIndex = 2;
            // 
            // workingHoursTextBox
            // 
            workingHoursTextBox.Font = new Font("Segoe UI", 11F);
            workingHoursTextBox.Location = new Point(151, 127);
            workingHoursTextBox.Margin = new Padding(4);
            workingHoursTextBox.Name = "workingHoursTextBox";
            workingHoursTextBox.Size = new Size(310, 27);
            workingHoursTextBox.TabIndex = 3;
            // 
            // ratingNumeric
            // 
            ratingNumeric.Font = new Font("Segoe UI", 11F);
            ratingNumeric.Location = new Point(151, 161);
            ratingNumeric.Margin = new Padding(4);
            ratingNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ratingNumeric.Name = "ratingNumeric";
            ratingNumeric.Size = new Size(88, 27);
            ratingNumeric.TabIndex = 4;
            // 
            // hasWiFiCheckBox
            // 
            hasWiFiCheckBox.AutoSize = true;
            hasWiFiCheckBox.Font = new Font("Segoe UI", 11F);
            hasWiFiCheckBox.Location = new Point(151, 231);
            hasWiFiCheckBox.Margin = new Padding(4);
            hasWiFiCheckBox.Name = "hasWiFiCheckBox";
            hasWiFiCheckBox.Size = new Size(90, 24);
            hasWiFiCheckBox.TabIndex = 6;
            hasWiFiCheckBox.Text = "Есть WiFi";
            hasWiFiCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasTablesCheckBox
            // 
            hasTablesCheckBox.AutoSize = true;
            hasTablesCheckBox.Font = new Font("Segoe UI", 11F);
            hasTablesCheckBox.Location = new Point(151, 266);
            hasTablesCheckBox.Margin = new Padding(4);
            hasTablesCheckBox.Name = "hasTablesCheckBox";
            hasTablesCheckBox.Size = new Size(116, 24);
            hasTablesCheckBox.TabIndex = 7;
            hasTablesCheckBox.Text = "Есть столики";
            hasTablesCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxCapacityNumeric
            // 
            maxCapacityNumeric.Font = new Font("Segoe UI", 11F);
            maxCapacityNumeric.Location = new Point(151, 197);
            maxCapacityNumeric.Margin = new Padding(4);
            maxCapacityNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            maxCapacityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxCapacityNumeric.Name = "maxCapacityNumeric";
            maxCapacityNumeric.Size = new Size(88, 27);
            maxCapacityNumeric.TabIndex = 5;
            maxCapacityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(40, 167, 69);
            createButton.DialogResult = DialogResult.OK;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(85, 324);
            createButton.Margin = new Padding(4);
            createButton.Name = "createButton";
            createButton.Size = new Size(134, 38);
            createButton.TabIndex = 8;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(108, 117, 125);
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(247, 324);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(134, 38);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 10;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(50, 50, 50);
            label2.Location = new Point(24, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "Адрес:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(50, 50, 50);
            label3.Location = new Point(24, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 12;
            label3.Text = "Телефон:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(50, 50, 50);
            label4.Location = new Point(24, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 13;
            label4.Text = "Время работы:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(50, 50, 50);
            label5.Location = new Point(24, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 14;
            label5.Text = "Рейтинг:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(50, 50, 50);
            label6.Location = new Point(24, 200);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 15;
            label6.Text = "Вместимость:";
            // 
            // CreateCoffeeHouseForm
            // 
            AcceptButton = createButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            CancelButton = cancelButton;
            ClientSize = new Size(481, 391);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(createButton);
            Controls.Add(maxCapacityNumeric);
            Controls.Add(hasTablesCheckBox);
            Controls.Add(hasWiFiCheckBox);
            Controls.Add(ratingNumeric);
            Controls.Add(workingHoursTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(nameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateCoffeeHouseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создание кофейни";
            Load += CreateCoffeeHouseForm_Load;
            ((System.ComponentModel.ISupportInitialize)ratingNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxCapacityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private TextBox workingHoursTextBox;
        private NumericUpDown ratingNumeric;
        private CheckBox hasWiFiCheckBox;
        private CheckBox hasTablesCheckBox;
        private NumericUpDown maxCapacityNumeric;
        private Button createButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
} 