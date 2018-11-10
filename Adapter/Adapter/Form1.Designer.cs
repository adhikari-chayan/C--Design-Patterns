namespace Adapter
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(106, 60);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(165, 50);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.Location = new System.Drawing.Point(106, 143);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(165, 52);
            this.btnGetCustomers.TabIndex = 1;
            this.btnGetCustomers.Text = "Get Customers";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.Location = new System.Drawing.Point(60, 229);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(247, 165);
            this.lstCustomers.TabIndex = 2;
            this.lstCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 425);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnGetCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.ListView lstCustomers;
    }
}

