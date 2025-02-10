
namespace BikeRental
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnaddbiketoRent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRentABike = new System.Windows.Forms.Button();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddbiketoRent
            // 
            this.btnaddbiketoRent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnaddbiketoRent.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbiketoRent.Location = new System.Drawing.Point(12, 103);
            this.btnaddbiketoRent.Name = "btnaddbiketoRent";
            this.btnaddbiketoRent.Size = new System.Drawing.Size(213, 39);
            this.btnaddbiketoRent.TabIndex = 0;
            this.btnaddbiketoRent.Text = "Fill up Information";
            this.btnaddbiketoRent.UseVisualStyleBackColor = false;
            this.btnaddbiketoRent.Click += new System.EventHandler(this.btnaddbiketoRent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bike Rental";
            // 
            // btnRentABike
            // 
            this.btnRentABike.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRentABike.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentABike.Location = new System.Drawing.Point(359, 103);
            this.btnRentABike.Name = "btnRentABike";
            this.btnRentABike.Size = new System.Drawing.Size(213, 39);
            this.btnRentABike.TabIndex = 2;
            this.btnRentABike.Text = "RENT A BIKE";
            this.btnRentABike.UseVisualStyleBackColor = false;
            this.btnRentABike.Click += new System.EventHandler(this.btnRentABike_Click);
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReturnBike.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBike.Location = new System.Drawing.Point(195, 211);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(213, 39);
            this.btnReturnBike.TabIndex = 3;
            this.btnReturnBike.Text = "RETURN BIKE";
            this.btnReturnBike.UseVisualStyleBackColor = false;
            this.btnReturnBike.Click += new System.EventHandler(this.btnReturnBike_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 30);
            this.textBox1.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(492, 9);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnRentABike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddbiketoRent);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddbiketoRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRentABike;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

