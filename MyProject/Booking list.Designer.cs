namespace MyProject
{
    partial class Booking_list
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
            this.bookinglist = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.srcbtn = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookinglist
            // 
            this.bookinglist.AutoSize = true;
            this.bookinglist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookinglist.Location = new System.Drawing.Point(21, 37);
            this.bookinglist.Name = "bookinglist";
            this.bookinglist.Size = new System.Drawing.Size(136, 20);
            this.bookinglist.TabIndex = 64;
            this.bookinglist.Text = "Show All Booking:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 342);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(163, 31);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 33);
            this.loadBtn.TabIndex = 76;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(754, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 33);
            this.Back.TabIndex = 80;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // srcbtn
            // 
            this.srcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcbtn.Location = new System.Drawing.Point(570, 31);
            this.srcbtn.Name = "srcbtn";
            this.srcbtn.Size = new System.Drawing.Size(75, 33);
            this.srcbtn.TabIndex = 81;
            this.srcbtn.Text = "Search";
            this.srcbtn.UseVisualStyleBackColor = true;
            this.srcbtn.Click += new System.EventHandler(this.srcbtn_Click);
            // 
            // dltbtn
            // 
            this.dltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltbtn.Location = new System.Drawing.Point(663, 31);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(75, 33);
            this.dltbtn.TabIndex = 82;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = true;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(379, 31);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(168, 33);
            this.NameTxt.TabIndex = 92;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(244, 44);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(117, 20);
            this.phone.TabIndex = 93;
            this.phone.Text = "Phone number:";
            // 
            // Booking_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.srcbtn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bookinglist);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Booking_list";
            this.Text = "Booking_list";
            this.Load += new System.EventHandler(this.Booking_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookinglist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button srcbtn;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label phone;
    }
}