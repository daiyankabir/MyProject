namespace MyProject
{
    partial class Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowMaterial = new System.Windows.Forms.Label();
            this.drink = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newbtn = new System.Windows.Forms.Button();
            this.savetxt = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 251);
            this.dataGridView1.TabIndex = 1;
            // 
            // rowMaterial
            // 
            this.rowMaterial.AutoSize = true;
            this.rowMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowMaterial.Location = new System.Drawing.Point(12, 29);
            this.rowMaterial.Name = "rowMaterial";
            this.rowMaterial.Size = new System.Drawing.Size(113, 20);
            this.rowMaterial.TabIndex = 83;
            this.rowMaterial.Text = "Row Materials:";
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drink.Location = new System.Drawing.Point(12, 329);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(58, 20);
            this.drink.TabIndex = 84;
            this.drink.Text = "Drinks:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 362);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(605, 157);
            this.dataGridView2.TabIndex = 85;
            // 
            // productId
            // 
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.Location = new System.Drawing.Point(648, 144);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(89, 20);
            this.productId.TabIndex = 89;
            this.productId.Text = "Product ID:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(624, 184);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(114, 20);
            this.productName.TabIndex = 90;
            this.productName.Text = "Product Name:";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deletebtn.Location = new System.Drawing.Point(861, 300);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(81, 39);
            this.deletebtn.TabIndex = 91;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addbtn.Location = new System.Drawing.Point(752, 300);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(92, 39);
            this.addbtn.TabIndex = 92;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchbtn.Location = new System.Drawing.Point(819, 228);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(94, 35);
            this.searchbtn.TabIndex = 93;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            // 
            // CostTxt
            // 
            this.CostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTxt.Location = new System.Drawing.Point(743, 130);
            this.CostTxt.Multiline = true;
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.ReadOnly = true;
            this.CostTxt.Size = new System.Drawing.Size(169, 34);
            this.CostTxt.TabIndex = 94;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(743, 178);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 34);
            this.textBox1.TabIndex = 95;
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.newbtn.Location = new System.Drawing.Point(646, 300);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(92, 39);
            this.newbtn.TabIndex = 96;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = false;
            // 
            // savetxt
            // 
            this.savetxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.savetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetxt.ForeColor = System.Drawing.Color.Firebrick;
            this.savetxt.Location = new System.Drawing.Point(752, 362);
            this.savetxt.Name = "savetxt";
            this.savetxt.Size = new System.Drawing.Size(92, 39);
            this.savetxt.TabIndex = 97;
            this.savetxt.Text = "Save";
            this.savetxt.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(839, 479);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(93, 40);
            this.homebtn.TabIndex = 98;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 548);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.savetxt);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.rowMaterial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label rowMaterial;
        private System.Windows.Forms.Label drink;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label productId;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button savetxt;
        private System.Windows.Forms.Button homebtn;
    }
}