using Model.Core.MenuClasses;
using Model.Core.RestaurantClasses;
using Model.Core.DishClasses;
using RestaurantMenu.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Model.Data;

namespace RestaurantMenu
{
    public partial class Form2 : Form
    {
        private readonly Restaurant _restaurant;
        private IMenu _menu;
        private readonly bool _isSeasonalMenu;
        private Func<Dish, bool> _currentFilter;
        public void Reload(){
            InitializeDishTypeFilter();
            FillMenuTable();
        }
        public Form2(Restaurant restaurant, IMenu menu, bool isSeasonalMenu = false)
        {
            InitializeComponent();
            _restaurant = restaurant;
            _menu = menu;
            _isSeasonalMenu = isSeasonalMenu;
            _currentFilter = dish => true;
            menuDataGridView.CellClick += MenuDataGridView_CellClick;
            clearMenuButton.Enabled = _isSeasonalMenu;
        }
        private void ClearMenuButton_Click(object sender, EventArgs e)
        {
            if (!_isSeasonalMenu) return;
            var result = MessageBox.Show("Вы уверены, что хотите очистить сезонное меню?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _restaurant.RemoveSeasonalMenu();
                SerializationHelper.SaveRestaurant(_restaurant);
                _menu = new Menu();
                Reload();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = $"Меню ресторана {_restaurant.Name}" + (_isSeasonalMenu ? " (Сезонное)" : "");
            Reload();
        }
        private void InitializeDishTypeFilter()
        {
            dishTypeComboBox.Items.Clear();
            dishTypeComboBox.Items.Add("Все блюда");
            var dishTypes = _menu.Dishes
                .Select(d => d.DishType)
                .Distinct()
                .OrderBy(t => t);
            foreach (var type in dishTypes)
            {
                dishTypeComboBox.Items.Add(type);
            }
            dishTypeComboBox.SelectedIndex = 0;
        }
        private void MenuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteColumn.Index && e.RowIndex >= 0)
            {
                menuDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                saveButton.Enabled = true;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in menuDataGridView.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightPink)
                {
                    var dishName = row.Cells["NameColumn"].Value.ToString();
                    _menu.RemoveDish(dishName);
                }
            }
            SerializationHelper.SaveRestaurant(_restaurant);
            Reload();
            saveButton.Enabled = false;
            MessageBox.Show("Изменения внесены успешно");
        }
        private void FillMenuTable(string filterType = null)
        {
            menuDataGridView.Rows.Clear();
            bool showAllDishes = filterType == null || filterType == "Все блюда";
            // Если количество столбцов больше 4, удаляем лишние (кнопку удалить тоже)
            while (menuDataGridView.Columns.Count > 4) menuDataGridView.Columns.RemoveAt(3);
            List<Dish> dishes;
            if (!_isSeasonalMenu)
            {
                if (showAllDishes) dishes = _menu.Dishes.ToList();
                else dishes = _restaurant.Select(filterType);
            }
            else
            {
                _currentFilter = showAllDishes ? dish => true : dish => dish.DishType == filterType;
                dishes = _menu.Dishes.Where(_currentFilter).ToList();
            }

            if (!showAllDishes && dishes.Count > 0)
            {
                var sampleDish = dishes.FirstOrDefault();
                AddSpecificColumns(sampleDish);
            }
            foreach (var dish in dishes)
            {
                var row = new DataGridViewRow();
                row.CreateCells(menuDataGridView); // Инициализирует ячейки строки 
                row.Cells[0].Value = dish.Name;
                row.Cells[1].Value = dish.Price;
                row.Cells[2].Value = dish.DishType;
                if (!showAllDishes)
                {
                    FillSpecificColumns(row, dish);
                }
                menuDataGridView.Rows.Add(row);
            }
        }
        
        private void AddSpecificColumns(Dish sampleDish)
        {
            if (sampleDish == null) return;
            
            // Получаем информацию о колонках из самого блюда
            var columnInfo = sampleDish.GetColumnInfo();
            
            // Добавляем колонки в таблицу
            foreach (var column in columnInfo)
            {
                AddColumn(column.Key, column.Value);
            }
        }
        
        private void AddColumn(string name, string headerText)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            menuDataGridView.Columns.Insert(menuDataGridView.Columns.Count - 1, column);
        }

        private void FillSpecificColumns(DataGridViewRow row, Dish dish)
        {
            int baseColumnCount = 3; // Количество базовых столбцов (Название, Цена, Тип)
            
            // Получаем значения для колонок из самого блюда
            var columnValues = dish.GetColumnValues();
            
            // Заполняем ячейки значениями
            foreach (var column in columnValues)
            {
                // Найдем индекс колонки по имени
                int index = -1;
                for (int i = baseColumnCount; i < menuDataGridView.Columns.Count - 1; i++)
                {
                    if (menuDataGridView.Columns[i].Name == column.Key)
                    {
                        index = i;
                        break;
                    }
                }
                
                // Если колонка найдена, заполняем ее значением
                if (index >= 0)
                {
                    row.Cells[index].Value = column.Value;
                }
            }
        }

        private void DishTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = dishTypeComboBox.SelectedIndex == 0 ? null : dishTypeComboBox.SelectedItem.ToString();
            FillMenuTable(selectedType);
        }

        private void AddDishButton_Click(object sender, EventArgs e)
        {
            var form3 = new Form3(_menu);
            var result = form3.ShowDialog();
            if (result == DialogResult.OK)
            {
                SerializationHelper.SaveRestaurant(_restaurant);
                Reload();
            }
        }
    }
}
