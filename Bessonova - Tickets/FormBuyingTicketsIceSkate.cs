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
    public partial class FormBuyingTicketsIceSkate : Form
    {
        public FormBuyingTicketsIceSkate()
        {
            InitializeComponent();
        }

        private void buttonViewTicket_Click(object sender, EventArgs e)
        {

            FormViewTIcket fvt = new FormViewTIcket("client");
            this.Hide();
            fvt.ShowDialog();
            this.Show();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
