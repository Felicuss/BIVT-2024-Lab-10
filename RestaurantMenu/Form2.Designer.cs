namespace RestaurantMenu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            dishTypeComboBox = new ComboBox();
            addDishButton = new Button();
            saveButton = new Button();
            clearMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuDataGridView
            // 
            menuDataGridView.AllowUserToAddRows = false;
            menuDataGridView.AllowUserToDeleteRows = false;
            menuDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, PriceColumn, TypeColumn, DeleteColumn });
            menuDataGridView.Location = new Point(10, 45);
            menuDataGridView.Margin = new Padding(3, 2, 3, 2);
            menuDataGridView.Name = "menuDataGridView";
            menuDataGridView.ReadOnly = true;
            menuDataGridView.RowHeadersVisible = false;
            menuDataGridView.RowHeadersWidth = 51;
            menuDataGridView.Size = new Size(663, 256);
            menuDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Тип блюда";
            TypeColumn.MinimumWidth = 6;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Действия";
            DeleteColumn.MinimumWidth = 6;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Text = "Удалить";
            DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // dishTypeComboBox
            // 
            dishTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dishTypeComboBox.Font = new Font("Segoe UI", 12F);
            dishTypeComboBox.FormattingEnabled = true;
            dishTypeComboBox.Location = new Point(10, 9);
            dishTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            dishTypeComboBox.Name = "dishTypeComboBox";
            dishTypeComboBox.Size = new Size(219, 29);
            dishTypeComboBox.TabIndex = 1;
            dishTypeComboBox.SelectedIndexChanged += DishTypeComboBox_SelectedIndexChanged;
            // 
            // addDishButton
            // 
            addDishButton.Location = new Point(245, 9);
            addDishButton.Margin = new Padding(3, 2, 3, 2);
            addDishButton.Name = "addDishButton";
            addDishButton.Size = new Size(131, 27);
            addDishButton.TabIndex = 3;
            addDishButton.Text = "Добавить блюдо";
            addDishButton.UseVisualStyleBackColor = true;
            addDishButton.Click += AddDishButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(542, 9);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(131, 27);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // clearMenuButton
            // 
            clearMenuButton.Location = new Point(394, 9);
            clearMenuButton.Margin = new Padding(3, 2, 3, 2);
            clearMenuButton.Name = "clearMenuButton";
            clearMenuButton.Size = new Size(131, 27);
            clearMenuButton.TabIndex = 4;
            clearMenuButton.Text = "Очистить меню";
            clearMenuButton.UseVisualStyleBackColor = true;
            clearMenuButton.Click += ClearMenuButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 316);
            Controls.Add(addDishButton);
            Controls.Add(saveButton);
            Controls.Add(dishTypeComboBox);
            Controls.Add(menuDataGridView);
            Controls.Add(clearMenuButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(702, 355);
            Name = "Form2";
            Text = "Меню";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)menuDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView menuDataGridView;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewButtonColumn DeleteColumn;
        private ComboBox dishTypeComboBox;
        private Button saveButton;
        private Button addDishButton;
        private Button clearMenuButton;
    }
}