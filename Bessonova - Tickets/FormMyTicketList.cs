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
    public partial class FormMyTicketList : Form
    {
        public FormMyTicketList()
        {
            InitializeComponent();
        }
        TicketBLL Ticket = new TicketBLL();
        DBTicketDataSet.TicketsDataTable tick;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMyTicketList_Load(object sender, EventArgs e)
        {
            tick = Ticket.ShowTickets();
        }
    }
}
