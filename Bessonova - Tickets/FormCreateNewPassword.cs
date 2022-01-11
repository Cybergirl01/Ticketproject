using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova___Tickets
{
    public partial class FormCreateNewPassword : Form
    {
        public string log;
        public FormCreateNewPassword()
        {
            InitializeComponent();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                this.textBoxNewPas.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxNewPas.PasswordChar = '*';
            }
        }

        private void checkBoxShowPas2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                this.textBoxPasConfirm.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxPasConfirm.PasswordChar = '*';
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string emailforchangingpass = log;
            string newpass = textBoxNewPas.Text;
            string conpass = textBoxPasConfirm.Text;
            ClientsBLL clientsBLL = new ClientsBLL();
            if (conpass == newpass)
            {
                clientsBLL.UpdatePassword(emailforchangingpass, newpass);
                    
            }
        }
    }
}
