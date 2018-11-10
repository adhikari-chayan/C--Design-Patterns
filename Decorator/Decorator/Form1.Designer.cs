namespace Decorator
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
            this.grpMemory = new System.Windows.Forms.GroupBox();
            this.grpStorage = new System.Windows.Forms.GroupBox();
            this.rad8RAM = new System.Windows.Forms.RadioButton();
            this.rad16RAM = new System.Windows.Forms.RadioButton();
            this.rad128SSD = new System.Windows.Forms.RadioButton();
            this.rad256SSD = new System.Windows.Forms.RadioButton();
            this.rad512SSD = new System.Windows.Forms.RadioButton();
            this.chkApplyDiscount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpMemory.SuspendLayout();
            this.grpStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMemory
            // 
            this.grpMemory.Controls.Add(this.rad16RAM);
            this.grpMemory.Controls.Add(this.rad8RAM);
            this.grpMemory.Location = new System.Drawing.Point(37, 38);
            this.grpMemory.Name = "grpMemory";
            this.grpMemory.Size = new System.Drawing.Size(311, 112);
            this.grpMemory.TabIndex = 0;
            this.grpMemory.TabStop = false;
            this.grpMemory.Text = "Memory";
            // 
            // grpStorage
            // 
            this.grpStorage.Controls.Add(this.rad512SSD);
            this.grpStorage.Controls.Add(this.rad256SSD);
            this.grpStorage.Controls.Add(this.rad128SSD);
            this.grpStorage.Location = new System.Drawing.Point(37, 193);
            this.grpStorage.Name = "grpStorage";
            this.grpStorage.Size = new System.Drawing.Size(311, 158);
            this.grpStorage.TabIndex = 1;
            this.grpStorage.TabStop = false;
            this.grpStorage.Text = "Storage";
            // 
            // rad8RAM
            // 
            this.rad8RAM.AutoSize = true;
            this.rad8RAM.Location = new System.Drawing.Point(39, 38);
            this.rad8RAM.Name = "rad8RAM";
            this.rad8RAM.Size = new System.Drawing.Size(121, 21);
            this.rad8RAM.TabIndex = 0;
            this.rad8RAM.TabStop = true;
            this.rad8RAM.Text = "8 GBytes($70)";
            this.rad8RAM.UseVisualStyleBackColor = true;
            // 
            // rad16RAM
            // 
            this.rad16RAM.AutoSize = true;
            this.rad16RAM.Location = new System.Drawing.Point(39, 75);
            this.rad16RAM.Name = "rad16RAM";
            this.rad16RAM.Size = new System.Drawing.Size(137, 21);
            this.rad16RAM.TabIndex = 1;
            this.rad16RAM.TabStop = true;
            this.rad16RAM.Text = "16 GBytes($150)";
            this.rad16RAM.UseVisualStyleBackColor = true;
            // 
            // rad128SSD
            // 
            this.rad128SSD.AutoSize = true;
            this.rad128SSD.Location = new System.Drawing.Point(39, 41);
            this.rad128SSD.Name = "rad128SSD";
            this.rad128SSD.Size = new System.Drawing.Size(162, 21);
            this.rad128SSD.TabIndex = 1;
            this.rad128SSD.TabStop = true;
            this.rad128SSD.Text = "128 GByte SSD($74)";
            this.rad128SSD.UseVisualStyleBackColor = true;
            // 
            // rad256SSD
            // 
            this.rad256SSD.AutoSize = true;
            this.rad256SSD.Location = new System.Drawing.Point(39, 77);
            this.rad256SSD.Name = "rad256SSD";
            this.rad256SSD.Size = new System.Drawing.Size(170, 21);
            this.rad256SSD.TabIndex = 2;
            this.rad256SSD.TabStop = true;
            this.rad256SSD.Text = "256 GByte SSD($120)";
            this.rad256SSD.UseVisualStyleBackColor = true;
            // 
            // rad512SSD
            // 
            this.rad512SSD.AutoSize = true;
            this.rad512SSD.Location = new System.Drawing.Point(39, 121);
            this.rad512SSD.Name = "rad512SSD";
            this.rad512SSD.Size = new System.Drawing.Size(170, 21);
            this.rad512SSD.TabIndex = 3;
            this.rad512SSD.TabStop = true;
            this.rad512SSD.Text = "512 GByte SSD($230)";
            this.rad512SSD.UseVisualStyleBackColor = true;
            // 
            // chkApplyDiscount
            // 
            this.chkApplyDiscount.AutoSize = true;
            this.chkApplyDiscount.Location = new System.Drawing.Point(76, 382);
            this.chkApplyDiscount.Name = "chkApplyDiscount";
            this.chkApplyDiscount.Size = new System.Drawing.Size(124, 21);
            this.chkApplyDiscount.TabIndex = 2;
            this.chkApplyDiscount.Text = "Apply Discount";
            this.chkApplyDiscount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model #";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(76, 553);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 17);
            this.lblModel.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(419, 480);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 579);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkApplyDiscount);
            this.Controls.Add(this.grpStorage);
            this.Controls.Add(this.grpMemory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMemory.ResumeLayout(false);
            this.grpMemory.PerformLayout();
            this.grpStorage.ResumeLayout(false);
            this.grpStorage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemory;
        private System.Windows.Forms.GroupBox grpStorage;
        private System.Windows.Forms.RadioButton rad16RAM;
        private System.Windows.Forms.RadioButton rad8RAM;
        private System.Windows.Forms.RadioButton rad512SSD;
        private System.Windows.Forms.RadioButton rad256SSD;
        private System.Windows.Forms.RadioButton rad128SSD;
        private System.Windows.Forms.CheckBox chkApplyDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotal;
    }
}

