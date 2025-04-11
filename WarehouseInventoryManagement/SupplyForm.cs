using System;
using System.Windows.Forms;

namespace WarehouseInventoryManagement
{
    public class SupplyForm : Form
    {
        public SupplyForm()
        {
            this.Text = "Управление поставками";
            this.Width = 600;
            this.Height = 400;

            Label label = new Label()
            {
                Text = "Форма управления поставками",
                AutoSize = true,
                Top = 20,
                Left = 20
            };

            this.Controls.Add(label);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // SupplyForm
            // 
            ClientSize = new System.Drawing.Size(417, 350);
            Name = "SupplyForm";
            Load += SupplyForm_Load;
            ResumeLayout(false);

        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
