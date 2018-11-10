namespace Composite
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
            this.btnBuildPartsList = new System.Windows.Forms.Button();
            this.lstParts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBuildPartsList
            // 
            this.btnBuildPartsList.Location = new System.Drawing.Point(84, 61);
            this.btnBuildPartsList.Name = "btnBuildPartsList";
            this.btnBuildPartsList.Size = new System.Drawing.Size(337, 35);
            this.btnBuildPartsList.TabIndex = 0;
            this.btnBuildPartsList.Text = "Build Part List";
            this.btnBuildPartsList.UseVisualStyleBackColor = true;
            this.btnBuildPartsList.Click += new System.EventHandler(this.btnBuildPartsList_Click);
            // 
            // lstParts
            // 
            this.lstParts.Location = new System.Drawing.Point(84, 113);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(337, 296);
            this.lstParts.TabIndex = 1;
            this.lstParts.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 488);
            this.Controls.Add(this.lstParts);
            this.Controls.Add(this.btnBuildPartsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuildPartsList;
        private System.Windows.Forms.ListView lstParts;
    }
}

