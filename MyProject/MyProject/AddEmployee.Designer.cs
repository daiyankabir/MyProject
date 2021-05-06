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
            this.possitionCombo = new System.Windows.Forms.ComboBox();
            this.gmail = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.scndnameTxt = new System.Windows.Forms.TextBox();
            this.fstnameTxt = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.gndr = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.frstName = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savetxt
            // 
            this.savetxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.savetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetxt.ForeColor = System.Drawing.Color.DarkRed;
            this.savetxt.Location = new System.Drawing.Point(452, 446);
            this.savetxt.Name = "savetxt";
            this.savetxt.Size = new System.Drawing.Size(95, 31);
            this.savetxt.TabIndex = 55;
            this.savetxt.Text = "Save";
            this.savetxt.UseVisualStyleBackColor = false;
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
            this.gmailtxt.Location = new System.Drawing.Point(169, 352);
            this.gmailtxt.Multiline = true;
            this.gmailtxt.Name = "gmailtxt";
            this.gmailtxt.Size = new System.Drawing.Size(344, 32);
            this.gmailtxt.TabIndex = 53;
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(169, 308);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(344, 35);
            this.addresstxt.TabIndex = 52;
            // 
            // possitionCombo
            // 
            this.possitionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possitionCombo.FormattingEnabled = true;
            this.possitionCombo.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Waiter",
            "Staff"});
            this.possitionCombo.Location = new System.Drawing.Point(169, 390);
            this.possitionCombo.Name = "possitionCombo";
            this.possitionCombo.Size = new System.Drawing.Size(119, 32);
            this.possitionCombo.TabIndex = 51;
            // 
            // gmail
            // 
            this.gmail.AutoSize = true;
            this.gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail.Location = new System.Drawing.Point(100, 358);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(54, 20);
            this.gmail.TabIndex = 50;
            this.gmail.Text = "Gmail:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(82, 314);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(72, 20);
            this.address.TabIndex = 49;
            this.address.Text = "Address:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(301, 226);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(92, 28);
            this.female.TabIndex = 47;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(169, 226);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(69, 28);
            this.male.TabIndex = 46;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // scndnameTxt
            // 
            this.scndnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndnameTxt.Location = new System.Drawing.Point(169, 177);
            this.scndnameTxt.Multiline = true;
            this.scndnameTxt.Name = "scndnameTxt";
            this.scndnameTxt.Size = new System.Drawing.Size(278, 35);
            this.scndnameTxt.TabIndex = 45;
            // 
            // fstnameTxt
            // 
            this.fstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fstnameTxt.Location = new System.Drawing.Point(169, 125);
            this.fstnameTxt.Multiline = true;
            this.fstnameTxt.Name = "fstnameTxt";
            this.fstnameTxt.Size = new System.Drawing.Size(278, 34);
            this.fstnameTxt.TabIndex = 44;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(85, 402);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(69, 20);
            this.position.TabIndex = 43;
            this.position.Text = "Position:";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(106, 269);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(48, 20);
            this.dob.TabIndex = 42;
            this.dob.Text = "DOB:";
            // 
            // gndr
            // 
            this.gndr.AutoSize = true;
            this.gndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gndr.Location = new System.Drawing.Point(87, 226);
            this.gndr.Name = "gndr";
            this.gndr.Size = new System.Drawing.Size(67, 20);
            this.gndr.TabIndex = 41;
            this.gndr.Text = "Gender:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(64, 183);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(90, 20);
            this.lastName.TabIndex = 40;
            this.lastName.Text = "Last Name:";
            // 
            // frstName
            // 
            this.frstName.AutoSize = true;
            this.frstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstName.Location = new System.Drawing.Point(64, 131);
            this.frstName.Name = "frstName";
            this.frstName.Size = new System.Drawing.Size(90, 20);
            this.frstName.TabIndex = 39;
            this.frstName.Text = "First Name:";
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(169, 81);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(214, 32);
            this.passwordtext.TabIndex = 77;
            this.passwordtext.UseSystemPasswordChar = true;
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtext.Location = new System.Drawing.Point(169, 40);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.ReadOnly = true;
            this.Idtext.Size = new System.Drawing.Size(214, 32);
            this.Idtext.TabIndex = 76;
            this.Idtext.TextChanged += new System.EventHandler(this.Idtext_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(67, 87);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(82, 20);
            this.passwordtxt.TabIndex = 75;
            this.passwordtxt.Text = "Password:";
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(117, 40);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(30, 20);
            this.Idtxt.TabIndex = 74;
            this.Idtxt.Text = "ID:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 496);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.savetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmailtxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.possitionCombo);
            this.Controls.Add(this.gmail);
            this.Controls.Add(this.address);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.scndnameTxt);
            this.Controls.Add(this.fstnameTxt);
            this.Controls.Add(this.position);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.gndr);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.frstName);
            this.Name = "RegForm";
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
        private System.Windows.Forms.ComboBox possitionCombo;
        private System.Windows.Forms.Label gmail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox scndnameTxt;
        private System.Windows.Forms.TextBox fstnameTxt;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label gndr;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label frstName;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Label Idtxt;
    }
}

