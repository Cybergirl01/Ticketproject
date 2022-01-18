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
        OrganaiserBLL Organaiser = new OrganaiserBLL();
        DBTicketDataSet.IceSkateEventDataTable icelist;
        TicketBLL TicketBLL = new TicketBLL();
        public int idEventplace;
        DBTicketDataSet.ClientDataTable cli;
        DBTicketDataSet.ClientRow rowcli;

        private void buttonViewTicket_Click(object sender, EventArgs e)
        {

            FormViewTIcket fvt = new FormViewTIcket("client");
            this.Hide();
            fvt.ShowDialog();
            fvt.title = (string)comboBoxIcebuy.SelectedItem;
            fvt.viewtime = (TimeSpan)comboBoxTimeview.SelectedItem;
            fvt.place = (int)numericUpDownPlace.Value;
            fvt.price = labelSum.Text;
            fvt.row = (int)numericUpDownRad.Value;
            fvt.room = (int)numericUpDownZal.Value;
            fvt.date = DateTime.Now;
            fvt.IDEventPlace = idEventplace;
            this.Show();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            int zal, place, rad, clientwallet;
            string ice, price;
            TimeSpan timeview;
            cli = clientTableAdapter1.GetData();
            rowcli = cli.FindByID(ClassforIDUsers.idU);
            clientwallet = (int)rowcli.Wallet;
            price = labelSum.Text;
            if (comboBoxIcebuy.SelectedItem == null)
            {
                MessageBox.Show("Выберите каток!");
            }
            else if (clientwallet < Convert.ToInt32(price))
            {
                MessageBox.Show("не достаточно средств.");
            }
            else
            {
                zal = (int)numericUpDownZal.Value;
                place = (int)numericUpDownPlace.Value;
                rad = (int)numericUpDownRad.Value;
                ice = (string)comboBoxIcebuy.SelectedItem;
                timeview = (TimeSpan)comboBoxTimeview.SelectedItem;
                bool inact = false;
                DateTime dateTimeactive = DateTime.Now;
                ticketClientTableAdapter1.Insert(ClassforIDUsers.idU, idEventplace, ice, timeview, zal, rad, place, price, dateTimeactive, inact);
                TicketBLL.buyingTicket(idEventplace, zal, rad, place, dateTimeactive, price, inact);

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIcebuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price;
            icelist = Organaiser.ShowIceskateEvent();
            for (int i = 0; i < icelist.Count; i++)
            {
                price = icelist.ElementAt(i).Price;
                labelSum.Text = Convert.ToString(price);
            }
        }

        private void FormBuyingTicketsIceSkate_Load(object sender, EventArgs e)
        {
            this.comboBoxIcebuy.DataSource = Organaiser.ShowIceskateEvent();
            this.comboBoxIcebuy.ValueMember = "ID";
            this.comboBoxIcebuy.DisplayMember = "Title";
            this.comboBoxTimeview.DataSource = Organaiser.ShowIceskateEvent();
            this.comboBoxTimeview.ValueMember = "ID";
            this.comboBoxTimeview.DisplayMember = "ViewingTime";
        }
    }
}
