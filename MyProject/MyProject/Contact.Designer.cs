namespace MyProject
{
    partial class Contact
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
            this.name = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gmail = new System.Windows.Forms.Label();
            this.phoneNo = new System.Windows.Forms.Label();
            this.gmailtxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(181, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(354, 37);
            this.name.TabIndex = 93;
            this.name.Text = "Food Buddy Restaurent";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(296, 97);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(104, 20);
            this.time.TabIndex = 94;
            this.time.Text = "Service Hour:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 183);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail.Location = new System.Drawing.Point(158, 366);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(54, 20);
            this.gmail.TabIndex = 96;
            this.gmail.Text = "Gmail:";
            // 
            // phoneNo
            // 
            this.phoneNo.AutoSize = true;
            this.phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNo.Location = new System.Drawing.Point(131, 407);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(81, 20);
            this.phoneNo.TabIndex = 97;
            this.phoneNo.Text = "Phone no:";
            // 
            // gmailtxt
            // 
            this.gmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailtxt.Location = new System.Drawing.Point(218, 360);
            this.gmailtxt.Multiline = true;
            this.gmailtxt.Name = "gmailtxt";
            this.gmailtxt.ReadOnly = true;
            this.gmailtxt.Size = new System.Drawing.Size(341, 32);
            this.gmailtxt.TabIndex = 98;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(218, 406);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 32);
            this.textBox1.TabIndex = 99;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gmailtxt);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.name);
            this.Name = "Contact";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.Label phoneNo;
        private System.Windows.Forms.TextBox gmailtxt;
        private System.Windows.Forms.TextBox textBox1;
    }
}