namespace Facade
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
            this.btnFollowSomeone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFollowSomeone
            // 
            this.btnFollowSomeone.Location = new System.Drawing.Point(65, 89);
            this.btnFollowSomeone.Name = "btnFollowSomeone";
            this.btnFollowSomeone.Size = new System.Drawing.Size(307, 70);
            this.btnFollowSomeone.TabIndex = 0;
            this.btnFollowSomeone.Text = "Follow Someone";
            this.btnFollowSomeone.UseVisualStyleBackColor = true;
            this.btnFollowSomeone.Click += new System.EventHandler(this.btnFollowSomeone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 383);
            this.Controls.Add(this.btnFollowSomeone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFollowSomeone;
    }
}

