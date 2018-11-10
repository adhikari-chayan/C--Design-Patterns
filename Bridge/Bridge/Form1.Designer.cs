namespace Bridge
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
            this.radSMS = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radSMS
            // 
            this.radSMS.AutoSize = true;
            this.radSMS.Location = new System.Drawing.Point(110, 70);
            this.radSMS.Name = "radSMS";
            this.radSMS.Size = new System.Drawing.Size(58, 21);
            this.radSMS.TabIndex = 0;
            this.radSMS.TabStop = true;
            this.radSMS.Text = "SMS";
            this.radSMS.UseVisualStyleBackColor = true;
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.Location = new System.Drawing.Point(278, 70);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(63, 21);
            this.radEmail.TabIndex = 1;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "Email";
            this.radEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(110, 158);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(278, 22);
            this.txtTo.TabIndex = 4;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(184, 414);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(125, 51);
            this.btnSendMessage.TabIndex = 6;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(110, 227);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(278, 154);
            this.txtMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 491);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radEmail);
            this.Controls.Add(this.radSMS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSMS;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

