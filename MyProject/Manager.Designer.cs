namespace MyProject
{
    partial class Manager
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.frstName = new System.Windows.Forms.Label();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridViewmanager = new System.Windows.Forms.DataGridView();
            this.tableBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.customerListToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(917, 29);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 25);
            this.toolStripMenuItem1.Text = "Home";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 25);
            this.toolStripMenuItem2.Text = "Inventory";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem3});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(156, 25);
            this.toolStripMenuItem5.Text = "All Employee";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem6.Text = "Add employee";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem3.Text = "Employee List";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.tableBookingToolStripMenuItem});
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(156, 25);
            this.toolStripMenuItem8.Text = "show Booking";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(202, 26);
            this.toolStripMenuItem9.Text = "Booking List";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationToolStripMenuItem,
            this.customerListToolStripMenuItem1});
            this.customerListToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.customerListToolStripMenuItem.Text = "Customer ";
            this.customerListToolStripMenuItem.Click += new System.EventHandler(this.customerListToolStripMenuItem_Click);
            // 
            // customerRegistrationToolStripMenuItem
            // 
            this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
            this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.customerRegistrationToolStripMenuItem.Text = "Customer Registration";
            this.customerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem_Click);
            // 
            // customerListToolStripMenuItem1
            // 
            this.customerListToolStripMenuItem1.Name = "customerListToolStripMenuItem1";
            this.customerListToolStripMenuItem1.Size = new System.Drawing.Size(311, 26);
            this.customerListToolStripMenuItem1.Text = "Customer list";
            this.customerListToolStripMenuItem1.Click += new System.EventHandler(this.customerListToolStripMenuItem1_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDelete.Controls.Add(this.typecombo);
            this.panelDelete.Controls.Add(this.label1);
            this.panelDelete.Controls.Add(this.NameTxt);
            this.panelDelete.Controls.Add(this.frstName);
            this.panelDelete.Controls.Add(this.Idtext);
            this.panelDelete.Controls.Add(this.Idtxt);
            this.panelDelete.Controls.Add(this.deleteBtn);
            this.panelDelete.Controls.Add(this.searchBtn);
            this.panelDelete.Location = new System.Drawing.Point(558, 48);
            this.panelDelete.Margin = new System.Windows.Forms.Padding(2);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(348, 391);
            this.panelDelete.TabIndex = 7;
            // 
            // typecombo
            // 
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Items.AddRange(new object[] {
            "Customer",
            "Employee"});
            this.typecombo.Location = new System.Drawing.Point(114, 128);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(162, 21);
            this.typecombo.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Type:";
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(114, 68);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(214, 34);
            this.NameTxt.TabIndex = 91;
            // 
            // frstName
            // 
            this.frstName.AutoSize = true;
            this.frstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstName.Location = new System.Drawing.Point(53, 74);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(55, 20);
            this.frstName.TabIndex = 90;
            this.frstName.Text = "Name:";
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtext.Location = new System.Drawing.Point(114, 30);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.ReadOnly = true;
            this.Idtext.Size = new System.Drawing.Size(214, 32);
            this.Idtext.TabIndex = 89;
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(78, 36);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(30, 20);
            this.Idtxt.TabIndex = 88;
            this.Idtxt.Text = "ID:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(253, 159);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteBtn.TabIndex = 87;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(172, 159);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 86;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridViewmanager
            // 
            this.dataGridViewmanager.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmanager.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewmanager.Name = "dataGridViewmanager";
            this.dataGridViewmanager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewmanager.Size = new System.Drawing.Size(541, 390);
            this.dataGridViewmanager.TabIndex = 8;
            this.dataGridViewmanager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmanager_CellClick);
            // 
            // tableBookingToolStripMenuItem
            // 
            this.tableBookingToolStripMenuItem.Name = "tableBookingToolStripMenuItem";
            this.tableBookingToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.tableBookingToolStripMenuItem.Text = "Table Booking";
            this.tableBookingToolStripMenuItem.Click += new System.EventHandler(this.tableBookingToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.dataGridViewmanager);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmanager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridViewmanager;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label frstName;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem1;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tableBookingToolStripMenuItem;
    }
}