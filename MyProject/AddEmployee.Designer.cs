namespace MyProject
{
    partial class AddEmployee
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
            this.savetxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gmailtxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.gmail = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.scndnameTxt = new System.Windows.Forms.TextBox();
            this.fstnameTxt = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.frstName = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textBoxconfirmpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savetxt
            // 
            this.savetxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.savetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetxt.ForeColor = System.Drawing.Color.DarkRed;
            this.savetxt.Location = new System.Drawing.Point(418, 440);
            this.savetxt.Name = "savetxt";
            this.savetxt.Size = new System.Drawing.Size(95, 31);
            this.savetxt.TabIndex = 55;
            this.savetxt.Text = "Save";
            this.savetxt.UseVisualStyleBackColor = false;
            this.savetxt.Click += new System.EventHandler(this.savetxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 54;
            // 
            // gmailtxt
            // 
            this.gmailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailtxt.Location = new System.Drawing.Point(169, 312);
            this.gmailtxt.Multiline = true;
            this.gmailtxt.Name = "gmailtxt";
            this.gmailtxt.Size = new System.Drawing.Size(344, 32);
            this.gmailtxt.TabIndex = 53;
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(169, 231);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(344, 35);
            this.addresstxt.TabIndex = 52;
            // 
            // combotype
            // 
            this.combotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Waiter",
            "Staff"});
            this.combotype.Location = new System.Drawing.Point(169, 362);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(119, 32);
            this.combotype.TabIndex = 51;
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail.Location = new System.Drawing.Point(99, 318);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(54, 20);
            this.gmail.TabIndex = 50;
            this.gmail.Text = "Gmail:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(81, 237);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(72, 20);
            this.address.TabIndex = 49;
            this.address.Text = "Address:";
            // 
            // scndnameTxt
            // 
            this.scndnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndnameTxt.Location = new System.Drawing.Point(169, 190);
            this.scndnameTxt.Multiline = true;
            this.scndnameTxt.Name = "scndnameTxt";
            this.scndnameTxt.Size = new System.Drawing.Size(278, 35);
            this.scndnameTxt.TabIndex = 45;
            // 
            // fstnameTxt
            // 
            this.fstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstnameTxt.Location = new System.Drawing.Point(169, 150);
            this.fstnameTxt.Multiline = true;
            this.fstnameTxt.Name = "fstnameTxt";
            this.fstnameTxt.Size = new System.Drawing.Size(278, 34);
            this.fstnameTxt.TabIndex = 44;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(84, 368);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(69, 20);
            this.position.TabIndex = 43;
            this.position.Text = "Position:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(63, 196);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(90, 20);
            this.lastName.TabIndex = 40;
            this.lastName.Text = "Last Name:";
            // 
            // frstName
            // 
            this.frstName.AutoSize = true;
            this.frstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstName.Location = new System.Drawing.Point(63, 156);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(90, 20);
            this.frstName.TabIndex = 39;
            this.frstName.Text = "First Name:";
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(169, 62);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(214, 32);
            this.textpassword.TabIndex = 77;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(71, 68);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(82, 20);
            this.passwordtxt.TabIndex = 75;
            this.passwordtxt.Text = "Password:";
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(66, 36);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(87, 20);
            this.Idtxt.TabIndex = 74;
            this.Idtxt.Text = "Username:";
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusername.Location = new System.Drawing.Point(169, 24);
            this.textusername.Multiline = true;
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(214, 32);
            this.textusername.TabIndex = 78;
            this.textusername.UseSystemPasswordChar = true;
            // 
            // textBoxconfirmpassword
            // 
            this.textBoxconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxconfirmpassword.Location = new System.Drawing.Point(169, 100);
            this.textBoxconfirmpassword.Multiline = true;
            this.textBoxconfirmpassword.Name = "textBoxconfirmpassword";
            this.textBoxconfirmpassword.PasswordChar = '*';
            this.textBoxconfirmpassword.Size = new System.Drawing.Size(214, 32);
            this.textBoxconfirmpassword.TabIndex = 80;
            this.textBoxconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Confirm Password:";
            // 
            // textphone
            // 
            this.textphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textphone.Location = new System.Drawing.Point(169, 272);
            this.textphone.Multiline = true;
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(278, 34);
            this.textphone.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Phone number:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(317, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 83;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(587, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxconfirmpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.savetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmailtxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.address);
            this.Controls.Add(this.scndnameTxt);
            this.Controls.Add(this.fstnameTxt);
            this.Controls.Add(this.position);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.frstName);
            this.Name = "AddEmployee";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gmailtxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox scndnameTxt;
        private System.Windows.Forms.TextBox fstnameTxt;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label frstName;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textBoxconfirmpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

