using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeInventory.data;
using HomeInventory.entites;
using HomeInventory.GUI;

namespace HomeInventory
{
    public partial class frms : Form
    {
        public frms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" & txtlname.Text == "" & txtpass.Text == "" & txtusername.Text == "")
            {
                MessageBox.Show("FILL TO FEIDS ");

            }

            else
            {
                string message = "HI USER ♥";
                string title = "LOGIN ";

                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons);

            }
        }

        private void lblgotohome_Click(object sender, EventArgs e)
        {
            Form f = null;
            f = new frmHome();
            f.Show();
        }

        private void frms_Load(object sender, EventArgs e)
        {

        }
    }
}
