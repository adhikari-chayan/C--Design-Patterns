using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge
{
    public partial class Form1 : Form
    {

        private MessageController _messageController = new MessageController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if(radSMS.Checked)
            {
                _messageController.SetMessageType(MessageType.SMS);
            }
            else
            {
                _messageController.SetMessageType(MessageType.Email);
            }

            _messageController.SendMessage(txtTo.Text, txtMessage.Text);
        }
    }
}
