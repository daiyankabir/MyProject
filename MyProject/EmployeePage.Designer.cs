namespace MyProject
{
    partial class EmployeePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HOMEstripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookATableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewmanager = new System.Windows.Forms.DataGridView();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.Label();
            this.fstnameTxt = new System.Windows.Forms.TextBox();
            this.frstName = new System.Windows.Forms.Label();
            this.savetxt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HOMEstripMenuItem1,
            this.bookATableToolStripMenuItem,
            this.contactUSToolStripMenuItem,
            this.contactUsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HOMEstripMenuItem1
            // 
            this.HOMEstripMenuItem1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEstripMenuItem1.Name = "HOMEstripMenuItem1";
            this.HOMEstripMenuItem1.Size = new System.Drawing.Size(72, 25);
            this.HOMEstripMenuItem1.Text = "Home";
            this.HOMEstripMenuItem1.Click += new System.EventHandler(this.HOMEstripMenuItem1_Click);
            // 
            // bookATableToolStripMenuItem
            // 
            this.bookATableToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookATableToolStripMenuItem.Name = "bookATableToolStripMenuItem";
            this.bookATableToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.bookATableToolStripMenuItem.Text = "Booking List";
            this.bookATableToolStripMenuItem.Click += new System.EventHandler(this.bookATableToolStripMenuItem_Click);
            // 
            // contactUSToolStripMenuItem
            // 
            this.contactUSToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUSToolStripMenuItem.Name = "contactUSToolStripMenuItem";
            this.contactUSToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
            this.contactUSToolStripMenuItem.Text = "information";
            this.contactUSToolStripMenuItem.Click += new System.EventHandler(this.contactUSToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem1
            // 
            this.contactUsToolStripMenuItem1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsToolStripMenuItem1.Name = "contactUsToolStripMenuItem1";
            this.contactUsToolStripMenuItem1.Size = new System.Drawing.Size(201, 25);
            this.contactUsToolStripMenuItem1.Text = "Booked table list";
            this.contactUsToolStripMenuItem1.Click += new System.EventHandler(this.contactUsToolStripMenuItem1_Click);
            // 
            // dataGridViewmanager
            // 
            this.dataGridViewmanager.AllowUserToDeleteRows = false;
            this.dataGridViewmanager.AllowUserToResizeColumns = false;
            this.dataGridViewmanager.AllowUserToResizeRows = false;
            this.dataGridViewmanager.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewmanager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmanager.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridViewmanager.Location = new System.Drawing.Point(11, 43);
            this.dataGridViewmanager.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewmanager.Name = "dataGridViewmanager";
            this.dataGridViewmanager.RowTemplate.Height = 24;
            this.dataGridViewmanager.Size = new System.Drawing.Size(417, 396);
            this.dataGridViewmanager.TabIndex = 7;
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(529, 103);
            this.idTxt.Multiline = true;
            this.idTxt.Name = "idTxt";
            this.idTxt.ReadOnly = true;
            this.idTxt.Size = new System.Drawing.Size(169, 34);
            this.idTxt.TabIndex = 96;
            // 
            // productId
            // 
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.Location = new System.Drawing.Point(493, 109);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(30, 20);
            this.productId.TabIndex = 95;
            this.productId.Text = "ID:";
            // 
            // fstnameTxt
            // 
            this.fstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstnameTxt.Location = new System.Drawing.Point(529, 154);
            this.fstnameTxt.Multiline = true;
            this.fstnameTxt.Name = "fstnameTxt";
            this.fstnameTxt.Size = new System.Drawing.Size(250, 34);
            this.fstnameTxt.TabIndex = 98;
            // 
            // frstName
            // 
            this.frstName.AutoSize = true;
            this.frstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstName.Location = new System.Drawing.Point(433, 160);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(90, 20);
            this.frstName.TabIndex = 97;
            this.frstName.Text = "First Name:";
            // 
            // savetxt
            // 
            this.savetxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.savetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetxt.ForeColor = System.Drawing.Color.Firebrick;
            this.savetxt.Location = new System.Drawing.Point(687, 217);
            this.savetxt.Name = "savetxt";
            this.savetxt.Size = new System.Drawing.Size(92, 39);
            this.savetxt.TabIndex = 99;
            this.savetxt.Text = "Search";
            this.savetxt.UseVisualStyleBackColor = false;
            this.savetxt.Click += new System.EventHandler(this.savetxt_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.savetxt);
            this.Controls.Add(this.fstnameTxt);
            this.Controls.Add(this.frstName);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.dataGridViewmanager);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HOMEstripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookATableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewmanager;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label productId;
        private System.Windows.Forms.TextBox fstnameTxt;
        private System.Windows.Forms.Label frstName;
        private System.Windows.Forms.Button savetxt;
    }
}