using System;
using System.Windows.Forms;

namespace WarehouseInventoryManagement
{
    public class CategoryForm : Form
    {
        public CategoryForm()
        {
            this.Text = "Управление категориями";
            this.Width = 600;
            this.Height = 400;

            Label label = new Label()
            {
                Text = "Форма управления категориями",
                AutoSize = true,
                Top = 20,
                Left = 20
            };

            this.Controls.Add(label);
        }
    }
}
