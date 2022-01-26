using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeInventory.entites;
using HomeInventory.data;
using HomeInventory.Enums;


namespace HomeInventory.GUI
{
    public partial class frminv : Form
    {
        public frminv()
        {
            InitializeComponent();
        }

        private void frminv_Load(object sender, EventArgs e)
        {
            
            cbitem.ValueMember = "ItemID";
            cbitem.DisplayMember = "ItemName";
            cbitem.DataSource = ItemsDAL.GetAllItem();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form ff = null;
            ff = new frmHome();
            ff.Show();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbitem.SelectedValue.ToString()));
            currentItem.Quantity += int.Parse(txtQuantity.Text);
            ItemsDAL.UpdateItem(currentItem);

           
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbitem.SelectedValue.ToString()));
            currentItem.Quantity -= int.Parse(txtQuantity.Text);
            ItemsDAL.UpdateItem(currentItem);
        }
    }
}
