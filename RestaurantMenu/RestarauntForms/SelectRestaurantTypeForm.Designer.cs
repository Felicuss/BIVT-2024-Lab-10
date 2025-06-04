namespace RestaurantMenu
{
    partial class SelectRestaurantTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectRestaurantTypeForm));
            comboBoxType = new ComboBox();
            buttonSelect = new Button();
            labelType = new Label();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 12F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Ресторан", "Кафе", "Кофейня" });
            comboBoxType.Location = new Point(12, 42);
            comboBoxType.Margin = new Padding(3, 2, 3, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(361, 29);
            comboBoxType.TabIndex = 0;
            comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            // 
            // buttonSelect
            // 
            buttonSelect.BackColor = Color.FromArgb(40, 167, 69);
            buttonSelect.Enabled = false;
            buttonSelect.FlatAppearance.BorderSize = 0;
            buttonSelect.FlatStyle = FlatStyle.Flat;
            buttonSelect.Font = new Font("Segoe UI", 12F);
            buttonSelect.ForeColor = Color.White;
            buttonSelect.Location = new Point(140, 84);
            buttonSelect.Margin = new Padding(3, 2, 3, 2);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(114, 34);
            buttonSelect.TabIndex = 1;
            buttonSelect.Text = "Выбрать";
            buttonSelect.UseVisualStyleBackColor = false;
            buttonSelect.Click += ButtonSelect_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelType.ForeColor = Color.FromArgb(50, 50, 50);
            labelType.Location = new Point(12, 9);
            labelType.Name = "labelType";
            labelType.Size = new Size(203, 21);
            labelType.TabIndex = 2;
            labelType.Text = "Выберите тип заведения:";
            // 
            // SelectRestaurantTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(385, 142);
            Controls.Add(labelType);
            Controls.Add(buttonSelect);
            Controls.Add(comboBoxType);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectRestaurantTypeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор типа ресторана";
            Load += SelectRestaurantTypeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelType;
    }
} 