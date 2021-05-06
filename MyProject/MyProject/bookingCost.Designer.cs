namespace MyProject
{
    partial class Bookingcost
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
            this.costTxt = new System.Windows.Forms.Label();
            this.ammountTxt = new System.Windows.Forms.TextBox();
            this.hometxt = new System.Windows.Forms.Button();
            this.confimationtxt = new System.Windows.Forms.Button();
            this.functiontxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // costTxt
            // 
            this.costTxt.AutoSize = true;
            this.costTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTxt.Location = new System.Drawing.Point(134, 187);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(65, 20);
            this.costTxt.TabIndex = 60;
            this.costTxt.Text = "Budget:";
            // 
            // ammountTxt
            // 
            this.ammountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammountTxt.Location = new System.Drawing.Point(218, 181);
            this.ammountTxt.Multiline = true;
            this.ammountTxt.Name = "ammountTxt";
            this.ammountTxt.ReadOnly = true;
            this.ammountTxt.Size = new System.Drawing.Size(197, 34);
            this.ammountTxt.TabIndex = 77;
            // 
            // hometxt
            // 
            this.hometxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.hometxt.Location = new System.Drawing.Point(138, 319);
            this.hometxt.Name = "hometxt";
            this.hometxt.Size = new System.Drawing.Size(81, 39);
            this.hometxt.TabIndex = 78;
            this.hometxt.Text = "Home";
            this.hometxt.UseVisualStyleBackColor = false;
            // 
            // confimationtxt
            // 
            this.confimationtxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.confimationtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confimationtxt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.confimationtxt.Location = new System.Drawing.Point(339, 319);
            this.confimationtxt.Name = "confimationtxt";
            this.confimationtxt.Size = new System.Drawing.Size(173, 44);
            this.confimationtxt.TabIndex = 79;
            this.confimationtxt.Text = "Confirm Booking";
            this.confimationtxt.UseVisualStyleBackColor = false;
            // 
            // functiontxt
            // 
            this.functiontxt.AutoSize = true;
            this.functiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functiontxt.Location = new System.Drawing.Point(134, 131);
            this.functiontxt.Name = "functiontxt";
            this.functiontxt.Size = new System.Drawing.Size(67, 20);
            this.functiontxt.TabIndex = 80;
            this.functiontxt.Text = "Funtion:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 34);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bookingcosttxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.functiontxt);
            this.Controls.Add(this.confimationtxt);
            this.Controls.Add(this.hometxt);
            this.Controls.Add(this.ammountTxt);
            this.Controls.Add(this.costTxt);
            this.Name = "bookingcosttxt";
            this.Text = "BookingCost";
            this.Load += new System.EventHandler(this.bookingcosttxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label costTxt;
        private System.Windows.Forms.TextBox ammountTxt;
        private System.Windows.Forms.Button hometxt;
        private System.Windows.Forms.Button confimationtxt;
        private System.Windows.Forms.Label functiontxt;
        private System.Windows.Forms.TextBox textBox1;
    }
}

