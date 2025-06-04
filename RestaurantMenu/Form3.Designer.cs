namespace RestaurantMenu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboBox1 = new ComboBox();
            label1 = new Label();
            selectButton = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 42);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 1;
            label1.Text = "Выберите тип блюда:";
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.FromArgb(40, 167, 69);
            selectButton.Enabled = false;
            selectButton.FlatAppearance.BorderSize = 0;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Segoe UI", 12F);
            selectButton.ForeColor = Color.White;
            selectButton.Location = new Point(135, 84);
            selectButton.Margin = new Padding(3, 2, 3, 2);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(114, 34);
            selectButton.TabIndex = 2;
            selectButton.Text = "Выбрать";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(385, 142);
            Controls.Add(selectButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Выбор типа блюда";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button selectButton;
    }
}