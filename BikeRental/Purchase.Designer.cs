
namespace BikeRental
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.label1 = new System.Windows.Forms.Label();
            this.CbSelectBike = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.btnSubtotal = new System.Windows.Forms.Button();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BikeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBikeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRent3 = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblcash = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.pbBikes = new System.Windows.Forms.PictureBox();
            this.btnDisplayReceipt = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent A Bike";
            // 
            // CbSelectBike
            // 
            this.CbSelectBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSelectBike.FormattingEnabled = true;
            this.CbSelectBike.Items.AddRange(new object[] {
            "RoadBike",
            "MountainBike",
            "AdventureBike",
            "ClassicBike",
            "ElectricBike",
            "FoldingBike",
            "HybridBike"});
            this.CbSelectBike.Location = new System.Drawing.Point(559, 73);
            this.CbSelectBike.Name = "CbSelectBike";
            this.CbSelectBike.Size = new System.Drawing.Size(176, 33);
            this.CbSelectBike.TabIndex = 2;
            this.CbSelectBike.SelectedIndexChanged += new System.EventHandler(this.CbSelectBike_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Bike";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyRate.Location = new System.Drawing.Point(559, 115);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(100, 31);
            this.txtDailyRate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(422, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Daily Rate";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightCoral;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 24);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back To Bike Rental ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Rent ID";
            // 
            // txtRentID
            // 
            this.txtRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentID.Location = new System.Drawing.Point(559, 36);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(100, 31);
            this.txtRentID.TabIndex = 21;
            // 
            // btnSubtotal
            // 
            this.btnSubtotal.BackColor = System.Drawing.Color.Silver;
            this.btnSubtotal.Location = new System.Drawing.Point(525, 421);
            this.btnSubtotal.Name = "btnSubtotal";
            this.btnSubtotal.Size = new System.Drawing.Size(106, 23);
            this.btnSubtotal.TabIndex = 24;
            this.btnSubtotal.Text = "Subtotal";
            this.btnSubtotal.UseVisualStyleBackColor = false;
            this.btnSubtotal.Click += new System.EventHandler(this.btnSubtotal_Click);
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.Column2,
            this.dailyrate,
            this.BikeNo,
            this.Total,
            this.cancel});
            this.dgvPurchase.Location = new System.Drawing.Point(6, 457);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.Size = new System.Drawing.Size(620, 199);
            this.dgvPurchase.TabIndex = 25;
            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellContentClick);
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "ItemNumber";
            this.ItemNumber.Name = "ItemNumber";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bike";
            this.Column2.Name = "Column2";
            // 
            // dailyrate
            // 
            this.dailyrate.HeaderText = "dailyrate";
            this.dailyrate.Name = "dailyrate";
            // 
            // BikeNo
            // 
            this.BikeNo.HeaderText = "BikeNo";
            this.BikeNo.Name = "BikeNo";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // cancel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cancel.DefaultCellStyle = dataGridViewCellStyle1;
            this.cancel.HeaderText = "cancel";
            this.cancel.Name = "cancel";
            this.cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cancel.Text = "Delete";
            this.cancel.ToolTipText = "Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(444, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "bike No";
            // 
            // txtBikeNo
            // 
            this.txtBikeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtBikeNo.Location = new System.Drawing.Point(559, 152);
            this.txtBikeNo.Name = "txtBikeNo";
            this.txtBikeNo.Size = new System.Drawing.Size(100, 31);
            this.txtBikeNo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(440, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sub Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(559, 228);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 29;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Silver;
            this.btnTotal.Location = new System.Drawing.Point(782, 421);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(109, 23);
            this.btnTotal.TabIndex = 30;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnRent3
            // 
            this.btnRent3.BackColor = System.Drawing.Color.Silver;
            this.btnRent3.Location = new System.Drawing.Point(672, 585);
            this.btnRent3.Name = "btnRent3";
            this.btnRent3.Size = new System.Drawing.Size(94, 23);
            this.btnRent3.TabIndex = 31;
            this.btnRent3.Text = "Rent";
            this.btnRent3.UseVisualStyleBackColor = false;
            this.btnRent3.Click += new System.EventHandler(this.btnRent3_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(750, 504);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(157, 21);
            this.txtCash.TabIndex = 33;
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.BackColor = System.Drawing.Color.Transparent;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(637, 501);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(53, 24);
            this.lblcash.TabIndex = 32;
            this.lblcash.Text = "Cash";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(772, 471);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(135, 21);
            this.txtTotalPayment.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Payment";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(750, 543);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(157, 21);
            this.txtChange.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Change";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(469, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(559, 189);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 31);
            this.txtStock.TabIndex = 38;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // pbBikes
            // 
            this.pbBikes.Location = new System.Drawing.Point(12, 80);
            this.pbBikes.Name = "pbBikes";
            this.pbBikes.Size = new System.Drawing.Size(356, 298);
            this.pbBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBikes.TabIndex = 17;
            this.pbBikes.TabStop = false;
            // 
            // btnDisplayReceipt
            // 
            this.btnDisplayReceipt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDisplayReceipt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReceipt.Location = new System.Drawing.Point(782, 579);
            this.btnDisplayReceipt.Name = "btnDisplayReceipt";
            this.btnDisplayReceipt.Size = new System.Drawing.Size(109, 29);
            this.btnDisplayReceipt.TabIndex = 40;
            this.btnDisplayReceipt.Text = "VIEW RECEIPT";
            this.btnDisplayReceipt.UseVisualStyleBackColor = false;
            this.btnDisplayReceipt.Click += new System.EventHandler(this.btnDisplayReceipt_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(817, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(68, 25);
            this.lblname.TabIndex = 41;
            this.lblname.Text = "Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(710, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Welcome";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnDisplayReceipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.btnRent3);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBikeNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.btnSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.pbBikes);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbSelectBike);
            this.Controls.Add(this.label1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentABike";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Purchase_FormClosing);
            this.Load += new System.EventHandler(this.RentABike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSelectBike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pbBikes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Button btnSubtotal;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBikeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnRent3;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnDisplayReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn cancel;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label10;
    }
}