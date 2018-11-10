namespace ChainOfResponsibility
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtDrawingNumber = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drawing #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(39, 416);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(388, 22);
            this.txtResult.TabIndex = 7;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(154, 267);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(221, 22);
            this.txtBudget.TabIndex = 8;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(154, 116);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(221, 22);
            this.txtPartNumber.TabIndex = 9;
            // 
            // txtDrawingNumber
            // 
            this.txtDrawingNumber.Location = new System.Drawing.Point(154, 192);
            this.txtDrawingNumber.Name = "txtDrawingNumber";
            this.txtDrawingNumber.Size = new System.Drawing.Size(221, 22);
            this.txtDrawingNumber.TabIndex = 10;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(154, 324);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(187, 51);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "Approve New Material";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 462);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtDrawingNumber);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtDrawingNumber;
        private System.Windows.Forms.Button btnApprove;
    }
}

