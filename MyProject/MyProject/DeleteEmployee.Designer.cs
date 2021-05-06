namespace MyProject
{
    partial class deleteEemployee
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.Label();
            this.fstnameTxt = new System.Windows.Forms.TextBox();
            this.frstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(427, 328);
            this.dataGridView1.TabIndex = 74;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(76, 110);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 33);
            this.searchBtn.TabIndex = 75;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(195, 110);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteBtn.TabIndex = 76;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtext.Location = new System.Drawing.Point(108, 12);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(214, 32);
            this.Idtext.TabIndex = 82;
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(72, 24);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(30, 20);
            this.Idtxt.TabIndex = 81;
            this.Idtxt.Text = "ID:";
            // 
            // fstnameTxt
            // 
            this.fstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstnameTxt.Location = new System.Drawing.Point(108, 54);
            this.fstnameTxt.Multiline = true;
            this.fstnameTxt.Name = "fstnameTxt";
            this.fstnameTxt.Size = new System.Drawing.Size(275, 34);
            this.fstnameTxt.TabIndex = 84;
            // 
            // frstName
            // 
            this.frstName.AutoSize = true;
            this.frstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstName.Location = new System.Drawing.Point(12, 60);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(90, 20);
            this.frstName.TabIndex = 83;
            this.frstName.Text = "First Name:";
            // 
            // deleteEemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.fstnameTxt);
            this.Controls.Add(this.frstName);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deleteEemployee";
            this.Text = "DeleteEmployee";
            this.Load += new System.EventHandler(this.deleteEemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.TextBox fstnameTxt;
        private System.Windows.Forms.Label frstName;
    }
}