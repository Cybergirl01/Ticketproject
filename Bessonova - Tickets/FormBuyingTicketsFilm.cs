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

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            int zal, place, rad;
            string film, price;
            if (comboBoxfilmbuy.SelectedItem == null)
            {
                MessageBox.Show("Выберите фильм!");
            }
            else
            {
                flimlist = Organaiser.ShowFilms();
                for (int i = 0; i < flimlist.Count; i++)
                {
                    price = flimlist.ElementAt(i).Price;
                    zal = (int)numericUpDownZal.Value;
                    place = (int)numericUpDownPlace.Value;
                    rad = (int)numericUpDownRad.Value;
                    film = (string)comboBoxfilmbuy.SelectedItem;
                 
                    bool inact = false;
                    DateTime dateTimeactive = DateTime.Now;

                    TicketBLL.buyingTicket(idEventplace, zal, rad, place, dateTimeactive, price, inact);
                }
            }
        }

        private void buttonViewTicket_Click(object sender, EventArgs e)
        {

            FormViewTIcket fvt = new FormViewTIcket("client");
            this.Hide();
            fvt.ShowDialog();
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
