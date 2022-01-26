namespace HomeInventory.GUI
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Shopping");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MY Inventory");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Home Inventory ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelcontant = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView1.Location = new System.Drawing.Point(0, 62);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodefrmshopping";
            treeNode1.Text = "Shopping";
            treeNode2.Name = "Nodemyinventory";
            treeNode2.Text = "MY Inventory";
            treeNode3.Name = "Nodehome";
            treeNode3.Text = "Home Inventory ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(183, 385);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelcontant
            // 
            this.panelcontant.Location = new System.Drawing.Point(180, 59);
            this.panelcontant.Name = "panelcontant";
            this.panelcontant.Size = new System.Drawing.Size(620, 388);
            this.panelcontant.TabIndex = 3;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 63);
            this.panelheader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Inventory System";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelcontant);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panelcontant;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
    }
}