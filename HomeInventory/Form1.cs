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

namespace HomeInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtfname.Text ==""& txtlname.Text == "" & txtpass.Text == "" & txtusername.Text == "")
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
            Form f1 = null;
            f1= new frmHome();
            f1.Show();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.userDataSet.User);
            userDataGridView.Show();

        }

        private void lblsgin_Click(object sender, EventArgs e)
        {
            Form f = null;
            f = new frms();
            f.Show();
        }
    }
}
