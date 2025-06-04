namespace RestaurantMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label3 = new Label();
            EnterButton = new Button();
            comboBox2 = new ComboBox();
            label2 = new Label();
            btnAddRestaurant = new Button();
            panel2 = new Panel();
            button1 = new Button();
            lblRestaurantInfo = new Label();
            Selectmenu = new ComboBox();
            comboBoxType = new ComboBox();
            labelType = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(195, 17);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Выберите ресторан:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EnterButton);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAddRestaurant);
            panel1.Location = new Point(18, 90);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 308);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 60);
            button2.Name = "button2";
            button2.Size = new Size(195, 33);
            button2.TabIndex = 5;
            button2.Text = "Удалить ресторан";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(3, 211);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Текущий формат:";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Gainsboro;
            EnterButton.ForeColor = Color.Black;
            EnterButton.Location = new Point(60, 263);
            EnterButton.Margin = new Padding(3, 2, 3, 2);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(100, 28);
            EnterButton.TabIndex = 3;
            EnterButton.Text = "Выбрать";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(42, 236);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 183);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 1;
            label2.Text = "Формат сохранения";
            // 
            // btnAddRestaurant
            // 
            btnAddRestaurant.BackColor = Color.FromArgb(40, 167, 69);
            btnAddRestaurant.Font = new Font("Segoe UI", 10F);
            btnAddRestaurant.ForeColor = Color.White;
            btnAddRestaurant.Location = new Point(12, 20);
            btnAddRestaurant.Margin = new Padding(12, 20, 12, 2);
            btnAddRestaurant.Name = "btnAddRestaurant";
            btnAddRestaurant.Size = new Size(195, 35);
            btnAddRestaurant.TabIndex = 0;
            btnAddRestaurant.Text = "Добавить ресторан";
            btnAddRestaurant.UseVisualStyleBackColor = false;
            btnAddRestaurant.Click += btnAddRestaurant_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblRestaurantInfo);
            panel2.Location = new Point(254, 90);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 308);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Enabled = false;
            button1.Location = new Point(152, 260);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(149, 35);
            button1.TabIndex = 1;
            button1.Text = "Посмотреть меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblRestaurantInfo
            // 
            lblRestaurantInfo.AutoSize = true;
            lblRestaurantInfo.Font = new Font("Segoe UI", 10F);
            lblRestaurantInfo.Location = new Point(20, 20);
            lblRestaurantInfo.Margin = new Padding(20);
            lblRestaurantInfo.Name = "lblRestaurantInfo";
            lblRestaurantInfo.Size = new Size(0, 19);
            lblRestaurantInfo.TabIndex = 0;
            // 
            // Selectmenu
            // 
            Selectmenu.DropDownStyle = ComboBoxStyle.DropDownList;
            Selectmenu.Enabled = false;
            Selectmenu.Font = new Font("Segoe UI", 10F);
            Selectmenu.FormattingEnabled = true;
            Selectmenu.Items.AddRange(new object[] { "Основное меню", "Сезонное меню" });
            Selectmenu.Location = new Point(470, 17);
            Selectmenu.Margin = new Padding(3, 2, 3, 2);
            Selectmenu.Name = "Selectmenu";
            Selectmenu.Size = new Size(239, 25);
            Selectmenu.TabIndex = 4;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 10F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(195, 52);
            comboBoxType.Margin = new Padding(3, 2, 3, 2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(260, 25);
            comboBoxType.TabIndex = 5;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 11F);
            labelType.Location = new Point(18, 52);
            labelType.Name = "labelType";
            labelType.Size = new Size(120, 20);
            labelType.TabIndex = 6;
            labelType.Text = "Фильтр по типу:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(730, 421);
            Controls.Add(labelType);
            Controls.Add(comboBoxType);
            Controls.Add(Selectmenu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(746, 460);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление ресторанами";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private Button btnAddRestaurant;
        private Panel panel2;
        private Label lblRestaurantInfo;
        private Button button1;
        private ComboBox Selectmenu;
        private Label label2;
        private Button EnterButton;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBoxType;
        private Label labelType;
        private Button button2;
    }
}
