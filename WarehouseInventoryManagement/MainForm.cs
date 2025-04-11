using System;
using System.Windows.Forms;

namespace WarehouseInventoryManagement
{
    public class MainForm : Form
    {
        private Button btnProducts;
        private Button btnCategories;
        private Button btnSupplies;

        public MainForm()
        {
            this.Text = "Система управления складскими запасами";
            this.Width = 800;
            this.Height = 600;

            Label label = new Label()
            {
                Text = "Выберите раздел для управления:",
                AutoSize = true,
                Top = 30,
                Left = 50
            };

            btnProducts = new Button()
            {
                Text = "Товары",
                Width = 200,
                Top = 80,
                Left = 50
            };
            btnProducts.Click += (sender, e) => new ProductForm().ShowDialog();

            btnCategories = new Button()
            {
                Text = "Категории",
                Width = 200,
                Top = 130,
                Left = 50
            };
            btnCategories.Click += (sender, e) => new CategoryForm().ShowDialog();

            btnSupplies = new Button()
            {
                Text = "Поставки",
                Width = 200,
                Top = 180,
                Left = 50
            };
            btnSupplies.Click += (sender, e) => new SupplyForm().ShowDialog();

            this.Controls.Add(label);
            this.Controls.Add(btnProducts);
            this.Controls.Add(btnCategories);
            this.Controls.Add(btnSupplies);
        }
    }
}
