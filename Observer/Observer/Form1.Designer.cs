﻿namespace Observer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObserver1 = new System.Windows.Forms.Label();
            this.lblObserver2 = new System.Windows.Forms.Label();
            this.btnSetNewPrice = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observer 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observer 2:";
            // 
            // lblObserver1
            // 
            this.lblObserver1.AutoSize = true;
            this.lblObserver1.Location = new System.Drawing.Point(189, 295);
            this.lblObserver1.Name = "lblObserver1";
            this.lblObserver1.Size = new System.Drawing.Size(0, 17);
            this.lblObserver1.TabIndex = 3;
            // 
            // lblObserver2
            // 
            this.lblObserver2.AutoSize = true;
            this.lblObserver2.Location = new System.Drawing.Point(189, 343);
            this.lblObserver2.Name = "lblObserver2";
            this.lblObserver2.Size = new System.Drawing.Size(0, 17);
            this.lblObserver2.TabIndex = 4;
            // 
            // btnSetNewPrice
            // 
            this.btnSetNewPrice.Location = new System.Drawing.Point(154, 157);
            this.btnSetNewPrice.Name = "btnSetNewPrice";
            this.btnSetNewPrice.Size = new System.Drawing.Size(146, 38);
            this.btnSetNewPrice.TabIndex = 5;
            this.btnSetNewPrice.Text = "Set New Price";
            this.btnSetNewPrice.UseVisualStyleBackColor = true;
            this.btnSetNewPrice.Click += new System.EventHandler(this.btnSetNewPrice_Click);
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(136, 79);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(208, 22);
            this.numPrice.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 417);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnSetNewPrice);
            this.Controls.Add(this.lblObserver2);
            this.Controls.Add(this.lblObserver1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblObserver1;
        private System.Windows.Forms.Label lblObserver2;
        private System.Windows.Forms.Button btnSetNewPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}

