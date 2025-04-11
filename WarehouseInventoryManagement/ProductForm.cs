using System;
using System.Windows.Forms;

namespace WarehouseInventoryManagement
{
    public class ProductForm : Form
    {
        public ProductForm()
        {
            this.Text = "Управление товарами";
            this.Width = 600;
            this.Height = 400;

            Label label = new Label()
            {
                Text = "Форма управления товарами",
                AutoSize = true,
                Top = 20,
                Left = 20
            };

            this.Controls.Add(label);
        }
    }
}
