namespace Strategy
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
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkLoyalty = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSale = new System.Windows.Forms.NumericUpDown();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(87, 44);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(138, 21);
            this.chkStudent.TabIndex = 0;
            this.chkStudent.Text = "Student Discount";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // chkLoyalty
            // 
            this.chkLoyalty.AutoSize = true;
            this.chkLoyalty.Location = new System.Drawing.Point(87, 92);
            this.chkLoyalty.Name = "chkLoyalty";
            this.chkLoyalty.Size = new System.Drawing.Size(134, 21);
            this.chkLoyalty.TabIndex = 1;
            this.chkLoyalty.Text = "Loyalty Discount";
            this.chkLoyalty.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Sale";
            // 
            // numSale
            // 
            this.numSale.Location = new System.Drawing.Point(156, 170);
            this.numSale.Name = "numSale";
            this.numSale.Size = new System.Drawing.Size(243, 22);
            this.numSale.TabIndex = 3;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Location = new System.Drawing.Point(156, 267);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(152, 38);
            this.btnApplyDiscount.TabIndex = 4;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Final Price: ";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(241, 345);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 17);
            this.lblFinalPrice.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 420);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApplyDiscount);
            this.Controls.Add(this.numSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLoyalty);
            this.Controls.Add(this.chkStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkLoyalty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSale;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalPrice;
    }
}

