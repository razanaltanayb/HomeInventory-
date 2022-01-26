namespace HomeInventory.GUI
{
    partial class frminv
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
            System.Windows.Forms.Button BTNADD;
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            BTNADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "BACK TO HOME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(146, 99);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(245, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(47, 99);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Location = new System.Drawing.Point(51, 52);
            this.lblitem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(44, 13);
            this.lblitem.TabIndex = 11;
            this.lblitem.Text = "ItemID";
            // 
            // cbitem
            // 
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(149, 52);
            this.cbitem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(244, 21);
            this.cbitem.TabIndex = 10;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(254, 189);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(178, 28);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // BTNADD
            // 
            BTNADD.Location = new System.Drawing.Point(34, 186);
            BTNADD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BTNADD.Name = "BTNADD";
            BTNADD.Size = new System.Drawing.Size(178, 31);
            BTNADD.TabIndex = 8;
            BTNADD.Text = "ADD";
            BTNADD.UseVisualStyleBackColor = true;
            BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeInventory.Properties.Resources.category_1;
            this.pictureBox1.Location = new System.Drawing.Point(410, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frminv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(BTNADD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frminv";
            this.Text = "frminv";
            this.Load += new System.EventHandler(this.frminv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Button btnremove;
    }
}