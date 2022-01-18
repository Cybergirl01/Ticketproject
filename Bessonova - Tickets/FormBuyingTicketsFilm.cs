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
    public partial class FormBuyingTicketsFilm : Form
    {
        public FormBuyingTicketsFilm()
        {
            InitializeComponent();
        }
        OrganaiserBLL Organaiser = new OrganaiserBLL();
        DBTicketDataSet.FilmsDataTable flimlist;
        TicketBLL TicketBLL = new TicketBLL(); 
        public int idEventplace;
        DBTicketDataSet.ClientDataTable cli;
        DBTicketDataSet.ClientRow rowcli;


        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            int zal, place, rad, clientwallet;
            string film, price;
            TimeSpan timeview;
            cli = clientTableAdapter1.GetData();
            rowcli = cli.FindByID(ClassforIDUsers.idU);
            clientwallet = (int)rowcli.Wallet;
            price = labelSum.Text;
            if (comboBoxfilmbuy.SelectedItem == null)
            {
                MessageBox.Show("Выберите фильм!");
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
                    film = (string)comboBoxfilmbuy.SelectedItem;
                    timeview = (TimeSpan)comboBoxTimeview.SelectedItem;
                    bool inact = false;
                    DateTime dateTimeactive = DateTime.Now;
                    ticketClientTableAdapter1.Insert(ClassforIDUsers.idU, idEventplace, film, timeview, zal, rad, place, price, dateTimeactive, inact);
                    TicketBLL.buyingTicket(idEventplace, zal, rad, place, dateTimeactive, price, inact); 
                
            }
        }

        private void buttonViewTicket_Click(object sender, EventArgs e)
        {

            FormViewTIcket fvt = new FormViewTIcket("client");
            this.Hide();
            fvt.ShowDialog();
            fvt.filmname = (string)comboBoxfilmbuy.SelectedItem;
            fvt.place = (int)numericUpDownPlace.Value;
            fvt.price = labelSum.Text;
            fvt.row = (int)numericUpDownRad.Value;
            fvt.room = (int)numericUpDownZal.Value;
            fvt.date = DateTime.Now;
            fvt.IDEventPlace = idEventplace;
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuyingTicketsFilm_Load(object sender, EventArgs e)
        {
            this.comboBoxfilmbuy.DataSource = Organaiser.ShowFilms();
            this.comboBoxfilmbuy.ValueMember = "ID";
            this.comboBoxfilmbuy.DisplayMember = "Title";
            this.comboBoxTimeview.DataSource = Organaiser.ShowFilms();
            this.comboBoxTimeview.ValueMember = "ID";
            this.comboBoxTimeview.DisplayMember = "ViewingTime";
        }

        private void comboBoxfilmbuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price;
            flimlist = Organaiser.ShowFilms();
            for (int i = 0; i < flimlist.Count; i++)
            {
                price = flimlist.ElementAt(i).Price;
                labelSum.Text = Convert.ToString(price);
            }
        }
    }
}
