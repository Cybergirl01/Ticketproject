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
    public partial class FormRegistrationClients : Form
    {
        public FormRegistrationClients()
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
                this.textBoxPasReg.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxPasReg.PasswordChar = '*';
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string newlogEmail = textBoxLogReg.Text;
            string newpass = textBoxPasReg.Text;
            ClientsBLL clientsBLL = new ClientsBLL();
            clientsBLL.RegisterClient(newlogEmail, newpass);
        }
    }
}
