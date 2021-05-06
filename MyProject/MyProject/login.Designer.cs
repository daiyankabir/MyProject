namespace MyProject
{
    partial class Logintxt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Idtxt = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Idtxt
            // 
            this.Idtxt.AutoSize = true;
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(102, 117);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(32, 24);
            this.Idtxt.TabIndex = 0;
            this.Idtxt.Text = "ID:";
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(37, 168);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(97, 24);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.Text = "Password:";
            // 
            // Idtext
            // 
            this.Idtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtext.Location = new System.Drawing.Point(140, 109);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(214, 32);
            this.Idtext.TabIndex = 2;
            this.Idtext.TextChanged += new System.EventHandler(this.Idtext_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(140, 168);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '*';
            this.passwordtext.Size = new System.Drawing.Size(214, 32);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(213, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logintxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.Idtxt);
            this.Name = "Logintxt";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Logintxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idtxt;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button button1;
    }
}

