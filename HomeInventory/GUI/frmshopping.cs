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
    public partial class frmshopping : Form
    {
        FormState frmState = FormState.Add;
        Item currentItem = new Item();
        public frmshopping()
        {
            InitializeComponent();
        }

        private void frmshopping_Load(object sender, EventArgs e)
        {
            itemDataGridView.Show();
            // TODO: This line of code loads data into the 'itemDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.itemDataSet.Item);

            SetFormState();
            RefreshItemGrid();
            txtitemname.Focus();
        }
        private void SetFormState()
        {
            if (frmState == FormState.Add)
            {
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
            }
            else if (frmState == FormState.WaitingToSave)
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
            }
            else if (frmState == FormState.WaitingToSaveOrDelete)
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }
            txtitemname.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();

            ClearForm();
        }
        private void ClearForm()
        {
           txtitemname.Text = "";
            txtunit.Text = "";
            txtQuantity.Text = "";

            txtitemname.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemsDAL.DeleteItem(currentItem);

            frmState = FormState.Add;
            SetFormState();
            RefreshItemGrid();
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmState == FormState.WaitingToSave)
            {
                currentItem.ItemName = txtitemname.Text;
                currentItem.Unit = txtunit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
                currentItem.UserID = 1;

                ItemsDAL.CreateItem(currentItem);
            }
            else if (frmState == FormState.WaitingToSaveOrDelete)
            {
                currentItem.ItemName = txtitemname.Text;
                currentItem.Unit = txtunit.Text;
                currentItem.Quantity = double.Parse(txtQuantity.Text);
                ItemsDAL.UpdateItem(currentItem);
            }


            frmState = FormState.Add;
            SetFormState();
            RefreshItemGrid();
            ClearForm();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmState = FormState.WaitingToSave;
            SetFormState();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemDataSet);

        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = new DataGridViewRow();
            currentRow = itemDataGridView.Rows[e.RowIndex];

            currentItem.ItemID = int.Parse(currentRow.Cells[0].Value.ToString());
            currentItem.ItemName = currentRow.Cells[1].Value.ToString();
            currentItem.Unit = currentRow.Cells[2].Value.ToString();
            currentItem.Quantity = double.Parse(currentRow.Cells[3].Value.ToString());
            currentItem.UserID = int.Parse(currentRow.Cells[4].Value.ToString());

            txtitemname.Text = currentItem.ItemName;
            txtunit.Text = currentItem.Unit;
            txtQuantity.Text = currentItem.Quantity.ToString();


            frmState = FormState.WaitingToSaveOrDelete;
            SetFormState();
        }
        private void RefreshItemGrid()
        {
            itemDataGridView.DataSource = ItemsDAL.GetAllItem();
        }
    }
}
