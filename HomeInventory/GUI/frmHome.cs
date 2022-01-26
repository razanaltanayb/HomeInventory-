using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeInventory.GUI;

namespace HomeInventory.GUI
{
    public partial class frmHome : Form
    {
        private Form currentActiveForm = null;
        public frmHome()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form frm = null;

            TreeNode node = e.Node;

            if (node.Name == "Nodefrmshopping")
                frm = new frmshopping();
            else if (node.Name == "Nodemyinventory")
                frm = new frminv();


            if (frm != null)
            {
                if (currentActiveForm != null && currentActiveForm != frm)
                {
                    currentActiveForm.Close();
                    panelcontant.Controls.Remove(currentActiveForm);
                }

                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.BackColor = Color.Beige;
                currentActiveForm = frm;

                panelcontant.Controls.Add(frm);
                frm.Show();
            }
        }
    }
}
