namespace Visitor
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
            this.btnAddCredits = new System.Windows.Forms.Button();
            this.btnUpdateExpirationDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGregStatus = new System.Windows.Forms.Label();
            this.lblRichardStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCredits
            // 
            this.btnAddCredits.Location = new System.Drawing.Point(140, 72);
            this.btnAddCredits.Name = "btnAddCredits";
            this.btnAddCredits.Size = new System.Drawing.Size(174, 48);
            this.btnAddCredits.TabIndex = 0;
            this.btnAddCredits.Text = "Add Credits";
            this.btnAddCredits.UseVisualStyleBackColor = true;
            this.btnAddCredits.Click += new System.EventHandler(this.btnAddCredits_Click);
            // 
            // btnUpdateExpirationDate
            // 
            this.btnUpdateExpirationDate.Location = new System.Drawing.Point(140, 145);
            this.btnUpdateExpirationDate.Name = "btnUpdateExpirationDate";
            this.btnUpdateExpirationDate.Size = new System.Drawing.Size(174, 50);
            this.btnUpdateExpirationDate.TabIndex = 1;
            this.btnUpdateExpirationDate.Text = "Update Expiration Date";
            this.btnUpdateExpirationDate.UseVisualStyleBackColor = true;
            this.btnUpdateExpirationDate.Click += new System.EventHandler(this.btnUpdateExpirationDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Greg Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Richard Status: ";
            // 
            // lblGregStatus
            // 
            this.lblGregStatus.AutoSize = true;
            this.lblGregStatus.Location = new System.Drawing.Point(151, 228);
            this.lblGregStatus.Name = "lblGregStatus";
            this.lblGregStatus.Size = new System.Drawing.Size(0, 17);
            this.lblGregStatus.TabIndex = 4;
            // 
            // lblRichardStatus
            // 
            this.lblRichardStatus.AutoSize = true;
            this.lblRichardStatus.Location = new System.Drawing.Point(151, 296);
            this.lblRichardStatus.Name = "lblRichardStatus";
            this.lblRichardStatus.Size = new System.Drawing.Size(0, 17);
            this.lblRichardStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 373);
            this.Controls.Add(this.lblRichardStatus);
            this.Controls.Add(this.lblGregStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateExpirationDate);
            this.Controls.Add(this.btnAddCredits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCredits;
        private System.Windows.Forms.Button btnUpdateExpirationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGregStatus;
        private System.Windows.Forms.Label lblRichardStatus;
    }
}

