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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        DBTicketDataSet.ClientProfDataTable clients;
        DBTicketDataSet.ClientProfRow ClientRow;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            FormMyTicketList myTicketList = new FormMyTicketList();
            this.Hide();
            myTicketList.ShowDialog();
            this.Show();
        }

     

        private void buttonBuyticket_Click(object sender, EventArgs e)
        {
            FormSelectPlaceEvent formSelectPlace = new FormSelectPlaceEvent();
            this.Hide();
            formSelectPlace.ShowDialog();
            this.Show();

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            //Получили все данные
            clients = this.clientProfileTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            ClientRow = clients.FindByID(ClassforIDUsers.idU);
            if (ClientRow == null)
            {
                MessageBox.Show("У вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Форма профиля
                FormProfileClient fpc = new FormProfileClient("Addition");
                this.Hide();
                fpc.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("У вас заполнен профиль."
                                    + Environment.NewLine + "Можете работать в системе");
            }
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            FormProfileClient fpc = new FormProfileClient("ViewEdit");
            this.Hide();
            fpc.ShowDialog();
            this.Show();
        }
    }
}
