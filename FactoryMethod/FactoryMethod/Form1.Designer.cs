namespace FactoryMethod
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
            this.radUseSqlServer = new System.Windows.Forms.RadioButton();
            this.radUseOleDb = new System.Windows.Forms.RadioButton();
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radUseSqlServer
            // 
            this.radUseSqlServer.AutoSize = true;
            this.radUseSqlServer.Location = new System.Drawing.Point(72, 46);
            this.radUseSqlServer.Name = "radUseSqlServer";
            this.radUseSqlServer.Size = new System.Drawing.Size(124, 21);
            this.radUseSqlServer.TabIndex = 0;
            this.radUseSqlServer.TabStop = true;
            this.radUseSqlServer.Text = "Use Sql Server";
            this.radUseSqlServer.UseVisualStyleBackColor = true;
            // 
            // radUseOleDb
            // 
            this.radUseOleDb.AutoSize = true;
            this.radUseOleDb.Location = new System.Drawing.Point(72, 111);
            this.radUseOleDb.Name = "radUseOleDb";
            this.radUseOleDb.Size = new System.Drawing.Size(109, 21);
            this.radUseOleDb.TabIndex = 1;
            this.radUseOleDb.TabStop = true;
            this.radUseOleDb.Text = "Use OLE DB";
            this.radUseOleDb.UseVisualStyleBackColor = true;
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Location = new System.Drawing.Point(73, 194);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(123, 44);
            this.btnGetDatabase.TabIndex = 2;
            this.btnGetDatabase.Text = "Get Database";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 322);
            this.Controls.Add(this.btnGetDatabase);
            this.Controls.Add(this.radUseOleDb);
            this.Controls.Add(this.radUseSqlServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUseSqlServer;
        private System.Windows.Forms.RadioButton radUseOleDb;
        private System.Windows.Forms.Button btnGetDatabase;
    }
}

