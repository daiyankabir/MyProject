namespace MyProject
{
    partial class Order
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
            this.selecteditem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cashReturn = new System.Windows.Forms.Label();
            this.receivedCash = new System.Windows.Forms.TextBox();
            this.cashReceived = new System.Windows.Forms.Label();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.totalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 370);
            this.dataGridView1.TabIndex = 80;
            // 
            // selecteditem
            // 
            this.selecteditem.AutoSize = true;
            this.selecteditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecteditem.Location = new System.Drawing.Point(12, 19);
            this.selecteditem.Name = "selecteditem";
            this.selecteditem.Size = new System.Drawing.Size(110, 20);
            this.selecteditem.TabIndex = 81;
            this.selecteditem.Text = "Selected item:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(598, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 34);
            this.textBox1.TabIndex = 91;
            // 
            // cashReturn
            // 
            this.cashReturn.AutoSize = true;
            this.cashReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashReturn.Location = new System.Drawing.Point(521, 179);
            this.cashReturn.Name = "cashReturn";
            this.cashReturn.Size = new System.Drawing.Size(62, 20);
            this.cashReturn.TabIndex = 90;
            this.cashReturn.Text = "Return:";
            // 
            // receivedCash
            // 
            this.receivedCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedCash.Location = new System.Drawing.Point(598, 121);
            this.receivedCash.Multiline = true;
            this.receivedCash.Name = "receivedCash";
            this.receivedCash.Size = new System.Drawing.Size(169, 34);
            this.receivedCash.TabIndex = 89;
            // 
            // cashReceived
            // 
            this.cashReceived.AutoSize = true;
            this.cashReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashReceived.Location = new System.Drawing.Point(463, 127);
            this.cashReceived.Name = "cashReceived";
            this.cashReceived.Size = new System.Drawing.Size(120, 20);
            this.cashReceived.TabIndex = 88;
            this.cashReceived.Text = "Cash Received:";
            // 
            // CostTxt
            // 
            this.CostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTxt.Location = new System.Drawing.Point(598, 69);
            this.CostTxt.Multiline = true;
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(169, 34);
            this.CostTxt.TabIndex = 87;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(498, 75);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(85, 20);
            this.totalCost.TabIndex = 86;
            this.totalCost.Text = "Total Cost:";
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cashReturn);
            this.Controls.Add(this.receivedCash);
            this.Controls.Add(this.cashReceived);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.selecteditem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label selecteditem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cashReturn;
        private System.Windows.Forms.TextBox receivedCash;
        private System.Windows.Forms.Label cashReceived;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.Label totalCost;
    }
}