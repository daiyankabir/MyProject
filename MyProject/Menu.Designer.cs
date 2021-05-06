namespace MyProject
{
    partial class Menu
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
            this.availableitem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drinks = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderbtn = new System.Windows.Forms.Button();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.totalCost = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Srlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantitydgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricedgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.itemNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recivetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returntxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.billtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // availableitem
            // 
            this.availableitem.AutoSize = true;
            this.availableitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableitem.ForeColor = System.Drawing.Color.White;
            this.availableitem.Location = new System.Drawing.Point(8, 9);
            this.availableitem.Name = "availableitem";
            this.availableitem.Size = new System.Drawing.Size(110, 20);
            this.availableitem.TabIndex = 82;
            this.availableitem.Text = "Available item:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dgvName,
            this.dgvPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(427, 285);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "M_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.FillWeight = 150F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // Drinks
            // 
            this.Drinks.AutoSize = true;
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.ForeColor = System.Drawing.Color.White;
            this.Drinks.Location = new System.Drawing.Point(8, 332);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(58, 20);
            this.Drinks.TabIndex = 84;
            this.Drinks.Text = "Drinks:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.name,
            this.Price});
            this.dataGridView2.Location = new System.Drawing.Point(12, 355);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 176);
            this.dataGridView2.TabIndex = 85;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // DID
            // 
            this.DID.DataPropertyName = "D_ID";
            this.DID.HeaderText = "ID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 150F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.Silver;
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.Location = new System.Drawing.Point(739, 488);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(115, 40);
            this.orderbtn.TabIndex = 86;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // CostTxt
            // 
            this.CostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTxt.Location = new System.Drawing.Point(935, 210);
            this.CostTxt.Multiline = true;
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.ReadOnly = true;
            this.CostTxt.Size = new System.Drawing.Size(175, 34);
            this.CostTxt.TabIndex = 89;
            this.CostTxt.Text = " \r\n";
            this.CostTxt.TextChanged += new System.EventHandler(this.CostTxt_TextChanged);
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.ForeColor = System.Drawing.Color.White;
            this.totalCost.Location = new System.Drawing.Point(976, 187);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(85, 20);
            this.totalCost.TabIndex = 88;
            this.totalCost.Text = "Total Cost:";
            // 
            // homebtn
            // 
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(502, 488);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(115, 40);
            this.homebtn.TabIndex = 90;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srlno,
            this.itemdgv,
            this.Quantitydgv,
            this.pricedgv,
            this.totaldgv});
            this.dataGridView3.Location = new System.Drawing.Point(475, 210);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(454, 196);
            this.dataGridView3.TabIndex = 91;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Srlno
            // 
            this.Srlno.DataPropertyName = "Srlno";
            this.Srlno.HeaderText = "Srlno";
            this.Srlno.Name = "Srlno";
            this.Srlno.ReadOnly = true;
            this.Srlno.Visible = false;
            // 
            // itemdgv
            // 
            this.itemdgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemdgv.DataPropertyName = "Itemname";
            this.itemdgv.HeaderText = "Item";
            this.itemdgv.Name = "itemdgv";
            this.itemdgv.ReadOnly = true;
            // 
            // Quantitydgv
            // 
            this.Quantitydgv.DataPropertyName = "Quantity";
            this.Quantitydgv.HeaderText = "Quantity";
            this.Quantitydgv.Name = "Quantitydgv";
            this.Quantitydgv.ReadOnly = true;
            // 
            // pricedgv
            // 
            this.pricedgv.DataPropertyName = "Price";
            this.pricedgv.HeaderText = "Price";
            this.pricedgv.Name = "pricedgv";
            this.pricedgv.ReadOnly = true;
            // 
            // totaldgv
            // 
            this.totaldgv.DataPropertyName = "Total";
            this.totaldgv.HeaderText = "Total";
            this.totaldgv.Name = "totaldgv";
            this.totaldgv.ReadOnly = true;
            // 
            // selectedItem
            // 
            this.selectedItem.AutoSize = true;
            this.selectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedItem.ForeColor = System.Drawing.Color.White;
            this.selectedItem.Location = new System.Drawing.Point(471, 187);
            this.selectedItem.Name = "selectedItem";
            this.selectedItem.Size = new System.Drawing.Size(110, 20);
            this.selectedItem.TabIndex = 92;
            this.selectedItem.Text = "Selected item:";
            // 
            // itemNametxt
            // 
            this.itemNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNametxt.Location = new System.Drawing.Point(591, 42);
            this.itemNametxt.Multiline = true;
            this.itemNametxt.Name = "itemNametxt";
            this.itemNametxt.ReadOnly = true;
            this.itemNametxt.Size = new System.Drawing.Size(169, 34);
            this.itemNametxt.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Item code:";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(591, 154);
            this.quantitytxt.Multiline = true;
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(169, 34);
            this.quantitytxt.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Quantity:";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(805, 67);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 40);
            this.btnadd.TabIndex = 97;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Silver;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(805, 113);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(115, 40);
            this.btnremove.TabIndex = 98;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(705, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "Bill Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(783, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 29);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // itemtxt
            // 
            this.itemtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtxt.Location = new System.Drawing.Point(591, 82);
            this.itemtxt.Multiline = true;
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.ReadOnly = true;
            this.itemtxt.Size = new System.Drawing.Size(169, 34);
            this.itemtxt.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(475, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Item name:";
            // 
            // itemPricetxt
            // 
            this.itemPricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPricetxt.Location = new System.Drawing.Point(591, 118);
            this.itemPricetxt.Multiline = true;
            this.itemPricetxt.Name = "itemPricetxt";
            this.itemPricetxt.ReadOnly = true;
            this.itemPricetxt.Size = new System.Drawing.Size(169, 34);
            this.itemPricetxt.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(481, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Item price:";
            // 
            // recivetxt
            // 
            this.recivetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recivetxt.Location = new System.Drawing.Point(935, 283);
            this.recivetxt.Multiline = true;
            this.recivetxt.Name = "recivetxt";
            this.recivetxt.Size = new System.Drawing.Size(175, 34);
            this.recivetxt.TabIndex = 108;
            this.recivetxt.Text = " \r\n";
            this.recivetxt.Enter += new System.EventHandler(this.returntxt_VisibleChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(976, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 107;
            this.label6.Text = "Recived cash:\r\n";
            // 
            // returntxt
            // 
            this.returntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntxt.Location = new System.Drawing.Point(886, 414);
            this.returntxt.Multiline = true;
            this.returntxt.Name = "returntxt";
            this.returntxt.ReadOnly = true;
            this.returntxt.Size = new System.Drawing.Size(175, 34);
            this.returntxt.TabIndex = 110;
            this.returntxt.Text = " \r\n";
            this.returntxt.TextChanged += new System.EventHandler(this.returntxt_TextChanged);
            this.returntxt.VisibleChanged += new System.EventHandler(this.returntxt_VisibleChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(779, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "Return cash:\r\n";
            // 
            // billtxt
            // 
            this.billtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billtxt.Location = new System.Drawing.Point(556, 414);
            this.billtxt.Multiline = true;
            this.billtxt.Name = "billtxt";
            this.billtxt.ReadOnly = true;
            this.billtxt.Size = new System.Drawing.Size(175, 34);
            this.billtxt.TabIndex = 112;
            this.billtxt.Text = " \r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(517, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "Bill:\r\n";
            // 
            // enterbtn
            // 
            this.enterbtn.BackColor = System.Drawing.Color.Silver;
            this.enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbtn.Location = new System.Drawing.Point(995, 332);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(115, 40);
            this.enterbtn.TabIndex = 113;
            this.enterbtn.Text = "Enter";
            this.enterbtn.UseVisualStyleBackColor = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1122, 540);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.billtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returntxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recivetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemPricetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedItem);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.availableitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableitem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Drinks;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label selectedItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox itemNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemPricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantitydgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricedgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldgv;
        private System.Windows.Forms.TextBox recivetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox returntxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox billtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button enterbtn;
    }
}